using AfterDarkSettings.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AfterDarkSettings.ModulesHandling
{
    class ModuleUtils
    {
        /// <summary>
        /// Gets a list of available modules within a specified path.
        /// </summary>
        /// <param name="path">Path to search for modules.</param>
        /// <returns>List of strings with file names.</returns>
        public static List<string> GetModuleList(string path)
        {
            return new List<string>(Directory.GetFiles(path, "*.dll"));
        }

        /// <summary>
        /// Gets a list of After Dark Modules
        /// </summary>
        /// <param name="dllFile">List of Dll files to check for Module capabilities.</param>
        /// <returns>List of IAfterDarkModule objects.</returns>
        public static IEnumerable<IAfterDarkModule> GetModules(List<string> dllFiles)
        {
            return dllFiles.SelectMany(GetModulesFromAssembly);
        }

        /// <summary>
        /// Gets a list of After Dark Modules within a single Assembly
        /// </summary>
        /// <param name="dllFile">List of Dll files to check for Module capabilities.</param>
        /// <returns>List of IAfterDarkModule objects.</returns>
        public static IEnumerable<IAfterDarkModule> GetModulesFromAssembly(string dllFile)
        {
            try
            {
                // Load Dll.
                Assembly assembly = Assembly.LoadFile(dllFile);
                var moduleClasses = assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IAfterDarkModule)));

                return moduleClasses.Select(m => (IAfterDarkModule)assembly.CreateInstance(m.FullName));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
