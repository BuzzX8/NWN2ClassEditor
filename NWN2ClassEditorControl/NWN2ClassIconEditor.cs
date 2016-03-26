using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NWN2Toolset.NWN2.IO;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ClassIconEditor : Button
    {
        private NWN2IconChooserForm iconChooserDialog;

        public NWN2ClassIconEditor()
        {
            InitializeComponent();
            iconChooserDialog = new NWN2IconChooserForm();
            Size = new Size(50, 50);
            FlatStyle = FlatStyle.Flat;
            BackgroundImage = BuzzX8.NWN2ClassEditor.Properties.Resources.NoImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            Click += new EventHandler(NWN2ClassIconEditor_Click);
        }

        public string ImageResRef
        {
            get
            {
                if (iconChooserDialog.ImageResource == null) return null;
                return iconChooserDialog.ImageResource.ResRef.Value;
            }
            set
            {
                iconChooserDialog.SetImageByResRef(value);

                if (iconChooserDialog.GetImageByResRef(value) == null) BackgroundImage = BuzzX8.NWN2ClassEditor.Properties.Resources.NoImage;
                else BackgroundImage = iconChooserDialog.GetImageByResRef(value);
            }
        }

        public Image ClassIcon
        {
            get
            {
                return BackgroundImage;
            }
        }

        void NWN2ClassIconEditor_Click(object sender, EventArgs e)
        {
            iconChooserDialog.Location = PointToScreen(new Point(Location.X + Width, Location.Y));

            if (iconChooserDialog.ShowDialog() == DialogResult.OK)
            {
                if (iconChooserDialog.SelectedIcon == null) BackgroundImage = BuzzX8.NWN2ClassEditor.Properties.Resources.NoImage;
                else BackgroundImage = iconChooserDialog.SelectedIcon;
            }
        }

        public NWN2ResourceManager ResourceManager
        {
            set
            {
                iconChooserDialog.ResourceManeger = value;
            }
        }
    }
}
