namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2PackageListBox
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
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.removePackageButton = new System.Windows.Forms.Button();
            this.editPackageButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.packagesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // packageListBox
            // 
            this.packageListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.packageListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.Location = new System.Drawing.Point(3, 29);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(173, 249);
            this.packageListBox.TabIndex = 0;
            this.packageListBox.SelectedValueChanged += new System.EventHandler(this.packageListBox_SelectedValueChanged);
            // 
            // addPackageButton
            // 
            this.addPackageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPackageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPackageButton.Location = new System.Drawing.Point(182, 29);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(75, 23);
            this.addPackageButton.TabIndex = 1;
            this.addPackageButton.Text = "Add";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // removePackageButton
            // 
            this.removePackageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removePackageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePackageButton.Location = new System.Drawing.Point(182, 58);
            this.removePackageButton.Name = "removePackageButton";
            this.removePackageButton.Size = new System.Drawing.Size(75, 23);
            this.removePackageButton.TabIndex = 2;
            this.removePackageButton.Text = "Remove";
            this.removePackageButton.UseVisualStyleBackColor = true;
            this.removePackageButton.Click += new System.EventHandler(this.removePackageButton_Click);
            // 
            // editPackageButton
            // 
            this.editPackageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPackageButton.Enabled = false;
            this.editPackageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPackageButton.Location = new System.Drawing.Point(182, 87);
            this.editPackageButton.Name = "editPackageButton";
            this.editPackageButton.Size = new System.Drawing.Size(75, 23);
            this.editPackageButton.TabIndex = 3;
            this.editPackageButton.Text = "Edit";
            this.editPackageButton.UseVisualStyleBackColor = true;
            this.editPackageButton.Click += new System.EventHandler(this.editPackageButton_Click);
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Location = new System.Drawing.Point(182, 228);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 4;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Location = new System.Drawing.Point(182, 257);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 23);
            this.downButton.TabIndex = 5;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // packagesLabel
            // 
            this.packagesLabel.AutoSize = true;
            this.packagesLabel.Location = new System.Drawing.Point(3, 8);
            this.packagesLabel.Name = "packagesLabel";
            this.packagesLabel.Size = new System.Drawing.Size(55, 13);
            this.packagesLabel.TabIndex = 6;
            this.packagesLabel.Text = "Packages";
            // 
            // NWN2PackageListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.packagesLabel);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.editPackageButton);
            this.Controls.Add(this.removePackageButton);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.packageListBox);
            this.Name = "NWN2PackageListBox";
            this.Size = new System.Drawing.Size(260, 286);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Button removePackageButton;
        private System.Windows.Forms.Button editPackageButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Label packagesLabel;
    }
}
