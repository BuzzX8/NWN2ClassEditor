namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2NameEditorDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NWN2NameEditorDialogForm));
            this.classLabelLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pluralLabel = new System.Windows.Forms.Label();
            this.classLabelTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pluralTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.nameStrRefCheckBox = new System.Windows.Forms.CheckBox();
            this.pluralStrRefCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerRedRefCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerTextBox = new System.Windows.Forms.TextBox();
            this.lowerLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // classLabelLabel
            // 
            resources.ApplyResources(this.classLabelLabel, "classLabelLabel");
            this.classLabelLabel.Name = "classLabelLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // pluralLabel
            // 
            resources.ApplyResources(this.pluralLabel, "pluralLabel");
            this.pluralLabel.Name = "pluralLabel";
            // 
            // classLabelTextBox
            // 
            resources.ApplyResources(this.classLabelTextBox, "classLabelTextBox");
            this.classLabelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classLabelTextBox.Name = "classLabelTextBox";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Name = "nameTextBox";
            // 
            // pluralTextBox
            // 
            resources.ApplyResources(this.pluralTextBox, "pluralTextBox");
            this.pluralTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pluralTextBox.Name = "pluralTextBox";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.nameStrRefCheckBox);
            this.mainPanel.Controls.Add(this.pluralStrRefCheckBox);
            this.mainPanel.Controls.Add(this.lowerRedRefCheckBox);
            this.mainPanel.Controls.Add(this.lowerTextBox);
            this.mainPanel.Controls.Add(this.lowerLabel);
            this.mainPanel.Controls.Add(this.classLabelLabel);
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.okButton);
            this.mainPanel.Controls.Add(this.pluralLabel);
            this.mainPanel.Controls.Add(this.pluralTextBox);
            this.mainPanel.Controls.Add(this.classLabelTextBox);
            this.mainPanel.Controls.Add(this.nameTextBox);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // nameStrRefCheckBox
            // 
            resources.ApplyResources(this.nameStrRefCheckBox, "nameStrRefCheckBox");
            this.nameStrRefCheckBox.Name = "nameStrRefCheckBox";
            this.nameStrRefCheckBox.UseVisualStyleBackColor = true;
            this.nameStrRefCheckBox.Click += new System.EventHandler(this.nameStrRefCheckBox_CheckedChanged);
            // 
            // pluralStrRefCheckBox
            // 
            resources.ApplyResources(this.pluralStrRefCheckBox, "pluralStrRefCheckBox");
            this.pluralStrRefCheckBox.Name = "pluralStrRefCheckBox";
            this.pluralStrRefCheckBox.UseVisualStyleBackColor = true;
            this.pluralStrRefCheckBox.Click += new System.EventHandler(this.pluralCheckBox_CheckedChanged);
            // 
            // lowerRedRefCheckBox
            // 
            resources.ApplyResources(this.lowerRedRefCheckBox, "lowerRedRefCheckBox");
            this.lowerRedRefCheckBox.Name = "lowerRedRefCheckBox";
            this.lowerRedRefCheckBox.UseVisualStyleBackColor = true;
            this.lowerRedRefCheckBox.Click += new System.EventHandler(this.lowerCheckBox_CheckedChanged);
            // 
            // lowerTextBox
            // 
            resources.ApplyResources(this.lowerTextBox, "lowerTextBox");
            this.lowerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerTextBox.Name = "lowerTextBox";
            // 
            // lowerLabel
            // 
            resources.ApplyResources(this.lowerLabel, "lowerLabel");
            this.lowerLabel.Name = "lowerLabel";
            // 
            // NWN2NameEditorDialogForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NWN2NameEditorDialogForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label classLabelLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label pluralLabel;
        private System.Windows.Forms.TextBox classLabelTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox pluralTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox lowerTextBox;
        private System.Windows.Forms.Label lowerLabel;
        private System.Windows.Forms.CheckBox nameStrRefCheckBox;
        private System.Windows.Forms.CheckBox pluralStrRefCheckBox;
        private System.Windows.Forms.CheckBox lowerRedRefCheckBox;
    }
}