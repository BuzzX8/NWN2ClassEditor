using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BuzzX8.NWN2ClassEditor;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ProperyCheckedListbox : System.Windows.Forms.CheckedListBox
    {        
        private TextBox descriptionTextBox;

        public TextBox DescriptionTextBox
        {
            get 
            {
                return descriptionTextBox; 
            }
            set
            {
                descriptionTextBox = value; 
            }
        }

        public NWN2PropertyListItem this[int index]
        {
            get
            {
                return (NWN2PropertyListItem)base.Items[index];
            }
        }

        [Browsable(false)]
        public NWN2PropertyList NWN2PropertyList
        {
            get
            {
                return SelectedItems;
            }
            set
            {
                this.Items.Clear();
                this.Sorted = false;

                if (value == null) return;

                this.Items.AddRange(value.ToArray());
                this.Sorted = true;
            }
        }

        [Browsable(false)]
        public new NWN2PropertyList SelectedItems
        {
            get
            {
                return new NWN2PropertyList(base.CheckedItems);
            }
            set
            {
                if (Items.Count > 0) CheckAllItems(false);
                if (value == null) return;

                for (int i = 0; i < value.Count; i++)
                {
                    this.SelectedItem = value[i];
                }
            }
        }

        [Browsable(false)]
        public new NWN2PropertyListItem SelectedItem
        {
            get
            {
                return (NWN2PropertyListItem)base.SelectedItem;
            }
            set
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    if (value == (NWN2PropertyListItem)Items[i])
                    {
                        base.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        public NWN2ProperyCheckedListbox()
        {
            InitializeComponent();
        }

        public NWN2ProperyCheckedListbox(NWN2PropertyList list, TextBox descTextBox) : this()
        {
            this.NWN2PropertyList = list;
            this.descriptionTextBox = descTextBox;
        }

        public void CheckAllItems(bool checkedState)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                SetItemChecked(i, checkedState);
            }
        }
    }
}

