namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2ClassReqFeatsTable
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
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.checkAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.featsDataGridView = new System.Windows.Forms.DataGridView();
            this.reqFeatColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.featNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orFeatColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripButton,
            this.clearListToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(325, 25);
            this.mainToolStrip.TabIndex = 0;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // checkAllToolStripButton
            // 
            this.checkAllToolStripButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.CheckAll;
            this.checkAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkAllToolStripButton.Name = "checkAllToolStripButton";
            this.checkAllToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.checkAllToolStripButton.Text = "Check all";
            // 
            // clearListToolStripButton
            // 
            this.clearListToolStripButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.ClearList;
            this.clearListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearListToolStripButton.Name = "clearListToolStripButton";
            this.clearListToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.clearListToolStripButton.Text = "Clear";
            // 
            // featsDataGridView
            // 
            this.featsDataGridView.AllowUserToAddRows = false;
            this.featsDataGridView.AllowUserToDeleteRows = false;
            this.featsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.featsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.featsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.featsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqFeatColumn,
            this.featNameColumn,
            this.orFeatColumn});
            this.featsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.featsDataGridView.Name = "featsDataGridView";
            this.featsDataGridView.RowHeadersVisible = false;
            this.featsDataGridView.Size = new System.Drawing.Size(325, 185);
            this.featsDataGridView.TabIndex = 1;
            // 
            // reqFeatColumn
            // 
            this.reqFeatColumn.FalseValue = false;
            this.reqFeatColumn.FillWeight = 20F;
            this.reqFeatColumn.HeaderText = "Require";
            this.reqFeatColumn.Name = "reqFeatColumn";
            this.reqFeatColumn.TrueValue = true;
            // 
            // featNameColumn
            // 
            this.featNameColumn.FillWeight = 60F;
            this.featNameColumn.HeaderText = "Feat";
            this.featNameColumn.Name = "featNameColumn";
            this.featNameColumn.ReadOnly = true;
            this.featNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // orFeatColumn
            // 
            this.orFeatColumn.FalseValue = false;
            this.orFeatColumn.FillWeight = 20F;
            this.orFeatColumn.HeaderText = "Or";
            this.orFeatColumn.Name = "orFeatColumn";
            this.orFeatColumn.TrueValue = true;
            // 
            // NWN2ClassReqFeatsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.featsDataGridView);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "NWN2ClassReqFeatsTable";
            this.Size = new System.Drawing.Size(325, 210);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton checkAllToolStripButton;
        private System.Windows.Forms.ToolStripButton clearListToolStripButton;
        private System.Windows.Forms.DataGridView featsDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reqFeatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featNameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orFeatColumn;
    }
}
