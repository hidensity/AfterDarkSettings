using AfterDarkSettings.Modules.Ext;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AfterDarkSettings.Modules.Interfaces
{
    public interface IAfterDarkModule
    {
        /// <summary>
        /// Gets the module's name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the module's settings registry folder.
        /// </summary>
        string RegistryFolder { get; }

        /// <summary>
        /// Gets the module's settings.
        /// </summary>
        IEnumerable<ModuleSetting> ModuleSettings { get; }

        /// <summary>
        /// Gets the module's settings control.
        /// </summary>
        Control SettingsControl { get; }
    }
}
