namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2SpontaneousConversationForm
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
            this.spellConversationDataGridView = new System.Windows.Forms.DataGridView();
            this.spellLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversationSpellColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.overlayIconColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.altSpellConversationDataGridView = new System.Windows.Forms.DataGridView();
            this.altSpellConversationColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.altSpellOverlayIconColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.altSpellsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spellConversationDataGridView)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altSpellConversationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // spellConversationDataGridView
            // 
            this.spellConversationDataGridView.AllowUserToAddRows = false;
            this.spellConversationDataGridView.AllowUserToDeleteRows = false;
            this.spellConversationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.spellConversationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spellConversationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spellLevelColumn,
            this.conversationSpellColumn,
            this.overlayIconColumn});
            this.spellConversationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellConversationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.spellConversationDataGridView.MultiSelect = false;
            this.spellConversationDataGridView.Name = "spellConversationDataGridView";
            this.spellConversationDataGridView.RowHeadersVisible = false;
            this.spellConversationDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.spellConversationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.spellConversationDataGridView.Size = new System.Drawing.Size(380, 214);
            this.spellConversationDataGridView.TabIndex = 0;
            this.spellConversationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // spellLevelColumn
            // 
            this.spellLevelColumn.FillWeight = 10F;
            this.spellLevelColumn.HeaderText = "Spell level";
            this.spellLevelColumn.Name = "spellLevelColumn";
            // 
            // conversationSpellColumn
            // 
            this.conversationSpellColumn.FillWeight = 75F;
            this.conversationSpellColumn.HeaderText = "Conversation spell";
            this.conversationSpellColumn.Name = "conversationSpellColumn";
            // 
            // overlayIconColumn
            // 
            this.overlayIconColumn.FillWeight = 15F;
            this.overlayIconColumn.HeaderText = "Overlay icon";
            this.overlayIconColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.overlayIconColumn.Name = "overlayIconColumn";
            this.overlayIconColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spellConversationDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.altSpellConversationDataGridView);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(380, 214);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 2;
            // 
            // altSpellConversationDataGridView
            // 
            this.altSpellConversationDataGridView.AllowUserToAddRows = false;
            this.altSpellConversationDataGridView.AllowUserToDeleteRows = false;
            this.altSpellConversationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.altSpellConversationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.altSpellConversationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.altSpellConversationColumn,
            this.altSpellOverlayIconColumn});
            this.altSpellConversationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altSpellConversationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.altSpellConversationDataGridView.MultiSelect = false;
            this.altSpellConversationDataGridView.Name = "altSpellConversationDataGridView";
            this.altSpellConversationDataGridView.RowHeadersVisible = false;
            this.altSpellConversationDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.altSpellConversationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.altSpellConversationDataGridView.Size = new System.Drawing.Size(150, 46);
            this.altSpellConversationDataGridView.TabIndex = 1;
            this.altSpellConversationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.altSpellConversationDataGridView_CellClick);
            // 
            // altSpellConversationColumn
            // 
            this.altSpellConversationColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altSpellConversationColumn.HeaderText = "Conversation spell";
            this.altSpellConversationColumn.Name = "altSpellConversationColumn";
            this.altSpellConversationColumn.Width = 89;
            // 
            // altSpellOverlayIconColumn
            // 
            this.altSpellOverlayIconColumn.HeaderText = "Overlay icon";
            this.altSpellOverlayIconColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.altSpellOverlayIconColumn.Name = "altSpellOverlayIconColumn";
            this.altSpellOverlayIconColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.altSpellOverlayIconColumn.Width = 65;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(227, 223);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(308, 223);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // altSpellsCheckBox
            // 
            this.altSpellsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.altSpellsCheckBox.AutoSize = true;
            this.altSpellsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altSpellsCheckBox.Location = new System.Drawing.Point(12, 226);
            this.altSpellsCheckBox.Name = "altSpellsCheckBox";
            this.altSpellsCheckBox.Size = new System.Drawing.Size(102, 17);
            this.altSpellsCheckBox.TabIndex = 5;
            this.altSpellsCheckBox.Text = "Alternative spells";
            this.altSpellsCheckBox.UseVisualStyleBackColor = true;
            this.altSpellsCheckBox.CheckedChanged += new System.EventHandler(this.altSpellsCheckBox_CheckedChanged);
            // 
            // NWN2SpontaneousConversationForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(386, 250);
            this.Controls.Add(this.altSpellsCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NWN2SpontaneousConversationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spontaneous conversation";
            ((System.ComponentModel.ISupportInitialize)(this.spellConversationDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.altSpellConversationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView spellConversationDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellLevelColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn conversationSpellColumn;
        private System.Windows.Forms.DataGridViewImageColumn overlayIconColumn;
        private System.Windows.Forms.DataGridView altSpellConversationDataGridView;
        private System.Windows.Forms.CheckBox altSpellsCheckBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn altSpellConversationColumn;
        private System.Windows.Forms.DataGridViewImageColumn altSpellOverlayIconColumn;
    }
}