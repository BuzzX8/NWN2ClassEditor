using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BuzzX8.NWN2ClassEditor;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2PropertySelectableList : BuzzX8.NWN2ClassEditor.NWN2PropertyListExt
    {
        public event ItemCheckEventHandler ItemCheck;

        public NWN2PropertySelectableList() : this(false, false)
        { }

        public NWN2PropertySelectableList(bool search, bool filter)
        {            
            InitializeComponent();
            PropertyListCheckedListBox.ItemCheck += new ItemCheckEventHandler(PropertyListCheckedListBox_ItemCheck);
            SearchPanel = search;
            FilterPanel = filter;            
        }        

        public bool SearchPanel
        {
            get
            {
                return SearchToolStripLabel.Visible;
            }
            set
            {
                SearchToolStripLabel.Visible = value;
                SearchToolStripTextBox.Visible = value;
                SearchToolStripButton.Visible = value;
                Separator1.Visible = value;
            }
        }

        public bool FilterPanel
        {
            get
            {
                return FilterToolStripLabel.Visible;
            }
            set
            {
                FilterToolStripLabel.Visible = value;
                FilterToolStripTextBox.Visible = value;
                FilterToolStripButton.Visible = value;
            }
        }

        public new NWN2PropertyList PropertyList
        {
            get
            {
                if (PropertyListCheckedListBox.Items.Count == 0) return null;
                else return new NWN2PropertyList(PropertyListCheckedListBox.Items);
            }
            set
            {
                PropertyListCheckedListBox.Items.Clear();

                if (value == null) return;

                PropertyListCheckedListBox.Sorted = false;
                PropertyListCheckedListBox.Items.AddRange(value.ToArray());
                PropertyListCheckedListBox.Sorted = true;
            }
        }
        
        void PropertyListCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ItemCheck != null) ItemCheck(this, e);
        }
    }
}

