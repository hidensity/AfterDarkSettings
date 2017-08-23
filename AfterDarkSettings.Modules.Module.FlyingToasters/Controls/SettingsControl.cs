using System.Collections.Generic;
using AfterDarkSettings.Modules.Ext.Base.Controls;
using AfterDarkSettings.Modules.Ext;
using AfterDarkSettings.Modules.Ext.Enums;

namespace AfterDarkSettings.Modules.Module.FlyingToasters.Controls
{
    public partial class SettingsControl : AfterDarkSettingsControlBase
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the module's settings.
        /// </summary>
        public override IEnumerable<ModuleSetting> ModuleSettings
        {
            get
            {
                return new List<ModuleSetting>() {
                    FlightType,
                    ToasterType,
                    PlayMusic,
                    DisplayKaraoke
                };
            }
            set
            {
                SetModuleSettings(value);
            }
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets the Flying Toaster's flight type.
        /// </summary>
        private ModuleSetting FlightType
        {
            get { return GetFlightType(); }
        }

        /// <summary>
        /// Gets the type of Flying Toaster's.
        /// </summary>
        private ModuleSetting ToasterType
        {
            get { return GetToasterType(); }
        }

        /// <summary>
        /// Gets the duration of playing the music.
        /// </summary>
        private ModuleSetting PlayMusic
        {
            get { return GetPlayMusic(); }
        }

        /// <summary>
        /// Gets the style of the Karaoke display.
        /// </summary>
        private ModuleSetting DisplayKaraoke
        {
            get { return GetDisplayKaraoke(); }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Initializes the SettingsControl object.
        /// </summary>
        public SettingsControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Sets the initial module's settings.
        /// </summary>
        /// <param name="moduleSettings">IEnumerable of ModuleSetting objects.</param>
        private void SetModuleSettings(IEnumerable<ModuleSetting> moduleSettings)
        {
            return;
        }

        /// <summary>
        /// Gets the Flying Toaster's flight type.
        /// </summary>
        /// <returns>ModuleSetting object.</returns>
        private ModuleSetting GetFlightType()
        {
            return new ModuleSetting()
            {
                Name = "Control0",
                DataType = RegistryDataType.REG_DWORD,
                // TODO: Replace 0 with value coming from the control
                Value = 0
            };
        }

        /// <summary>
        /// Gets the type of Flying Toaster's.
        /// </summary>
        /// <returns>ModuleSetting object.</returns>
        private ModuleSetting GetToasterType()
        {
            return new ModuleSetting()
                {
                    Name = "Control1",
                    DataType = RegistryDataType.REG_DWORD,
                    // TODO: Replace 0 with value coming from the control
                    Value = 0
                };
        }

        /// <summary>
        /// Gets the duration of playing the music.
        /// </summary>
        /// <returns>ModuleSetting object.</returns>
        private ModuleSetting GetPlayMusic()
        {
            return new ModuleSetting()
            {
                Name = "Control2",
                DataType = RegistryDataType.REG_DWORD,
                // TODO: Replace 0 with value coming from the control
                Value = 0
            };
        }

        /// <summary>
        /// Gets the style of the Karaoke display.
        /// </summary>
        /// <returns>ModuleSetting object.</returns>
        private ModuleSetting GetDisplayKaraoke()
        {
            return new ModuleSetting()
            {
                Name = "Control3",
                DataType = RegistryDataType.REG_DWORD,
                // TODO: Replace 0 with value coming from the control
                Value = 0
            };
        }

        #endregion

    }
}
