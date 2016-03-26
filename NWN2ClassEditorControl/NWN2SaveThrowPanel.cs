using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2SaveThrowPanel : UserControl
    {
        private Dictionary<SaveThrow, NWN2PropertyListItem> strRefItems = new Dictionary<SaveThrow, NWN2PropertyListItem>();
        private NWN2PropertyListItem title;

        public NWN2SaveThrowPanel()
        {
            InitializeComponent();

            title = new NWN2PropertyListItem(316);
            strRefItems.Add(SaveThrow.Fortidute, new NWN2PropertyListItem(317));
            strRefItems.Add(SaveThrow.Reflex, new NWN2PropertyListItem(318));
            strRefItems.Add(SaveThrow.Will, new NWN2PropertyListItem(319));
            UpdateLabels();
        }

        public SaveThrow SaveThrowSpecialization
        {
            get
            {
                SaveThrow result = new SaveThrow();

                if (fortiduteCheckBox.Checked) result |= SaveThrow.Fortidute;
                if (reflexThrowCheckBox.Checked) result |= SaveThrow.Reflex;
                if (willThrowCheckBox.Checked) result |= SaveThrow.Will;

                return result;
            }
            set
            {
                if ((value & SaveThrow.Fortidute) == SaveThrow.Fortidute) fortiduteCheckBox.Checked = true;
                else fortiduteCheckBox.Checked = false;

                if ((value & SaveThrow.Reflex) == SaveThrow.Reflex) reflexThrowCheckBox.Checked = true;
                else reflexThrowCheckBox.Checked = false;

                if ((value & SaveThrow.Will) == SaveThrow.Will) willThrowCheckBox.Checked = true;
                else willThrowCheckBox.Checked = false;
            }
        }

        internal string GetSaveThrowTableResRef()
        {
            SaveThrow current = SaveThrowSpecialization;

            switch (SaveThrowSpecialization)
            { 
                case SaveThrow.Fortidute:
                    return "CLS_SAVTHR_BARB";                    

                case SaveThrow.Reflex:
                    return "CLS_SAVTHR_ROG";
                    
                case SaveThrow.Will:
                    return "CLS_SAVTHR_WIZ";

                case SaveThrow.Fortidute ^ SaveThrow.Reflex:
                    return "CLS_SAVTHR_RANG";                    

                case SaveThrow.Fortidute ^ SaveThrow.Will:
                    return "CLS_SAVTHR_DRU";

                case SaveThrow.Reflex ^ SaveThrow.Will:
                    return "CLS_SAVTHR_BARD";

                case SaveThrow.Fortidute ^ SaveThrow.Reflex ^ SaveThrow.Will:
                    return "CLS_SAVTHR_MONK";

                default:
                    return null;
            }
        }

        internal void UpdateLabels()
        {
            saveThrowTitleLabel.Text = title.Name;
            fortiduteCheckBox.Text = strRefItems[SaveThrow.Fortidute].Name;
            reflexThrowCheckBox.Text = strRefItems[SaveThrow.Reflex].Name;
            willThrowCheckBox.Text = strRefItems[SaveThrow.Will].Name;
        }
    }
}
