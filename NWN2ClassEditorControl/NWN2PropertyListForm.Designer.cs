namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2PropertyListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NWN2PropertyListForm));
            this.propListCheckedListBox = new BuzzX8.NWN2ClassEditor.NWN2ProperyCheckedListbox();
            this.propertyDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.selectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deselectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.mainToolStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // propListCheckedListBox
            // 
            this.propListCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.propListCheckedListBox.DescriptionTextBox = this.propertyDescriptionTextBox;
            this.propListCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propListCheckedListBox.FormattingEnabled = true;
            this.propListCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.propListCheckedListBox.Name = "propListCheckedListBox";

            this.propListCheckedListBox.SelectedItem = null;

            this.propListCheckedListBox.Size = new System.Drawing.Size(446, 180);
            this.propListCheckedListBox.Sorted = true;
            this.propListCheckedListBox.TabIndex = 0;
            // 
            // propertyDescriptionTextBox
            // 
            this.propertyDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.propertyDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyDescriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.propertyDescriptionTextBox.Multiline = true;
            this.propertyDescriptionTextBox.Name = "propertyDescriptionTextBox";
            this.propertyDescriptionTextBox.Size = new System.Drawing.Size(446, 69);
            this.propertyDescriptionTextBox.TabIndex = 0;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripButton,
            this.deselectAllToolStripButton,
            this.toolStripSeparator1,
            this.toolStripLabel,
            this.searchToolStripTextBox,
            this.toolStripButton3});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(454, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // selectAllToolStripButton
            // 
            this.selectAllToolStripButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.CheckAll;
            this.selectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllToolStripButton.Name = "selectAllToolStripButton";
            this.selectAllToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.selectAllToolStripButton.Text = "Check all";
            this.selectAllToolStripButton.Click += new System.EventHandler(this.selectAllToolStripButton_Click);
            // 
            // deselectAllToolStripButton
            // 
            this.deselectAllToolStripButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.ClearList;
            this.deselectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deselectAllToolStripButton.Name = "deselectAllToolStripButton";
            this.deselectAllToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.deselectAllToolStripButton.Text = "Clear";
            this.deselectAllToolStripButton.Click += new System.EventHandler(this.deselectAllToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel.Text = "Search :";
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.searchToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchToolStripTextBox_KeyPress);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.Search;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(295, 295);
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
            this.cancelButton.Location = new System.Drawing.Point(376, 295);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Silver;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.splitContainer);
            this.mainPanel.Controls.Add(this.okButton);
            this.mainPanel.Controls.Add(this.mainToolStrip);
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(456, 325);
            this.mainPanel.TabIndex = 3;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(3, 28);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.propertyDescriptionTextBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel2.Controls.Add(this.propListCheckedListBox);
            this.splitContainer.Size = new System.Drawing.Size(448, 263);
            this.splitContainer.SplitterDistance = 71;
            this.splitContainer.TabIndex = 3;
            // 
            // NWN2PropertyListForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(456, 325);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NWN2PropertyListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feats list";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox propertyDescriptionTextBox;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton selectAllToolStripButton;
        private System.Windows.Forms.ToolStripButton deselectAllToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private NWN2ProperyCheckedListbox propListCheckedListBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}