using AfterDarkSettings.Forms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace AfterDarkSettings
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsAdmin())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    WorkingDirectory = Environment.CurrentDirectory,
                    FileName = Application.ExecutablePath,
                    Verb = "runas"
                };
                try
                {
                    Process p = Process.Start(startInfo);
                    Application.Exit();
                }
                catch (Win32Exception)
                {
                    MessageBox.Show(
                        "This utility requires elevated user privileges.",
                        "Error: UAC Authorization required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }

        /// <summary>
        /// Gets whether the current user is an admin.
        /// </summary>
        /// <returns>True, if user is admin</returns>
        static bool IsAdmin()
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
