using System.Windows.Forms;
namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2ClassFeatsGrid : NWN2TablePropertyList
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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.featNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gainLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onMenuColumn = new DataGridViewCheckBoxColumn();
            //
            //addSimpleWeaponProf
            //
            this.addSimpleWeaponProf = new ToolStripMenuItem();
            this.addSimpleWeaponProf.Text = "Simple weapon prof";
            this.addSimpleWeaponProf.Click += new System.EventHandler(addSimpleWeaponProf_Click);
            //
            //addMartialWeaponProf
            //
            this.addMartialWeaponProf = new ToolStripMenuItem();
            this.addMartialWeaponProf.Text = "Martial weapon prof";
            this.addMartialWeaponProf.Click += new System.EventHandler(addMartialWeaponProf_Click);
            //
            //addExoticWeaponProf
            //
            this.addExoticWeaponProf = new ToolStripMenuItem();
            this.addExoticWeaponProf.Text = "Exotic weapon prof";
            this.addExoticWeaponProf.Click += new System.EventHandler(addExoticWeaponProf_Click);
            //
            //addLightArmorProf
            //
            this.addLightArmorProf = new ToolStripMenuItem();
            this.addLightArmorProf.Text = "Light armour prof";
            this.addLightArmorProf.Click += new System.EventHandler(addLightArmorProf_Click);
            //
            //addMediumArmorProf
            //
            this.addMediumArmorProf = new ToolStripMenuItem();
            this.addMediumArmorProf.Text = "Medium armour prof";
            this.addMediumArmorProf.Click += new System.EventHandler(addMediumArmorProf_Click);
            //
            //addHevyArmorProf
            //
            this.addHevyArmorProf = new ToolStripMenuItem();
            this.addHevyArmorProf.Text = "Hevy armour prof";
            this.addHevyArmorProf.Click += new System.EventHandler(addHevyArmorProf_Click);
            //
            //addShieldProf
            //
            this.addShieldProf = new ToolStripMenuItem();
            this.addShieldProf.Text = "Shield prof";
            this.addShieldProf.Click += new System.EventHandler(addShieldProf_Click);
            //
            //addTowerShieldProf
            //
            this.addTowerShieldProf = new ToolStripMenuItem();
            this.addTowerShieldProf.Text = "Tower shield prof";
            this.addTowerShieldProf.Click += new System.EventHandler(addTowerShieldProf_Click);
            //
            //addStandartFeatsButton
            //
            this.addStandartFeatsButton = new ToolStripSplitButton();
            this.addStandartFeatsButton.Text = "Standart feats";
            this.addStandartFeatsButton.DropDownItems.Add(addSimpleWeaponProf);
            this.addStandartFeatsButton.DropDownItems.Add(addMartialWeaponProf);
            this.addStandartFeatsButton.DropDownItems.Add(addExoticWeaponProf);
            this.addStandartFeatsButton.DropDownItems.Add(new ToolStripSeparator());
            this.addStandartFeatsButton.DropDownItems.Add(addShieldProf);
            this.addStandartFeatsButton.DropDownItems.Add(addTowerShieldProf);
            this.addStandartFeatsButton.DropDownItems.Add(new ToolStripSeparator());
            this.addStandartFeatsButton.DropDownItems.Add(addLightArmorProf);
            this.addStandartFeatsButton.DropDownItems.Add(addMediumArmorProf);
            this.addStandartFeatsButton.DropDownItems.Add(addHevyArmorProf);
            // 
            // featNameColumn
            // 
            this.featNameColumn.HeaderText = "Feat";
            this.featNameColumn.Name = "FeatNameColumn";            
            this.featNameColumn.DisplayMember = "Name";
            this.featNameColumn.DropDownWidth = 100;            
            this.featNameColumn.MaxDropDownItems = 40;
            this.featNameColumn.ValueType = typeof(NWN2PropertyListItem);
            this.featNameColumn.ValueMember = "Name";
            this.featNameColumn.FillWeight = 75.0f;
            // 
            // gainLevelColumn
            // 
            this.gainLevelColumn.HeaderText = "Gain level";
            this.gainLevelColumn.Name = "GainLevelColumn";
            this.gainLevelColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gainLevelColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gainLevelColumn.ValueType = typeof(int);
            this.gainLevelColumn.FillWeight = 15.0f;
            //
            //onMenuColumn
            //
            this.onMenuColumn.HeaderText = "On menu";
            this.onMenuColumn.Name = "OnMenuColumn";
            this.onMenuColumn.ValueType = typeof(bool);
            this.onMenuColumn.TrueValue = true;
            this.onMenuColumn.FalseValue = false;
            this.onMenuColumn.FillWeight = 10f;
            //
            //addFeatButton
            //
            this.addFeatButton = new System.Windows.Forms.ToolStripButton();
            this.addFeatButton.Text = "Add";
            this.addFeatButton.Image = BuzzX8.NWN2ClassEditor.Properties.Resources.AddImage;
            this.addFeatButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFeatButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;            
            this.addFeatButton.Click += new System.EventHandler(addFeatButton_Click);            
            //
            //removeFeatButton
            //
            this.removeFeatButton = new System.Windows.Forms.ToolStripButton();
            this.removeFeatButton.Text = "Remove";
            this.removeFeatButton.Image = BuzzX8.NWN2ClassEditor.Properties.Resources.RemoveImage;
            this.removeFeatButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeFeatButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.removeFeatButton.Click += new System.EventHandler(removeFeatButton_Click);
            //
            //clearFeatsListButton
            //
            this.clearFeatListButton = new System.Windows.Forms.ToolStripButton();
            this.clearFeatListButton.Text = "Clear list";
            this.clearFeatListButton.Image = BuzzX8.NWN2ClassEditor.Properties.Resources.ClearList;
            this.clearFeatListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.clearFeatListButton.Click += new System.EventHandler(clearFeatListButton_Click);
            //
            //selectFromListButton
            //
            selectFromListButton = new ToolStripButton();
            selectFromListButton.Text = "Select from list";
            selectFromListButton.Image = BuzzX8.NWN2ClassEditor.Properties.Resources.SelectFromList;
            selectFromListButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            selectFromListButton.Click += new System.EventHandler(selectFromListButton_Click);
            
            //            
            //
            this.MainToolStrip.Items.Add(addFeatButton);
            this.MainToolStrip.Items.Add(removeFeatButton);
            this.MainToolStrip.Items.Add(addStandartFeatsButton);
            this.MainToolStrip.Items.Add(new System.Windows.Forms.ToolStripSeparator());
            this.MainToolStrip.Items.Add(clearFeatListButton);
            this.MainToolStrip.Items.Add(selectFromListButton);            
            this.NWN2PropertyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.featNameColumn,
            this.gainLevelColumn,
            this.onMenuColumn});            
        }

        void addTowerShieldProf_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(111640, 111, 113061), 0, false);
        }

        void addShieldProf_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(217, 32, 524), 0, false);
        }

        void addExoticWeaponProf_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(437, 44, 438), 0, false);
        }

        void addMartialWeaponProf_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(439, 45, 440), 0, false);
        }

        void addSimpleWeaponProf_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(441, 46, 442), 0, false);
        }

        void addHevyArmorProf_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(207, 3, 225), 0, false);
            AddFeat(new NWN2PropertyListItem(206, 4, 224), 0, false);
            AddFeat(new NWN2PropertyListItem(205, 2, 223), 0, false);            
        }

        void addMediumArmorProf_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(207, 3, 225), 0, false);
            AddFeat(new NWN2PropertyListItem(206, 4, 224), 0, false);
        }

        void addLightArmorProf_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(207, 3, 255), 0, false);
        }

        void selectFromListButton_Click(object sender, System.EventArgs e)
        {
            //DataGridViewRow listRow;
            //DataGridViewComboBoxCell featCell;
            //DataGridViewTextBoxCell gainLevelCell;

            selectionList.NWN2PropertyList = featsList;

            if (selectionList.ShowDialog() == DialogResult.OK)
            {
                foreach (NWN2PropertyListItem item in selectionList.SelectedItems)
                {
                    AddFeat(item, 0, false);
                }
            }
        }

        void NWN2PropertyDataGridView_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.DataGridView.HitTestInfo hitInfo = NWN2PropertyDataGridView.HitTest(e.X, e.Y);
            System.Windows.Forms.DataGridViewComboBoxCell featCell;
            NWN2PropertyListItem selectedItem;
            object selected;

            if (hitInfo.Equals(System.Windows.Forms.DataGridView.HitTestInfo.Nowhere) || hitInfo.RowIndex < 0) return;

            featCell = (System.Windows.Forms.DataGridViewComboBoxCell)NWN2PropertyDataGridView.Rows[hitInfo.RowIndex].Cells["FeatNameColumn"];

            if (featCell.Value == null || descriptionTextBox == null) return;

            selected = featCell.Value;

            if (selected is NWN2PropertyListItem)
            {
                selectedItem = (NWN2PropertyListItem)selected;
                descriptionTextBox.Text = selectedItem.Description;
            }

            if (selected is string)
            {
                foreach (NWN2PropertyListItem item in featsList)
                {
                    if (selected.ToString() == item.Name)
                    {
                        descriptionTextBox.Text = item.Description;
                        break;
                    }
                }
            }
        }
        
        void clearFeatListButton_Click(object sender, System.EventArgs e)
        {
            this.NWN2PropertyDataGridView.Rows.Clear();
        }

        void removeFeatButton_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewCell selectedCell in NWN2PropertyDataGridView.SelectedCells)
            {
                NWN2PropertyDataGridView.Rows.RemoveAt(selectedCell.RowIndex);
            }
        }

        void addFeatButton_Click(object sender, System.EventArgs e)
        {
            AddFeat(new NWN2PropertyListItem(0, 0, 0), 0, false);
        }

        public void AddFeat(NWN2PropertyListItem feat, int gainLevel, bool onMenu)
        {
            System.Windows.Forms.DataGridViewComboBoxCell featCell = new System.Windows.Forms.DataGridViewComboBoxCell();
            System.Windows.Forms.DataGridViewTextBoxCell gainLevelCell = new System.Windows.Forms.DataGridViewTextBoxCell();
            System.Windows.Forms.DataGridViewCheckBoxCell onMenuCell = new DataGridViewCheckBoxCell();
            System.Windows.Forms.DataGridViewRow row = new System.Windows.Forms.DataGridViewRow();

            featCell.DataSource = featsList;
            featCell.ValueType = typeof(NWN2PropertyListItem);
            featCell.ValueMember = "Name";
            featCell.Value = feat;
            gainLevelCell.ValueType = typeof(int);
            gainLevelCell.Value = gainLevel;
            onMenuCell.Value = onMenu;

            row.Cells.Add(featCell);
            row.Cells.Add(gainLevelCell);
            row.Cells.Add(onMenuCell);
            NWN2PropertyDataGridView.Rows.Add(row);
        }

        #endregion
        
        private System.Windows.Forms.DataGridViewComboBoxColumn featNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gainLevelColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onMenuColumn;
        private System.Windows.Forms.ToolStripButton addFeatButton;
        private System.Windows.Forms.ToolStripSplitButton addStandartFeatsButton;
        private System.Windows.Forms.ToolStripButton removeFeatButton;
        private System.Windows.Forms.ToolStripButton clearFeatListButton;
        private System.Windows.Forms.ToolStripButton selectFromListButton;
        private System.Windows.Forms.ToolStripMenuItem addLightArmorProf;
        private System.Windows.Forms.ToolStripMenuItem addMediumArmorProf;
        private System.Windows.Forms.ToolStripMenuItem addHevyArmorProf;
        private System.Windows.Forms.ToolStripMenuItem addMartialWeaponProf;
        private System.Windows.Forms.ToolStripMenuItem addSimpleWeaponProf;
        private System.Windows.Forms.ToolStripMenuItem addExoticWeaponProf;
        private System.Windows.Forms.ToolStripMenuItem addShieldProf;
        private System.Windows.Forms.ToolStripMenuItem addTowerShieldProf;
    }
}
