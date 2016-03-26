using BuzzX8.NWN2ClassEditor;
namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2PropertyListExt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NWN2PropertyListExt));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.PropertyListCheckedListBox = new BuzzX8.NWN2ClassEditor.NWN2ProperyCheckedListbox();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(254, 25);
            this.MainToolStrip.TabIndex = 0;
            // 
            // PropertyListCheckedListBox
            // 
            this.PropertyListCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyListCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropertyListCheckedListBox.DescriptionTextBox = null;
            this.PropertyListCheckedListBox.Location = new System.Drawing.Point(0, 25);
            this.PropertyListCheckedListBox.Name = "PropertyListCheckedListBox";
            this.PropertyListCheckedListBox.NWN2PropertyList = ((BuzzX8.NWN2ClassEditor.NWN2PropertyList)(resources.GetObject("PropertyListCheckedListBox.NWN2PropertyList")));
            this.PropertyListCheckedListBox.SelectedItem = null;
            this.PropertyListCheckedListBox.SelectedItems = ((BuzzX8.NWN2ClassEditor.NWN2PropertyList)(resources.GetObject("PropertyListCheckedListBox.SelectedItems")));
            this.PropertyListCheckedListBox.Size = new System.Drawing.Size(254, 300);
            this.PropertyListCheckedListBox.TabIndex = 1;
            // 
            // NWN2PropertyListExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.PropertyListCheckedListBox);
            this.Name = "NWN2PropertyListExt";
            this.Size = new System.Drawing.Size(254, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip MainToolStrip;
        internal NWN2ProperyCheckedListbox PropertyListCheckedListBox;

    }
}
