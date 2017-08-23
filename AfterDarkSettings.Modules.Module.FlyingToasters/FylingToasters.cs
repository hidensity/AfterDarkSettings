using AfterDarkSettings.Modules.Base;
using AfterDarkSettings.Modules.Ext.Base.Controls;
using AfterDarkSettings.Modules.Module.FlyingToasters.Controls;

namespace AfterDarkSettings.Modules.Module.FlyingToasters
{
    public class FylingToasters : AfterDarkModuleBase
    {
        AfterDarkSettingsControlBase settingsControl;

        #region Public Properties

        /// <summary>
        /// Gets the module's name.
        /// </summary>
        public override string Name
        {
            get { return "Flying Toasters!"; }
        }

        /// <summary>
        /// Gets the module's settings registry folder.
        /// </summary>
        public override string RegistryFolder
        {
            get { return "Flying Toasters!"; }
        }

        /// <summary>
        /// Gets the module's settings control.
        /// </summary>
        public override AfterDarkSettingsControlBase SettingsControl
        {
            get { return new SettingsControl(); }
        }

        #endregion
    }
}
