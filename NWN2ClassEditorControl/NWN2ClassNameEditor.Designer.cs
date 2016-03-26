namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2ClassNameEditor
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
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.editClassNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.classNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classNameTextBox.Enabled = false;
            this.classNameTextBox.Location = new System.Drawing.Point(0, 16);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.classNameTextBox.TabIndex = 29;
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(64, 13);
            this.ClassNameLabel.TabIndex = 28;
            this.ClassNameLabel.Text = "Class name:";
            // 
            // editClassNameButton
            // 
            this.editClassNameButton.BackColor = System.Drawing.Color.Silver;
            this.editClassNameButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editClassNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClassNameButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.ClassNameImage;
            this.editClassNameButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editClassNameButton.Location = new System.Drawing.Point(0, 41);
            this.editClassNameButton.Name = "editClassNameButton";
            this.editClassNameButton.Size = new System.Drawing.Size(100, 24);
            this.editClassNameButton.TabIndex = 30;
            this.editClassNameButton.Text = "Edit name";
            this.editClassNameButton.UseVisualStyleBackColor = false;
            this.editClassNameButton.Click += new System.EventHandler(this.editClassNameButton_Click);
            // 
            // NWN2ClassNameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editClassNameButton);
            this.Controls.Add(this.classNameTextBox);
            this.Controls.Add(this.ClassNameLabel);
            this.MinimumSize = new System.Drawing.Size(100, 65);
            this.Name = "NWN2ClassNameEditor";
            this.Size = new System.Drawing.Size(100, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editClassNameButton;
        private System.Windows.Forms.TextBox classNameTextBox;
        public System.Windows.Forms.Label ClassNameLabel;
    }
}
