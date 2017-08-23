using System.Collections.Generic;
using System.Windows.Forms;

namespace AfterDarkSettings.Modules.Ext.Base.Controls
{
    public abstract class AfterDarkSettingsControlBase : UserControl
    {
        /// <summary>
        /// Gets or sets the module's settings.
        /// </summary>
        public abstract IEnumerable<ModuleSetting> ModuleSettings { get; set; }
    }
}
