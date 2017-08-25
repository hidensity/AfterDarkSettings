using AfterDarkSettings.Enums;
using AfterDarkSettings.Forms;
using AfterDarkSettings.Modules.Base;
using AfterDarkSettings.ModulesHandling;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace AfterDarkSettings.Core.Helpers
{
    class FormHelper : IDisposable
    {
        #region Private Members

        private ComboBox cmbModules;
        private CheckBox chkSound;
        private CheckBox chkAnimatedPreview;

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the MainForm object.
        /// </summary>
        private MainForm MainForm { get; set; }

        /// <summary>
        /// Gets or sets the RegistryHelper object.
        /// </summary>
        private RegistryHelper RegistryHelper { get; set; }

        #endregion

        /// <summary>
        /// Initializes a new FormHelper object.
        /// </summary>
        /// <param name="MainForm">MainForm instance to inject.</param>
        /// <param name="RegistryHelper">RegistryHelper instance to inject.</param>
        public FormHelper(MainForm MainForm, RegistryHelper RegistryHelper)
        {
            this.MainForm = MainForm;
            this.RegistryHelper = RegistryHelper;

            Init();
        }

        /// <summary>
        /// Populates the form object.
        /// </summary>
        /// <returns>Success state.</returns>
        public ErrorState Populate()
        {
            ErrorState errorState = PopulateModuleComboBox();
            if (errorState != ErrorState.Success)
            {
                return errorState;
            }

            PopulateSoundCheckBox();
            PopulateAnimatedPreviewsCheckBox();

            return ErrorState.Success;
        }

        public void SaveSettings()
        {
            RegistryHelper.SaveSettings((AfterDarkModuleBase)cmbModules.SelectedItem, chkSound.Checked, chkAnimatedPreview.Checked);
        }

        /// <summary>
        /// Initializes the helper.
        /// </summary>
        private void Init()
        {
            cmbModules = MainForm.ModuleComboBox;
            chkSound = MainForm.SoundCheckBox;
            chkAnimatedPreview = MainForm.AnimatedPreviewsCheckBox;
        }

        /// <summary>
        /// Populates the module combo box.
        /// </summary>
        /// <returns>Success state.</returns>
        private ErrorState PopulateModuleComboBox()
        {
            cmbModules.Items.Clear();
            foreach (AfterDarkModuleBase module in GetModules())
            {
                cmbModules.Items.Add(module);
            }

            cmbModules.Text = RegistryHelper.GetActiveScreenSaverModuleName();

            return (cmbModules.SelectedItem != null) ? ErrorState.Success : ErrorState.SelectedModuleNotFound;
        }

        /// <summary>
        /// Populates the sound mute check box.
        /// </summary>
        private void PopulateSoundCheckBox()
        {
            chkSound.Checked = RegistryHelper.IsSoundMuted();
        }

        /// <summary>
        /// Populates the sound mute check box.
        /// </summary>
        private void PopulateAnimatedPreviewsCheckBox()
        {
            chkAnimatedPreview.Checked = RegistryHelper.IsAnimatedPreview();
        }

        /// <summary>
        /// Gets a list of After Dark modules.
        /// </summary>
        /// <returns>List of IAfterDarkModule instances.</returns>
        private IEnumerable<AfterDarkModuleBase> GetModules()
        {
            return ModuleUtils.GetAfterDarkModules();
        }

        #region IDisposable Members

        /// <summary>
        /// Disposes the object.
        /// </summary>
        public void Dispose()
        {
            FieldInfo[] fields = GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var fieldInfo in fields)
            {
                var value = fieldInfo.GetValue(this) as IDisposable;
                if (value != null)
                {
                    value.Dispose();
                    fieldInfo.SetValue(this, null);
                }
            }
        }

        #endregion
    }
}
