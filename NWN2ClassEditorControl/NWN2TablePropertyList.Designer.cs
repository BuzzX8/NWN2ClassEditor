namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2TablePropertyList
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
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.NWN2PropertyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NWN2PropertyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(301, 25);
            this.MainToolStrip.TabIndex = 0;
            // 
            // NWN2PropertyDataGridView
            // 
            this.NWN2PropertyDataGridView.AllowUserToAddRows = false;
            this.NWN2PropertyDataGridView.AllowUserToDeleteRows = false;
            this.NWN2PropertyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NWN2PropertyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NWN2PropertyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NWN2PropertyDataGridView.Location = new System.Drawing.Point(0, 25);
            this.NWN2PropertyDataGridView.Name = "NWN2PropertyDataGridView";
            this.NWN2PropertyDataGridView.RowHeadersVisible = false;
            this.NWN2PropertyDataGridView.Size = new System.Drawing.Size(301, 290);
            this.NWN2PropertyDataGridView.TabIndex = 1;
            // 
            // NWN2TablePropertyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NWN2PropertyDataGridView);
            this.Controls.Add(this.MainToolStrip);
            this.Name = "NWN2TablePropertyList";
            this.Size = new System.Drawing.Size(301, 315);
            ((System.ComponentModel.ISupportInitialize)(this.NWN2PropertyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView NWN2PropertyDataGridView;
        public System.Windows.Forms.ToolStrip MainToolStrip;        
    }
}
