namespace Dnd35.Class
{
    public class CharacterClass
    {
        public bool IsBaseClass { get; set; }

        public int DescriptionId { get; set; }

        public uint HitDie { get; set; }

        public uint SkillPointBase { get; set; }

        public BaseAttackBonus BaseAttackBonus { get; set; }
                
        public Ability MainAbility { get; set; }

        public SaveThrow SaveThrowSpecialization { get; set; }

        public int[] BonusFeats;
        public short FavoredWeaponProficiency;
        public short FavoredWeaponFocus;
        public short FavoredWeaponSpecialization;

        //Spellcaster properties
        public bool AllSpellsKnown;
        public int[] BonusSpellCaster;
        public bool MetaMagicAllowed;
        public bool MemorizesSpells;
        public bool HasDivine;
        public bool HasArcane;
        public bool HasSpontaneousSpells;
        public bool HasInfiniteSpells;
        public bool HasDomains;
        public bool HasSchool;
        public bool HasFamiliar;
        public bool HasAnimalCompanion;
        public bool SpellCaster;
        public int[,] SpellGainTable;
        public int[,] SpellKnownTable;
        public int SpellSwapMinLvl;
        public int SpellSwapLvlInterval;
        public int SpellSwapLvlDiff;
        public Ability SpellAbility;

        //2da files        
        //public DefaultAbility DefaultAbility;
        public IPropertyList<ClassProperty> ClassFeatsList { get; }

        public IPropertyList<ClassProperty> ClassSpellsList { get; }

        public IPropertyList<ClassProperty> ClassSkillsList { get; }
        
        //public NWN2Package[] ClassPackages;
    }
}