using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2StrRefCheckBox : CheckBox
    {
        private TextBox textBox;
        private NWN2StrRefCooser strRefDialog;        

        public NWN2StrRefCheckBox()
        {
            InitializeComponent();
            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            Text = "StrRef";
            Click += new EventHandler(NWN2StrRefCheckBox_Click);
            strRefDialog = new NWN2StrRefCooser();
        }

        public int StrRef
        {
            get
            {
                return strRefDialog.SelectedStrRef;
            }
            set
            {
                strRefDialog.SelectedStrRef = value;

                if (value >= 0) Checked = true; else Checked = false;
                if (textBox == null) return;
                if (value >= 0)
                {
                    textBox.Text = strRefDialog.SelectedString;
                    textBox.Enabled = false;
                }
                else textBox.Enabled = true;
            }
        }

        void NWN2StrRefCheckBox_Click(object sender, EventArgs e)
        {
            if (textBox == null) return;

            if (this.Checked)
            {
                if (strRefDialog.ShowDialog() == DialogResult.OK)
                {
                    //descriptionStrRef = strRefDialog.SelectedStrRef;
                    textBox.Text = strRefDialog.SelectedString;
                    textBox.Enabled = false;
                }
                else this.Checked = false;
            }
            else textBox.Enabled = true;
        }
        
        [Browsable(true)]
        public TextBox TextBox
        {
            get 
            {
                return textBox; 
            }
            set
            {
                textBox = value; 
            }
        }
    }
}
