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
    public partial class NWN2StrRefCooser : Form
    {
        private string prewString = "";

        public NWN2StrRefCooser()
        {
            InitializeComponent();
            SelectedStrRef = 0;
        }

        public int SelectedStrRef
        {
            get
            {
                if (strRefTextBox.Text == null || strRefTextBox.Text == "") return -1;

                return int.Parse(strRefTextBox.Text);
            }
            set
            {
                strRefTextBox.Text = value.ToString();
                showString(value);
            }
        }

        public string SelectedString
        {
            get
            {
                return stringTextBox.Text;
            }
        }

        private void showString(int strRef)
        {
            if (NWN2PropertyListItem.TalkTable != null && NWN2PropertyListItem.TalkTable.Elements.Count > strRef)
                stringTextBox.Text = NWN2PropertyListItem.TalkTable[strRef];
            else stringTextBox.Text = "StrRef " + strRef;
        }

        private void strRefTextBox_TextChanged(object sender, EventArgs e)
        {            
            int strRef;            

            try
            {
                strRef = int.Parse(strRefTextBox.Text);
            }
            catch (FormatException ex)
            {
                if (strRefTextBox.Text == "")
                {
                    stringTextBox.Text = "";
                    return;
                }

                MessageBox.Show(ex.Message);
                strRefTextBox.Text = prewString;
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
                strRefTextBox.Text = prewString;
                return;
            }

            showString(strRef);
        }

        private void strRefTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string prewString = strRefTextBox.Text;
        }       
    }
}
