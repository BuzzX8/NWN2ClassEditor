using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ClassFeatsGrid : NWN2TablePropertyList
    {
        private NWN2PropertyListForm selectionList = new NWN2PropertyListForm();
        private NWN2PropertyList featsList = new NWN2PropertyList();
        private TwoDATable featTable;
        private TextBox descriptionTextBox;        

        public NWN2ClassFeatsGrid()
        {
            InitializeComponent();

            this.featNameColumn.DataSource = featsList;            
            this.NWN2PropertyDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(NWN2PropertyDataGridView_MouseClick);
            this.NWN2PropertyDataGridView.DataError += new DataGridViewDataErrorEventHandler(NWN2PropertyDataGridView_DataError);
        }
        
        [Browsable(false)]
        public TwoDATable FeatsList
        {
            get
            {
                if (featsList.Count == 0) return null;
                return featTable;
            }
            set
            {
                featsList.Clear();
                if (value == null) return;
                featsList = value.ConvertToList("FEAT", "DESCRIPTION", "REMOVED", "1");
                featsList.Sort(new Comparison<NWN2PropertyListItem>(NWN2PropertyList.Compare));
                featTable = value;
            }
        }

        public TextBox DescriptionTextBox
        {
            get
            {
                return descriptionTextBox;
            }
            set
            {
                descriptionTextBox = value;
            }
        }

        public NWN2ClassFeatsList ClassFeats
        {
            get
            {
                NWN2ClassFeatsList classFeats = new NWN2ClassFeatsList();
                
                if (NWN2PropertyDataGridView.Rows.Count == 0) return null;

                for (int i = 0; i < NWN2PropertyDataGridView.Rows.Count; i++ )
                {
                    classFeats.Add(new NWN2ClassFeatsListItem(featsList[NWN2PropertyDataGridView["FeatNameColumn", i].Value.ToString()], (int)NWN2PropertyDataGridView["GainLevelColumn", i].Value, (bool)NWN2PropertyDataGridView["OnMenuColumn", i].Value));
                }

                return classFeats;
            }
            set
            {
                if (value == null)
                {
                    NWN2PropertyDataGridView.Rows.Clear();
                    return;
                }
                for (int i = 0; i < value.Count; i++)
                {
                    AddFeat(value[i], (int)value[i].GainLevel, value[i].OnMenu);
                }
            }
        }

        public TwoDATable Create2DATable()
        {
            TwoDATable classFeats2DA;
            int index = 0;

            if (featsList == null || ClassFeats == null) return null;

            classFeats2DA = new TwoDATable("FeatLabel", "FeatIndex", "List", "GrantedOnLevel", "OnMenu");
            classFeats2DA.TableName = "cls_feat_";

            foreach (NWN2ClassFeatsListItem classFeat in ClassFeats)
            {
                classFeats2DA.Add();
                classFeats2DA[index, "FeatLabel"] = featTable[classFeat.PropertyID, "LABEL"];
                classFeats2DA[index, "FeatIndex"] = classFeat.PropertyID.ToString();
                classFeats2DA[index, "List"] = "3";
                classFeats2DA[index, "GrantedOnLevel"] = classFeat.GainLevel.ToString();
                classFeats2DA[index, "OnMenu"] = Convert.ToByte(classFeat.OnMenu).ToString();
                index++;
            }

            return classFeats2DA;
        }

        public void Clear()
        {
            NWN2PropertyDataGridView.Rows.Clear();
        }

        public bool ContainsFeat(NWN2PropertyListItem feat)
        {
            for (int i = 0; i < NWN2PropertyDataGridView.RowCount; i++)
            {
                if ((NWN2PropertyListItem)NWN2PropertyDataGridView["FeatNameColumn", i].Value == feat) return true;
            }

            return false;
        }

        internal void UpdateLabels()
        {
            if (NWN2PropertyListItem.TalkTable == null) return;

            addSimpleWeaponProf.Text = NWN2PropertyListItem.TalkTable[441];
            addMartialWeaponProf.Text = NWN2PropertyListItem.TalkTable[439];
            addExoticWeaponProf.Text = NWN2PropertyListItem.TalkTable[437];
            addLightArmorProf.Text = NWN2PropertyListItem.TalkTable[207];
            addMediumArmorProf.Text = NWN2PropertyListItem.TalkTable[206];
            addHevyArmorProf.Text = NWN2PropertyListItem.TalkTable[205];
            addShieldProf.Text = NWN2PropertyListItem.TalkTable[217];
            addTowerShieldProf.Text = NWN2PropertyListItem.TalkTable[111640];
        }

        void NWN2PropertyDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
            //MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK);
        }
    }
}
