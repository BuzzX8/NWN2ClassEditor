namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2ClassDescriptionEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionResRefCheckBox = new System.Windows.Forms.CheckBox();
            this.classDescriptionLabel = new System.Windows.Forms.Label();
            this.classDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.createDescriptionTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionResRefCheckBox
            // 
            this.descriptionResRefCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionResRefCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.descriptionResRefCheckBox.AutoSize = true;
            this.descriptionResRefCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionResRefCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionResRefCheckBox.Location = new System.Drawing.Point(95, 4);
            this.descriptionResRefCheckBox.Name = "descriptionResRefCheckBox";
            this.descriptionResRefCheckBox.Size = new System.Drawing.Size(47, 23);
            this.descriptionResRefCheckBox.TabIndex = 25;
            this.descriptionResRefCheckBox.Text = "StrRef";
            this.descriptionResRefCheckBox.UseVisualStyleBackColor = false;
            this.descriptionResRefCheckBox.Click += new System.EventHandler(this.descriptionResRefCheckBox_Click);
            // 
            // classDescriptionLabel
            // 
            this.classDescriptionLabel.AutoSize = true;
            this.classDescriptionLabel.Location = new System.Drawing.Point(3, 8);
            this.classDescriptionLabel.Name = "classDescriptionLabel";
            this.classDescriptionLabel.Size = new System.Drawing.Size(92, 13);
            this.classDescriptionLabel.TabIndex = 24;
            this.classDescriptionLabel.Text = "Class description :";
            // 
            // classDescriptionTextBox
            // 
            this.classDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.classDescriptionTextBox.BackColor = System.Drawing.Color.White;
            this.classDescriptionTextBox.Location = new System.Drawing.Point(0, 32);
            this.classDescriptionTextBox.Multiline = true;
            this.classDescriptionTextBox.Name = "classDescriptionTextBox";
            this.classDescriptionTextBox.Size = new System.Drawing.Size(145, 52);
            this.classDescriptionTextBox.TabIndex = 23;
            // 
            // createDescriptionTextButton
            // 
            this.createDescriptionTextButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createDescriptionTextButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.DescriptionLetter;
            this.createDescriptionTextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createDescriptionTextButton.Location = new System.Drawing.Point(0, 87);
            this.createDescriptionTextButton.Name = "createDescriptionTextButton";
            this.createDescriptionTextButton.Size = new System.Drawing.Size(145, 23);
            this.createDescriptionTextButton.TabIndex = 22;
            this.createDescriptionTextButton.Text = "Create description";
            this.createDescriptionTextButton.UseVisualStyleBackColor = true;
            this.createDescriptionTextButton.Click += new System.EventHandler(this.createDescriptionTextButton_Click);
            // 
            // NWN2ClassDescriptionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionResRefCheckBox);
            this.Controls.Add(this.classDescriptionLabel);
            this.Controls.Add(this.classDescriptionTextBox);
            this.Controls.Add(this.createDescriptionTextButton);
            this.MinimumSize = new System.Drawing.Size(145, 110);
            this.Name = "NWN2ClassDescriptionEditor";
            this.Size = new System.Drawing.Size(145, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox descriptionResRefCheckBox;
        private System.Windows.Forms.Label classDescriptionLabel;
        private System.Windows.Forms.TextBox classDescriptionTextBox;
        private System.Windows.Forms.Button createDescriptionTextButton;
    }
}
