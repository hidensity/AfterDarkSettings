namespace AfterDarkSettings.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.chkAnimatedPreview = new System.Windows.Forms.CheckBox();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeperator01 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.grpGeneral.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.chkAnimatedPreview);
            this.grpGeneral.Controls.Add(this.chkSound);
            this.grpGeneral.Controls.Add(this.cmbModule);
            this.grpGeneral.Controls.Add(this.lblModule);
            this.grpGeneral.Location = new System.Drawing.Point(12, 27);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(451, 71);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // chkAnimatedPreview
            // 
            this.chkAnimatedPreview.AutoSize = true;
            this.chkAnimatedPreview.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnimatedPreview.Location = new System.Drawing.Point(105, 46);
            this.chkAnimatedPreview.Name = "chkAnimatedPreview";
            this.chkAnimatedPreview.Size = new System.Drawing.Size(116, 17);
            this.chkAnimatedPreview.TabIndex = 3;
            this.chkAnimatedPreview.Text = "Animated Previews";
            this.chkAnimatedPreview.UseVisualStyleBackColor = true;
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSound.Location = new System.Drawing.Point(2, 46);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(84, 17);
            this.chkSound.TabIndex = 2;
            this.chkSound.Text = "Mute Sound";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // cmbModule
            // 
            this.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(51, 19);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(394, 21);
            this.cmbModule.TabIndex = 1;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(3, 22);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(42, 13);
            this.lblModule.TabIndex = 0;
            this.lblModule.Text = "Module";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileSeperator01,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(195, 22);
            this.mnuFileOpen.Text = "&Open .ini File...";
            // 
            // mnuFileSeperator01
            // 
            this.mnuFileSeperator01.Name = "mnuFileSeperator01";
            this.mnuFileSeperator01.Size = new System.Drawing.Size(192, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(195, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "After Dark Settings";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.CheckBox chkAnimatedPreview;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeperator01;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Button button1;
    }
}