using AfterDarkSettings.Enums;
using System.Windows.Forms;

namespace AfterDarkSettings.Core.Helpers
{
    class ErrorHelper
    {
        /// <summary>
        /// Displays a general error.
        /// </summary>
        public static void DisplayGeneralError()
        {
            MessageBox.Show(
                "An error occurred when reading the After Dark 4.0 settings.\n\r" +
                "Make sure the After Dark 4.0 software has been properly installed.",
                "Error reading Settings",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        /// <summary>
        /// Displays an appropriate error message.
        /// </summary>
        /// <param name="errorState">ErrorState to display message for.</param>
        /// <returns>DialogResult</returns>
        public static DialogResult DisplayError(ErrorState errorState)
        {
            switch (errorState)
            {
                case ErrorState.SelectedModuleNotFound:
                    return MessageBox.Show(
                        "This software does not provide settings for your\n\r" +
                        "currently selected After Dark module.\n\r\n\r" +
                        "Do you want to continue?",
                        "Unsupported Module found",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2
                    );
            }

            return DialogResult.None;
        }
    }
}
