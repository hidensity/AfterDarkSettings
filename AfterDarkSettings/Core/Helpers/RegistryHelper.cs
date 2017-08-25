using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AfterDarkSettings.Modules.Base;
using AfterDarkSettings.Modules.Ext;

namespace AfterDarkSettings.Core.Helpers
{
    class RegistryHelper
    {
        private const string AD_GENERAL_REGISTRY_PATH = @"Software\Berkeley Systems\After Dark";
        private const string AD_GENERAL_SETTING_MUTE_SOUND = "Mutesound";
        private const string AD_GENERAL_SETTING_ANIMATED_PREVIEWS = "AnimatedMiniPreview";
        private const string AD_ACTIVE_MODULE_NAME = "After Dark 4.0";
        private const string AD_MODULE_SETTINGS_PATH = @"Software\Berkeley Systems\After Dark\Module Settings\After Dark 4.0";

        /// <summary>
        /// Gets the name of the currently selected After Dark module.
        /// </summary>
        /// <returns>String containing the name.</returns>
        public string GetActiveScreenSaverModuleName()
        {
            try
            {
                return GetValue(AD_ACTIVE_MODULE_NAME, @"\Folders") as string;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets, whether sound is enabled.
        /// </summary>
        /// <returns>State of enabled sound.</returns>
        public bool IsSoundMuted()
        {
            try
            {
                object mute = GetValue(AD_GENERAL_SETTING_MUTE_SOUND);

                return (mute != null && (Convert.ToInt16(mute) == 1));
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets, whether sound is enabled.
        /// </summary>
        /// <returns>State of enabled sound.</returns>
        public bool IsAnimatedPreview()
        {
            try
            {
                object animated = GetValue(AD_GENERAL_SETTING_ANIMATED_PREVIEWS);

                return (animated != null && (Convert.ToInt16(animated) == 1));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SaveSettings(AfterDarkModuleBase module, bool isMute, bool isAnimatedPreview)
        {
            SaveModuleName(module.Name);
            SaveMuteState(isMute ? 1 : 0);
            SaveAnimatedPreviewState(isAnimatedPreview ? 1 : 0);

            foreach (ModuleSetting moduleSetting in module.SettingsControl.ModuleSettings)
            {
                SaveModuleSetting(moduleSetting, string.Format("{0}\\{1}", AD_MODULE_SETTINGS_PATH, module.RegistryFolder));
                int i = 6;
            }
        }

        /// <summary>
        /// Reads a registry key value
        /// </summary>
        /// <param name="value">Value to retrieve.</param>
        /// <param name="path">Path to the registry key.</param>
        /// <returns>Object containing the key's value.</returns>
        private object GetValue(string value, string path = "")
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(AD_GENERAL_REGISTRY_PATH + path);
                if (key != null)
                {
                    return key.GetValue(value);
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the selected module's name.
        /// </summary>
        /// <param name="moduleName">Name of the currently selected After Dark module.</param>
        private void SaveModuleName(string moduleName)
        {
            SaveModuleSetting(new ModuleSetting()
            {
                Name = AD_ACTIVE_MODULE_NAME,
                DataType = RegistryValueKind.String,
                Value = moduleName
            }, AD_GENERAL_REGISTRY_PATH + @"\Folders");
        }

        /// <summary>
        /// Saves the mute state.
        /// </summary>
        /// <param name="mute">Value of the mute setting.</param>
        private void SaveMuteState(int mute)
        {
            SaveModuleSetting(new ModuleSetting()
            {
                Name = AD_GENERAL_SETTING_MUTE_SOUND,
                DataType = RegistryValueKind.DWord,
                Value = mute
            });
        }

        /// <summary>
        /// Saves the animated mini preview state.
        /// </summary>
        /// <param name="animatedPreview">Value of the animated preview setting.</param>
        private void SaveAnimatedPreviewState(int animatedPreview)
        {
            SaveModuleSetting(new ModuleSetting()
            {
                Name = AD_GENERAL_SETTING_ANIMATED_PREVIEWS,
                DataType = RegistryValueKind.DWord,
                Value = animatedPreview
            });
        }

        /// <summary>
        /// Saves a single ModuleSetting to the registry.
        /// </summary>
        /// <param name="setting">ModuleSetting to save.</param>
        /// <param name="path">Path to the registry key.</param>
        private void SaveModuleSetting(ModuleSetting setting, string path = AD_GENERAL_REGISTRY_PATH)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);

            if (key == null)
            {
                Registry.CurrentUser.CreateSubKey(path);
                key = Registry.CurrentUser.OpenSubKey(path, true);
            }

            key.SetValue(setting.Name, setting.Value, setting.DataType);
        }
    }
}
