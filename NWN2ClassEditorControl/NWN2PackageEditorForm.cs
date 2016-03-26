using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2PackageEditorForm : Form
    {
        private NWN2PropertyList featsList = null;
        private NWN2PropertyList classSpellsList = null;
        private NWN2PropertyList associateList = null;
        private NWN2PropertyList domainsList = null;
        private NWN2PropertyList schoolsList = null;
        private NWN2PropertyList skillsList = null;
        private NWN2Package package;

        private NWN2PropertyList packSPList;
        private NWN2PropertyList packFTList;
        private NWN2PropertyList packSKList;

        private TwoDATable featsTable = null;
        private TwoDATable skillTable = null;
        private TwoDATable spellsTable = null;

        public TwoDATable SpellsList
        {            
            set 
            {
                spellsTable = value; 
            }
        }

        public NWN2Package Package
        {
            get 
            {
                if (assosiateComboBox.Items.Count > 0) package.Associate = (short)assosiateComboBox.SelectedIndex;
                if (domain1ComboBox.Items.Count > 0 || domain2ComboBox.Items.Count > 0)
                {
                    package.Domain1 = (short)domain1ComboBox.SelectedIndex;
                    package.Domain2 = (short)domain2ComboBox.SelectedIndex;
                }
                package.Gold = (short)goldNumericUpDown.Value;
                package.PackageLabel = packageLabelTextBox.Text;
                package.PackageName = packageNameTextBox.Text;
                package.PackageDescription = packageDescriptionTextBox.Text;

                if (packageNameStrRefCheckBox.Checked) package.PackageNameStrRef = packageNameStrRefCheckBox.StrRef;
                if (packageDescriptionStrRefCheckBox.Checked) package.PackageDescriptionStrRef = packageDescriptionStrRefCheckBox.StrRef;

                package.SpellPref2DA = CreateSpellPref2DA(packSPList);
                package.SkillPref2DA = CreateSkillPref2DA(packSKList);
                package.FeatPref2DA = CreateFeatPref2DA(packFTList);

                return package; 
            }
            set 
            {
                if(assosiateComboBox.Items.Count > 0) assosiateComboBox.SelectedIndex = value.Associate;
                if (domain1ComboBox.Items.Count > 0)
                {
                    domain1ComboBox.SelectedIndex = value.Domain1;
                    domain2ComboBox.SelectedIndex = value.Domain2;
                }

                attributeComboBox.SelectedItem = value.Attribute;
                goldNumericUpDown.Value = value.Gold;
                packageLabelTextBox.Text = value.PackageLabel;
                packageNameTextBox.Text = value.PackageName;
                packageDescriptionTextBox.Text = value.PackageDescription;
                packageNameStrRefCheckBox.StrRef = value.PackageNameStrRef;
                packageDescriptionStrRefCheckBox.StrRef = value.PackageDescriptionStrRef;
                package = value;

                if (package.SpellPref2DA == null) package.SpellPref2DA = CreateSpellPref2DA();
                if (package.SkillPref2DA == null) package.SkillPref2DA = CreateSkillPref2DA();                
                if (package.FeatPref2DA == null) package.FeatPref2DA = CreateFeatPref2DA();
                
                packSPList = createPackSPList(package.SpellPref2DA);
                packFTList = createPackFTList(package.FeatPref2DA);
                packSKList = createPackSKList(package.SkillPref2DA);
            }
        }

        public NWN2PropertyList ClassSpells
        {
            set
            {
                classSpellsList = value;
            }
        }

        public Ability Attribute
        {
            get
            {
                return (Ability)attributeComboBox.SelectedItem;
            }
            set
            {
                attributeComboBox.SelectedItem = value;
            }
        }

        public TwoDATable AssociateList
        {            
            set
            {
                assosiateComboBox.Items.Clear();

                if (value == null)
                {
                    assosiateComboBox.SelectedIndex = -1;
                    return;
                }

                associateList = value.ConvertToList("STRREF", "DESCRIPTION");

                for (int i = 0; i < associateList.Count; i++)
                {
                    assosiateComboBox.Items.Add(associateList[i]);
                }
            }
        }

        public TwoDATable FeatsList
        {
            set
            {
                featsTable = value;
                featsList = value.ConvertToList("FEAT",	"DESCRIPTION");
            }
        }

        public TwoDATable DomainsList
        {            
            set
            {                
                domain1ComboBox.Items.Clear();
                domain2ComboBox.Items.Clear();

                if (value == null)
                {
                    domain1ComboBox.SelectedIndex = -1;
                    domain2ComboBox.SelectedIndex = -1;
                    return;
                }

                domainsList = value.ConvertToList("Name", "Description");

                for (int i = 0; i < domainsList.Count; i++)
                {
                    domain1ComboBox.Items.Add(domainsList[i]);
                    domain2ComboBox.Items.Add(domainsList[i]);
                }

                domain1ComboBox.SelectedIndex = 0;
                domain2ComboBox.SelectedIndex = 0;
            }
        }

        public TwoDATable SchoolsList
        {         
            set
            {
                schoolComboBox.Items.Clear();

                if (value == null)
                {
                    schoolComboBox.SelectedIndex = -1;
                    return;
                }

                schoolsList = value.ConvertToList("StringRef", "Description");

                for (int i = 0; i < schoolsList.Count; i++)
                {
                    schoolComboBox.Items.Add(schoolsList[i]);
                }

                schoolComboBox.SelectedIndex = 0;
            }
        }

        public TwoDATable SkillsList
        {            
            set
            {
                skillTable = value;

                if (value == null) return;

                skillsList = value.ConvertToList("Name", "Description", "REMOVED", "1"); 
            }
        }

        public NWN2PackageEditorForm()
        {
            InitializeComponent();
            attributeComboBox.StrRefItems = new int[] { 135, 133, 132, 134, 136, 131 }; ;
            attributeComboBox.EnumType = typeof(Ability);
        }

        public TwoDATable CreateSpellPref2DA()
        {
            return CreateSpellPref2DA(classSpellsList);
        }

        public TwoDATable CreateSpellPref2DA(NWN2PropertyList classSpellsList)
        {
            if (classSpellsList == null) return null;
            if (classSpellsList.Count == 0) return null;

            TwoDATable result;
            
            result = new TwoDATable("SpellIndex", "Label");
            result.TableName = "PackSP";
            
            for (int i = 0; i < classSpellsList.Count; i++)
            {
                //Debugger.Launch();
                result.Add();
                result[i, "SpellIndex"] = classSpellsList[i].PropertyID.ToString();
                result[i, "Label"] = spellsTable[classSpellsList[i].PropertyID, "Label"];
            }

            return result;
        }

        public TwoDATable CreateFeatPref2DA()
        {
            return CreateFeatPref2DA(featsList);
        }

        public TwoDATable CreateFeatPref2DA(NWN2PropertyList featsList)
        {
            if (featsList == null) return null;

            TwoDATable result = new TwoDATable("FeatIndex", "Label");
            result.TableName = "PackFT";

            for (int i = 0; i < featsList.Count; i++)
            {
                result.Add();
                result[i, "FeatIndex"] = featsList[i].PropertyID.ToString();
                result[i, "Label"] = featsTable[featsList[i].PropertyID, "LABEL"];
            }

            return result;
        }

        public TwoDATable CreateSkillPref2DA()
        {
            return CreateSkillPref2DA(skillsList);
        }

        public TwoDATable CreateSkillPref2DA(NWN2PropertyList skillsList)
        {
            if(skillTable == null) return null;

            TwoDATable result = new TwoDATable("SKILLINDEX", "LABEL");
            result.TableName = "PackSK";
            //Debugger.Launch();
            for (int i = 0; i < skillsList.Count; i++)
            {
                if(skillTable[i, "REMOVED"] == "1") continue;

                result.Add();
                result[result.RowCount - 1, "SKILLINDEX"] = skillsList[i].PropertyID.ToString();
                result[result.RowCount - 1, "LABEL"] = skillTable[skillsList[i].PropertyID, "Label"];
            }

            return result;
        }

        private NWN2PropertyList createPackSPList(TwoDATable table)
        {
            NWN2PropertyList result = new NWN2PropertyList();

            if (table == null) return null;

            for (int i = 0; i < table.RowCount; i++)
            {
                if (table[i, "SpellIndex"] == null || table[i, "SpellIndex"] == "") continue;

                result.Add(new NWN2PropertyListItem(int.Parse(spellsTable[int.Parse(table[i, "SpellIndex"]), "Name"]), int.Parse(table[i, "SpellIndex"]), int.Parse(spellsTable[int.Parse(table[i, "SpellIndex"]), "SpellDesc"])));
            }

            return result;
        }

        private NWN2PropertyList createPackFTList(TwoDATable table)
        {
            NWN2PropertyList result = new NWN2PropertyList();

            if (table == null) return null;

            for (int i = 0; i < table.RowCount; i++)
            {
                if (table[i, "FeatIndex"] == null || table[i, "FeatIndex"] == "") continue;
                
                result.Add(new NWN2PropertyListItem(int.Parse(featsTable[int.Parse(table[i, "FeatIndex"]), "FEAT"]), int.Parse(table[i, "FeatIndex"]), int.Parse(featsTable[int.Parse(table[i, "FeatIndex"]), "DESCRIPTION"])));
            }

            return result;
        }

        private NWN2PropertyList createPackSKList(TwoDATable table)
        {
            NWN2PropertyList result = new NWN2PropertyList();

            if (table == null) return null;

            for (int i = 0; i < table.RowCount; i++)
            {
                if (table[i, "SKILLINDEX"] == null || table[i, "SKILLINDEX"] == "") continue;

                result.Add(new NWN2PropertyListItem(int.Parse(skillTable[int.Parse(table[i, "SKILLINDEX"]), "Name"]), int.Parse(table[i, "SKILLINDEX"]), int.Parse(skillTable[int.Parse(table[i, "SKILLINDEX"]), "Description"])));
            }

            return result;
        }

        private void moveUpItem(NWN2PropertyList list, int itemIndex)
        {
            NWN2PropertyListItem item;

            if (itemIndex == 0) return;

            item = list[itemIndex];
            list.RemoveAt(itemIndex);
            listBox.Items.RemoveAt(itemIndex);
            list.Insert(itemIndex - 1, item);
            listBox.Items.Insert(itemIndex - 1, item);
            listBox.SelectedIndex = itemIndex - 1;
        }

        private void moveDownItem(NWN2PropertyList list, int itemIndex)
        {
            NWN2PropertyListItem item;

            if (itemIndex == list.Count - 1) return;

            item = list[itemIndex];
            list.RemoveAt(itemIndex);
            listBox.Items.RemoveAt(itemIndex);
            list.Insert(itemIndex + 1, item);
            listBox.Items.Insert(itemIndex + 1, item);
            listBox.SelectedIndex = itemIndex + 1;
        }

        private void featsToolStripButton_Click(object sender, EventArgs e)
        {
            skillsToolStripButton.Checked = spellsToolStripButton.Checked = false;
            listBox.Items.Clear();
            listBox.BeginUpdate();

            if (packFTList == null) return;

            for (int i = 0; i < packFTList.Count; i++)
                listBox.Items.Add(packFTList[i]);
            
            listBox.EndUpdate();
        }

        private void skillsToolStripButton_Click(object sender, EventArgs e)
        {
            featsToolStripButton.Checked = spellsToolStripButton.Checked = false;
            listBox.Items.Clear();
            listBox.BeginUpdate();

            if (packSKList == null) return;

            for (int i = 0; i < packSKList.Count; i++)
            {
                listBox.Items.Add(packSKList[i]);
            }

            listBox.EndUpdate();
        }

        private void spellsToolStripButton_Click(object sender, EventArgs e)
        {
            featsToolStripButton.Checked = skillsToolStripButton.Checked = false;
            listBox.Items.Clear();
            listBox.BeginUpdate();

            if (packSPList == null) return;            

            for (int i = 0; i < packSPList.Count; i++)
            {
                listBox.Items.Add(packSPList[i]);
            }

            listBox.EndUpdate();
        }

        private void upToolStripButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;
            if (featsToolStripButton.Checked) moveUpItem(packFTList, listBox.SelectedIndex);
            if (skillsToolStripButton.Checked) moveUpItem(packSKList, listBox.SelectedIndex);
            if (spellsToolStripButton.Checked) moveUpItem(packSPList, listBox.SelectedIndex);
        }

        private void downToolStripButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;
            if (featsToolStripButton.Checked) moveDownItem(packFTList, listBox.SelectedIndex);
            if (skillsToolStripButton.Checked) moveDownItem(packSKList, listBox.SelectedIndex);
            if (spellsToolStripButton.Checked) moveDownItem(packSPList, listBox.SelectedIndex);
        }
    }
}