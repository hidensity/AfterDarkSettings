using AfterDarkSettings.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfterDarkSettings.Forms
{
    public partial class MainForm : Form
    {
        private FormHelper FormHelper;

        #region Public Properties

        /// <summary>
        /// Gets the ComboBox object holding the modules.
        /// </summary>
        public ComboBox ModuleComboBox
        {
            get { return cmbModule; }
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        /// <summary>
        /// Exit got clicked.
        /// </summary>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        /// <summary>
        /// Form has been shown.
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            FormHelper = new FormHelper(this);
            FormHelper.Populate();
        }
    }
}
