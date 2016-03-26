using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NWN2Toolset.NWN2.IO;
using OEIShared.IO;
using NWN2Toolset.NWN2.Data.Instances;
using System.Diagnostics;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2CharGenChooserForm : Form
    {
        private NWN2Toolset.NWN2.IO.NWN2ResourceManager resourceManager;        
        public event EventHandler ValueChanged;
        
        public NWN2CharGenChooserForm()
        {
            InitializeComponent();            
        }

        public NWN2Toolset.NWN2.IO.NWN2ResourceManager ResourceManager
        {
            get 
            {
                return resourceManager; 
            }
            set 
            {
                List<NWN2ItemInstance> equipItems;

                charGenListBox.Items.Clear();                
                resourceManager = value;
                
                if (resourceManager == null) return;

                equipItems = new List<NWN2ItemInstance>();
                charGenListBox.Sorted = false;

                foreach (IResourceRepository repository in resourceManager.Repositories)
                {
                    foreach (IResourceEntry resource in repository.Resources)
                    {
                        if (resource.ResourceType == 2025) equipItems.Add(new NWN2ItemInstance(resource));                        
                    }
                }
                
                foreach (NWN2ItemInstance item in equipItems)
                {
                    if (item.BaseItem.Row == 16) charGenListBox.Items.Add(new ResourceListItem(item));                    
                }

                charGenListBox.Sorted = true;
            }
        }
        
        public NWN2ItemInstance SelectedItem
        {
            get
            {
                return ((ResourceListItem)charGenListBox.SelectedItem).Item;
            }
        }

        public NWN2ItemInstance GetItemByResRef(string resRef)
        {
            ResourceListItem item;

            for (int i = 0; i < charGenListBox.Items.Count; i++)
            { 
                item = (ResourceListItem)charGenListBox.Items[i];

                if (item.Name == resRef) return item.Item;
            }

            return null;
        }

        private void charGenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null) ValueChanged(this, EventArgs.Empty);
        }
    }

    internal class ResourceListItem
    {
        public NWN2ItemInstance Item;

        public ResourceListItem(NWN2ItemInstance item)
        {
            this.Item = item;
        }

        public string Name
        {
            get
            {
                return Item.Template.ResRef.Value;
            }
        }

        internal static int Compare(ResourceListItem res1, ResourceListItem res2)
        {
            return string.Compare(res1.Item.Template.ResRef.Value, res2.Item.Template.ResRef.Value);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}