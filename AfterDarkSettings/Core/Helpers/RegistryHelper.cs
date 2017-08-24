using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AfterDarkSettings.Core.Helpers
{
    class RegistryHelper
    {
        private const string AD_REGISTRY_PATH = @"Software\Berkeley Systems\After Dark";
        private const string AD_MODULE_NAME = "After Dark 4.0";
        private const string AD_GENERAL_SETTING_MUTE_SOUND = "Mutesound";
        private const string AD_GENERAL_SETTING_ANIMATED_PREVIEWS = "AnimatedMiniPreview";

        /// <summary>
        /// Gets the name of the currently selected After Dark module.
        /// </summary>
        /// <returns>String containing the name.</returns>
        public string GetActiveScreenSaverModuleName()
        {
            try
            {
                return GetValue(AD_MODULE_NAME, @"\Folders") as string;
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
                RegistryKey key = Registry.CurrentUser.OpenSubKey(AD_REGISTRY_PATH + path);
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
    }
}
