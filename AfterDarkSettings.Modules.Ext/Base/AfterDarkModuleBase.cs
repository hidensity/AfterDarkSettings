using AfterDarkSettings.Modules.Ext.Base.Controls;

namespace AfterDarkSettings.Modules.Base
{
    public abstract class AfterDarkModuleBase
    {
        /// <summary>
        /// Gets the module's name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the module's settings registry folder.
        /// </summary>
        public abstract string RegistryFolder { get; }

        /// <summary>
        /// Gets the module's settings control.
        /// </summary>
        public abstract AfterDarkSettingsControlBase SettingsControl { get; }

        /// <summary>
        /// Gets a string representation of the model.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
