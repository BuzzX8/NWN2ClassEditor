using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2AdvancedSpellcasterSettingsForm : Form
    {
        public NWN2AdvancedSpellcasterSettingsForm()
        {
            InitializeComponent();
        }

        public bool HasFeatExtraSlot
        {
            get
            {
                return extraSlotCheckBox.Checked;
            }
            set
            {
                extraSlotCheckBox.Checked = value;
            }
        }

        public bool HasFeatPracticedSpellcaster
        {
            get
            {
                return hasFeatPracSpellcasterCheckBox.Checked;
            }
            set
            {
                hasFeatPracSpellcasterCheckBox.Checked = value;
            }
        }

        public bool HasFeatArmoredCaster
        {
            get
            {
                return featArmoredCasterCheckBox.Checked;
            }
            set
            {
                featArmoredCasterCheckBox.Checked = value;
            }
        }

        public int FeatExtraSlotStrRef
        {
            get
            {
                return extraSlotStrRefCheckBox.StrRef;
            }
            set
            {
                extraSlotStrRefCheckBox.StrRef = value;
            }
        }

        public string FeatExtraSlotName
        {
            get
            {
                return featPracSpellcasterNameStrRefCheckBox.TextBox.Text;
            }
            set
            {
                featPracSpellcasterNameStrRefCheckBox.StrRef = -1;
                featPracSpellcasterNameStrRefCheckBox.TextBox.Text = value;
            }
        }

        public int FeatPracticedSpellcasterStrRef
        {
            get
            {
                return featPracSpellcasterNameStrRefCheckBox.StrRef;
            }
            set
            {
                featPracSpellcasterNameStrRefCheckBox.StrRef = value;
            }
        }

        public string FeatPracticedSpellcasterName
        {
            get
            {
                return featPracSpellcasterNameTextBox.Text;
            }
            set
            {
                featPracSpellcasterNameStrRefCheckBox.StrRef = -1;
                featPracSpellcasterNameTextBox.Text = value;
            }
        }

        public int FeatArmoredCasterStrRef
        {
            get
            {
                return featArmoredCasterNameStrRefCheckBox.StrRef;
            }
            set
            {
                featArmoredCasterNameStrRefCheckBox.StrRef = value;
            }
        }

        public string FeatArmoredCasterName
        {
            get
            {
                return featArmoredCasterNameTextBox.Text;
            }
            set
            {
                featArmoredCasterNameStrRefCheckBox.StrRef = -1;
                featArmoredCasterNameTextBox.Text = value;
            }
        }

        public int ArcSpellLvlMod
        {
            get
            {
                return (int)arcSpellLvlModNumericUpDown.Value;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Value must be greater or equal to zero");

                arcSpellLvlModNumericUpDown.Value = value;
            }
        }

        public int DivSpellLvlMod
        {
            get
            {
                return (int)divSpellLvlModNumericUpDown.Value;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Value must be greater or equal to zero");

                divSpellLvlModNumericUpDown.Value = value;
            }
        }

        public void ImportIn2DA(TwoDATable classesTable, TwoDATable featTable, int featIndex)
        {
            int tableRow;

            if (!TwoDAValidator.IsClasses2DA(classesTable)) throw new ArgumentException();
            if (!TwoDAValidator.IsFeat2DA(featTable)) throw new ArgumentException();

            //featTable.Add();
        }

        private void extraSlotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            featExtraSlotPanel.Enabled = extraSlotCheckBox.Checked;
        }

        private void hasFeatPracSpellcasterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pracSpellCasterPanel.Enabled = hasFeatPracSpellcasterCheckBox.Checked;
        }

        private void featArmoredCasterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            armoredCasterFeatPanel.Enabled = featArmoredCasterCheckBox.Checked;
        }       
    }
}