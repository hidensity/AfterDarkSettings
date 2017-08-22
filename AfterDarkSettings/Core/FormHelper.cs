using AfterDarkSettings.Forms;
using AfterDarkSettings.Modules.Interfaces;
using AfterDarkSettings.ModulesHandling;
using System.Collections.Generic;
using System.IO;

namespace AfterDarkSettings.Core
{
    class FormHelper
    {
        /// <summary>
        /// Gets or sets the MainForm object.
        /// </summary>
        private MainForm MainForm { get; set; }

        /// <summary>
        /// Initializes a new FormHelper object.
        /// </summary>
        /// <param name="MainForm">MainForm instance to inject.</param>
        public FormHelper(MainForm MainForm)
        {
            this.MainForm = MainForm;
        }

        /// <summary>
        /// Populates the form object.
        /// </summary>
        public void Populate()
        {
            MainForm.cmbModule.Items.Clear();
            IEnumerable<IAfterDarkModule> o = GetModules();
            int i = 5;
        }

        /// <summary>
        /// Gets a list of After Dark modules.
        /// </summary>
        /// <returns>List of IAfterDarkModule instances.</returns>
        private IEnumerable<IAfterDarkModule> GetModules()
        {
            return ModuleUtils.GetModules(ModuleUtils.GetModuleList(Directory.GetCurrentDirectory()));
        }
    }
}
