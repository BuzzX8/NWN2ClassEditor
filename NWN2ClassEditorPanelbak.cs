using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NWN2Toolset;
using OEIShared;
using OEIShared.IO;
using OEIShared.IO.TalkTable;
using OEIShared.IO.TwoDA;

namespace NWN2ClassEditorControl
{
    [Flags]
    enum SaveThrow { Fortidute = 0x01, Reflex = 0x02, Will = 0x08 }
    enum Ability { Str, Dex, Con, Wis, Int, Cha }
    enum BaseAB { Hight, Medium, Low }
    
    public partial class Nwn2ClassEditorControl : UserControl
    {
        private TalkTableFile talkTable = null;
        private Hashtable localizedStrings = new Hashtable();
        private List<NWN2PropertyListItem> featsList = new List<NWN2PropertyListItem>();
        private List<NWN2PropertyListItem> skillsList = new List<NWN2PropertyListItem>();
        private List<NWN2PropertyListItem> spellsList = new List<NWN2PropertyListItem>();

        private NWN2Class mainClass = new NWN2Class();

        public TwoDATable FeatsList
        {            
            set
            {
                NWN2PropertyListItem listItem;
                
                featsList.Clear();

                for (int i = 0; i < value.RowCount; i++)
                {
                    if (value[i, "REMOVED"] == "1") continue;
                    listItem = new NWN2PropertyListItem(int.Parse(value[i, "FEAT"]), i, int.Parse(value[i, "DESCRIPTION"]));
                    featsList.Add(listItem);
                }

                RefreshClassFeatsColumn(); 
            }
        }

        public TwoDATable SkillsList
        {            
            set
            {
                NWN2PropertyListItem listItem;

                skillsList.Clear();

                for (int i = 0; i < value.RowCount; i++)
                {
                    if (value[i, "REMOVED"] == "1") continue;
                    listItem = new NWN2PropertyListItem(int.Parse(value[i, "Name"]), i, int.Parse(value[i, "Description"]));
                    skillsList.Add(listItem);
                }

                RefreshClassSkillsListBox();
            }
        }
        
        public TwoDATable SpellsList
        {            
            set
            {
                NWN2PropertyListItem listItem;

                spellsList.Clear();

                for (int i = 0; i < value.RowCount; i++)
                {                   
                    if (value[i, "REMOVED"] == "1" || value[i, "Name"] == null || value[i, "SpellDesc"] == null) continue;
                    listItem = new NWN2PropertyListItem(int.Parse(value[i, "Name"]), i, int.Parse(value[i, "SpellDesc"]));
                    spellsList.Add(listItem);                                        
                }
            }
        }

        public TalkTableFile TalkTable
        {
            get 
            {
                return talkTable; 
            }
            set
            {
                talkTable = value;
                NWN2PropertyListItem.TalkTable = value;
            }
        }

        public Nwn2ClassEditorControl()
        {
            TalkTable = new TalkTableFile();
            talkTable.Open("dialog.TLK", false);
            //SkillsList = new TwoDATable("skills.2da");
            //FeatsList = new TwoDATable("feat.2da");
            SpellsList = new TwoDATable("spells.2da");
            
            InitializeComponent();
            RefreshClassFeatsColumn();
            RefreshClassSkillsListBox();
            classFeatsDataGridView.DataError += new DataGridViewDataErrorEventHandler(classFeatsDataGridView_DataError);
        }
        
        private void RefreshClassFeatsColumn()
        {
            if (featNameColumn == null) return;

            featNameColumn.Items.Clear();
            featNameColumn.Sorted = false;

            foreach (NWN2PropertyListItem item in featsList)
            {
                featNameColumn.Items.Add(item.Name);
            }
            featNameColumn.Sorted = true;
            featNameColumn.Selected = true;
        }

        private void RefreshClassSkillsListBox()
        {
            if (classSkillCheckedListBox == null) return;

            classSkillCheckedListBox.Items.Clear();

            foreach (NWN2PropertyListItem item in skillsList)
            {
                classSkillCheckedListBox.Items.Add(item, false);
            }
        }

        void classFeatsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            //MessageBox.Show(e.Exception.Message);
        }

        private void classNameTextBox_TextChanged(object sender, EventArgs e)
        {
            mainClass.className = classNameTextBox.Text;
        }

