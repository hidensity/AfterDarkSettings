using AfterDarkSettings.Modules.Ext;
using AfterDarkSettings.Modules.Ext.Enums;
using AfterDarkSettings.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AfterDarkSettings.Modules.Module.FlyingToasters
{
    public class FylingToasters : IAfterDarkModule
    {

        #region Public Properties

        /// <summary>
        /// Gets the module's name.
        /// </summary>
        public string Name
        {
            get
            {
                return "Flying Toasters!";
            }
        }

        /// <summary>
        /// Gets the module's settings registry folder.
        /// </summary>
        public string RegistryFolder
        {
            get
            {
                return "Flying Toasters!";
            }
        }

        /// <summary>
        /// Gets the module's settings control.
        /// </summary>
        public Control SettingsControl
        {
            get
            {
                return new Control();
            }
        }

        /// <summary>
        /// Gets the module's settings.
        /// </summary>
        public IEnumerable<ModuleSetting> ModuleSettings
        {
            get
            {
                return new List<ModuleSetting>() {
                    ObjectType,
                    ToasterType,
                    PlayMusic,
                    DisplayKaraoke
                };
            }
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets the Flying Toaster's object type.
        /// </summary>
        private ModuleSetting ObjectType
        {
            get
            {
                return new ModuleSetting() {
                    Name = "Control0",
                    DataType = RegistryDataType.REG_DWORD,
                    // TODO: Replace 0 with value coming from the control
                    Value = 0
                };
            }
        }

        /// <summary>
        /// Gets the type of Flying Toaster's.
        /// </summary>
        private ModuleSetting ToasterType
        {
            get
            {
                return new ModuleSetting()
                {
                    Name = "Control1",
                    DataType = RegistryDataType.REG_DWORD,
                    // TODO: Replace 0 with value coming from the control
                    Value = 0
                };
            }
        }

        /// <summary>
        /// Gets the duration of playing the music.
        /// </summary>
        private ModuleSetting PlayMusic
        {
            get
            {
                return new ModuleSetting()
                {
                    Name = "Control2",
                    DataType = RegistryDataType.REG_DWORD,
                    // TODO: Replace 0 with value coming from the control
                    Value = 0
                };
            }
        }

        /// <summary>
        /// Gets the style of the Karaoke display.
        /// </summary>
        private ModuleSetting DisplayKaraoke
        {
            get
            {
                return new ModuleSetting()
                {
                    Name = "Control3",
                    DataType = RegistryDataType.REG_DWORD,
                    // TODO: Replace 0 with value coming from the control
                    Value = 0
                };
            }
        }

        #endregion

    }
}
