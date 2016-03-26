using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ClassNameEditor : UserControl
    {
        private NWN2NameEditorDialogForm nameDialog;
        private NWN2ClassName className;

        public NWN2ClassNameEditor()
        {
            InitializeComponent();
            nameDialog = new NWN2NameEditorDialogForm();
        }

        [Browsable(false)]
        public NWN2ClassName ClassName
        {           
            get
            {
                return className; 
            }
            set 
            {
                className = value;
                nameDialog.ClassName = value;

                if (className.NameStrRef >= 0)
                {
                    if (NWN2PropertyListItem.TalkTable != null) classNameTextBox.Text = NWN2PropertyListItem.TalkTable[className.NameStrRef];
                    else classNameTextBox.Text = "StrRef " + className.NameStrRef;
                }
                else classNameTextBox.Text = className.LocalizedName;
            }
        }

        public string ClassLebel
        {
            get
            {
                return className.Label;
            }
            set
            {
                if (value == null) className.Label = "";
                else className.Label = value;
            }
        }

        public string LocalizedName
        {
            get
            {
                return className.LocalizedName;
            }
            set
            {
                if (value == null) className.LocalizedName = classNameTextBox.Text = "";
                else className.LocalizedName = classNameTextBox.Text = value;
            }
        }

        public string ClassPlural
        {
            get
            {
                return className.Plural;
            }
            set
            {
                if (value == null) className.Plural = "";
                else className.Plural = value;
            }
        }

        public string ClassLower
        {
            get
            {
                return className.Lower;
            }
            set
            {
                if (value == null) className.Lower = "";
                else className.Lower = value;
            }
        }

        private void editClassNameButton_Click(object sender, EventArgs e)
        {
            nameDialog.ClassName = className;
            nameDialog.Location = Parent.PointToScreen(this.Location);

            if (nameDialog.ShowDialog() == DialogResult.OK)
            {
                className = nameDialog.ClassName;                
                classNameTextBox.Text = className.LocalizedName;

                if (ValueCanged != null) ValueCanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler ValueCanged;
    }
}
