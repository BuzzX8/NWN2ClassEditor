using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NWN2Toolset;
using OEIShared;
using OEIShared.IO;
using OEIShared.IO.TalkTable;
using OEIShared.IO.TwoDA;
using System.Runtime.Serialization.Formatters.Binary;
using NWN2Toolset.NWN2.IO;
using OEIShared.UI.ImageLoader;
using System.Diagnostics;
using System.Reflection;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ClassEditor : UserControl
    {
        #region Private members

        //Dialogs
        private NWN2AdvancedSpellcasterSettingsForm advancedSpellDialog;
        private BonusFeatsEditorForm bonusFeatDialog;
        private BonusSpellcasterLevelEditorForm bonusSpellcasterLvlDialog;
        private EffectiveCRLevelEditorForm effCRDialog;        
        private NWN2PreReqTableDialogForm preReqDialog;
        private NWN2SpellGainDialogForm spellGainDialog;
        private NWN2SpellKnownDialogForm spellKnownDialog;
        private NWN2SpontaneousConversationForm spontaneousConvDialog;        

        private NWN2ResourceManager toolsetResManager;
        private NWN2ClassName className = new NWN2ClassName();
        private TwoDATable domainsList = null;
        private TwoDATable featsList = null;
        private TwoDATable skillsList = null;
        private TwoDATable spellSchoolsList = null;
        private TwoDATable packagesList = null;
        private TwoDATable familiarList = null;
        private TwoDATable animalCompanionList = null;
        private TalkTableFile talkTable = null;        
        private string charGenChest = null;
        
        #endregion

        #region Propetys zone

        public bool HasFeatExtraSlot
        {
            get
            {
                return advancedSpellDialog.HasFeatExtraSlot;
            }
            set
            {
                advancedSpellDialog.HasFeatExtraSlot = value;
            }
        }

        public bool HasFeatPracticedSpellcaster
        {
            get
            {
                return advancedSpellDialog.HasFeatPracticedSpellcaster; ;
            }
            set
            {
                advancedSpellDialog.HasFeatPracticedSpellcaster = value;
            }
        }

        public bool HasFeatArmoredCaster
        {
            get
            {
                return advancedSpellDialog.HasFeatArmoredCaster;
            }
            set
            {
                advancedSpellDialog.HasFeatArmoredCaster = value;
            }
        }

        public int FeatExtraSlotStrRef
        {
            get
            {
                return advancedSpellDialog.FeatExtraSlotStrRef;
            }
            set
            {
                advancedSpellDialog.FeatExtraSlotStrRef = value;
            }
        }

        public string FeatExtraSlotName
        {
            get
            {
                return advancedSpellDialog.FeatExtraSlotName;
            }
            set
            {
                advancedSpellDialog.FeatExtraSlotName = value;
            }
        }

        public int FeatPracticedSpellcasterStrRef
        {
            get
            {
                return advancedSpellDialog.FeatExtraSlotStrRef;
            }
            set
            {
                advancedSpellDialog.FeatExtraSlotStrRef = value;
            }
        }

        public string FeatPracticedSpellcasterName
        {
            get
            {
                return advancedSpellDialog.FeatPracticedSpellcasterName;
            }
            set
            {
                advancedSpellDialog.FeatPracticedSpellcasterName = value;
            }
        }

        public int FeatArmoredCasterStrRef
        {
            get
            {
                return advancedSpellDialog.FeatArmoredCasterStrRef;
            }
            set
            {
                advancedSpellDialog.FeatArmoredCasterStrRef = value;
            }
        }

        public string FeatArmoredCasterName
        {
            get
            {
                return advancedSpellDialog.FeatArmoredCasterName;
            }
            set
            {
                advancedSpellDialog.FeatArmoredCasterName = value;
            }
        }

        public int ArcSpellLvlMod
        {
            get
            {
                return advancedSpellDialog.ArcSpellLvlMod;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Value must be greater or equal to zero");

                advancedSpellDialog.ArcSpellLvlMod = value;
            }
        }

        public int DivSpellLvlMod
        {
            get
            {
                return advancedSpellDialog.DivSpellLvlMod;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Value must be greater or equal to zero");

                advancedSpellDialog.DivSpellLvlMod = value;
            }
        }

        [Browsable(false)]
        public string ClassIconResRef
        {
            get
            {
                return classIconButton.ImageResRef;
            }
            set
            {
                classIconButton.ImageResRef = value;
            }
        }

        [Browsable(false)]
        public int DescriptionStrRef
        {
            get 
            {
                return classDescriptionEditor.DescriptionStrRef; 
            }
            set 
            {                
                classDescriptionEditor.DescriptionStrRef = value;
            }
        }

        public short FavoredWeaponFocus
        {
            get
            {
                if (!favoredWeaponCheckBox.Checked) return -1;

                return (short)weaponFocusNumericUpDown.Value;
            }
            set
            {
                weaponFocusNumericUpDown.Value = value;
            }
        }

        public short FavoredWeaponProficiency
        {
            get
            {
                if (!favoredWeaponCheckBox.Checked) return -1;

                return (short)weaponProfLevelNumericUpDown.Value;
            }
            set
            {
                weaponProfLevelNumericUpDown.Value = value;
            }
        }

        public short FavoredWeaponSpecialization
        {
            get
            {
                if (!favoredWeaponCheckBox.Checked) return -1;

                return (short)weaponSpecialNumericUpDown.Value;
            }
            set
            {
                weaponSpecialNumericUpDown.Value = value;
            }
        }

        [Browsable(false)]
        public DefaultAbility DefaultAbilitys
        {
            get
            {
                return abilityPointManagePanel.Ability;
            }
            set
            {
                abilityPointManagePanel.Ability = value;
            }
        }
        
        [Description("List of allowed alignments")]
        public Alignment[] AllowedAlignments
        {
            get
            {
                return classAlignmentPanel.SelectedAlignments;
            }
            set
            {
                classAlignmentPanel.SelectedAlignments = value;
            }
        }

        public NWN2Package[] ClassPackages
        {
            get
            {
                return classPackageListBox.ClassPackages;
            }
            set
            {
                classPackageListBox.ClassPackages = value;
            }
        }

        public TwoDATable FamiliarList
        {
            set
            {
                familiarList = value;
            }
        }

        public TwoDATable AnimalCompanionList
        {
            set
            {
                animalCompanionList = value;
            }
        }

        //public List<IResourceEntry> ImageResourcesList
        //{
        //    set
        //    {
        //        iconChooser.ImageResources = value;
        //    }
        //}

        //Fixed
        [Browsable(false)]
        public TwoDATable FeatsList
        {
            set
            {
                if (!TwoDAValidator.IsFeat2DA(value)) throw new ArgumentException("Table is not feat list 2da");

                classFeatsGrid.Clear();
                featsList = value;
                if (value == null) return;
                
                classFeatsGrid.FeatsList = value;
                classPackageListBox.FeatsList = value;                
                preReqDialog.FeatsList = value;
            }
        }

        [Browsable(false)]
        public TwoDATable DomainsList
        {
            set
            {
                domainsList = value;
                classPackageListBox.DomainsList = value;

                if (domainsList != null) domainsList.TableName = "domains";
                
            }
        }

        public TwoDATable SpellSchoolsList
        {
            set
            {
                spellSchoolsList = value;
                
                if(HasSchool) classPackageListBox.SchoolsList = value;
            }
        }

        //Fixed
        [Browsable(false)]
        public TwoDATable SkillsList
        {            
            set
            {
                if (!TwoDAValidator.IsSkills2DA(value)) throw new ArgumentException("Table is not skills list 2da");

                classSkillCheckedListBox.Items.Clear();
                if (value == null) return;

                skillsList = value;
                classPackageListBox.SkillsList = value;
                classSkillCheckedListBox.NWN2PropertyList = value.ConvertToList("Name", "Description", "REMOVED", "1");
                preReqDialog.SkillsList = value;                
            }
        }
        
        //Fixed
        [Browsable(false)]
        public TwoDATable SpellsList
        {            
            set
            {
                if (!TwoDAValidator.IsSpells2DA(value)) throw new ArgumentException("Table is not spell list 2da");

                classSpellsCheckedListBox.Clear();

                if (value == null) return;
                                
                classPackageListBox.SpellsList = value;
                classSpellsCheckedListBox.PropertyList = value.ConvertToList("Name", "SpellDesc", "REMOVED", "1");
                spontaneousConvDialog.SpellsList = value;
            }
        }

        //Fixed
        [Browsable(false)]
        public TwoDATable RacialSubtypesList
        {
            set
            {
                preReqDialog.RacialSubTypesList = value;              
            }
        }

        [Browsable(false)]
        public NWN2ResourceManager ResourceManager
        {
            get
            {
                return toolsetResManager;
            }
            set
            {
                toolsetResManager = value;
                classIconButton.ResourceManager = value;
            }
        }

        [Browsable(false)]
        public TwoDATable PackagesList
        {
            get
            {
                return packagesList;
            }
            set
            {
                packagesList = value;

                if (packagesList != null) packagesList.TableName = "packages";
            }
        }

        //Fixed
        [Browsable(false)]
        public TalkTableFile TalkTable
        {
            get 
            {
                return talkTable; 
            }
            set
            {
                talkTable = value;                
                NWN2PropertyListItem.TalkTable = value;

                abilityPointManagePanel.UpdateLabels();
                classAlignmentPanel.UpdateLabels();
                classSaveThrowPanel.UpdateLabels();
                classFeatsGrid.UpdateLabels();
                classPackageListBox.UpdateLabel();

                if (TalkTableUpdated != null) TalkTableUpdated(this, EventArgs.Empty);
            }
        }
        
        [Description("Primary ability")]
        public Ability MainAbility
        {
            get
            {
                return (Ability)mainAbilityComboBox.SelectedItem;
            }
            set
            {                
                if (mainAbilityComboBox.Items.Count <= 0) return;
                mainAbilityComboBox.SelectedItem = value;
                classPackageListBox.DefaultAbility = value;
            }
        }
        
        [Description("Ability-key for casting spells.")]
        public Ability SpellAbility
        {
            get
            {
                return (Ability)spellAbilityComboBox.SelectedItem;
            }
            set
            {
                if (spellAbilityComboBox.Items.Count <= 0) return;
                spellAbilityComboBox.SelectedItem = value;
            }
        }

        public BaseAB BaseAttackBonus
        {
            get
            {
                return (BaseAB)baseABComboBox.SelectedItem;
            }
            set
            {
                if (baseABComboBox.Items.Count <= 0) return;
                baseABComboBox.SelectedItem = value;
            }
        }

        [Description("How many HP a class can take for each level without constitution bonus")]
        public int HitDie
        {
            get
            {
                return (int)hitDieNumericUpDown.Value;
            }
            set
            {
                if (value < 1) throw new ArgumentException("Value must be greater then zero.");
                
                hitDieNumericUpDown.Value = (decimal)value;
            }
        }

        //Fixed_1.0
        [Browsable(false)]
        [Description("Available feats for the class")]
        public NWN2ClassFeatsList ClassFeats
        {
            get
            {
                return classFeatsGrid.ClassFeats;
            }
            set
            {
                classFeatsGrid.ClassFeats = value;
            }
        }

        [Description("Number of skill points given at each level without intelligence bonus.")]
        public int SkillPoints
        {
            get
            {
                return (int)skillPointsNumericUpDown.Value;
            }
            set
            {
                if (value < 0) throw new ArgumentException("This property can't be less than zero");                
                skillPointsNumericUpDown.Value = value;
            }
        }

        [Description("Indicates that class can cast spells")]
        public bool SpellCaster
        {
            get
            {
                return spellcasterCheckBox.Checked;
            }
            set
            {                
                spellcasterCheckBox.Checked = value;
            }
        }

        [Browsable(false)]
        [Description("Class's base saving throws.")]
        public SaveThrow SaveThrowSpecialization
        {
            get
            {
                return classSaveThrowPanel.SaveThrowSpecialization;
            }
            set
            {
                classSaveThrowPanel.SaveThrowSpecialization = value;
            }
        }
         
        [Description("true if PC has a familiar (i.e. Sourcer), false if hasn't")]
        public bool HasFamiliar
        {
            get
            {
                return hasFamiliarCheckBox.Checked;
            }
            set
            {
                hasFamiliarCheckBox.Checked = value;
            }
        }

        [Description("true if PC has an animal companion (i.e. Ranger), false if hasn't")]
        public bool HasAnimalCompanion
        {
            get
            {
                return hasAnimalCompanionCheckBox.Checked;
            }
            set
            {
                hasAnimalCompanionCheckBox.Checked = value;
            }
        }

        [Description("true if casts divine spells, false is doesen't.")]
        public bool HasDivine
        {
            get
            {
                return hasDivineCheckBox.Checked;
            }
            set
            {
                hasDivineCheckBox.Checked = value;
            }
        }

        [Description("true if casts arcane spells, false if doesen't.")]
        public bool HasArcane
        {
            get
            {
                return hasArcaneCheckBox.Checked;
            }
            set
            {
                hasArcaneCheckBox.Checked = value;
            }
        }

        [Description("true if can cast metamagic spells, false if cannot")]
        public bool MetaMagicAllowed
        {
            get
            {
                return metaMagicAllowedCheckBox.Checked;
            }
            set
            {
                metaMagicAllowedCheckBox.Checked = value;
            }
        }

        [Description("true if character must memorize the spells that want to cast (i.e. Wizard), false if directly casts spells (i.e. Sourcer)")]
        public bool MemorizesSpells
        {
            get
            {
                return memorizesSpellsCheckBox.Checked;
            }
            set
            {
                memorizesSpellsCheckBox.Checked = value;
            }
        }
                
        public bool HasSpontaneousSpells
        {
            get
            {
                return hasSpontaneousSpellsCheckBox.Checked;
            }
            set
            {
                hasSpontaneousSpellsCheckBox.Checked = value;
            }
        }

        [Description("The first level at which the character gets to swap one spell for another of their choice")]
        public int SpellSwapMinLevel
        {
            get
            {
                return (int)spellSwapMinLvlNumericUpDown.Value;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Value must be greater or equal than zero");
                spellSwapMinLvlNumericUpDown.Value = value;
            }
        }

        [Description("How many levels after the first the character gets to swap one more spell ")]
        public int SpellSwapLevelInterval
        {
            get
            {
                return (int)spellSwapLvlIntervalNumericUpDown.Value;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Value must be greater or equal than zero");
                spellSwapLvlIntervalNumericUpDown.Value = value;
            }
        }

        [Description("When the character gets to swap a spell, it must be at least this many difficulty levels below their current highest casting level")]
        public int SpellSwapLevelDifficult
        {
            get
            {
                return (int)spellSwapLvlDiffNumericUpDown.Value;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Value must be greater or equal than zero");
                spellSwapLvlDiffNumericUpDown.Value = value;
            }
        }

        [Description("false if the character is not a spellcasting class or needs to select spells at level up (like a sorcerer) or true if spells need not be selected (like a cleric).")]
        public bool AllSpellsKnown
        {
            get
            {
                return allSpellsKnownCheckBox.Checked;
            }
            set
            {
                allSpellsKnownCheckBox.Checked = value;
            }
        }

        [Description("true - infinite spells, false - finite spells")]
        public bool HasInfiniteSpells
        {
            get
            {
                return infiniteSpellsCheckBox.Checked;
            }
            set
            {
                infiniteSpellsCheckBox.Checked = value;
            }
        }

        [Description("true if PC has domains (i.e. Cleric), false if hasn't")]
        public bool HasDomains
        {
            get
            {
                return domainsAllowedCheckBox.Checked;
            }
            set
            {
                domainsAllowedCheckBox.Checked = value;
            }
        }

        [Browsable(false)]
        public NWN2SkillReqList ClassReqSkills
        {
            get
            {
                if (prestigeClassTypeRadioButton.Checked == false) return null;
                return preReqDialog.ClassReqSkills;
            }
        }

        [Browsable(false)]
        public List<NWN2FeatReq> ClassReqFeats
        {
            get
            {
                return preReqDialog.ClassReqFeats;
            }
        }

        [Browsable(false)]
        public NWN2PropertyList ClassSkills
        {
            get
            {
                return classSkillCheckedListBox.SelectedItems;
            }
            set
            {
                classSkillCheckedListBox.SelectedItems = value;
            }
        }

        public string ClassLabel
        {
            get
            {
                return className.Label;
            }
            set
            {
                className.Label = value;
                classPackageListBox.ClassLabel = value;
            }
        }

        [Browsable(false)]
        public NWN2ClassName ClassName
        {
            get
            {
                return classNameEditor.ClassName;
            }
            set
            {                
                classNameEditor.ClassName = value;
            }
        }

        public string ClassDescription
        {
            get
            {
                return classDescriptionEditor.Description;
            }
            set
            {
                classDescriptionEditor.Description = value;
            }
        }

        [Description("true if PC has Schools of Magic (i.e. wizard), false if hasn't")]
        public bool HasSchool
        {
            get
            {
                return schoolAllowedCheckBox.Checked;
            }
            set
            {
                schoolAllowedCheckBox.Checked = value;
            }
        }

        [Browsable(false)]
        public NWN2PropertyList ClassSpells
        {
            get
            {
                return classSpellsCheckedListBox.SelectedItems;
            }
            set
            {
                classSpellsCheckedListBox.SelectedItems = value;
            }
        }

        public bool BaseClass
        {
            get
            {
                return baseClassTypeRadioButton.Checked;
            }
            set
            {
                if (value == false && prestigeClassTypeRadioButton.Checked == false) return;

                baseClassTypeRadioButton.Checked = value;
            }
        }

        public bool PrestigeClass
        {
            get
            {
                return prestigeClassTypeRadioButton.Checked;
            }
            set
            {
                if (value == false && baseClassTypeRadioButton.Checked == false) return;

                prestigeClassTypeRadioButton.Checked = value;
                maxLevelNumericUpDown.Enabled = value;
            }
        }

        [Browsable(false)]
        public Panel ClassArmorPanel
        {
            get
            {
                return generalSplitContainer.Panel1;
            }
        }

        [Browsable(false)]
        [Description("This is the clothing that the PC appears in on the creation screens.")]
        public string CharGenChest
        {
            get
            {
                return charGenChest;
            }
            set
            {
                charGenChest = value;
            }
        }

        #endregion

        #region Constructors

        public NWN2ClassEditor()
        {
            int[] ability = new int[] { 135, 133, 132, 134, 136, 131 };
            int[] abBonus = new int[] { 53152, 53151, 53150 };

            InitializeComponent();
            mainAbilityComboBox.StrRefItems = ability;
            mainAbilityComboBox.EnumType = typeof(Ability);

            spellAbilityComboBox.StrRefItems = ability;
            spellAbilityComboBox.EnumType = typeof(Ability);

            baseABComboBox.StrRefItems = abBonus;
            baseABComboBox.EnumType = typeof(BaseAB);

            bonusFeatDialog = new BonusFeatsEditorForm();            

            spellGainDialog = new NWN2SpellGainDialogForm();
            spellGainDialog.SpellTable.LevelCount = 60;

            spellKnownDialog = new NWN2SpellKnownDialogForm();
            spellKnownDialog.SpellTable.LevelCount = 60;

            bonusSpellcasterLvlDialog = new BonusSpellcasterLevelEditorForm();
            advancedSpellDialog = new NWN2AdvancedSpellcasterSettingsForm();
            preReqDialog = new NWN2PreReqTableDialogForm();
            effCRDialog = new EffectiveCRLevelEditorForm();

            spontaneousConvDialog = new NWN2SpontaneousConversationForm();
            spontaneousConvDialog.IconChooserDialog = new NWN2IconChooserForm();
        }

        #endregion

        #region Public functions

        public void InitializeNewClass(string classLabel)
        {
            CharGenChest = null;
            ClassName = new NWN2ClassName(classLabel);            
            ClassDescription = "";
            ClassFeats = null;
            ClassIconResRef = null;
            ClassSkills = null;
            ClassSpells = null;
            DescriptionStrRef = -1;

            if (NewClassInitialized != null) NewClassInitialized(this, EventArgs.Empty);
        }

        public void SaveToFile(string fileName)
        {            
            FileStream file = new FileStream(fileName, FileMode.Create);

            SaveToStream(file);
            file.Flush();
            file.Close();
        }

        public void SaveToStream(Stream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();            
            NWN2Class classToSave = CreateClass();
                        
            formatter.Serialize(stream, classToSave);            
        }

        public void LoadFromStream(Stream stream)
        {                        
            BinaryFormatter formatter = new BinaryFormatter();            
            object classToLoad;            
            
            classToLoad = formatter.Deserialize(stream);            
            InitializeFromClass(classToLoad);
        }

        public void LoadFromFile(string fileName)
        {
            FileStream file = File.OpenRead(fileName);

            LoadFromStream(file);
            file.Flush();
            file.Close();
        }

        internal int ImportIn2DA(TwoDATable class2DA)
        {
            class2DA.Add();
            ImportIn2DA(class2DA, class2DA.RowCount - 1);

            return class2DA.RowCount - 1;
        }

        internal void ImportIn2DA(TwoDATable class2DA, int indexToSave)
        {            
            if (ClassName.NameStrRef >= 0) class2DA[indexToSave, "Name"] = ClassName.NameStrRef.ToString();
            if (ClassName.PluralStrRef >= 0) class2DA[indexToSave, "Plural"] = ClassName.PluralStrRef.ToString();
            if (ClassName.LowerStrRef >= 0) class2DA[indexToSave, "Lower"] = ClassName.LowerStrRef.ToString();
            if (DescriptionStrRef >= 0) class2DA[indexToSave, "Description"] = DescriptionStrRef.ToString();

            class2DA[indexToSave, "Label"] = ClassLabel;
            class2DA[indexToSave, "Icon"] = ClassIconResRef;
            class2DA[indexToSave, "HitDie"] = HitDie.ToString();
            class2DA[indexToSave, "AttackBonusTable"] = "CLS_ATK_" + (((IConvertible)BaseAttackBonus).ToInt16(null) + 1);
            class2DA[indexToSave, "SavingThrowTable"] = classSaveThrowPanel.GetSaveThrowTableResRef();
            class2DA[indexToSave, "SkillPointBase"] = SkillPoints.ToString();
            class2DA[indexToSave, "PlayerClass"] = "1";
            class2DA[indexToSave, "SpellCaster"] = Convert.ToByte(SpellCaster).ToString();
            class2DA[indexToSave, "MetaMagicAllowed"] = Convert.ToByte(MetaMagicAllowed).ToString();
            class2DA[indexToSave, "MemorizesSpells"] = Convert.ToByte(MemorizesSpells).ToString();
            class2DA[indexToSave, "HasArcane"] = Convert.ToByte(HasArcane).ToString();
            class2DA[indexToSave, "HasDivine"] = Convert.ToByte(HasDivine).ToString();
            class2DA[indexToSave, "HasSpontaneousSpells"] = Convert.ToByte(HasSpontaneousSpells).ToString();            
            class2DA[indexToSave, "AllSpellsKnown"] = Convert.ToByte(AllSpellsKnown).ToString();
            class2DA[indexToSave, "HasInfiniteSpells"] = Convert.ToByte(HasInfiniteSpells).ToString();
            class2DA[indexToSave, "HasDomains"] = Convert.ToByte(HasDomains).ToString();
            class2DA[indexToSave, "HasSchool"] = Convert.ToByte(HasSchool).ToString();
            class2DA[indexToSave, "HasFamiliar"] = Convert.ToByte(HasFamiliar).ToString();
            class2DA[indexToSave, "HasAnimalCompanion"] = Convert.ToByte(HasAnimalCompanion).ToString();
            class2DA[indexToSave, "PrimaryAbil"] = MainAbility.ToString().ToUpper();
            class2DA[indexToSave, "ArcSpellLvlMod"] = "0";
            class2DA[indexToSave, "DivSpellLvlMod"] = "0";

            if (SpellCaster)
            {                
                class2DA[indexToSave, "SpellAbil"] = SpellAbility.ToString().ToUpper();
                class2DA[indexToSave, "ArcSpellLvlMod"] = ArcSpellLvlMod.ToString();
                class2DA[indexToSave, "DivSpellLvlMod"] = DivSpellLvlMod.ToString();

                if (!MemorizesSpells)
                {
                    class2DA[indexToSave, "SpellSwapMinLvl"] = SpellSwapMinLevel.ToString();
                    class2DA[indexToSave, "SpellSwapLvlInterval"] = SpellSwapLevelInterval.ToString();
                    class2DA[indexToSave, "SpellSwapLvlDiff"] = SpellSwapLevelDifficult.ToString();
                }
            }

            class2DA[indexToSave, "AlignRestrict"] = classAlignmentPanel.GetAlignmentRestrictString();
            class2DA[indexToSave, "AlignRstrctType"] = classAlignmentPanel.GetAlignmentRestrictTypeString();
            class2DA[indexToSave, "InvertRestrict"] = Convert.ToByte(classAlignmentPanel.InvertedRestrict).ToString();
            class2DA[indexToSave, "Constant"] = "CLASS_TYPE_" + ClassLabel.ToUpper();

            //EffCRLvl
            for (int i = 1; i <= effCRDialog.ArrayLength; i++)
            {
                if (i < 10) class2DA[indexToSave, "EffCRLvl0" + i.ToString()] = effCRDialog[i - 1].ToString();// ((int)(effCRMod * i)).ToString();
                else class2DA[indexToSave, "EffCRLvl" + i.ToString()] = effCRDialog[i - 1].ToString();// ((int)(effCRMod * i)).ToString();
            }

            if (BaseClass)
            {
                class2DA[indexToSave, "MaxLevel"] = "0";
                class2DA[indexToSave, "XPPenalty"] = "1";
                class2DA[indexToSave, "EpicLevel"] = "-1";
            }
            else
            {
                class2DA[indexToSave, "MaxLevel"] = maxLevelNumericUpDown.Value.ToString();
                class2DA[indexToSave, "XPPenalty"] = "0";
                class2DA[indexToSave, "EpicLevel"] = maxLevelNumericUpDown.Value.ToString();
            }

            if (SpellCaster && BaseClass)
            {
                
            }

            if (favoredWeaponCheckBox.Checked)
            {
                class2DA[indexToSave, "FavoredWeaponFocus"] = weaponFocusNumericUpDown.Value.ToString();
                class2DA[indexToSave, "FavoredWeaponProficiency"] = weaponProfLevelNumericUpDown.Value.ToString();
                class2DA[indexToSave, "FavoredWeaponSpecialization"] = weaponSpecialNumericUpDown.Value.ToString();
            }
            else
            {
                class2DA[indexToSave, "FavoredWeaponFocus"] = "-1";
                class2DA[indexToSave, "FavoredWeaponProficiency"] = "-1";
                class2DA[indexToSave, "FavoredWeaponSpecialization"] = "-1";
            }

            class2DA[indexToSave, "CharGen_Chest"] = charGenChest;
        }

        public TwoDATable[] Create2DATables(TwoDATable class2DA)
        {
            if (!TwoDAValidator.IsClasses2DA(class2DA)) throw new ArgumentException();            
            List<TwoDATable> result = new List<TwoDATable>();
            NWN2Package[] packages = ClassPackages;
            DefaultAbility defAbil = abilityPointManagePanel.Ability;
            TwoDATable featsTable;
            TwoDATable packagesList = (TwoDATable)this.packagesList.Clone();
            TwoDATable table;             
            int index = ImportIn2DA(class2DA);
            
            //Create feats table            
            table = classFeatsGrid.Create2DATable();
            
            if (table != null)
            {
                result.Add(table);
                table.TableName += ClassLabel.ToLower();
                class2DA[index, "FeatsTable"] = table.TableName.ToUpper();
            }

            //Create skills table            
            table = createSkillTable();
            class2DA[index, "SkillsTable"] = table.TableName.ToUpper();
            result.Add(table);

            //Create bonus feats table
            table = bonusFeatDialog.Create2DA();

            if (table != null)
            {
                table.TableName += ClassLabel.ToLower();
                class2DA[index, "BonusFeatsTable"] = table.TableName.ToUpper();
                result.Add(table);
            }

            //Create spell gain table
            table = spellGainDialog.Create2DATable();
            table.TableName = "cls_spgn_" + ClassLabel.ToLower();

            if (SpellCaster && BaseClass && table != null)
            {                
                class2DA[index, "SpellGainTable"] = table.TableName.ToUpper();
                result.Add(table);
                
                //Create spell known table
                table = spellKnownDialog.Create2DATable();
                table.TableName = "cls_spkn_" + ClassLabel.ToLower();

                if (!MemorizesSpells && table != null)
                {                
                    class2DA[index, "SpellKnownTable"] = table.TableName.ToUpper();
                    result.Add(table);
                }
            }            

            if (SpellCaster && PrestigeClass)
            {
                table = bonusSpellcasterLvlDialog.Create2DA();
                table.TableName = "cls_bsplvl_" + ClassLabel.ToLower();
                class2DA[index, "BonusSpellcasterLevelTable"] = table.TableName.ToUpper();
                result.Add(table);
            }

            //Create spontaneous conversation table
            if (HasSpontaneousSpells)
            {
                table = spontaneousConvDialog.Create2DATable();
                table.TableName = "cls_spon_" + ClassLabel.ToLower();
                class2DA[index, "SpontaneousConversionTable"] = table.TableName.ToUpper();
                result.Add(table);
            }

            //Initialize default ability
            class2DA[index, "Str"] = defAbil.Str.ToString();
            class2DA[index, "Dex"] = defAbil.Dex.ToString();
            class2DA[index, "Con"] = defAbil.Con.ToString();
            class2DA[index, "Wis"] = defAbil.Wis.ToString();
            class2DA[index, "Int"] = defAbil.Int.ToString();
            class2DA[index, "Cha"] = defAbil.Cha.ToString();

            //Generating packages
            if (packagesList != null && packages.Length > 0)
            {
                //Debugger.Launch();
                packages[0].ClassID = (short)index;
                class2DA[index, "Package"] = packages[0].ImportIn2DA(packagesList).ToString();//packages[0].PackageLabel;
                
                if (packages[0].SpellPref2DA != null) result.Add(packages[0].SpellPref2DA);
                if (packages[0].FeatPref2DA != null) result.Add(packages[0].FeatPref2DA);
                if (packages[0].SkillPref2DA != null) result.Add(packages[0].SkillPref2DA);

                if (packages.Length > 1)
                    for (int i = 1; i < packages.Length; i++)
                    {
                        packages[i].ClassID = (short)index;
                        packages[i].ImportIn2DA(packagesList);                        

                        if (packages[i].SpellPref2DA != null) result.Add(packages[i].SpellPref2DA);
                        if (packages[i].FeatPref2DA != null) result.Add(packages[i].FeatPref2DA);
                        if (packages[i].SkillPref2DA != null) result.Add(packages[i].SkillPref2DA);
                    }

                result.Add(packagesList);
            }
            //Feat extra slot
            if (HasFeatExtraSlot)
            {
                table = (TwoDATable)featsList.Clone();
            }

            //Reqs
            if (PrestigeClass)
            {
                table = preReqDialog.Create2DA();
                table.TableName += ClassLabel.ToLower();
                class2DA[index, "PreReqTable"] = table.TableName.ToUpper();
                result.Add(table);
            }

            result.Add(class2DA);

            return result.ToArray();
        }

        public void ImportToTlkFile(TwoDATable class2DA, TalkTableFile tlkFile)
        {
            ImportToTlkFile(class2DA, class2DA.RowCount - 1, tlkFile);            
        }

        private void ImportToTlkFile(TwoDATable class2DA, int classIndex, TalkTableFile tlkFile)
        {
            class2DA[classIndex, "Name"] = importStringToTlk(className.LocalizedName, tlkFile).ToString();
            class2DA[classIndex, "Plural"] = importStringToTlk(className.Plural, tlkFile).ToString();
            class2DA[classIndex, "Lower"] = importStringToTlk(className.Lower, tlkFile).ToString();
            class2DA[classIndex, "Description"] = importStringToTlk(ClassDescription, tlkFile).ToString();
        }

        #endregion

        #region Private functions zone

        private NWN2Class CreateClass()
        {
            NWN2Class nwn2Class = new NWN2Class();
            
            nwn2Class.AllSpellsKnown = this.AllSpellsKnown;
            nwn2Class.BaseAttackBonus = this.BaseAttackBonus;
            nwn2Class.BaseClass = this.BaseClass;
            nwn2Class.BonusFeats = bonusFeatDialog.ValueArray;
            nwn2Class.charGenChest = this.CharGenChest;
            nwn2Class.ClassDescription = this.ClassDescription;            
            if (featsList != null) nwn2Class.ClassFeatsList = this.ClassFeats;
            nwn2Class.ClassIcon = classIconButton.ImageResRef;
            nwn2Class.ClassName = this.ClassName;
            nwn2Class.ClassPackages = this.ClassPackages;
            nwn2Class.ClassSkillsList = this.ClassSkills;
            nwn2Class.ClassSpellsList = this.ClassSpells;
            nwn2Class.DefaultAbility = this.DefaultAbilitys;
            nwn2Class.DescriptionStrRef = this.DescriptionStrRef;
            nwn2Class.FavoredWeaponProficiency = this.FavoredWeaponProficiency;
            nwn2Class.FavoredWeaponFocus = this.FavoredWeaponFocus;
            nwn2Class.FavoredWeaponSpecialization = this.FavoredWeaponSpecialization;
            nwn2Class.HasAnimalCompanion = this.HasAnimalCompanion;
            nwn2Class.HasArcane = this.HasArcane;
            nwn2Class.HasDivine = this.HasDivine;
            nwn2Class.HasDomains = this.HasDomains;
            nwn2Class.HasFamiliar = this.HasFamiliar;
            nwn2Class.HasInfiniteSpells = this.HasInfiniteSpells;
            nwn2Class.HasSchool = this.HasSchool;            
            nwn2Class.HasSpontaneousSpells = this.HasSpontaneousSpells;
            nwn2Class.HitDie = (uint)this.HitDie;
            nwn2Class.MainAbility = this.MainAbility;
            nwn2Class.MemorizesSpells = this.MemorizesSpells;
            nwn2Class.MetaMagicAllowed = this.MetaMagicAllowed;
            nwn2Class.SaveThrowSpecialization = this.SaveThrowSpecialization;
            nwn2Class.SkillPointBase = (uint)this.SkillPoints;
            nwn2Class.SpellAbility = this.SpellAbility;
            nwn2Class.SpellCaster = this.SpellCaster;
            nwn2Class.SpellGainTable = spellGainDialog.SpellTable.Table;
            nwn2Class.SpellKnownTable = spellKnownDialog.SpellTable.Table;
            nwn2Class.SpellSwapLvlDiff = this.SpellSwapLevelDifficult;
            nwn2Class.SpellSwapLvlInterval = this.SpellSwapLevelInterval;
            nwn2Class.SpellSwapMinLvl = this.SpellSwapMinLevel;

            return nwn2Class;
        }

        private void InitializeFromClass(object nwn2Class)
        {
            DefaultAbility defAbil = new DefaultAbility();
            NWN2PropertyList propList;
            NWN2PropertyListItem listItem;
            NWN2Package[] packs;
            Type classType = nwn2Class.GetType();
            Type tempType, tempType2;
            IList list;
            object tempObj;
            
            this.AllSpellsKnown = (bool)classType.GetField("AllSpellsKnown").GetValue(nwn2Class);
            this.BaseAttackBonus = (BaseAB)classType.GetField("BaseAttackBonus").GetValue(nwn2Class);
            this.BaseClass = (bool)classType.GetField("BaseClass").GetValue(nwn2Class);
            this.bonusFeatDialog.ValueArray = (int[])classType.GetField("BonusFeats").GetValue(nwn2Class);
            this.CharGenChest = (string)classType.GetField("charGenChest").GetValue(nwn2Class);
            this.ClassDescription = (string)classType.GetField("ClassDescription").GetValue(nwn2Class);
            this.ClassIconResRef = (string)classType.GetField("ClassIcon").GetValue(nwn2Class);            
            this.DescriptionStrRef = (int)classType.GetField("DescriptionStrRef").GetValue(nwn2Class);            
            this.FavoredWeaponProficiency = (short)classType.GetField("FavoredWeaponProficiency").GetValue(nwn2Class);
            this.FavoredWeaponFocus = (short)classType.GetField("FavoredWeaponFocus").GetValue(nwn2Class);
            this.FavoredWeaponSpecialization = (short)classType.GetField("FavoredWeaponSpecialization").GetValue(nwn2Class);
            this.HasAnimalCompanion = (bool)classType.GetField("HasAnimalCompanion").GetValue(nwn2Class);
            this.HasArcane = (bool)classType.GetField("HasArcane").GetValue(nwn2Class);
            this.HasDivine = (bool)classType.GetField("HasDivine").GetValue(nwn2Class);
            this.HasDomains = (bool)classType.GetField("HasDomains").GetValue(nwn2Class);
            this.HasFamiliar = (bool)classType.GetField("HasFamiliar").GetValue(nwn2Class);
            this.HasInfiniteSpells = (bool)classType.GetField("HasInfiniteSpells").GetValue(nwn2Class);
            this.HasSchool = (bool)classType.GetField("HasSchool").GetValue(nwn2Class);
            this.HasSpontaneousSpells = (bool)classType.GetField("HasSpontaneousSpells").GetValue(nwn2Class);
            this.HitDie = (int)(uint)classType.GetField("HitDie").GetValue(nwn2Class);
            this.MainAbility = (Ability)classType.GetField("MainAbility").GetValue(nwn2Class);
            this.MemorizesSpells = (bool)classType.GetField("MemorizesSpells").GetValue(nwn2Class);
            this.MetaMagicAllowed = (bool)classType.GetField("MetaMagicAllowed").GetValue(nwn2Class);
            this.SaveThrowSpecialization = (SaveThrow)classType.GetField("SaveThrowSpecialization").GetValue(nwn2Class);
            this.SkillPoints = (int)(uint)classType.GetField("SkillPointBase").GetValue(nwn2Class);
            this.SpellAbility = (Ability)classType.GetField("SpellAbility").GetValue(nwn2Class);
            this.SpellCaster = (bool)classType.GetField("SpellCaster").GetValue(nwn2Class);
            this.spellGainDialog.SpellTable.Table = (int[,])classType.GetField("SpellGainTable").GetValue(nwn2Class);
            this.spellKnownDialog.SpellTable.Table = (int[,])classType.GetField("SpellKnownTable").GetValue(nwn2Class);
            this.SpellSwapLevelDifficult = (int)classType.GetField("SpellSwapLvlDiff").GetValue(nwn2Class);
            this.SpellSwapLevelInterval = (int)classType.GetField("SpellSwapLvlInterval").GetValue(nwn2Class);
            this.SpellSwapMinLevel = (int)classType.GetField("SpellSwapMinLvl").GetValue(nwn2Class);

            //Class name
            tempObj = classType.GetField("ClassName").GetValue(nwn2Class);
            tempType = tempObj.GetType();
            this.className.Label = (string)tempType.GetField("Label").GetValue(tempObj);
            this.className.LocalizedName = (string)tempType.GetField("LocalizedName").GetValue(tempObj);
            this.className.Lower = (string)tempType.GetField("Lower").GetValue(tempObj);
            this.className.Plural = (string)tempType.GetField("Plural").GetValue(tempObj);
            this.className.NameStrRef = (int)tempType.GetField("NameStrRef").GetValue(tempObj);
            this.className.PluralStrRef = (int)tempType.GetField("PluralStrRef").GetValue(tempObj);
            this.className.LowerStrRef = (int)tempType.GetField("LowerStrRef").GetValue(tempObj);
            this.ClassName = this.className;

            //Skills
            list = (IList)classType.GetField("ClassSkillsList").GetValue(nwn2Class);            
            propList = new NWN2PropertyList();

            for (int i = 0; i < list.Count; i++)
            {
                tempObj = list[i];
                tempType = tempObj.GetType();
                listItem = new NWN2PropertyListItem(0);
                listItem.PropertyDescriptionResRef = (int)tempType.GetProperty("PropertyDescriptionResRef").GetValue(tempObj, null);
                listItem.PropertyID = (int)tempType.GetProperty("PropertyID").GetValue(tempObj, null);
                listItem.PropertyNameResRef = (int)tempType.GetProperty("PropertyNameResRef").GetValue(tempObj, null);
                propList.Add(listItem);
            }

            this.ClassSkills = propList;

            //Spells
            list = (IList)classType.GetField("ClassSpellsList").GetValue(nwn2Class);
            propList = new NWN2PropertyList();

            for (int i = 0; i < list.Count; i++)
            {
                tempObj = list[i];
                tempType = tempObj.GetType();
                listItem = new NWN2PropertyListItem(0);
                listItem.PropertyDescriptionResRef = (int)tempType.GetProperty("PropertyDescriptionResRef").GetValue(tempObj, null);
                listItem.PropertyID = (int)tempType.GetProperty("PropertyID").GetValue(tempObj, null);
                listItem.PropertyNameResRef = (int)tempType.GetProperty("PropertyNameResRef").GetValue(tempObj, null);
                propList.Add(listItem);
            }

            this.ClassSpells = propList;

            //Feats
            list = (IList)classType.GetField("ClassFeatsList").GetValue(nwn2Class);
            propList = new NWN2ClassFeatsList();

            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    tempObj = list[i];
                    tempType = tempObj.GetType();
                    listItem = new NWN2ClassFeatsListItem(new NWN2PropertyListItem(0), 0);
                    listItem.PropertyDescriptionResRef = (int)tempType.GetProperty("PropertyDescriptionResRef").GetValue(tempObj, null);
                    listItem.PropertyID = (int)tempType.GetProperty("PropertyID").GetValue(tempObj, null);
                    listItem.PropertyNameResRef = (int)tempType.GetProperty("PropertyNameResRef").GetValue(tempObj, null);
                    ((NWN2ClassFeatsListItem)listItem).GainLevel = (uint)tempType.GetProperty("GainLevel").GetValue(tempObj, null);
                    ((NWN2ClassFeatsListItem)listItem).OnMenu = (bool)tempType.GetProperty("OnMenu").GetValue(tempObj, null);
                    ((NWN2ClassFeatsList)propList).Add(listItem);
                }

            }
            
            this.ClassFeats = (NWN2ClassFeatsList)propList;
            
            //Packages
            list = (IList)classType.GetField("ClassPackages").GetValue(nwn2Class);
            packs = new NWN2Package[list.Count];
            
            for (int i = 0; i < list.Count; i++)
            {                
                tempObj = list[i];
                tempType = tempObj.GetType();
                packs[i] = new NWN2Package("");
                packs[i].Associate = (short)tempType.GetField("Associate").GetValue(tempObj);
                packs[i].Attribute = (Ability)tempType.GetField("Attribute").GetValue(tempObj);
                packs[i].ClassID = (short)tempType.GetField("ClassID").GetValue(tempObj);
                packs[i].Domain1 = (short)tempType.GetField("Domain1").GetValue(tempObj);
                packs[i].Domain2 = (short)tempType.GetField("Domain2").GetValue(tempObj);
                packs[i].Gold = (short)tempType.GetField("Gold").GetValue(tempObj);
                packs[i].PackageDescription = (string)tempType.GetField("PackageDescription").GetValue(tempObj);
                packs[i].PackageLabel = (string)tempType.GetField("PackageLabel").GetValue(tempObj);
                packs[i].School = (short)tempType.GetField("School").GetValue(tempObj);
                
                if (tempType.GetField("SpellPref2DA").GetValue(tempObj) != null)
                {
                    tempType2 = tempType.GetField("SpellPref2DA").GetValue(tempObj).GetType();
                    packs[i].SpellPref2DA = new TwoDATable((string[,])tempType2.GetMethod("ToArray").Invoke(tempType.GetField("SpellPref2DA").GetValue(tempObj), null));
                    packs[i].SpellPref2DA.TableName = (string)tempType2.GetProperty("TableName").GetValue(tempType.GetField("SpellPref2DA").GetValue(tempObj), null);
                }
                
                if (tempType.GetField("FeatPref2DA").GetValue(tempObj) != null)
                {
                    tempType2 = tempType.GetField("FeatPref2DA").GetValue(tempObj).GetType();
                    packs[i].FeatPref2DA = new TwoDATable((string[,])tempType2.GetMethod("ToArray").Invoke(tempType.GetField("FeatPref2DA").GetValue(tempObj), null));
                    packs[i].FeatPref2DA.TableName = (string)tempType2.GetProperty("TableName").GetValue(tempType.GetField("FeatPref2DA").GetValue(tempObj), null);
                }

                if (tempType.GetField("SkillPref2DA").GetValue(tempObj) != null)
                {
                    tempType2 = tempType.GetField("SkillPref2DA").GetValue(tempObj).GetType();
                    packs[i].SkillPref2DA = new TwoDATable((string[,])tempType2.GetMethod("ToArray").Invoke(tempType.GetField("SkillPref2DA").GetValue(tempObj), null));
                    packs[i].SkillPref2DA.TableName = (string)tempType2.GetProperty("TableName").GetValue(tempType.GetField("SkillPref2DA").GetValue(tempObj), null);
                }
            }

            this.ClassPackages = packs;
            
            tempObj = classType.GetField("DefaultAbility").GetValue(nwn2Class);
            tempType = tempObj.GetType();
            defAbil.Str = (byte)tempType.GetField("Str").GetValue(tempObj);
            defAbil.Dex = (byte)tempType.GetField("Dex").GetValue(tempObj);
            defAbil.Con = (byte)tempType.GetField("Con").GetValue(tempObj);
            defAbil.Int = (byte)tempType.GetField("Int").GetValue(tempObj);
            defAbil.Wis = (byte)tempType.GetField("Wis").GetValue(tempObj);
            defAbil.Cha = (byte)tempType.GetField("Cha").GetValue(tempObj);
            defAbil.AbilityPointsCount = (byte)tempType.GetField("AbilityPointsCount").GetValue(tempObj);

            this.DefaultAbilitys = defAbil;

            if (FavoredWeaponFocus > 0 || FavoredWeaponProficiency > 0 || FavoredWeaponSpecialization > 0) favoredWeaponCheckBox.Checked = true;
            else favoredWeaponCheckBox.Checked = true;

            if (NewClassInitialized != null) NewClassInitialized(this, EventArgs.Empty);
        }

        private int importStringToTlk(string str, TalkTableFile talkTable)
        {
            TalkTableElement importedString;

            if (talkTable == null) return 0;
            //Debugger.Launch();
            importedString = new TalkTableElement();
            importedString.String = str;
            importedString.OffsetToString = (uint)talkTable.Elements.Count;

            return talkTable.Elements.Add(importedString);
        }

        private TwoDATable createSkillTable()
        {
            TwoDATable classSkillsTable;
            int index;

            if (skillsList == null) return null;

            classSkillsTable = new TwoDATable("SkillLabel", "SkillIndex", "ClassSkill");
            classSkillsTable.TableName = "cls_skill_" + ClassLabel.ToLower();

            foreach (NWN2PropertyListItem skillItem in ClassSkills)
            {
                classSkillsTable.Add();
                index = classSkillsTable.RowCount - 1;
                classSkillsTable[index, "SkillLabel"] = skillsList[skillItem.PropertyID, "Label"];
                classSkillsTable[index, "SkillIndex"] = skillItem.PropertyID.ToString();
                classSkillsTable[index, "ClassSkill"] = "1";
            }

            return classSkillsTable;
        }
        
        private void effCRLvlButton_Click(object sender, EventArgs e)
        {
            effCRDialog.ShowDialog(this);
        }

        private void bonusSpellcasterButton_Click(object sender, EventArgs e)
        {
            bonusSpellcasterLvlDialog.ShowDialog();
        }

        private void bonusFeatsButton_Click(object sender, EventArgs e)
        {
            bonusFeatDialog.ShowDialog();
        }

        private void skillFeatDescriptionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }                        

        private void hasSpontaneousSpellsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            spontaneousSettingsButton.Enabled = hasSpontaneousSpellsCheckBox.Checked;
        }

        private void spellcasterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            classSpellsCheckedListBox.Enabled = spellcasterCheckBox.Checked;
            generalSpellPanel.Enabled = spellcasterCheckBox.Checked;
            spellGainButton.Enabled = spellcasterCheckBox.Checked;
            spellsSettingPanel.Enabled = spellcasterCheckBox.Checked;            
        }

        private void memorizesSpellsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            spellKnownPanel.Enabled = !memorizesSpellsCheckBox.Checked;
        }        

        private void prestigeClassTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            maxLevelNumericUpDown.Enabled = prestigeClassTypeRadioButton.Checked;
            bonusSpellcasterButton.Enabled = prestigeClassTypeRadioButton.Checked;
            preReqButton.Enabled = prestigeClassTypeRadioButton.Checked;
        }
        
        private void spontaneousSettingsButton_Click(object sender, EventArgs e)
        {
            spontaneousConvDialog.Location = PointToScreen(this.Location);
            spontaneousConvDialog.ShowDialog();
        }

        private void spellGainButton_Click(object sender, EventArgs e)
        {
            spellGainDialog.Location = PointToScreen(this.Location);
            spellGainDialog.ShowDialog();
        }

        private void spellKnownButton_Click(object sender, EventArgs e)
        {
            spellKnownDialog.Location = PointToScreen(this.Location);
            spellKnownDialog.ShowDialog();
        }       

        private void hasFamiliarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasFamiliarCheckBox.Checked && hasAnimalCompanionCheckBox.Checked) hasAnimalCompanionCheckBox.Checked = false;
            if (!hasFamiliarCheckBox.Checked) return;
            
            classPackageListBox.AssociateList = familiarList;
        }

        private void hasAnimalCompanionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasFamiliarCheckBox.Checked && hasAnimalCompanionCheckBox.Checked) hasFamiliarCheckBox.Checked = false;
            if (!hasAnimalCompanionCheckBox.Checked) return;

            classPackageListBox.AssociateList = animalCompanionList;
        }

        private void domainsAllowedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HasDomains) classPackageListBox.DomainsList = domainsList;
            else classPackageListBox.DomainsList = null;
        }

        private void schoolAllowedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HasSchool) classPackageListBox.SchoolsList = spellSchoolsList;
            else classPackageListBox.SchoolsList = null;
        }

        private void mainAbilityComboBox_Click(object sender, EventArgs e)
        {
            classPackageListBox.DefaultAbility = (Ability)mainAbilityComboBox.SelectedItem;
        }

        private void preReqButton_Click(object sender, EventArgs e)
        {
            preReqDialog.ShowDialog(this);
        }

        private void favoredWeaponCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            favoredWeaponPanel.Enabled = favoredWeaponCheckBox.Checked;
        }                      

        private void advancedSpellcasterSettingsButton_Click(object sender, EventArgs e)
        {
            advancedSpellDialog.ShowDialog();
        }        
        //private void mainAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    classPackageListBox.DefaultAbility = mainAbilityComboBox.SelectedItem;
        //}

        #endregion
        
        public event EventHandler TalkTableUpdated;
        public event EventHandler NewClassInitialized;

        
    }
}