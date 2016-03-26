using System.Windows.Forms;
using BuzzX8.NWN2ClassEditor;
namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2PropertySelectableList
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
            this.SelectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeselectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SearchToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.SearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            // 
            // propertyList
            // 
            this.PropertyListCheckedListBox.Size = new System.Drawing.Size(326, 304);
            // 
            // SelectAllToolStripButton
            // 
            this.SelectAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.SelectAllToolStripButton.Name = "SelectAllToolStripButton";
            this.SelectAllToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.SelectAllToolStripButton.Text = "Check all";
            this.SelectAllToolStripButton.Image = BuzzX8.NWN2ClassEditor.Properties.Resources.CheckAll;
            this.SelectAllToolStripButton.Click += new System.EventHandler(this.selectAllToolStripButton_Click);
            // 
            // DeselectAllToolStripButton
            // 
            this.DeselectAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.DeselectAllToolStripButton.Name = "DeselectAllToolStripButton";
            this.DeselectAllToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.DeselectAllToolStripButton.Text = "Clear";
            this.DeselectAllToolStripButton.Image = BuzzX8.NWN2ClassEditor.Properties.Resources.ClearList;
            this.DeselectAllToolStripButton.Click += new System.EventHandler(this.deselectAllToolStripButton_Click);
            // 
            // SearchToolStripLabel
            // 
            this.SearchToolStripLabel.Name = "SearchToolStripLabel";
            this.SearchToolStripLabel.Size = new System.Drawing.Size(47, 22);
            this.SearchToolStripLabel.Text = "Search:";
            // 
            // SearchToolStripTextBox
            // 
            this.SearchToolStripTextBox.Name = "SearchToolStripTextBox";
            this.SearchToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // SearchToolStripButton
            // 
            this.SearchToolStripButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.Search;
            this.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchToolStripButton.Name = "SearchToolStripButton";
            this.SearchToolStripButton.Size = new System.Drawing.Size(31, 22);
            this.SearchToolStripButton.Text = "Find";
            //
            //FilterToolStripLabel
            //
            this.FilterToolStripLabel = new ToolStripLabel();
            this.FilterToolStripLabel.Text = "Filter :";
            //
            //FilterToolStripTextBox
            //
            this.FilterToolStripTextBox = new ToolStripTextBox();
            //
            //FilterToolStripButton
            //
            this.FilterToolStripButton = new ToolStripButton();
            this.FilterToolStripButton.Text = "Filter";
            // 
            // NWN2PropertySelectableList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "NWN2PropertySelectableList";
            this.Size = new System.Drawing.Size(254, 329);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            //Separator1
            //
            Separator1 = new ToolStripSeparator();            
            //
            //MainMenuToolStrip
            //
            this.PropertyListCheckedListBox.Width = this.Width;
            this.MainToolStrip.Items.Add(SelectAllToolStripButton);
            this.MainToolStrip.Items.Add(DeselectAllToolStripButton);
            this.MainToolStrip.Items.Add(new ToolStripSeparator());
            this.MainToolStrip.Items.Add(SearchToolStripLabel);
            this.MainToolStrip.Items.Add(SearchToolStripTextBox);
            this.MainToolStrip.Items.Add(SearchToolStripButton);
            this.MainToolStrip.Items.Add(Separator1);
            this.MainToolStrip.Items.Add(FilterToolStripLabel);
            this.MainToolStrip.Items.Add(FilterToolStripTextBox);
            this.MainToolStrip.Items.Add(FilterToolStripButton);
        }

        void deselectAllToolStripButton_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < PropertyListCheckedListBox.Items.Count; i++)
            {
                PropertyListCheckedListBox.SetItemChecked(i, false);

                if (ItemCheck != null) ItemCheck(this, new ItemCheckEventArgs(i, CheckState.Unchecked, CheckState.Unchecked));
            }
        }

        void selectAllToolStripButton_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < PropertyListCheckedListBox.Items.Count; i++)
            {
                PropertyListCheckedListBox.SetItemChecked(i, true);

                if (ItemCheck != null) ItemCheck(this, new ItemCheckEventArgs(i, CheckState.Checked, CheckState.Checked));
            }
        }

        protected ToolStripButton SelectAllToolStripButton;
        protected ToolStripButton DeselectAllToolStripButton;
        protected ToolStripLabel SearchToolStripLabel;
        protected ToolStripTextBox SearchToolStripTextBox;
        protected ToolStripButton SearchToolStripButton;
        protected ToolStripSeparator Separator1;
        protected ToolStripLabel FilterToolStripLabel;
        protected ToolStripTextBox FilterToolStripTextBox;
        protected ToolStripButton FilterToolStripButton;
        
        #endregion
    }
}
