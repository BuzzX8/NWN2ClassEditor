using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NWN2Toolset;
using OEIShared;
using OEIShared.IO;
using OEIShared.IO.TalkTable;
using OEIShared.IO.TwoDA;
using BuzzX8.NWN2ClassEditor;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2PropertyListForm : Form
    {        
        public NWN2PropertyListForm()
        {
            InitializeComponent();            
        }

        public NWN2PropertyListForm(NWN2PropertyList propertyList) : this()
        {
            propListCheckedListBox.NWN2PropertyList = propertyList;
        }

        public NWN2PropertyList NWN2PropertyList
        {
            get
            {
                return propListCheckedListBox.NWN2PropertyList;
            }
            set
            {
                propListCheckedListBox.NWN2PropertyList = value;                
            }
        }      

        public NWN2PropertyList SelectedItems
        {
            get
            {
                return propListCheckedListBox.SelectedItems;
            }
        }

        private void propListCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NWN2PropertyListItem selectedItem = (NWN2PropertyListItem)propListCheckedListBox.SelectedItem;

            propertyDescriptionTextBox.Text = selectedItem.Description;
        }

        private void selectAllToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < propListCheckedListBox.Items.Count; i++)
            {
                propListCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void deselectAllToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < propListCheckedListBox.Items.Count; i++)
            {
                propListCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void searchToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            for (int i = 0; i < propListCheckedListBox.Items.Count; i++)
            {
                if (((NWN2PropertyListItem)propListCheckedListBox.Items[i]).Name == searchToolStripTextBox.Text)
                {
                    propListCheckedListBox.SelectedIndex = i;
                    return;
                }
            }
        }
    }
}