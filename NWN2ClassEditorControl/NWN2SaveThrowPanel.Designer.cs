namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2SaveThrowPanel
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
            this.saveThrowTitleLabel = new System.Windows.Forms.Label();
            this.willThrowCheckBox = new System.Windows.Forms.CheckBox();
            this.reflexThrowCheckBox = new System.Windows.Forms.CheckBox();
            this.fortiduteCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // saveThrowTitleLabel
            // 
            this.saveThrowTitleLabel.AutoSize = true;
            this.saveThrowTitleLabel.Location = new System.Drawing.Point(4, 6);
            this.saveThrowTitleLabel.Name = "saveThrowTitleLabel";
            this.saveThrowTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.saveThrowTitleLabel.TabIndex = 0;
            this.saveThrowTitleLabel.Text = "SaveThrow";
            // 
            // willThrowCheckBox
            // 
            this.willThrowCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.willThrowCheckBox.AutoSize = true;
            this.willThrowCheckBox.Location = new System.Drawing.Point(8, 77);
            this.willThrowCheckBox.Name = "willThrowCheckBox";
            this.willThrowCheckBox.Size = new System.Drawing.Size(43, 17);
            this.willThrowCheckBox.TabIndex = 5;
            this.willThrowCheckBox.Text = "Will";
            this.willThrowCheckBox.UseVisualStyleBackColor = true;
            // 
            // reflexThrowCheckBox
            // 
            this.reflexThrowCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reflexThrowCheckBox.AutoSize = true;
            this.reflexThrowCheckBox.Location = new System.Drawing.Point(8, 54);
            this.reflexThrowCheckBox.Name = "reflexThrowCheckBox";
            this.reflexThrowCheckBox.Size = new System.Drawing.Size(56, 17);
            this.reflexThrowCheckBox.TabIndex = 4;
            this.reflexThrowCheckBox.Text = "Reflex";
            this.reflexThrowCheckBox.UseVisualStyleBackColor = true;
            // 
            // fortiduteCheckBox
            // 
            this.fortiduteCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fortiduteCheckBox.AutoSize = true;
            this.fortiduteCheckBox.Location = new System.Drawing.Point(8, 31);
            this.fortiduteCheckBox.Name = "fortiduteCheckBox";
            this.fortiduteCheckBox.Size = new System.Drawing.Size(67, 17);
            this.fortiduteCheckBox.TabIndex = 3;
            this.fortiduteCheckBox.Text = "Fortidute";
            this.fortiduteCheckBox.UseVisualStyleBackColor = true;
            // 
            // NWN2SaveThrowPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.willThrowCheckBox);
            this.Controls.Add(this.reflexThrowCheckBox);
            this.Controls.Add(this.fortiduteCheckBox);
            this.Controls.Add(this.saveThrowTitleLabel);
            this.Name = "NWN2SaveThrowPanel";
            this.Size = new System.Drawing.Size(169, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saveThrowTitleLabel;
        private System.Windows.Forms.CheckBox willThrowCheckBox;
        private System.Windows.Forms.CheckBox reflexThrowCheckBox;
        private System.Windows.Forms.CheckBox fortiduteCheckBox;
    }
}