        private void skillPointsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mainClass.skillPointBase = (uint)skillPointsNumericUpDown.Value;
        }

        private void hitDieNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mainClass.hitDie = (uint)hitDieNumericUpDown.Value;
        }

        private void spellcasterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mainClass.spellCaster = spellcasterCheckBox.Checked;
        }

        private void reflexThrowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mainClass.saveThrowSpecialization ^= SaveThrow.Reflex;
        }

        private void willThrowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mainClass.saveThrowSpecialization ^= SaveThrow.Will;
        }

        private void addFromListButton_Click(object sender, EventArgs e)
        {
            if ((mainClass.FeatsList == null) || (talkTable == null)) throw new NullReferenceException();

            FeatListForm form = new FeatListForm();//featsList, talkTable);
            form.TalkTable = talkTable;
            //form.FeatsList = mainClass.FeatsList;            
            form.ShowDialog(this);
        }

        private void fortiduteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mainClass.saveThrowSpecialization ^= SaveThrow.Fortidute;
        }

        private void addFeatButton_Click(object sender, EventArgs e)
        {
            classFeatsDataGridView.Rows.Add();
        }

        private void classSkillCheckedListBox_Click(object sender, EventArgs e)
        {
            NWN2PropertyListItem selectedItem = (NWN2PropertyListItem)classSkillCheckedListBox.SelectedItem;

            skillFeatDescriptionTextBox.Text = selectedItem.Description;
        }

        private void skillFeatDescriptionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void classFeatsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitInfo = classFeatsDataGridView.HitTest(e.X, e.Y);
            DataGridViewComboBoxCell featNameCell;          

            if (hitInfo.Equals(DataGridView.HitTestInfo.Nowhere)) return;

            featNameCell = (DataGridViewComboBoxCell)classFeatsDataGridView.CurrentRow.Cells[0];
            if (featNameCell.Value == null) return;

            foreach (NWN2PropertyListItem item in featsList)
            {
                if(item.Name == (string)featNameCell.Value) skillFeatDescriptionTextBox.Text = item.Description;
            }            
        }
    }

    [Serializable]
    internal class NWN2Class
    {
        //General properties
        public string className;
        public string classDescription;
        public uint hitDie;
        public BaseAB baseAttackBonus;
        public uint skillPointBase;
        public Ability mainAbility;
        public SaveThrow saveThrowSpecialization;

        //Spellcaster properties
        public bool spellCaster;
        public bool metaMagicAlloved;
        public bool memorizesSpells;
        public bool hasDivine;
        public bool hasArcane;
        public bool hasSpontaneousSpells;
        public bool allSpellsKnown;
        public bool hasInfiniteSpells;
        public bool hasDomains;
        public bool hasSchool;
        public bool hasFamiliar;
        public bool hasAnimalCompanion;
        public Ability spellAbility;

        //2da files
        public TwoDAFile mainClassList = null;
        public List<NWN2PropertyListItem> FeatsList = null;
        public TwoDAFile spellsList = null;
        public TwoDAFile skillsList = null;

        internal void ImportFrom2DA(string fileName)
        { }

        internal void ExportTo2DA(string fileName)
        { }
    }

    internal class NWN2PropertyListItem
    {
        private int propertyName;    //StrRef in dialog.tlk
        private int propertyID;      //Position in table
        [Browsable(false)]
        public int propertyDescription; //StrRef in dialog.tlk
        public static TalkTableFile TalkTable;

        public NWN2PropertyListItem(int id) : this(0, id)
        { }

        public NWN2PropertyListItem(int name, int id) : this(name, id, 0)
        {}        

        public NWN2PropertyListItem(int name, int id, int description)
        {
            propertyName = name;
            propertyID = id;
            propertyDescription = description;
        }

        public string Name
        {
            get
            {
                if (TalkTable == null) return "StrRef " + propertyName;
                else return TalkTable[propertyName];
            }
        }

        public string Description
        {
            get
            {
                if (TalkTable == null) return "StrRef " + propertyDescription;
                else return TalkTable[propertyDescription];
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            NWN2PropertyListItem item = obj as NWN2PropertyListItem;

            if (item == null) return false;
            else return this.propertyID == item.propertyID;
        }
    }
    
    public class TwoDATable
    {
        private string[] tableHeaders;
        private string[][] tableData;

        public TwoDATable(string fileName)
        {
            string[] data = File.ReadAllLines(fileName);

            if (!data[0].Contains("2DA")) throw new IOException("This file is not 2da");

            tableHeaders = data[2].Split('\t');
            this.tableData = new string[data.Length - 3][];

            //Fill table cells
            for (int i = 0; i < tableData.Length; i++)
            {
                tableData[i] = data[i + 3].Split('\t');
            }
        }

        public string this[int rowIndex, int columnIndex]
        {
            get
            {
                string result = tableData[rowIndex][columnIndex + 1];

                if (result.Contains("**")) return null;
                else return result;
            }
        }

        public string this[int rowIndex, string columnName]
        {
            get
            {
                if (!ContainColumn(columnName)) return null;
                else return this[rowIndex, GetColumnIndex(columnName)];
            }
        }

        public int ColumnCount
        {
            get
            {
                return tableHeaders.Length - 1;
            }
        }

        public int RowCount
        {
            get
            {
                return tableData.Length;
            }
        }

        public int GetColumnIndex(string columnName)
        {
            int result = 0;

            if (!ContainColumn(columnName)) throw new IOException("Given column does not contains in table");

            for (int i = 1; i < tableHeaders.Length; i++)
            {
                if (tableHeaders[i] == columnName) result = i - 1;
            }

            return result;
        }

        public bool ContainColumn(string columnName)
        {
            bool result = false;

            foreach (string header in tableHeaders)
            {
                if (header.ToLower() == columnName.ToLower()) result = true;
            }

            return result;
        }
    }
}