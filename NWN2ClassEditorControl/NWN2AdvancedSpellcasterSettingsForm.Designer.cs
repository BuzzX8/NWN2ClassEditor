namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2AdvancedSpellcasterSettingsForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.featArmoredCasterCheckBox = new System.Windows.Forms.CheckBox();
            this.armoredCasterFeatPanel = new System.Windows.Forms.Panel();
            this.featArmoredCasterNameLabel = new System.Windows.Forms.Label();
            this.featArmoredCasterNameTextBox = new System.Windows.Forms.TextBox();
            this.featArmoredCasterNameStrRefCheckBox = new BuzzX8.NWN2ClassEditor.NWN2StrRefCheckBox();
            this.hasFeatPracSpellcasterCheckBox = new System.Windows.Forms.CheckBox();
            this.pracSpellCasterPanel = new System.Windows.Forms.Panel();
            this.featPracSpellcasterNameLabel = new System.Windows.Forms.Label();
            this.featPracSpellcasterNameStrRefCheckBox = new BuzzX8.NWN2ClassEditor.NWN2StrRefCheckBox();
            this.featPracSpellcasterNameTextBox = new System.Windows.Forms.TextBox();
            this.extraSlotCheckBox = new System.Windows.Forms.CheckBox();
            this.featExtraSlotPanel = new System.Windows.Forms.Panel();
            this.featExtraSlotNameLabel = new System.Windows.Forms.Label();
            this.featExtraSlotNameTextBox = new System.Windows.Forms.TextBox();
            this.extraSlotStrRefCheckBox = new BuzzX8.NWN2ClassEditor.NWN2StrRefCheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.arcSpellLvlModLabel = new System.Windows.Forms.Label();
            this.arcSpellLvlModNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.divSpellLvlModNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.divSpellLvlModLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.armoredCasterFeatPanel.SuspendLayout();
            this.pracSpellCasterPanel.SuspendLayout();
            this.featExtraSlotPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arcSpellLvlModNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divSpellLvlModNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Silver;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.featArmoredCasterCheckBox);
            this.mainPanel.Controls.Add(this.armoredCasterFeatPanel);
            this.mainPanel.Controls.Add(this.hasFeatPracSpellcasterCheckBox);
            this.mainPanel.Controls.Add(this.pracSpellCasterPanel);
            this.mainPanel.Controls.Add(this.extraSlotCheckBox);
            this.mainPanel.Controls.Add(this.featExtraSlotPanel);
            this.mainPanel.Controls.Add(this.okButton);
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(330, 290);
            this.mainPanel.TabIndex = 0;
            // 
            // featArmoredCasterCheckBox
            // 
            this.featArmoredCasterCheckBox.AutoSize = true;
            this.featArmoredCasterCheckBox.Location = new System.Drawing.Point(7, 145);
            this.featArmoredCasterCheckBox.Name = "featArmoredCasterCheckBox";
            this.featArmoredCasterCheckBox.Size = new System.Drawing.Size(139, 17);
            this.featArmoredCasterCheckBox.TabIndex = 11;
            this.featArmoredCasterCheckBox.Text = "Has feat armored caster";
            this.featArmoredCasterCheckBox.UseVisualStyleBackColor = true;
            this.featArmoredCasterCheckBox.CheckedChanged += new System.EventHandler(this.featArmoredCasterCheckBox_CheckedChanged);
            // 
            // armoredCasterFeatPanel
            // 
            this.armoredCasterFeatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.armoredCasterFeatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.armoredCasterFeatPanel.Controls.Add(this.featArmoredCasterNameLabel);
            this.armoredCasterFeatPanel.Controls.Add(this.featArmoredCasterNameTextBox);
            this.armoredCasterFeatPanel.Controls.Add(this.featArmoredCasterNameStrRefCheckBox);
            this.armoredCasterFeatPanel.Enabled = false;
            this.armoredCasterFeatPanel.Location = new System.Drawing.Point(3, 152);
            this.armoredCasterFeatPanel.Name = "armoredCasterFeatPanel";
            this.armoredCasterFeatPanel.Size = new System.Drawing.Size(322, 58);
            this.armoredCasterFeatPanel.TabIndex = 14;
            // 
            // featArmoredCasterNameLabel
            // 
            this.featArmoredCasterNameLabel.AutoSize = true;
            this.featArmoredCasterNameLabel.Location = new System.Drawing.Point(0, 12);
            this.featArmoredCasterNameLabel.Name = "featArmoredCasterNameLabel";
            this.featArmoredCasterNameLabel.Size = new System.Drawing.Size(35, 13);
            this.featArmoredCasterNameLabel.TabIndex = 9;
            this.featArmoredCasterNameLabel.Text = "Name";
            // 
            // featArmoredCasterNameTextBox
            // 
            this.featArmoredCasterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.featArmoredCasterNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.featArmoredCasterNameTextBox.Location = new System.Drawing.Point(3, 33);
            this.featArmoredCasterNameTextBox.Name = "featArmoredCasterNameTextBox";
            this.featArmoredCasterNameTextBox.Size = new System.Drawing.Size(314, 20);
            this.featArmoredCasterNameTextBox.TabIndex = 8;
            // 
            // featArmoredCasterNameStrRefCheckBox
            // 
            this.featArmoredCasterNameStrRefCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.featArmoredCasterNameStrRefCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.featArmoredCasterNameStrRefCheckBox.AutoSize = true;
            this.featArmoredCasterNameStrRefCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featArmoredCasterNameStrRefCheckBox.Location = new System.Drawing.Point(270, 3);
            this.featArmoredCasterNameStrRefCheckBox.Name = "featArmoredCasterNameStrRefCheckBox";
            this.featArmoredCasterNameStrRefCheckBox.Size = new System.Drawing.Size(47, 23);
            this.featArmoredCasterNameStrRefCheckBox.StrRef = 0;
            this.featArmoredCasterNameStrRefCheckBox.TabIndex = 7;
            this.featArmoredCasterNameStrRefCheckBox.Text = "StrRef";
            this.featArmoredCasterNameStrRefCheckBox.TextBox = this.featArmoredCasterNameTextBox;
            this.featArmoredCasterNameStrRefCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasFeatPracSpellcasterCheckBox
            // 
            this.hasFeatPracSpellcasterCheckBox.AutoSize = true;
            this.hasFeatPracSpellcasterCheckBox.Location = new System.Drawing.Point(7, 74);
            this.hasFeatPracSpellcasterCheckBox.Name = "hasFeatPracSpellcasterCheckBox";
            this.hasFeatPracSpellcasterCheckBox.Size = new System.Drawing.Size(166, 17);
            this.hasFeatPracSpellcasterCheckBox.TabIndex = 10;
            this.hasFeatPracSpellcasterCheckBox.Text = "Has feat practiced spellcaster";
            this.hasFeatPracSpellcasterCheckBox.UseVisualStyleBackColor = true;
            this.hasFeatPracSpellcasterCheckBox.CheckedChanged += new System.EventHandler(this.hasFeatPracSpellcasterCheckBox_CheckedChanged);
            // 
            // pracSpellCasterPanel
            // 
            this.pracSpellCasterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pracSpellCasterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pracSpellCasterPanel.Controls.Add(this.featPracSpellcasterNameLabel);
            this.pracSpellCasterPanel.Controls.Add(this.featPracSpellcasterNameStrRefCheckBox);
            this.pracSpellCasterPanel.Controls.Add(this.featPracSpellcasterNameTextBox);
            this.pracSpellCasterPanel.Enabled = false;
            this.pracSpellCasterPanel.Location = new System.Drawing.Point(3, 81);
            this.pracSpellCasterPanel.Name = "pracSpellCasterPanel";
            this.pracSpellCasterPanel.Size = new System.Drawing.Size(322, 58);
            this.pracSpellCasterPanel.TabIndex = 13;
            // 
            // featPracSpellcasterNameLabel
            // 
            this.featPracSpellcasterNameLabel.AutoSize = true;
            this.featPracSpellcasterNameLabel.Location = new System.Drawing.Point(0, 12);
            this.featPracSpellcasterNameLabel.Name = "featPracSpellcasterNameLabel";
            this.featPracSpellcasterNameLabel.Size = new System.Drawing.Size(35, 13);
            this.featPracSpellcasterNameLabel.TabIndex = 7;
            this.featPracSpellcasterNameLabel.Text = "Name";
            // 
            // featPracSpellcasterNameStrRefCheckBox
            // 
            this.featPracSpellcasterNameStrRefCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.featPracSpellcasterNameStrRefCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.featPracSpellcasterNameStrRefCheckBox.AutoSize = true;
            this.featPracSpellcasterNameStrRefCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featPracSpellcasterNameStrRefCheckBox.Location = new System.Drawing.Point(270, 4);
            this.featPracSpellcasterNameStrRefCheckBox.Name = "featPracSpellcasterNameStrRefCheckBox";
            this.featPracSpellcasterNameStrRefCheckBox.Size = new System.Drawing.Size(47, 23);
            this.featPracSpellcasterNameStrRefCheckBox.StrRef = 0;
            this.featPracSpellcasterNameStrRefCheckBox.TabIndex = 5;
            this.featPracSpellcasterNameStrRefCheckBox.Text = "StrRef";
            this.featPracSpellcasterNameStrRefCheckBox.TextBox = this.featPracSpellcasterNameTextBox;
            this.featPracSpellcasterNameStrRefCheckBox.UseVisualStyleBackColor = true;
            // 
            // featPracSpellcasterNameTextBox
            // 
            this.featPracSpellcasterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.featPracSpellcasterNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.featPracSpellcasterNameTextBox.Location = new System.Drawing.Point(3, 33);
            this.featPracSpellcasterNameTextBox.Name = "featPracSpellcasterNameTextBox";
            this.featPracSpellcasterNameTextBox.Size = new System.Drawing.Size(314, 20);
            this.featPracSpellcasterNameTextBox.TabIndex = 6;
            // 
            // extraSlotCheckBox
            // 
            this.extraSlotCheckBox.AutoSize = true;
            this.extraSlotCheckBox.Location = new System.Drawing.Point(7, 4);
            this.extraSlotCheckBox.Name = "extraSlotCheckBox";
            this.extraSlotCheckBox.Size = new System.Drawing.Size(111, 17);
            this.extraSlotCheckBox.TabIndex = 9;
            this.extraSlotCheckBox.Text = "Has feat extra slot";
            this.extraSlotCheckBox.UseVisualStyleBackColor = true;
            this.extraSlotCheckBox.CheckedChanged += new System.EventHandler(this.extraSlotCheckBox_CheckedChanged);
            // 
            // featExtraSlotPanel
            // 
            this.featExtraSlotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.featExtraSlotPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.featExtraSlotPanel.Controls.Add(this.featExtraSlotNameLabel);
            this.featExtraSlotPanel.Controls.Add(this.featExtraSlotNameTextBox);
            this.featExtraSlotPanel.Controls.Add(this.extraSlotStrRefCheckBox);
            this.featExtraSlotPanel.Enabled = false;
            this.featExtraSlotPanel.Location = new System.Drawing.Point(3, 11);
            this.featExtraSlotPanel.Name = "featExtraSlotPanel";
            this.featExtraSlotPanel.Size = new System.Drawing.Size(322, 58);
            this.featExtraSlotPanel.TabIndex = 12;
            // 
            // featExtraSlotNameLabel
            // 
            this.featExtraSlotNameLabel.AutoSize = true;
            this.featExtraSlotNameLabel.Location = new System.Drawing.Point(0, 12);
            this.featExtraSlotNameLabel.Name = "featExtraSlotNameLabel";
            this.featExtraSlotNameLabel.Size = new System.Drawing.Size(35, 13);
            this.featExtraSlotNameLabel.TabIndex = 5;
            this.featExtraSlotNameLabel.Text = "Name";
            // 
            // featExtraSlotNameTextBox
            // 
            this.featExtraSlotNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.featExtraSlotNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.featExtraSlotNameTextBox.Location = new System.Drawing.Point(3, 32);
            this.featExtraSlotNameTextBox.Name = "featExtraSlotNameTextBox";
            this.featExtraSlotNameTextBox.Size = new System.Drawing.Size(314, 20);
            this.featExtraSlotNameTextBox.TabIndex = 4;
            // 
            // extraSlotStrRefCheckBox
            // 
            this.extraSlotStrRefCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extraSlotStrRefCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.extraSlotStrRefCheckBox.AutoSize = true;
            this.extraSlotStrRefCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extraSlotStrRefCheckBox.Location = new System.Drawing.Point(270, 3);
            this.extraSlotStrRefCheckBox.Name = "extraSlotStrRefCheckBox";
            this.extraSlotStrRefCheckBox.Size = new System.Drawing.Size(47, 23);
            this.extraSlotStrRefCheckBox.StrRef = 0;
            this.extraSlotStrRefCheckBox.TabIndex = 3;
            this.extraSlotStrRefCheckBox.Text = "StrRef";
            this.extraSlotStrRefCheckBox.TextBox = this.featExtraSlotNameTextBox;
            this.extraSlotStrRefCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(169, 261);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(250, 261);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.divSpellLvlModLabel);
            this.panel1.Controls.Add(this.divSpellLvlModNumericUpDown);
            this.panel1.Controls.Add(this.arcSpellLvlModNumericUpDown);
            this.panel1.Controls.Add(this.arcSpellLvlModLabel);
            this.panel1.Location = new System.Drawing.Point(3, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 34);
            this.panel1.TabIndex = 15;
            // 
            // arcSpellLvlModLabel
            // 
            this.arcSpellLvlModLabel.AutoSize = true;
            this.arcSpellLvlModLabel.Location = new System.Drawing.Point(7, 10);
            this.arcSpellLvlModLabel.Name = "arcSpellLvlModLabel";
            this.arcSpellLvlModLabel.Size = new System.Drawing.Size(81, 13);
            this.arcSpellLvlModLabel.TabIndex = 0;
            this.arcSpellLvlModLabel.Text = "ArcSpellLvlMod";
            // 
            // arcSpellLvlModNumericUpDown
            // 
            this.arcSpellLvlModNumericUpDown.Location = new System.Drawing.Point(94, 6);
            this.arcSpellLvlModNumericUpDown.Name = "arcSpellLvlModNumericUpDown";
            this.arcSpellLvlModNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.arcSpellLvlModNumericUpDown.TabIndex = 1;
            // 
            // divSpellLvlModNumericUpDown
            // 
            this.divSpellLvlModNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.divSpellLvlModNumericUpDown.Location = new System.Drawing.Point(272, 6);
            this.divSpellLvlModNumericUpDown.Name = "divSpellLvlModNumericUpDown";
            this.divSpellLvlModNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.divSpellLvlModNumericUpDown.TabIndex = 2;
            // 
            // divSpellLvlModLabel
            // 
            this.divSpellLvlModLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.divSpellLvlModLabel.AutoSize = true;
            this.divSpellLvlModLabel.Location = new System.Drawing.Point(185, 10);
            this.divSpellLvlModLabel.Name = "divSpellLvlModLabel";
            this.divSpellLvlModLabel.Size = new System.Drawing.Size(81, 13);
            this.divSpellLvlModLabel.TabIndex = 3;
            this.divSpellLvlModLabel.Text = "DivSpellLvlMod";
            // 
            // NWN2AdvancedSpellcasterSettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(330, 290);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NWN2AdvancedSpellcasterSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NWN2AdvancedSpellcasterSettingsForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.armoredCasterFeatPanel.ResumeLayout(false);
            this.armoredCasterFeatPanel.PerformLayout();
            this.pracSpellCasterPanel.ResumeLayout(false);
            this.pracSpellCasterPanel.PerformLayout();
            this.featExtraSlotPanel.ResumeLayout(false);
            this.featExtraSlotPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arcSpellLvlModNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divSpellLvlModNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox featArmoredCasterNameTextBox;
        private NWN2StrRefCheckBox featArmoredCasterNameStrRefCheckBox;
        private System.Windows.Forms.TextBox featPracSpellcasterNameTextBox;
        private NWN2StrRefCheckBox featPracSpellcasterNameStrRefCheckBox;
        private System.Windows.Forms.TextBox featExtraSlotNameTextBox;
        private NWN2StrRefCheckBox extraSlotStrRefCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox featArmoredCasterCheckBox;
        private System.Windows.Forms.CheckBox hasFeatPracSpellcasterCheckBox;
        private System.Windows.Forms.CheckBox extraSlotCheckBox;
        private System.Windows.Forms.Panel featExtraSlotPanel;
        private System.Windows.Forms.Label featExtraSlotNameLabel;
        private System.Windows.Forms.Panel pracSpellCasterPanel;
        private System.Windows.Forms.Label featPracSpellcasterNameLabel;
        private System.Windows.Forms.Panel armoredCasterFeatPanel;
        private System.Windows.Forms.Label featArmoredCasterNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown divSpellLvlModNumericUpDown;
        private System.Windows.Forms.NumericUpDown arcSpellLvlModNumericUpDown;
        private System.Windows.Forms.Label arcSpellLvlModLabel;
        private System.Windows.Forms.Label divSpellLvlModLabel;
    }
}