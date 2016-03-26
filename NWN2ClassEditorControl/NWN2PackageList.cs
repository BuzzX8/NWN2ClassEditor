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
    public partial class NWN2PackageListBox : UserControl
    {
        private NWN2PropertySelectableList classSpellsListBox = null;
        private NWN2ClassNameEditor nameEditor;

        private NWN2PropertyListItem packagesString;
        private NWN2PackageEditorForm packageEditor;
        private TwoDATable associateList = null;       
        private TwoDATable domainsList = null;
        private TwoDATable featsList = null;
        private TwoDATable schoolsList = null;
        private TwoDATable spellsList = null;
        private TwoDATable skillsList = null;
        private Ability defaultAbility = Ability.Str;
        private string classLabel = "";        

        [Browsable(true)]
        public NWN2PropertySelectableList ClassSpellsListBox
        {
            get
            {
                return classSpellsListBox; 
            }
            set
            {
                classSpellsListBox = value;                
                classSpellsListBox.ItemCheck += new ItemCheckEventHandler(classSpellsListBox_ItemCheck);
            }
        }        

        [Browsable(true)]
        public NWN2ClassNameEditor NameEditor
        {
            get
            {
                return nameEditor;
            }
            set
            {
                nameEditor = value;

                if (nameEditor == null) return;

                nameEditor.ValueCanged += new EventHandler(nameEditor_ValueCanged);
            }
        }

        [Browsable(false)]
        public TwoDATable AssociateList
        {
            get 
            {
                return associateList; 
            }
            set
            {
                associateList = value;
                packageEditor.AssociateList = value;
            }
        }

        [Browsable(false)]
        public TwoDATable DomainsList
        {
            get
            {
                return domainsList;
            }
            set
            {
                domainsList = value;
                packageEditor.DomainsList = value;
            }
        }

        [Bindable(false)]
        public TwoDATable FeatsList
        {
            set
            {
                featsList = value;

                if (value == null)
                {
                    packageEditor.FeatsList = featsList;
                    return;
                }

                for (int i = 0; i < value.RowCount; i++)
                {
                    if (featsList[i, "REMOVED"] == "1") featsList.Remove(i);
                }

                packageEditor.FeatsList = featsList;
            }
        }

        [Browsable(false)]
        public TwoDATable SchoolsList
        {
            get 
            {
                return schoolsList; 
            }
            set 
            {
                schoolsList = value;
                packageEditor.SchoolsList = value;
            }
        }

        [Browsable(false)]
        public TwoDATable SpellsList
        {
            get 
            {
                return spellsList; 
            }
            set 
            {
                spellsList = value;
                packageEditor.SpellsList = value;
            }
        }

        [Browsable(false)]
        public TwoDATable SkillsList
        {
            get
            {
                return skillsList;
            }
            set
            {
                skillsList = value;
                packageEditor.SkillsList = value;
            }
        }

        [Browsable(false)]
        public Ability DefaultAbility
        {
            get
            {
                return defaultAbility; 
            }
            set
            {
                defaultAbility = value;
                
            }
        }

        [Browsable(false)]
        public string ClassLabel
        {
            get 
            {
                if (NameEditor != null) return NameEditor.ClassLebel;
                return classLabel; 
            }
            set 
            {
                classLabel = value; 
            }
        }

        public NWN2PackageListBox()
        {
            InitializeComponent();

            packageEditor = new NWN2PackageEditorForm();
            packagesString = new NWN2PropertyListItem(146);
        }

        public NWN2Package[] ClassPackages
        {
            get
            {
                List<NWN2Package> classPackageList = new List<NWN2Package>();
                NWN2Package pack;

                for (int i = 0; i < packageListBox.Items.Count; i++)
                {
                    pack = (NWN2Package)packageListBox.Items[i];
                    classPackageList.Add(pack);
                }

                return classPackageList.ToArray();
            }
            set
            {
                packageListBox.Items.Clear();

                for (int i = 0; i < value.Length; i++)
                {
                    packageListBox.Items.Add(value[i]);
                }
            }
        }

        public int PackageCount
        {
            get
            {
                return packageListBox.Items.Count;
            }
        }

        private void addPackage(string label)
        {
            NWN2Package package = new NWN2Package(label);

            package.Attribute = defaultAbility;
            package.PackageLabel = label;
            package.Gold = 0;
            package.School = -1;
            package.Domain1 = -1;
            package.Domain2 = -1;
            package.Associate = -1;
            package.SpellPref2DA = packageEditor.CreateSpellPref2DA(classSpellsListBox.SelectedItems);

            if (package.SpellPref2DA != null) package.SpellPref2DA.TableName += classLabel + packageListBox.Items.Count;

            package.FeatPref2DA = packageEditor.CreateFeatPref2DA();
            package.FeatPref2DA.TableName += ClassLabel + packageListBox.Items.Count;
            package.SkillPref2DA = packageEditor.CreateSkillPref2DA();
            package.SkillPref2DA.TableName += ClassLabel + packageListBox.Items.Count;
            packageListBox.Items.Add(package);         
        }

        public void AddPackage(string name)
        {
            addPackage(name);
        }

        public void AddPackage()
        {
            addPackage(ClassLabel + packageListBox.Items.Count.ToString());
        }

        internal void UpdateLabel()
        {
            packagesLabel.Text = packagesString.Name;
        }

        private void addPackageButton_Click(object sender, EventArgs e)
        {
            AddPackage();
        }

        private void removePackageButton_Click(object sender, EventArgs e)
        {
            if (packageListBox.Items.Count == 0 || packageListBox.SelectedIndex == -1) return;

            packageListBox.Items.RemoveAt(packageListBox.SelectedIndex);

            if (packageListBox.Items.Count == 0) editPackageButton.Enabled = false;
            else packageListBox.SelectedIndex = packageListBox.Items.Count - 1;
        }

        private void classSpellsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {            
            //if (e.NewValue == CheckState.Checked)
            //{
            //    spellsList.Add(classSpellsListBox.SelectedValue);
            //}

            //if (e.NewValue == CheckState.Unchecked)
            //{
            //    spellsList.Remove(classSpellsListBox.SelectedValue);
            //}
        }

        private void editPackageButton_Click(object sender, EventArgs e)
        {
            NWN2Package pack;
            int selectedIndex;

            if (packageListBox.SelectedItem == null) return;
            
            packageEditor.Package = (NWN2Package)packageListBox.SelectedItem;
            packageEditor.ClassSpells = classSpellsListBox.SelectedItems;

            if (packageEditor.ShowDialog() == DialogResult.OK)
            {
                pack = packageEditor.Package;                
                selectedIndex = packageListBox.SelectedIndex;
                packageListBox.Items.RemoveAt(selectedIndex);
                packageListBox.Items.Insert(selectedIndex, pack);
                
                if (pack.SpellPref2DA != null) pack.SpellPref2DA.TableName += ClassLabel + packageListBox.Items.Count;
                if (pack.FeatPref2DA != null) pack.FeatPref2DA.TableName += ClassLabel + packageListBox.Items.Count;
                if (pack.SkillPref2DA != null) pack.SkillPref2DA.TableName += ClassLabel + packageListBox.Items.Count;
            }
        }

        private void packageListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (packageListBox.SelectedItem == null) editPackageButton.Enabled = false;
            if (!editPackageButton.Enabled) editPackageButton.Enabled = true;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            NWN2Package package;
            int selectedIndex = packageListBox.SelectedIndex;

            if (selectedIndex <= 0) return;

            package = (NWN2Package)packageListBox.SelectedItem;
            packageListBox.Items.RemoveAt(selectedIndex);
            packageListBox.Items.Insert(selectedIndex - 1, package);
            packageListBox.SelectedIndex = selectedIndex - 1;
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            NWN2Package package;
            int selectedIndex = packageListBox.SelectedIndex;

            if (selectedIndex == packageListBox.Items.Count - 1) return;

            package = (NWN2Package)packageListBox.SelectedItem;
            packageListBox.Items.RemoveAt(selectedIndex);
            packageListBox.Items.Insert(selectedIndex + 1, package);
            packageListBox.SelectedIndex = selectedIndex + 1;
        }
        
        void nameEditor_ValueCanged(object sender, EventArgs e)
        {
            ClassLabel = nameEditor.ClassLebel;
        }
    }
}
