using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ClassDescriptionEditor : UserControl
    {
        private NWN2StrRefCooser strRefDialog;
        private NWN2ClassNameEditor nameEditor;
        private int descriptionStrRef;

        public NWN2ClassDescriptionEditor()
        {
            InitializeComponent();
            descriptionStrRef = -1;
            strRefDialog = new NWN2StrRefCooser();
        }

        [Browsable(true)]
        public NWN2ClassNameEditor ClassNameEditor
        {
            get
            {
                return nameEditor;
            }
            set
            {
                nameEditor = value;
            }
        }

        [Browsable(false)]
        public int DescriptionStrRef
        {
            get
            {
                return descriptionStrRef;
            }
            set
            {
                descriptionStrRef = value;

                if (value < 0)
                {
                    descriptionResRefCheckBox.Checked = false;
                    classDescriptionTextBox.Enabled = true;
                    return;
                }
                else
                {
                    descriptionResRefCheckBox.Checked = true;
                    classDescriptionTextBox.Enabled = false;

                    if (NWN2PropertyListItem.TalkTable != null)
                    {
                        classDescriptionTextBox.Text = NWN2PropertyListItem.TalkTable[value];
                    }
                    else classDescriptionTextBox.Text = "StrRef " + value;
                }
            }
        }

        public string Description
        {
            get
            {
                return classDescriptionTextBox.Text;
            }
            set
            {
                DescriptionStrRef = -1;
                classDescriptionTextBox.Enabled = true;
                classDescriptionTextBox.Text = value;
            }
        }        

        private void descriptionResRefCheckBox_Click(object sender, EventArgs e)
        {
            if (descriptionResRefCheckBox.Checked)
            {
                if (strRefDialog.ShowDialog() == DialogResult.OK)
                {
                    descriptionStrRef = strRefDialog.SelectedStrRef;
                    classDescriptionTextBox.Text = strRefDialog.SelectedString;
                    classDescriptionTextBox.Enabled = false;
                }
                else descriptionResRefCheckBox.Checked = false;
            }
            else classDescriptionTextBox.Enabled = true;
        }

        public string CreateClassDescriptionString()
        {
            StringBuilder result = new StringBuilder();

            if (nameEditor != null) result.Append(nameEditor.LocalizedName);
            result.Append(Environment.NewLine);

            return result.ToString();
        }

        private void createDescriptionTextButton_Click(object sender, EventArgs e)
        {
            Description = CreateClassDescriptionString();
        }        
    }
}
