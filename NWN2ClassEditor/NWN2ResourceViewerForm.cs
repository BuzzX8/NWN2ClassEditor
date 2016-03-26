using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NWN2Toolset.NWN2.IO;
using OEIShared.IO;
using OEIShared.UI.ImageLoader;
using System.Diagnostics;
using System.IO;

namespace NWN2ResourceViewer
{
    public partial class NWN2ResourceViewerForm : Form
    {
        NWN2ResourceManager manager;

        public NWN2ResourceViewerForm()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            manager = NWN2ResourceManager.Instance;

            foreach (IResourceRepository repository in manager.Repositories)
            {
                repositoryesListBox.Items.Add(new Wraper(repository.Name, repository));
            }

            repositoryesListBox.Sorted = true;
        }

        private void repositoryesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IResourceRepository repository = (IResourceRepository)((Wraper)repositoryesListBox.SelectedItem).Value;

            resourceDataGridView.Rows.Clear();

            foreach (IResourceEntry resource in repository.Resources)
            {
                resourceDataGridView.Rows.Add(resource.FullName, resource.ResourceType, new Wraper(resource.ResRef.Value, resource));
            }
        }

        private void resourceDataGridView_Click(object sender, EventArgs e)
        {
            IResourceEntry resource;
            StreamReader reader;

            if (resourceDataGridView.SelectedRows.Count == 0) return;

            resource = (IResourceEntry)((Wraper)resourceDataGridView.SelectedRows[0].Cells["resRefColumn"].Value).Value;
            reader = new StreamReader(resource.GetStream(false), Encoding.ASCII);
            resourceContentTextBox.Text = reader.ReadToEnd();
            reader.Close();
        }      
    }

    internal class Wraper
    {
        public string Name;
        public object Value;

        public Wraper(string name, object val)
        {
            this.Name = name;
            this.Value = val;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}