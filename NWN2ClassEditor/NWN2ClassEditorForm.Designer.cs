using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace BuzzX8.NWN2ClassEditor
{
    partial class NWN2ClassEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NWN2ClassEditorForm));
            this.separator1ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.createFullPackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.createTlkTableToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.classEditorPanel = new BuzzX8.NWN2ClassEditor.NWN2ClassEditor();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embedInToolsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsetVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.generalToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.createTablesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStripContainer.ContentPanel.SuspendLayout();
            this.mainToolStripContainer.SuspendLayout();
            this.generalToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // separator1ToolStripSeparator
            // 
            this.separator1ToolStripSeparator.Name = "separator1ToolStripSeparator";
            this.separator1ToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // createFullPackToolStripButton
            // 
            this.createFullPackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createFullPackToolStripButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.CreateFullPack;
            this.createFullPackToolStripButton.Name = "createFullPackToolStripButton";
            this.createFullPackToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.createFullPackToolStripButton.Text = "Create full pack";
            this.createFullPackToolStripButton.Click += new System.EventHandler(this.createFullPackToolStripButton_Click);
            // 
            // createTlkTableToolStripButton
            // 
            this.createTlkTableToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createTlkTableToolStripButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.TalkTable;
            this.createTlkTableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createTlkTableToolStripButton.Name = "createTlkTableToolStripButton";
            this.createTlkTableToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.createTlkTableToolStripButton.Text = "Create dialog.tlk";
            this.createTlkTableToolStripButton.Click += new System.EventHandler(this.createTlkTableToolStripButton_Click);
            // 
            // classEditorPanel
            // 
            this.classEditorPanel.AllowedAlignments = new BuzzX8.NWN2ClassEditor.Alignment[] {
        BuzzX8.NWN2ClassEditor.Alignment.LawfulGood,
        BuzzX8.NWN2ClassEditor.Alignment.LawfulNeutral,
        BuzzX8.NWN2ClassEditor.Alignment.LawfulEvil,
        BuzzX8.NWN2ClassEditor.Alignment.NeutralGood,
        BuzzX8.NWN2ClassEditor.Alignment.TrueNeutral,
        BuzzX8.NWN2ClassEditor.Alignment.NeutralEvil,
        BuzzX8.NWN2ClassEditor.Alignment.ChaoticGood,
        BuzzX8.NWN2ClassEditor.Alignment.ChaoticNeutral,
        BuzzX8.NWN2ClassEditor.Alignment.ChaoticEvil};
            this.classEditorPanel.AllSpellsKnown = false;
            this.classEditorPanel.ArcSpellLvlMod = 0;
            this.classEditorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.classEditorPanel.BaseAttackBonus = BuzzX8.NWN2ClassEditor.BaseAB.Hight;
            this.classEditorPanel.BaseClass = true;
            this.classEditorPanel.CharGenChest = null;
            this.classEditorPanel.ClassDescription = "";
            this.classEditorPanel.ClassFeats = null;
            this.classEditorPanel.ClassIconResRef = null;
            this.classEditorPanel.ClassLabel = null;
            this.classEditorPanel.DescriptionStrRef = -1;
            this.classEditorPanel.DivSpellLvlMod = 0;
            this.classEditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classEditorPanel.FavoredWeaponFocus = ((short)(-1));
            this.classEditorPanel.FavoredWeaponProficiency = ((short)(-1));
            this.classEditorPanel.FavoredWeaponSpecialization = ((short)(-1));
            this.classEditorPanel.FeatArmoredCasterName = "";
            this.classEditorPanel.FeatArmoredCasterStrRef = 0;
            this.classEditorPanel.FeatExtraSlotName = "";
            this.classEditorPanel.FeatExtraSlotStrRef = 0;
            this.classEditorPanel.FeatPracticedSpellcasterName = "";
            this.classEditorPanel.FeatPracticedSpellcasterStrRef = 0;
            this.classEditorPanel.HasAnimalCompanion = false;
            this.classEditorPanel.HasArcane = false;
            this.classEditorPanel.HasDivine = false;
            this.classEditorPanel.HasDomains = false;
            this.classEditorPanel.HasFamiliar = false;
            this.classEditorPanel.HasFeatArmoredCaster = false;
            this.classEditorPanel.HasFeatExtraSlot = false;
            this.classEditorPanel.HasFeatPracticedSpellcaster = false;
            this.classEditorPanel.HasInfiniteSpells = false;
            this.classEditorPanel.HasSchool = false;
            this.classEditorPanel.HasSpontaneousSpells = false;
            this.classEditorPanel.HitDie = 1;
            this.classEditorPanel.Location = new System.Drawing.Point(0, 0);
            this.classEditorPanel.MainAbility = BuzzX8.NWN2ClassEditor.Ability.Str;
            this.classEditorPanel.MemorizesSpells = false;
            this.classEditorPanel.MetaMagicAllowed = false;
            this.classEditorPanel.MinimumSize = new System.Drawing.Size(560, 415);
            this.classEditorPanel.Name = "classEditorPanel";
            this.classEditorPanel.PackagesList = null;
            this.classEditorPanel.PrestigeClass = false;
            this.classEditorPanel.ResourceManager = null;
            this.classEditorPanel.Size = new System.Drawing.Size(652, 417);
            this.classEditorPanel.SkillPoints = 0;
            this.classEditorPanel.SpellAbility = BuzzX8.NWN2ClassEditor.Ability.Str;
            this.classEditorPanel.SpellCaster = false;
            this.classEditorPanel.SpellSwapLevelDifficult = 0;
            this.classEditorPanel.SpellSwapLevelInterval = 0;
            this.classEditorPanel.SpellSwapMinLevel = 0;
            this.classEditorPanel.TabIndex = 0;
            this.classEditorPanel.TalkTable = null;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(652, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.createTablesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(185, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // createTablesToolStripMenuItem
            // 
            this.createTablesToolStripMenuItem.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.Table;
            this.createTablesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createTablesToolStripMenuItem.Name = "createTablesToolStripMenuItem";
            this.createTablesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.createTablesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.createTablesToolStripMenuItem.Text = "Create &tables";
            this.createTablesToolStripMenuItem.Click += new System.EventHandler(this.createTablesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(145, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appearanceToolStripMenuItem,
            this.embedInToolsetToolStripMenuItem,
            this.toolsetVisibleToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // appearanceToolStripMenuItem
            // 
            this.appearanceToolStripMenuItem.Checked = true;
            this.appearanceToolStripMenuItem.CheckOnClick = true;
            this.appearanceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
            this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.appearanceToolStripMenuItem.Text = "Appearance tool strip";
            this.appearanceToolStripMenuItem.Click += new System.EventHandler(this.appearanceToolStripMenuItem_Click);
            // 
            // embedInToolsetToolStripMenuItem
            // 
            this.embedInToolsetToolStripMenuItem.CheckOnClick = true;
            this.embedInToolsetToolStripMenuItem.Name = "embedInToolsetToolStripMenuItem";
            this.embedInToolsetToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.embedInToolsetToolStripMenuItem.Text = "Embed in toolset";
            this.embedInToolsetToolStripMenuItem.Click += new System.EventHandler(this.embedInToolsetToolStripMenuItem_Click);
            // 
            // toolsetVisibleToolStripMenuItem
            // 
            this.toolsetVisibleToolStripMenuItem.CheckOnClick = true;
            this.toolsetVisibleToolStripMenuItem.Name = "toolsetVisibleToolStripMenuItem";
            this.toolsetVisibleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.toolsetVisibleToolStripMenuItem.Text = "Hide toolset window";
            this.toolsetVisibleToolStripMenuItem.Click += new System.EventHandler(this.toolsetVisibleToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(126, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "NWN2 class|*.n2c";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "n2c";
            this.saveFileDialog.Filter = "NWN2 class|*.n2c";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select folder where you need save 2da tables";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // mainToolStripContainer
            // 
            // 
            // mainToolStripContainer.ContentPanel
            // 
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.classEditorPanel);
            this.mainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(652, 417);
            this.mainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainToolStripContainer.Location = new System.Drawing.Point(0, 24);
            this.mainToolStripContainer.Name = "mainToolStripContainer";
            this.mainToolStripContainer.Size = new System.Drawing.Size(652, 442);
            this.mainToolStripContainer.TabIndex = 2;
            // 
            // generalToolStrip
            // 
            this.generalToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.generalToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.separator1ToolStripSeparator,
            this.createTablesToolStripButton,
            this.createTlkTableToolStripButton,
            this.createFullPackToolStripButton});
            this.generalToolStrip.Location = new System.Drawing.Point(3, 0);
            this.generalToolStrip.Name = "generalToolStrip";
            this.generalToolStrip.Size = new System.Drawing.Size(104, 25);
            this.generalToolStrip.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // createTablesToolStripButton
            // 
            this.createTablesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createTablesToolStripButton.Image = global::BuzzX8.NWN2ClassEditor.Properties.Resources.Table;
            this.createTablesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createTablesToolStripButton.Name = "createTablesToolStripButton";
            this.createTablesToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.createTablesToolStripButton.Text = "Create 2da tables";
            this.createTablesToolStripButton.Click += new System.EventHandler(this.createTablesToolStripMenuItem_Click);
            // 
            // NWN2ClassEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 466);
            this.Controls.Add(this.mainToolStripContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 500);
            this.Name = "NWN2ClassEditorForm";
            this.Text = "NWN2 class editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NWN2ClassEditorForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStripContainer.ContentPanel.ResumeLayout(false);
            this.mainToolStripContainer.ResumeLayout(false);
            this.mainToolStripContainer.PerformLayout();
            this.generalToolStrip.ResumeLayout(false);
            this.generalToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void createFullPackToolStripButton_Click(object sender, System.EventArgs e)
        {
            TwoDATable classes2DA;
            string packPath;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                packPath = folderBrowserDialog.SelectedPath;
                packPath = Path.Combine(packPath, classEditorPanel.ClassLabel);
                Directory.CreateDirectory(packPath, new System.Security.AccessControl.DirectorySecurity(packPath, System.Security.AccessControl.AccessControlSections.Access));
                classes2DA = SaveTalkTable(packPath);
                classes2DA.SaveToFile(packPath);
            }
        }

        void createTlkTableToolStripButton_Click(object sender, System.EventArgs e)
        {
            TwoDATable classes2DA;

            saveFileDialog.FileName = "dialog.tlk";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {                
                classes2DA = SaveTalkTable(saveFileDialog.FileName);
                classes2DA.SaveToFile(Path.GetDirectoryName(saveFileDialog.FileName));
            }
        }

        #endregion

        
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private ToolStripMenuItem createTablesToolStripMenuItem;
        private ToolStripContainer mainToolStripContainer;
        private ToolStrip generalToolStrip;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator separator1ToolStripSeparator;
        private ToolStripButton createTablesToolStripButton;
        private ToolStripButton createTlkTableToolStripButton;
        private ToolStripButton createFullPackToolStripButton;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem appearanceToolStripMenuItem;
        private ToolStripMenuItem embedInToolsetToolStripMenuItem;
        private NWN2ClassEditor classEditorPanel;
        private ToolStripMenuItem toolsetVisibleToolStripMenuItem;        
    }
}