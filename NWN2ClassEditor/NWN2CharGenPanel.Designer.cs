using System.Windows.Forms;
namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2CharGenPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NWN2CharGenPanel));
            this.charGenButton = new System.Windows.Forms.Button();
            this.apperanceToolStrip = new System.Windows.Forms.ToolStrip();
            this.apperanceToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apperanceToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.genderToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.genderToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.maleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.headToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.hairToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.hairToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tintSkinToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.electronPanel = new OEIShared.UI.ElectronPanel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.apperanceToolStrip.SuspendLayout();
            // 
            // charGenButton
            // 
            this.charGenButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.charGenButton.Location = new System.Drawing.Point(0, 0);
            this.charGenButton.Name = "charGenButton";
            this.charGenButton.Size = new System.Drawing.Size(75, 23);
            this.charGenButton.TabIndex = 0;
            this.charGenButton.Text = "Select CharGen";
            // 
            // apperanceToolStrip
            // 
            this.apperanceToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.apperanceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apperanceToolStripLabel,
            this.apperanceToolStripComboBox,
            this.toolStripSeparator1,
            this.genderToolStripLabel,
            this.genderToolStripSplitButton,
            this.headToolStripLabel,
            this.headToolStripComboBox,
            this.hairToolStripLabel,
            this.hairToolStripComboBox,
            this.toolStripSeparator2,
            this.tintSkinToolStripButton});
            this.apperanceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.apperanceToolStrip.Name = "apperanceToolStrip";
            this.apperanceToolStrip.Size = new System.Drawing.Size(100, 25);
            this.apperanceToolStrip.TabIndex = 0;
            // 
            // apperanceToolStripLabel
            // 
            this.apperanceToolStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.apperanceToolStripLabel.Name = "apperanceToolStripLabel";
            this.apperanceToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.apperanceToolStripLabel.Text = "Apperance";
            // 
            // apperanceToolStripComboBox
            // 
            this.apperanceToolStripComboBox.Name = "apperanceToolStripComboBox";
            this.apperanceToolStripComboBox.Size = new System.Drawing.Size(120, 21);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // genderToolStripLabel
            // 
            this.genderToolStripLabel.Name = "genderToolStripLabel";
            this.genderToolStripLabel.Size = new System.Drawing.Size(42, 13);
            this.genderToolStripLabel.Text = "Gender";
            // 
            // genderToolStripSplitButton
            // 
            this.genderToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.genderToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem,
            this.femaleToolStripMenuItem});
            this.genderToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("genderToolStripSplitButton.Image")));
            this.genderToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.genderToolStripSplitButton.Name = "genderToolStripSplitButton";
            this.genderToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            // 
            // maleToolStripMenuItem
            // 
            this.maleToolStripMenuItem.Name = "maleToolStripMenuItem";
            this.maleToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.maleToolStripMenuItem.Text = "Male";
            // 
            // femaleToolStripMenuItem
            // 
            this.femaleToolStripMenuItem.Name = "femaleToolStripMenuItem";
            this.femaleToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.femaleToolStripMenuItem.Text = "Female";
            // 
            // headToolStripLabel
            // 
            this.headToolStripLabel.Name = "headToolStripLabel";
            this.headToolStripLabel.Size = new System.Drawing.Size(39, 13);
            this.headToolStripLabel.Text = "Head :";
            // 
            // headToolStripComboBox
            // 
            this.headToolStripComboBox.DropDownWidth = 40;
            this.headToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headToolStripComboBox.Name = "headToolStripComboBox";
            this.headToolStripComboBox.Size = new System.Drawing.Size(75, 21);
            // 
            // hairToolStripLabel
            // 
            this.hairToolStripLabel.Name = "hairToolStripLabel";
            this.hairToolStripLabel.Size = new System.Drawing.Size(33, 13);
            this.hairToolStripLabel.Text = "Hair :";
            // 
            // hairToolStripComboBox
            // 
            this.hairToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hairToolStripComboBox.Name = "hairToolStripComboBox";
            this.hairToolStripComboBox.Size = new System.Drawing.Size(75, 21);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // tintSkinToolStripButton
            // 
            this.tintSkinToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tintSkinToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tintSkinToolStripButton.Image")));
            this.tintSkinToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tintSkinToolStripButton.Name = "tintSkinToolStripButton";
            this.tintSkinToolStripButton.Size = new System.Drawing.Size(50, 17);
            this.tintSkinToolStripButton.Text = "Tint skin";
            // 
            // electronPanel
            // 
            this.electronPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electronPanel.Location = new System.Drawing.Point(0, 0);
            this.electronPanel.Name = "electronPanel";
            this.electronPanel.Size = new System.Drawing.Size(336, 296);
            this.electronPanel.TabIndex = 0;
            this.electronPanel.Load += new System.EventHandler(this.electronPanel_Load);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            this.apperanceToolStrip.ResumeLayout(false);
            this.apperanceToolStrip.PerformLayout();

        }

        #endregion

        private Button charGenButton;
        private ToolStrip apperanceToolStrip;
        private OEIShared.UI.ElectronPanel electronPanel;
        private ToolStripLabel apperanceToolStripLabel;
        private ToolStripComboBox apperanceToolStripComboBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton genderToolStripSplitButton;
        private ToolStripLabel genderToolStripLabel;
        private ToolStripMenuItem maleToolStripMenuItem;
        private ToolStripMenuItem femaleToolStripMenuItem;
        private ColorDialog colorDialog;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tintSkinToolStripButton;
        private ToolStripLabel hairToolStripLabel;
        private ToolStripComboBox hairToolStripComboBox;
        private ToolStripLabel headToolStripLabel;
        private ToolStripComboBox headToolStripComboBox;
    }
}
