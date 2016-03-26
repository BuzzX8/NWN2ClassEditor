using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using BuzzX8.NWN2ClassEditor;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using OEIShared.IO.TwoDA;
using NWN2Toolset.NWN2.Data.Templates;
using Microsoft.DirectX;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2CharGenPanel : Component
    {
        private NWN2CharGenChooserForm charGenChooser;
        private NWN2Toolset.NWN2.NetDisplay.NWN2NetDisplayManager netDisplayManager;
        private NWN2Toolset.NWN2.IO.NWN2ResourceManager resourceManager;
        private NWN2Toolset.NWN2.Data.Instances.NWN2CreatureInstance armorDummy;
        
        private NWN2ClassEditor classEditorPanel;

        public ToolStrip AppearanceToolStrip
        {
            get
            {
                return apperanceToolStrip;
            }
        }
        
        public NWN2CharGenPanel()
        {            
            InitializeComponent();
            initialize();
            initializeApperance();
            electronPanel.Load += new EventHandler(electronPanel_Load);
            charGenChooser = new NWN2CharGenChooserForm();            
            charGenChooser.ValueChanged += new EventHandler(charGenChooser_ValueChanged);
            charGenButton.Click += new EventHandler(charGenButton_Click);
            maleToolStripMenuItem.Click += new EventHandler(maleToolStripMenuItem_Click);
            femaleToolStripMenuItem.Click += new EventHandler(femaleToolStripMenuItem_Click);
            tintSkinToolStripButton.Click += new EventHandler(tintSkinToolStripButton_Click);
            hairToolStripComboBox.SelectedIndexChanged += new EventHandler(hairToolStripComboBox_SelectedIndexChanged);
            headToolStripComboBox.SelectedIndexChanged += new EventHandler(headToolStripComboBox_SelectedIndexChanged);

            charGenChooser.ResourceManager = resourceManager;            

            for (byte i = 0; i <= 20; i++)
            {
                hairToolStripComboBox.Items.Add(i);
                headToolStripComboBox.Items.Add(i);
            }            
        }

        public NWN2Toolset.NWN2.IO.NWN2ResourceManager ResourceManager
        {
            get
            {
                return resourceManager;
            }
            set
            {
                resourceManager = value;

                if (classEditorPanel == null) classEditorPanel.ResourceManager = NWN2Toolset.NWN2.IO.NWN2ResourceManager.Instance;
            }
        }

        public NWN2ClassEditor ClassEditorPanel
        {
            get
            {
                return classEditorPanel; 
            }
            set
            {
                if (object.ReferenceEquals(classEditorPanel, value)) return;

                classEditorPanel = value;

                if (value == null) return;

                classEditorPanel.ClassArmorPanel.Controls.Add(charGenButton);                
                classEditorPanel.ClassArmorPanel.Controls.Add(electronPanel);
                classEditorPanel.TalkTableUpdated += new EventHandler(classEditorPanel_TalkTableUpdated);
                classEditorPanel.NewClassInitialized += new EventHandler(classEditorPanel_NewClassInitialized);
                                
                if (classEditorPanel.ResourceManager == null) classEditorPanel.ResourceManager = NWN2Toolset.NWN2.IO.NWN2ResourceManager.Instance;
                
            }
        }
        
        private void initialize()
        {
            resourceManager = NWN2Toolset.NWN2.IO.NWN2ResourceManager.Instance;
            netDisplayManager = NWN2Toolset.NWN2.NetDisplay.NWN2NetDisplayManager.Instance;

            if (resourceManager == null || netDisplayManager == null) return;

            initializeArmourDummy();
        }

        private void initializeArmourDummy()
        {
            armorDummy = new NWN2Toolset.NWN2.Data.Instances.NWN2CreatureInstance();
            armorDummy.AppearanceType.Row = 564;
            armorDummy.AppearanceHead = 2;
            armorDummy.AppearanceHair = 10;
            armorDummy.Orientation = new OEIShared.OEIMath.RHQuaternion(0.0f, 0.0f, 1.0f, 0.0f);

            armorDummy.TintFacialHair = Color.Black;
            armorDummy.TintHair1 = Color.Black;
            armorDummy.TintHair2 = Color.DarkGray;
            armorDummy.TintEyes = Color.Yellow;
            armorDummy.TintSkin = Color.LightGray;                        
        }

        void tintSkinToolStripButton_Click(object sender, EventArgs e)
        {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        armorDummy.TintSkin = colorDialog.Color;
                        netDisplayManager.UpdateAppearanceForInstance(armorDummy);
                    }
        }
        
        private void initializeApperance()
        {            
            TwoDAFile apperance = TwoDAManager.Instance.Get("appearance");

            if (apperance == null) return;

            apperanceToolStripComboBox.Sorted = false;

            for (int i = 0; i < apperance.RowCount; i++)
            {
                if (apperance["LABEL"][i] == "" || apperance["LABEL"][i] == null) continue;

                apperanceToolStripComboBox.Items.Add(new AppearanceListItem(apperance["LABEL"][i], i));
            }

            apperanceToolStripComboBox.Sorted = true;
            apperanceToolStripComboBox.SelectedIndexChanged += new EventHandler(apperanceToolStripComboBox_SelectedIndexChanged);
        }

        void hairToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            armorDummy.AppearanceHair = (byte)hairToolStripComboBox.SelectedItem;
            netDisplayManager.UpdateAppearanceForInstance(armorDummy);
        }

        void apperanceToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppearanceListItem selectedItem = (AppearanceListItem)apperanceToolStripComboBox.SelectedItem;

            if (armorDummy != null)
            {
                armorDummy.AppearanceType.Row = selectedItem.Row;
            }

            netDisplayManager.UpdateAppearanceForInstance(armorDummy);
        }

        void headToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            armorDummy.AppearanceHead = (byte)headToolStripComboBox.SelectedItem;
            netDisplayManager.UpdateAppearanceForInstance(armorDummy);
        }

        void classEditorPanel_NewClassInitialized(object sender, EventArgs e)
        {
            NWN2InstanceInventoryItem inventoryItem = new NWN2InstanceInventoryItem();

            if (classEditorPanel.CharGenChest == null || classEditorPanel.CharGenChest == "")
            {
                armorDummy.EquippedItems[1].Item = new NWN2InstanceInventoryItem();
                netDisplayManager.UpdateAppearanceForInstance(armorDummy);
            }

            inventoryItem.Item = charGenChooser.GetItemByResRef(classEditorPanel.CharGenChest);
            armorDummy.EquippedItems[1].Item = inventoryItem;
            netDisplayManager.UpdateAppearanceForInstance(armorDummy);
        }

        void maleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (armorDummy == null) return;

            armorDummy.Gender = CreatureGender.Male;
            genderToolStripSplitButton.Text = maleToolStripMenuItem.Text;
            netDisplayManager.UpdateAppearanceForInstance(armorDummy);
        }

        void femaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (armorDummy == null) return;

            armorDummy.Gender = CreatureGender.Female;
            genderToolStripSplitButton.Text = femaleToolStripMenuItem.Text;
            netDisplayManager.UpdateAppearanceForInstance(armorDummy);
        }

        private void electronPanel_Load(object sender, EventArgs e)
        {
            NWN2Toolset.NWN2.Data.Instances.NWN2PlaceableInstance placeable;
            //NWN2LightInstance light;
            NWN2Toolset.NWN2.Data.NWN2GameAreaTileData tile;

            if (netDisplayManager == null) return;

            electronPanel.Scene.ShowGroundPlane = false;
            electronPanel.Scene.ShowSky = false;
            electronPanel.FocusOn(new Vector3(0f, 0f, 1f));
            electronPanel.CameraPosition = new Vector3(0f, -3f, 1.3f);
            electronPanel.CameraOrientation = new OEIShared.OEIMath.RHQuaternion(0.05f, 0f, 0f, 1f);
            
            netDisplayManager.CreateNDOForInstance(armorDummy, electronPanel.Scene, 0);
            tile = new NWN2Toolset.NWN2.Data.NWN2GameAreaTileData(null);
            tile.Appearance.Row = 37;
            tile.CeilingTexture.Row = 5;
            tile.FloorTexture.Row = 6;
            tile.Position = new Vector3(0, 0, 0);
            netDisplayManager.CreateNDOForTile(tile, electronPanel.Scene, false, false, 1);

            //Worck brech
            placeable = new NWN2Toolset.NWN2.Data.Instances.NWN2PlaceableInstance();
            placeable.Appearance.Row = 1416;
            placeable.PositionNoSnap = new Vector3(0f, 3.5f, 0f);
            placeable.Heading = 0f;
            netDisplayManager.CreateNDOForInstance(placeable, electronPanel.Scene, 2);

            //Claudron
            placeable = new NWN2Toolset.NWN2.Data.Instances.NWN2PlaceableInstance();
            placeable.Appearance.Row = 1004;
            placeable.PositionNoSnap = new Vector3(-2.0f, 1.0f, 0f);
            placeable.Heading = 0f;
            netDisplayManager.CreateNDOForInstance(placeable, electronPanel.Scene, 3);

            //Banner
            placeable = new NWN2Toolset.NWN2.Data.Instances.NWN2PlaceableInstance();
            placeable.Appearance.Row = 2361;
            placeable.PositionNoSnap = new Vector3(0f, 4.0f, 1f);
            placeable.Heading = 0f;
            netDisplayManager.CreateNDOForInstance(placeable, electronPanel.Scene, 4);

            //Tarp
            placeable = new NWN2Toolset.NWN2.Data.Instances.NWN2PlaceableInstance();
            placeable.Appearance.Row = 2255;
            placeable.PositionNoSnap = new Vector3(0f, 0f, 0f);
            netDisplayManager.CreateNDOForInstance(placeable, electronPanel.Scene, 5);

            //Armor rack
            placeable = new NWN2Toolset.NWN2.Data.Instances.NWN2PlaceableInstance();
            placeable.Appearance.Row = 2246;
            placeable.PositionNoSnap = new Vector3(1.3f, 1f, 0f);
            placeable.Heading = 45f;
            netDisplayManager.CreateNDOForInstance(placeable, electronPanel.Scene, 6);

            //Armor pile
            placeable = new NWN2Toolset.NWN2.Data.Instances.NWN2PlaceableInstance();
            placeable.Appearance.Row = 2251;
            placeable.PositionNoSnap = new Vector3(-1.3f, -1f, 0f);
            placeable.Heading = 90f;
            netDisplayManager.CreateNDOForInstance(placeable, electronPanel.Scene, 7);

            //Light
            //light = new NWN2LightInstance();
            //light.PositionNoSnap = new Vector3(0f, 2f, 3f);
            //light.Color.DiffuseColor = Color.Aqua;
            //light.Color.Intensity = 2f;
            //light.IsOn = true;
            //netDisplayManager.CreateNDOForInstance(light, electronPanel.Scene, 6);
        }

        private void charGenButton_Click(object sender, EventArgs e)
        {
            NWN2InstanceInventoryItem backUpArmour;
            
            charGenChooser.Location = classEditorPanel.PointToScreen(new Point(electronPanel.Location.X + electronPanel.Width + 150, electronPanel.Location.Y + 30));
            backUpArmour = (NWN2InstanceInventoryItem)armorDummy.EquippedItems[1].Item;

            if (charGenChooser.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                armorDummy.EquippedItems[1].Item = backUpArmour;
            }
            else if (classEditorPanel != null) classEditorPanel.CharGenChest = ((NWN2InstanceInventoryItem)armorDummy.EquippedItems[1].Item).Item.Template.ResRef.Value;
            netDisplayManager.UpdateAppearanceForInstance(armorDummy);
        }

        private void classEditorPanel_TalkTableUpdated(object sender, EventArgs e)
        {
            if (classEditorPanel.TalkTable != null)
            {
                genderToolStripLabel.Text = classEditorPanel.TalkTable[150] + " :";
                maleToolStripMenuItem.Text = genderToolStripSplitButton.Text = classEditorPanel.TalkTable[156];
                femaleToolStripMenuItem.Text = classEditorPanel.TalkTable[157];
                tintSkinToolStripButton.Text = classEditorPanel.TalkTable[181288];
            }            
        }

        private void charGenChooser_ValueChanged(object sender, EventArgs e)
        {
            NWN2InstanceInventoryItem item = new NWN2InstanceInventoryItem();
                        
            item.Item = charGenChooser.SelectedItem;
            armorDummy.EquippedItems[1].Item = item;
            netDisplayManager.UpdateAppearanceForInstance(armorDummy);
        }
    }

    internal struct AppearanceListItem
    {
        public string Label;
        public int Row;

        public AppearanceListItem(string label, int row)
        {
            Label = label;
            Row = row;
        }

        public override string ToString()
        {
            return Label;
        }
    }
}
