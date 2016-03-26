using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OEIShared.IO;
using OEIShared.UI.ImageLoader;
using NWN2Toolset.NWN2.IO;
using System.Diagnostics;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2IconChooserForm : Form
    {
        private List<ResourceListItem> imageResources = new List<ResourceListItem>();
        private IResourceEntry selectedImage;
        private Bitmap icon;

        internal static int ImageResourceType = 3;

        public NWN2IconChooserForm()
        {
            InitializeComponent();
            pictureBox.BackgroundImage = BuzzX8.NWN2ClassEditor.Properties.Resources.NoImage;
        }

        public NWN2ResourceManager ResourceManeger
        {
            set
            {                
                imageResources.Clear();
                
                if (value == null) return;

                foreach (IResourceRepository repository in value.Repositories)
                {
                    foreach (IResourceEntry resource in repository.Resources)
                    {
                        if (resource.ResourceType == ImageResourceType)
                        {
                            imageResources.Add(new ResourceListItem(resource)); 
                        }
                    }
                }
                imageResources.Sort(new Comparison<ResourceListItem>(Compare));
                imageListBox.DataSource = imageResources;
            }
        }

        public IResourceEntry ImageResource
        {
            get
            {
                return selectedImage;
            }
        }

        //public List<IResourceEntry> ImageResources
        //{
        //    set
        //    {
        //        foreach (IResourceEntry resource in value)
        //        {
        //            if (resource.ResourceType != ImageResourceType) throw new ArgumentException("Resources not valid");
        //        }

        //        imageResources = value;
        //    }
        //}

        public Bitmap SelectedIcon
        {
            get
            {
                return icon;
            }
        }

        public Bitmap GetImageByResRef(string resRef)
        {
            foreach (ResourceListItem item in imageResources)
            {
                if (item.Resource.ResRef.Value == resRef)
                    return SpecialBitmapLoader.LoadImageFromStream(item.Resource.GetStream(false));
            }

            return null;
        }

        public void SetImageByResRef(string resRef)
        {
            if (resRef == null)
            {
                pictureBox.BackgroundImage = BuzzX8.NWN2ClassEditor.Properties.Resources.NoImage;
                return;
            }

            for (int i = 0; i < imageResources.Count; i++)
            {
                if (imageResources[i].Resource.ResRef.Value == resRef)
                {
                    imageListBox.SelectedIndex = i;
                    selectedImage = ((ResourceListItem)imageListBox.SelectedItem).Resource;
                    return;
                }
            }
        }

        private void imageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageResources.Count == 0) return;

            selectedImage = ((ResourceListItem)imageListBox.SelectedItem).Resource;
            icon = SpecialBitmapLoader.LoadImageFromStream(selectedImage.GetStream(false));//selectedImage.Repository.Name + "\\" + selectedImage.FullName);
            pictureBox.BackgroundImage = icon;
        }

        #region IComparer<ResourceListItem> Members

        internal int Compare(ResourceListItem x, ResourceListItem y)
        {
            return string.Compare(x.Resource.ResRef.Value, y.Resource.ResRef.Value);
        }

        #endregion       
    }

    internal class ResourceListItem
    {
        public IResourceEntry Resource;

        public ResourceListItem(IResourceEntry resource)
        {
            this.Resource = resource;
        }

        public override string ToString()
        {
            return Resource.ResRef.Value;
        }
    }
}