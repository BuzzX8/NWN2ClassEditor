using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.DirectX;

namespace BuzzX8.NWN2ClassEditor
{
    public class ToolsetSurrogateObject
    {
        private static Assembly nwn2ToolsetAssembly;        
        private static Assembly oeiSharedAssembly;
        private Type originalType;
        protected object originalObject;        
        
        public ToolsetSurrogateObject(string typeName)
        {
            if (nwn2ToolsetAssembly != null)
            {
                originalType = nwn2ToolsetAssembly.GetType(typeName);

                if (originalType != null) return;
            }

            if (oeiSharedAssembly != null)
            {
                originalType = oeiSharedAssembly.GetType(typeName);

                if (originalType != null) return;
            }

            throw new TypeLoadException("Reqired type not found");
        }

        public object OriginalObject
        {
            get { return originalObject; }            
        }
        public Type OriginalType
        {
            get 
            {
                return originalType; 
            }
        }

        internal static Assembly NWN2ToolsetAssembly
        {
            get 
            {
                return ToolsetSurrogateObject.nwn2ToolsetAssembly; 
            }
            set
            {
                ToolsetSurrogateObject.nwn2ToolsetAssembly = value; 
            }
        }
        internal static Assembly OEISharedAssembly
        {
            get 
            {
                return ToolsetSurrogateObject.oeiSharedAssembly; 
            }
            set 
            {
                ToolsetSurrogateObject.oeiSharedAssembly = value; 
            }
        }

        public static void Initialize()
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (assembly.GetName().Name == "NWN2Toolset") nwn2ToolsetAssembly = assembly;
                if (assembly.GetName().Name == "OEIShared") oeiSharedAssembly = assembly;
            }
        }
    }

    public class NWN2ResourceManager : ToolsetSurrogateObject
    {
        private new static object originalObject;
        private static NWN2ResourceManager thisObj;

        static NWN2ResourceManager()
        {
            thisObj = new NWN2ResourceManager();
            originalObject = thisObj.OriginalObject;
        }

        private NWN2ResourceManager() : base("NWN2Toolset.NWN2.IO.NWN2ResourceManager")
        {
            originalObject = OriginalType.GetProperty("Instance").GetValue(null, null);
        }

        public static NWN2ResourceManager Instance
        {
            get
            {
                return thisObj;
            }
        }
    }

    public class ElectronPanel : Control
    {
        ToolsetSurrogateObject electronPanel;
        RHQuaternion cameraOrientation;
        Control electronPanelControl;
        
        public ElectronPanel()
        {
            electronPanel = new ToolsetSurrogateObject("OEIShared.UI.ElectronPanel");
            electronPanelControl = (Control)electronPanel.OriginalType.GetConstructor(new Type[0]).Invoke(new object[0]);
            electronPanelControl.Dock = DockStyle.Fill;
            Controls.Add(electronPanelControl);
        }

        public Vector3 CameraPosition
        {
            get
            {
                return (Vector3)electronPanel.OriginalType.GetProperty("CameraPosition").GetValue(this, null);
            }
            set
            {
                electronPanel.OriginalType.GetProperty("CameraPosition").SetValue(this, value, null);
            }
        }

        public void FocusOn(Vector3 focusPoint)
        {
            electronPanel.OriginalType.GetMethod("FocusOn").Invoke(this, new object[] { focusPoint });
        }

        public RHQuaternion CameraOrientation
        {
            get
            {
                return cameraOrientation;
            }
            set
            {
                cameraOrientation = value;
                electronPanel.OriginalType.GetProperty("CameraOrientation").SetValue(this, value, null);
            }
        }
    }

    public class RHQuaternion : ToolsetSurrogateObject
    {
        public RHQuaternion(float x, float y, float z, float w) : base("OEIShared.OEIMath.RHQuaternion")
        {
            originalObject = OriginalType.GetConstructor(new Type[] { typeof(float), typeof(float), typeof(float), typeof(float) }).Invoke(new object[] { x, y, z, w });
        }
    }

    public class NetDisplayScene : ToolsetSurrogateObject
    {
        public NetDisplayScene(object originObject) : base("OEIShared.NetDisplay.NetDisplayScene")
        {
            if (originObject.GetType().FullName != "OEIShared.NetDisplay.NetDisplayScene") throw new ArgumentException();
            
            this.originalObject = originObject;
        }

        public bool ShowSky
        {
            get
            {
                return (bool)OriginalType.GetProperty("ShowSky").GetValue(originalObject, null);
            }
            set
            {
                OriginalType.GetProperty("ShowSky").SetValue(originalObject, value, null);                
            }
        }

        public bool ShowGroundPlane
        {
            get
            {
                return (bool)OriginalType.GetProperty("ShowGroundPlane").GetValue(originalObject, null);
            }
            set
            {
                OriginalType.GetProperty("ShowGroundPlane").SetValue(originalObject, value, null);
            }
        }
    }

    public class NWN2NetDisplayManager : ToolsetSurrogateObject
    {
        private new static object originalObject;
        private static NWN2NetDisplayManager thisObj;

        static NWN2NetDisplayManager()
        {
            thisObj = new NWN2NetDisplayManager();
            originalObject = thisObj.OriginalObject;
        }

        private NWN2NetDisplayManager() : base("NWN2Toolset.NWN2.NetDisplay.NWN2NetDisplayManager")
        {
            originalObject = OriginalType.GetProperty("Instance").GetValue(null, null);
        }

        public static NWN2NetDisplayManager Instance
        {
            get
            {
                return thisObj;
            }
        }
    }

    public class NWN2CreatureInstance : ToolsetSurrogateObject
    {
        public NWN2CreatureInstance() : base("NWN2Toolset.NWN2.Data.Instances.NWN2CreatureInstance")
        { }

        public byte AppearanceHead
        {
            get
            {
                return (byte)OriginalType.GetProperty("AppearanceHead").GetValue(originalObject, null);
            }
            set
            {
                OriginalType.GetProperty("AppearanceHead").SetValue(originalObject, value, null);
            }
        }

        public byte AppearanceHair
        {
            get
            {
                return (byte)OriginalType.GetProperty("AppearanceHair").GetValue(originalObject, null);
            }
            set
            {
                OriginalType.GetProperty("AppearanceHair").SetValue(originalObject, value, null);
            }
        }

        public RHQuaternion Orientation
        {
            //get
            //{
            //    return OriginalType.GetProperty("Orientation").GetValue(originalObject, null);
            //}
            set
            {
                OriginalType.GetProperty("Orientation").SetValue(originalObject, value.OriginalObject, null);
            }
        }
    }

    public class NWN2PlaceableInstance : ToolsetSurrogateObject
    {
        public NWN2PlaceableInstance() : base("NWN2Toolset.NWN2.Data.Instances.NWN2PlaceableInstance")
        { }

        public RHQuaternion Orientation
        {
            //get
            //{
            //    return OriginalType.GetProperty("Orientation").GetValue(originalObject, null);
            //}
            set
            {
                OriginalType.GetProperty("Orientation").SetValue(originalObject, value.OriginalObject, null);
            }
        }
    }
}
