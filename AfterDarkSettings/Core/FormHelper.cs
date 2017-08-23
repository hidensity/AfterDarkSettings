using AfterDarkSettings.Forms;
using AfterDarkSettings.Modules.Base;
using AfterDarkSettings.ModulesHandling;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AfterDarkSettings.Core
{
    class FormHelper
    {
        #region Private Members

        private ComboBox cmbModules;

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the MainForm object.
        /// </summary>
        private MainForm MainForm { get; set; }

        #endregion

        /// <summary>
        /// Initializes a new FormHelper object.
        /// </summary>
        /// <param name="MainForm">MainForm instance to inject.</param>
        public FormHelper(MainForm MainForm)
        {
            this.MainForm = MainForm;
            cmbModules = this.MainForm.ModuleComboBox;
        }

        /// <summary>
        /// Populates the form object.
        /// </summary>
        public void Populate()
        {
            cmbModules.Items.Clear();
            foreach (AfterDarkModuleBase module in GetModules())
            {
                cmbModules.Items.Add(module);
            }
            var foo = cmbModules.Items;
        }

        /// <summary>
        /// Gets a list of After Dark modules.
        /// </summary>
        /// <returns>List of IAfterDarkModule instances.</returns>
        private IEnumerable<AfterDarkModuleBase> GetModules()
        {
            return ModuleUtils.GetModules(ModuleUtils.GetModuleList(Directory.GetCurrentDirectory()));
        }
    }
}
