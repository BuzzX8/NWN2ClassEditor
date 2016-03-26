using System;
using System.Collections.Generic;
using System.Text;
using NWN2Toolset;
using NWN2Toolset.Plugins;
using OEIShared;
using TD.SandBar;
using System.Windows.Forms;
using OEIShared.IO.TalkTable;
using NWN2Toolset.NWN2.IO;
using NWN2Toolset.NWN2.NetDisplay;
using NWN2Toolset.NWN2.Data.Instances;
using System.Drawing;
using Microsoft.Win32;
using OEIShared.IO.TwoDA;
using System.Diagnostics;
using System.IO;

namespace BuzzX8.NWN2ClassEditor
{
    public class NWN2ClassEditorPlugin : INWN2Plugin
    {
        private NWN2ClassEditorForm classEditorForm = null;
        private MenuButtonItem menuButton;

        #region INWN2Plugin Members

        public string DisplayName
        {
            get 
            {
                return "NWN2 class editor"; 
            }
        }

        public void Load(INWN2PluginHost cHost)
        {            
            menuButton = cHost.GetMenuForPlugin(this);
            menuButton.Icon = BuzzX8.NWN2ClassEditor.Properties.Resources.CE;
            menuButton.Activate += new EventHandler(menuButton_Activate);
        }

        public string MenuName
        {
            get 
            {
                return "&Class editor";
            }
        }

        public string Name
        {
            get 
            {
                return "ClassEditor"; 
            }
        }

        public MenuButtonItem PluginMenuItem
        {
            get 
            {
                return menuButton;
            }
        }

        public object Preferences
        {
            get
            {
                return null;
            }
            set
            {                
            }
        }

        public void Shutdown(INWN2PluginHost cHost)
        {            
        }

        public void Startup(INWN2PluginHost cHost)
        {            
        }

        public void Unload(INWN2PluginHost cHost)
        {            
        }

        #endregion

        public static string GetNWN2InstallPath()
        {
            return (string)Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("Obsidian").OpenSubKey("NWN 2").OpenSubKey("Neverwinter").GetValue("Path");
        }

        public static string FindDialogTlk()
        {
            string mainPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            mainPath = Path.Combine(mainPath, "Neverwinter Nights 2");

            if (File.Exists(mainPath + "\\dialog.tlk")) return mainPath + "\\dialog.tlk";

            mainPath = Path.Combine(mainPath, "Override");

            if (File.Exists(mainPath + "\\dialog.tlk")) return mainPath + "\\dialog.tlk";

            mainPath = GetNWN2InstallPath();

            if (File.Exists(mainPath + "\\dialog.tlk")) return mainPath + "\\dialog.tlk";

            return null;
        }
                
        void menuButton_Activate(object sender, EventArgs e)
        {
            NWN2LoadBanner loadDialog = new NWN2LoadBanner();            
            TalkTableFile tlkFile = new TalkTableFile();
            string tlkPath = FindDialogTlk();

            if (tlkPath == null)
            {
                MessageBox.Show("Can't find file dialog.TLK!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Debugger.Launch();
            //ToolsetSurrogateObject.Initialize();
            loadDialog.Show();
            classEditorForm = new NWN2ClassEditorForm();                
            tlkFile.Open(tlkPath, true);                    
            classEditorForm.TalkTable = tlkFile;
            classEditorForm.Initialize(GetNWN2InstallPath() + "\\Data\\2DA_X1.zip", GetNWN2InstallPath() + "\\Data\\2DA.zip");
            loadDialog.Close();
            loadDialog.Dispose();
            classEditorForm.Show();
            
        }
    }
}
