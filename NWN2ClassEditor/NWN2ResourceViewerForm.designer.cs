namespace NWN2ResourceViewer
{
    partial class NWN2ResourceViewerForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.repositoryesListBox = new System.Windows.Forms.ListBox();
            this.resourceDataGridView = new System.Windows.Forms.DataGridView();
            this.fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resRefColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.resourceContentTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataGridView)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.repositoryesListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resourceDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(595, 313);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 0;
            // 
            // repositoryesListBox
            // 
            this.repositoryesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repositoryesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repositoryesListBox.FormattingEnabled = true;
            this.repositoryesListBox.Location = new System.Drawing.Point(0, 0);
            this.repositoryesListBox.Name = "repositoryesListBox";
            this.repositoryesListBox.Size = new System.Drawing.Size(267, 312);
            this.repositoryesListBox.TabIndex = 0;
            this.repositoryesListBox.SelectedIndexChanged += new System.EventHandler(this.repositoryesListBox_SelectedIndexChanged);
            // 
            // resourceDataGridView
            // 
            this.resourceDataGridView.AllowUserToAddRows = false;
            this.resourceDataGridView.AllowUserToDeleteRows = false;
            this.resourceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameColumn,
            this.typeColumn,
            this.resRefColumn});
            this.resourceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.resourceDataGridView.MultiSelect = false;
            this.resourceDataGridView.Name = "resourceDataGridView";
            this.resourceDataGridView.ReadOnly = true;
            this.resourceDataGridView.RowHeadersVisible = false;
            this.resourceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resourceDataGridView.Size = new System.Drawing.Size(324, 313);
            this.resourceDataGridView.TabIndex = 0;
            this.resourceDataGridView.Click += new System.EventHandler(this.resourceDataGridView_Click);
            // 
            // fullNameColumn
            // 
            this.fullNameColumn.HeaderText = "Full name";
            this.fullNameColumn.Name = "fullNameColumn";
            this.fullNameColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // resRefColumn
            // 
            this.resRefColumn.HeaderText = "ResRef";
            this.resRefColumn.Name = "resRefColumn";
            this.resRefColumn.ReadOnly = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.resourceContentTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(599, 424);
            this.splitContainer2.SplitterDistance = 317;
            this.splitContainer2.TabIndex = 1;
            // 
            // resourceContentTextBox
            // 
            this.resourceContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceContentTextBox.Location = new System.Drawing.Point(0, 0);
            this.resourceContentTextBox.Multiline = true;
            this.resourceContentTextBox.Name = "resourceContentTextBox";
            this.resourceContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resourceContentTextBox.Size = new System.Drawing.Size(595, 99);
            this.resourceContentTextBox.TabIndex = 0;
            // 
            // NWN2ResourceViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 424);
            this.Controls.Add(this.splitContainer2);
            this.Name = "NWN2ResourceViewerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NWN2ResourceViewer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataGridView)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox repositoryesListBox;
        private System.Windows.Forms.DataGridView resourceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resRefColumn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox resourceContentTextBox;
    }
}