using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OEIShared.UI;
using System.IO;
using System.Diagnostics;
using NWN2Toolset;
using OEIShared.IO.TwoDA;
using NWN2Toolset.NWN2.Views;
using NWN2Toolset.NWN2.Data;
using System.Collections;
using TD.SandBar;
using OEIShared.IO;
using NWN2Toolset.NWN2.IO;
using OEIShared.IO.TalkTable;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ClassEditorForm : Form
    {
        private NWN2CharGenPanel charGenPanel;        
        private NWN2TwoDAViewer viewer;
        private TwoDATable classes2DA;
        private string savePath = null;

        public NWN2ClassEditorForm()
        {
            InitializeComponent();            
            Icon = BuzzX8.NWN2ClassEditor.Properties.Resources.CE;            
            charGenPanel = new NWN2CharGenPanel();
            charGenPanel.ClassEditorPanel = classEditorPanel;
            generalToolStrip.Location = new Point(0, 0);            
            embedInToolsetToolStripMenuItem.Image = BuzzX8.NWN2ClassEditor.Properties.Resources.ToolsetIcon.ToBitmap();
            mainToolStripContainer.TopToolStripPanel.Controls.Add(charGenPanel.AppearanceToolStrip);
            mainToolStripContainer.TopToolStripPanel.Controls.Add(generalToolStrip);
            newToolStripButton.Click += new EventHandler(newToolStripButton_Click);
            classEditorPanel.ClassLabel = "my_class";
            folderBrowserDialog.SelectedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Neverwinter Nights 2\\Override");
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public TalkTableFile TalkTable
        {
            get
            {
                return classEditorPanel.TalkTable;
            }
            set
            {
                classEditorPanel.TalkTable = value;
            }
        }

        public TwoDATable Classes2DA
        {
            get
            {
                return classes2DA;
            }
            set
            {
                if (!TwoDAValidator.IsClasses2DA(value)) throw new ArgumentException("Table is not classes.2da");

                classes2DA = value;
                classes2DA.TableName = "classes";                
            }
        }

        public void Initialize(params string[] repositoryFiles)
        {
            IResourceRepository twoDARepository;
            IResourceEntry twoDAResource;
            Dictionary<string, TwoDATable> tables = new Dictionary<string,TwoDATable>();
            OEIShared.Utils.OEIResRef resRef = new OEIShared.Utils.OEIResRef();
            string[] tablesNemes = new string[] { "classes", "domains", "feat", "hen_companion", "hen_familiar", "packages", "racialsubtypes", "skills", "spells", "spellschools" };
            //Debugger.Launch();
            foreach (string tableName in tablesNemes)
            {
                for (int i = 0; i < repositoryFiles.Length; i++)
                {
                    twoDARepository = NWN2Toolset.NWN2.IO.NWN2ResourceManager.Instance.GetRepositoryByName(repositoryFiles[i]);
                    resRef.Value = tableName;
                    twoDAResource = twoDARepository.FindResource(resRef, 2017);

                    if (twoDAResource != null)
                    {
                        tables.Add(tableName, new TwoDATable(twoDAResource.GetStream(false)));
                        break;
                    }
                }
            }
            Initialize(tables);
        }

        public void Initialize(Dictionary<string, TwoDATable> initializationTables)
        {
            Classes2DA = initializationTables["classes"];
            classEditorPanel.AnimalCompanionList = initializationTables["hen_companion"];
            classEditorPanel.DomainsList = initializationTables["domains"];
            classEditorPanel.FamiliarList = initializationTables["hen_familiar"];
            classEditorPanel.FeatsList = initializationTables["feat"];            
            classEditorPanel.PackagesList = initializationTables["packages"];
            classEditorPanel.RacialSubtypesList = initializationTables["racialsubtypes"];
            classEditorPanel.SkillsList = initializationTables["skills"];
            classEditorPanel.SpellsList = initializationTables["spells"];
            classEditorPanel.SpellSchoolsList = initializationTables["spellschools"];            
        }

        public void SaveTables(string path)
        {
            //Debugger.Launch();
            TwoDATable[] tables = classEditorPanel.Create2DATables(classes2DA);
            
            foreach (TwoDATable table in tables)
            {
                table.SaveToFile(path);
            }
        }

        public TwoDATable SaveTalkTable(string path)
        {
            TalkTableFile tlkFile = new TalkTableFile();
            TwoDATable classes2DA = (TwoDATable)this.classes2DA.Clone();

            tlkFile.Open(NWN2ClassEditorPlugin.FindDialogTlk(), true);
            classEditorPanel.ImportToTlkFile(classes2DA, tlkFile);            
            tlkFile.Save(path);
            tlkFile.Close();

            return classes2DA;
        }

        void newToolStripButton_Click(object sender, EventArgs e)
        {
            classEditorPanel.InitializeNewClass("NewClass");
        }

        private void createTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SaveTables(folderBrowserDialog.SelectedPath);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = classEditorPanel.ClassLabel;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                classEditorPanel.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                classEditorPanel.LoadFromFile(openFileDialog.FileName);
                savePath = openFileDialog.FileName;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savePath == null)
            {
                saveFileDialog.FileName = classEditorPanel.ClassLabel;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    savePath = saveFileDialog.FileName;
                    classEditorPanel.SaveToFile(savePath);
                }

                return;
            }

            classEditorPanel.SaveToFile(savePath);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savePath = null;
        }

        private void appearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            charGenPanel.AppearanceToolStrip.Visible = appearanceToolStripMenuItem.Checked;
        }

        private void embedInToolsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NWN2TwoDAViewer viewer = null;
            TwoDAFile empty2DA;
            Type tabPanelType;
            IList toolsetTabs;
            Panel tabPage;
            int index;

            if (embedInToolsetToolStripMenuItem.Checked)
            {
                empty2DA = new TwoDAFile();                
                empty2DA.Name = "NWN2Class editor";                
                NWN2ToolsetMainForm.App.ShowResource(empty2DA);
                viewer = NWN2ToolsetMainForm.App.GetActiveViewer() as NWN2TwoDAViewer;                
                tabPanelType = viewer.Parent.GetType();
                toolsetTabs = (IList)tabPanelType.GetProperty("TabPages").GetValue(viewer.Parent, null);
                index = toolsetTabs.Count;
                tabPage = toolsetTabs[index - 1] as Panel;                
                tabPage.GetType().GetProperty("Icon").SetValue(tabPage, BuzzX8.NWN2ClassEditor.Properties.Resources.CE, null);                                

                foreach (Control control in viewer.Controls)
                {
                    control.Visible = false;
                }

                viewer.Controls.Add(classEditorPanel);                                
            }
            else
            {
                this.mainToolStripContainer.ContentPanel.Controls.Add(classEditorPanel);                
                NWN2ToolsetMainForm.App.CloseViewer(viewer, false);
            }

        }

        private void toolsetVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NWN2ToolsetMainForm.App == null) return;

            NWN2ToolsetMainForm.App.Visible = !toolsetVisibleToolStripMenuItem.Checked;
        }

        private void NWN2ClassEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NWN2ToolsetMainForm.App != null && !NWN2ToolsetMainForm.App.Visible)
                NWN2ToolsetMainForm.App.Visible = true;
        }
    }
}