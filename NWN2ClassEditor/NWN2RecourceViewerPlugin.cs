using System;
using System.Collections.Generic;
using System.Text;
using NWN2Toolset.Plugins;
using TD.SandBar;

namespace NWN2ResourceViewer
{
    public class NWN2ResourceViewerToolsetPlugin : INWN2Plugin
    {
        MenuButtonItem menuButton;

        #region INWN2Plugin Members

        public string DisplayName
        {
            get 
            {
                return "ResourceViewer"; 
            }
        }

        public void Load(INWN2PluginHost cHost)
        {
            menuButton = cHost.GetMenuForPlugin(this);
            menuButton.Image = BuzzX8.NWN2ClassEditor.Properties.Resources.CreateFullPack;
            menuButton.Activate += new EventHandler(menuButton_Activate);
        }

        void menuButton_Activate(object sender, EventArgs e)
        {
            NWN2ResourceViewerForm form = new NWN2ResourceViewerForm();
            form.Initialize();
            form.Show();
        }

        public string MenuName
        {
            get 
            {
                return "&Resource Viewer";
            }
        }

        public string Name
        {
            get 
            {
                return "ResourceViewer"; ; 
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
            //menuButton = cHost.GetMenuForPlugin(this);
            //menuButton.Activate += new EventHandler(menuButton_Activate);
        }

        public void Unload(INWN2PluginHost cHost)
        {
            
        }

        #endregion
    }
}
