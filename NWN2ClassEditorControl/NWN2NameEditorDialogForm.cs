using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2NameEditorDialogForm : Form
    {
        private NWN2StrRefCooser resRefDialog;
        private int nameStrRef = -1;
        private int pluralStrRef = -1;
        private int lowerStrRef = -1;

        public NWN2NameEditorDialogForm()
        {
            InitializeComponent();
            resRefDialog = new NWN2StrRefCooser();
            NameStrRef = -1;
            PluralStrRef = -1;
            LowerStrRef = -1;
        }

        public NWN2ClassName ClassName
        {
            get
            {
                NWN2ClassName result = new NWN2ClassName(classLabelTextBox.Text);

                result.Label = classLabelTextBox.Text;
                result.NameStrRef = NameStrRef;
                result.PluralStrRef = PluralStrRef;
                result.LowerStrRef = LowerStrRef;
                result.LocalizedName = Name;
                result.Plural = Plural;
                result.Lower = Lower;

                return result;
            }
            set
            {
                classLabelTextBox.Text = value.Label;

                if (value.NameStrRef >= 0) NameStrRef = value.NameStrRef;
                else Name = value.LocalizedName;

                if (value.PluralStrRef >= 0) PluralStrRef = value.PluralStrRef;
                else Plural = value.Plural;

                if (value.LowerStrRef >= 0) LowerStrRef = value.LowerStrRef;
                else Lower = value.Lower;
            }
        }

        public new string Name
        {
            get
            {
                return nameTextBox.Text;
            }
            set
            {
                nameStrRefCheckBox.Checked = false;
                nameTextBox.Enabled = true;
                nameTextBox.Text = value;
            }
        }

        public string Plural
        {
            get
            {
                return pluralTextBox.Text;
            }
            set
            {
                pluralStrRefCheckBox.Checked = false;
                pluralTextBox.Enabled = true;
                pluralTextBox.Text = value;
            }
        }

        public string Lower
        {
            get
            {
                return lowerTextBox.Text;
            }
            set
            {
                lowerRedRefCheckBox.Checked = false;
                lowerTextBox.Enabled = true;
                lowerTextBox.Text = value;
            }
        }        

        public int NameStrRef
        {
            get
            {
                return nameStrRef;
            }
            set
            {
                nameStrRef = value;
                
                if (value < 0) nameTextBox.Enabled = true;
                else
                {
                    nameTextBox.Enabled = false;
                    nameStrRefCheckBox.Checked = true;

                    if (NWN2PropertyListItem.TalkTable == null)
                    {
                        nameTextBox.Text = "StrRef " + nameStrRef;
                        return;
                    }
                    else nameTextBox.Text = NWN2PropertyListItem.TalkTable[nameStrRef];                    
                }
            }
        }

        public int PluralStrRef
        {
            get
            {
                return pluralStrRef;
            }
            set
            {
                pluralStrRef = value;
                
                if (value < 0) pluralTextBox.Enabled = true;
                else
                {
                    pluralTextBox.Enabled = false;
                    pluralStrRefCheckBox.Checked = true;

                    if (NWN2PropertyListItem.TalkTable == null)
                    {
                        pluralTextBox.Text = "StrRef " + pluralStrRef;
                        return;
                    }
                    else pluralTextBox.Text = NWN2PropertyListItem.TalkTable[pluralStrRef];
                }
            }
        }

        public int LowerStrRef
        {
            get
            {
                return lowerStrRef;
            }
            set
            {
                lowerStrRef = value;
                
                if (value < 0) lowerTextBox.Enabled = true;
                else
                {
                    lowerTextBox.Enabled = false;
                    lowerRedRefCheckBox.Checked = true;

                    if (NWN2PropertyListItem.TalkTable == null)
                    {
                        lowerTextBox.Text = "StrRef " + lowerStrRef;
                        return;
                    }
                    else lowerTextBox.Text = NWN2PropertyListItem.TalkTable[lowerStrRef];
                }
            }
        }

        private void checkChange(TextBox textBox, CheckBox checkBox, ref int value)
        {
            if (checkBox.Checked)
            {
                if (resRefDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Enabled = false;
                    textBox.Text = resRefDialog.SelectedString;
                    value = resRefDialog.SelectedStrRef;
                }
                else checkBox.Checked = false;
            }
            else
            {
                textBox.Enabled = true;
                value = -1;
            }
        }

        private void nameStrRefCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkChange(nameTextBox, nameStrRefCheckBox, ref nameStrRef);
        }

        private void pluralCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkChange(pluralTextBox, pluralStrRefCheckBox, ref pluralStrRef);
        }

        private void lowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkChange(lowerTextBox, lowerRedRefCheckBox, ref lowerStrRef);
        }
    }
}