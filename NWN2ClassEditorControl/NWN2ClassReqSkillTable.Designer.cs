using System.Windows.Forms;
namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2ClassReqSkillTable
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
            this.skillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqSkillLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsReqGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.skillsReqGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SkillName
            // 
            this.skillName.HeaderText = "Skill";
            this.skillName.Name = "SkillName";
            this.skillName.ValueType = typeof(NWN2PropertyListItem);
            this.skillName.ReadOnly = true;
            // 
            // ReqSkillLevel
            // 
            this.reqSkillLevel.HeaderText = "Requaried level";
            this.reqSkillLevel.Name = "ReqSkillLevel";
            this.reqSkillLevel.ValueType = typeof(int);
            // 
            // skillsReqGrid
            // 
            this.skillsReqGrid.AllowUserToAddRows = false;
            this.skillsReqGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skillsReqGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillName,
            this.reqSkillLevel});
            this.skillsReqGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsReqGrid.Location = new System.Drawing.Point(0, 0);
            this.skillsReqGrid.AllowUserToResizeRows = false;
            this.skillsReqGrid.MultiSelect = false;
            this.skillsReqGrid.Name = "skillsReqGrid";
            this.skillsReqGrid.RowHeadersVisible = false;
            this.skillsReqGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.skillsReqGrid.Size = new System.Drawing.Size(200, 200);
            this.skillsReqGrid.TabIndex = 0;
            this.skillsReqGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.skillsReqGrid_MouseClick);
            this.skillsReqGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.skillsReqGrid_DataError);
            // 
            // NWN2ClassReqSkillTable
            // 
            this.Controls.Add(this.skillsReqGrid);
            this.Name = "NWN2ClassReqSkillTable";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.skillsReqGrid)).EndInit();
            this.ResumeLayout(false);

        }

        void skillsReqGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
            MessageBox.Show(e.Exception.Message);
        }

        void skillsReqGrid_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.DataGridView.HitTestInfo hitInfo = skillsReqGrid.HitTest(e.X, e.Y);
            DataGridViewRow selectedRow;

            if (hitInfo.Equals(System.Windows.Forms.DataGridView.HitTestInfo.Nowhere) || hitInfo.RowIndex < 0 || descriptionTextBox == null) return;

            selectedRow = skillsReqGrid.Rows[hitInfo.RowIndex];
            descriptionTextBox.Text = ((NWN2PropertyListItem)selectedRow.Cells["SkillName"].Value).Description;
        }        

        #endregion
             
        private DataGridView skillsReqGrid;
        private DataGridViewTextBoxColumn skillName;
        private DataGridViewTextBoxColumn reqSkillLevel;
    }
}
