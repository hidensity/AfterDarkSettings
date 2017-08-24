using AfterDarkSettings.Core.Helpers;
using AfterDarkSettings.Enums;
using System;
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

        /// <summary>
        /// Gets the CheckBox object holding the sound setting.
        /// </summary>
        public CheckBox SoundCheckBox
        {
            get { return chkSound; }
        }

        /// <summary>
        /// Gets the CheckBox object holding the animated previews setting.
        /// </summary>
        public CheckBox AnimatedPreviewsCheckBox
        {
            get { return chkAnimatedPreview; }
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

        /// <summary>
        /// Form has been shown.
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            FormHelper = new FormHelper(this, new RegistryHelper());

            try
            {
                ErrorState errorState = FormHelper.Populate();
                if (errorState != ErrorState.Success)
                {
                    DialogResult result = ErrorHelper.DisplayError(errorState);
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            catch (Exception)
            {
                ErrorHelper.DisplayGeneralError();

                Close();
            }
        }

        #endregion
    }
}
