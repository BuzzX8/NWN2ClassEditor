using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    internal partial class NWN2EnumComboBox : ComboBox
    {
        private static NWN2PropertyListItem[] abilityItems;

        internal int[] StrRefItems
        {            
            set 
            {
                abilityItems = new NWN2PropertyListItem[value.Length];

                for(int i = 0; i < abilityItems.Length; i++)
                {
                    abilityItems[i] = new NWN2PropertyListItem(value[i]);
                    Items.Add(abilityItems[i]);
                }
                SelectedIndex = 0;
            }
        }

        internal Type EnumType;

        public NWN2EnumComboBox()
        {
            InitializeComponent();
            
        }

        public NWN2EnumComboBox(IContainer container) : this()
        {
            container.Add(this);            
        }

        [Browsable(false)]
        public new Enum SelectedItem
        {
            get
            {
                
                if (base.SelectedIndex < 0) return null;
                return (Enum)Enum.ToObject(EnumType, base.SelectedIndex);
            }
            set
            {
                if (Items.Count == 0 || value == null) return;
                SelectedIndex = ((IConvertible)value).ToInt32(null);
            }
        }
    }
}
