using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BuzzX8.NWN2ClassEditor;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2PropertyListExt : UserControl
    {
        private NWN2PropertyList propertyList = new NWN2PropertyList();

        [Browsable(false)]
        public NWN2PropertyList PropertyList
        {
            get 
            {
                return PropertyListCheckedListBox.NWN2PropertyList;
            }
            set
            {
                PropertyListCheckedListBox.NWN2PropertyList = value;
            }
        }

        public TextBox DescriptionTextBox
        {
            get
            {
                return PropertyListCheckedListBox.DescriptionTextBox;
            }
            set
            {
                this.PropertyListCheckedListBox.DescriptionTextBox = value;
            }
        }
        
        [Browsable(false)]
        public virtual NWN2PropertyList SelectedItems
        {
            get
            {
                return PropertyListCheckedListBox.SelectedItems;
            }
            set
            {
                PropertyListCheckedListBox.SelectedItems = value;
            }
        }

        [Browsable(false)]
        public virtual NWN2PropertyListItem SelectedValue
        {
            get
            {
                return PropertyListCheckedListBox.SelectedItem;
            }
        }

        public NWN2PropertyListExt()
        {            
            InitializeComponent();            
        }

        public void CheckAllItems(bool checkState)
        {
            PropertyListCheckedListBox.CheckAllItems(checkState);
        }

        public void Clear()
        {
            PropertyListCheckedListBox.Items.Clear();
        }
    }
}
