using AfterDarkSettings.Modules.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AfterDarkSettings.ModulesHandling
{
    class ModuleUtils
    {
        /// <summary>
        /// Gets a list of After Dark Modules
        /// </summary>
        /// <param name="dllFile">List of Dll files to check for Module capabilities.</param>
        /// <returns>List of IAfterDarkModule objects.</returns>
        public static IEnumerable<AfterDarkModuleBase> GetAfterDarkModules()
        {
            return GetModuleList().SelectMany(GetModulesFromAssembly).Where(t => t != null);
        }

        /// <summary>
        /// Gets a list of available modules within a specified path.
        /// </summary>
        /// <returns>List of strings with file names.</returns>
        private static List<string> GetModuleList()
        {
            return new List<string>(Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Modules", "*.dll"));
        }

        /// <summary>
        /// Gets a list of After Dark Modules within a single Assembly
        /// </summary>
        /// <param name="dllFile">List of Dll files to check for Module capabilities.</param>
        /// <returns>List of IAfterDarkModule objects.</returns>
        private static IEnumerable<AfterDarkModuleBase> GetModulesFromAssembly(string dllFile)
        {
            try
            {
                // Load Dll.
                Assembly assembly = Assembly.LoadFile(dllFile);
                var moduleClasses = assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(AfterDarkModuleBase)));

                return moduleClasses.Select(m => (AfterDarkModuleBase)assembly.CreateInstance(m.FullName));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
