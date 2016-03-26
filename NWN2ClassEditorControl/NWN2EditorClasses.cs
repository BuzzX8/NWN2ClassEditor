using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using OEIShared.IO.TalkTable;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BuzzX8.NWN2ClassEditor
{
    [Flags]
    public enum SaveThrow { Fortidute = 0x01, Reflex = 0x02, Will = 0x08 }
    public enum Ability { Str, Dex, Con, Int, Wis, Cha }
    public enum BaseAB { Hight, Medium , Low }
    public enum Alignment { LawfulGood, NeutralGood, ChaoticGood, LawfulNeutral, TrueNeutral, ChaoticNeutral, LawfulEvil, NeutralEvil, ChaoticEvil }
    
    [Serializable]
    public struct NWN2Class
    {
        //General properties
        public bool BaseClass;
        public NWN2ClassName ClassName;
        public string ClassIcon;
        public string ClassDescription;
        public int DescriptionStrRef;
        public uint HitDie;
        public uint SkillPointBase;
        public BaseAB BaseAttackBonus;
        public int[] BonusFeats;        
        public Ability MainAbility;
        public SaveThrow SaveThrowSpecialization;
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
        public DefaultAbility DefaultAbility;
        public NWN2ClassFeatsList ClassFeatsList;
        public NWN2PropertyList ClassSpellsList;
        public NWN2PropertyList ClassSkillsList;
        public NWN2Package[] ClassPackages;

        public string charGenChest;        
    }

    [Serializable]
    public class NWN2PropertyListItem
    {
        private int propertyName;          //StrRef in dialog.tlk        
        private int propertyID;            //Position in table
        private int propertyDescription;   //StrRef in dialog.tlk

        
        internal static TalkTableFile TalkTable;

        public NWN2PropertyListItem(int name)
            : this(name, 0)
        { }

        public NWN2PropertyListItem(int name, int id)
            : this(name, id, 0)
        { }

        public NWN2PropertyListItem(int name, int id, int description)
        {
            propertyName = name;
            propertyID = id;
            propertyDescription = description;
        }

        public NWN2PropertyListItem(NWN2PropertyListItem item) : this(item.propertyName, item.propertyID, item.propertyDescription)
        { }

        public static bool operator == (NWN2PropertyListItem item1, NWN2PropertyListItem item2)
        {
            return item1.Equals(item2);
        }

        public static bool operator !=(NWN2PropertyListItem item1, NWN2PropertyListItem item2)
        {
            return !item1.Equals(item2);
        }

        public int PropertyDescriptionResRef
        {
            get 
            {
                return propertyDescription; 
            }
            set
            {
                propertyDescription = value; 
            }
        }

        public int PropertyNameResRef
        {
            get 
            {
                return propertyName; 
            }
            set
            {
                propertyName = value; 
            }
        }

        public string Name
        {
            get
            {
                if (TalkTable == null) return "StrRef " + propertyName;
                else return TalkTable[propertyName];
            }
        }

        public string Description
        {
            get
            {
                if (TalkTable == null) return "StrRef " + propertyDescription;
                else return TalkTable[propertyDescription];
            }
        }

        public int PropertyID
        {
            get 
            {
                return propertyID; 
            }
            set
            {
                propertyID = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NWN2PropertyListItem)) return false;
            if (((NWN2PropertyListItem)obj).propertyName == this.propertyName) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return this.propertyName;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class TwoDATable : ICloneable
    {
        private char splitter;
        private string tableName;
        private List<string> tableHeaders;
        private List<string[]> tableData;

        public TwoDATable(params string[] columns)
        {
            if (columns.Length == 0) throw new ArgumentException("Table must have at last one column");

            tableHeaders = new List<string>(columns);            
            tableData = new List<string[]>();
            splitter = '\t';
        }

        public TwoDATable(string[,] array)
        {
            tableHeaders = new List<string>();
            tableData = new List<string[]>();
            
            //Headers
            for (int i = 0; i < array.GetLength(1); i++) tableHeaders.Add(array[0, i]);
            //Cells            
            for (int i = 1; i < array.GetLength(0); i++)
            {
                tableData.Add(new string[array.GetLength(1)]);

                for (int j = 0; j < array.GetLength(1); j++)
                    tableData[i - 1][j] = array[i, j];
            }
        }

        public TwoDATable(string fileName)
        {
            //string[] data = File.ReadAllLines(fileName);
            makeTable(File.ReadAllLines(fileName));
            tableName = Path.GetFileNameWithoutExtension(fileName);
        }

        private void makeTable(string[] data)
        {
            List<string> dataRow;
            List<string> dataRows = new List<string>(data);

            if (!data[0].Contains("2DA")) throw new IOException("This file is not 2da");

            splitter = data[0][3];

            for (int i = 0; i < dataRows.Count; i++)
            {
                if (dataRows[i].TrimEnd('\t') == "") dataRows.RemoveAt(i);
            }

            tableHeaders = new List<string>(dataRows[1].Split('\t'));
            tableData = new List<string[]>();
            tableHeaders.RemoveAt(0);

            //Fill table cells
            for (int i = 3; i < data.Length; i++)
            {
                dataRow = new List<string>(data[i].Split('\t'));
                dataRow.RemoveAt(0);

                if (dataRow.Count > tableHeaders.Count) dataRow.RemoveRange(tableHeaders.Count, dataRow.Count - tableHeaders.Count);

                tableData.Add(dataRow.ToArray());
            }
        }

        public TwoDATable(Stream stream)
        {
            StreamReader reader = new StreamReader(stream);            
            List<string> twoDA;            

            twoDA = new List<string>(reader.ReadToEnd().Split(Environment.NewLine.ToCharArray()));

            for (int i = 0; i < twoDA.Count; i++)
            {
                if (twoDA[i] == "") twoDA.RemoveAt(i);
            }

            for (int i = 0; i < twoDA.Count; i++)
            {
                if (twoDA[i] == "") twoDA.RemoveAt(i);
            }

            makeTable(twoDA.ToArray());
        }

        public string TableName
        {
            get
            {
                return tableName; 
            }
            set
            {
                tableName = value; 
            }
        }

        public string this[int rowIndex, int columnIndex]
        {
            get
            {
                if (tableData[rowIndex][columnIndex] == null) return "";
                if (tableData[rowIndex][columnIndex].Contains("**")) return "";
                else return tableData[rowIndex][columnIndex];
            }
            set
            {
                tableData[rowIndex][columnIndex] = value;
            }
        }

        public string this[int rowIndex, string columnName]
        {
            get
            {
                if (!ContainColumn(columnName)) throw new ArgumentException("Table not contain column \"" + columnName + "\"");
                else return this[rowIndex, GetColumnIndex(columnName)];
            }
            set
            {
                if (!ContainColumn(columnName)) throw new ArgumentException("Table not contain column \"" + columnName + "\"");

                this[rowIndex, GetColumnIndex(columnName)] = value;
            }
        }

        public int ColumnCount
        {
            get
            {
                return tableHeaders.Count;
            }
        }

        public int RowCount
        {
            get
            {
                return tableData.Count;
            }
        }

        public int GetColumnIndex(string columnName)
        {
            int result = 0;

            if (!ContainColumn(columnName) || columnName == "") throw new IOException("Given column does not contains in table");

            for (int i = 1; i < tableHeaders.Count; i++)
            {
                if (tableHeaders[i] == columnName) result = i;
            }

            return result;
        }

        public bool ContainColumn(string columnName)
        {
            bool result = false;

            foreach (string header in tableHeaders)
            {
                if (header == columnName) result = true;
            }

            return result;
        }

        public void Add()
        {
            string[] newRow = new string[ColumnCount];

            for (int i = 0; i < newRow.Length; i++)
            {
                newRow[i] = "";
            }
            
            tableData.Add(newRow);
        }

        public void Insert(int index)
        {
            string[] newRow = new string[tableHeaders.Count];

            for (int i = 0; i < newRow.Length; i++)
            {
                newRow[i] = "";
            }

            tableData.Insert(index, newRow);
        }

        public void Remove(int index)
        {
            tableData.RemoveAt(index);
        }

        public NWN2PropertyList ConvertToList(string nameColumn, string descriptionColumn)
        {
            NWN2PropertyList list = new NWN2PropertyList();

            for (int i = 0; i < this.RowCount; i++)
            {
                if (this[i, nameColumn] == "" || this[i, descriptionColumn] == "") continue;
                list.Add(new NWN2PropertyListItem(int.Parse(this[i, nameColumn]), i, int.Parse(this[i, descriptionColumn])));
            }

            return list;
        }

        public NWN2PropertyList ConvertToList(string nameColumn, string descriptionColumn, string restrictColumn, string restrictValue)
        {
            NWN2PropertyList list = new NWN2PropertyList();

            for (int i = 0; i < this.RowCount; i++)
            {
                if (this[i, nameColumn] == "" || this[i, descriptionColumn] == "" || this[i, restrictColumn] == restrictValue) continue;
                list.Add(new NWN2PropertyListItem(int.Parse(this[i, nameColumn]), i, int.Parse(this[i, descriptionColumn])));
            }

            return list;
        }

        public void SaveToStream(Stream stream)
        {            
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine("2DA\tV2.0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            writer.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");

            //Column headers
            writer.Write('\t');

            for (int i = 0; i < tableHeaders.Count; i++)
            {
                writer.Write(tableHeaders[i]);
                if (i < (tableHeaders.Count)) writer.Write('\t');
            }

            writer.WriteLine();

            //Rows
            for (int i = 0; i < this.RowCount; i++)
            {
                writer.Write(i);
                writer.Write('\t');
                //Cells
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    if (this[i, j] == "" || this[i, j] == null) writer.Write("****");
                        else writer.Write(this[i, j]);

                    if (j < ColumnCount) writer.Write('\t');
                }

                if (i < RowCount - 1) writer.WriteLine();
                writer.Flush();
            }
        }

        public string[,] ToArray()
        {
            string[,] result = new string[RowCount + 1, ColumnCount];

            //Headers
            for (int i = 0; i < tableHeaders.Count; i++) result[0, i] = tableHeaders[i];
            //Cells
            for (int i = 1; i < RowCount; i++)
                for (int j = 0; j < ColumnCount; j++) result[i, j] = this[i, j];

            return result;
        }

        public void SaveToFile(string filePath)
        {
            FileStream stream = new FileStream(filePath + "\\" + tableName + ".2da", FileMode.Create, FileAccess.Write);

            this.SaveToStream(stream);
            stream.Flush();
            stream.Close();
        }

        public static explicit operator string[,](TwoDATable table)
        {            
            return table.ToArray();
        }

        #region ICloneable Members

        public object Clone()
        {
            TwoDATable result = (TwoDATable)this.MemberwiseClone();

            result.tableHeaders = new List<string>();
            result.tableData = new List<string[]>();

            for (int i = 0; i < this.ColumnCount; i++)
            {
                result.tableHeaders.Add((string)this.tableHeaders[i].Clone());
            }
            
            for (int i = 0; i < this.RowCount; i++)
            {
                result.tableData.Add(new string[this.ColumnCount]);

                for (int j = 0; j < this.ColumnCount; j++)
                {
                    result[i, j] = (string)this[i, j].Clone();
                }
            }

            return result;
        }

        #endregion
    }

    [Serializable]
    public class NWN2PropertyList : List<NWN2PropertyListItem>
    {
        public NWN2PropertyList() : base()
        { }

        public NWN2PropertyList(NWN2PropertyListItem[] list) : base(list.Length)
        {
            foreach (NWN2PropertyListItem listItem in list)
            {
                Add(listItem);
            }
        }

        public NWN2PropertyList(IEnumerable<NWN2PropertyListItem> list) : base(list)
        { }

        public NWN2PropertyList(IList list) : base(list.Count)
        {
            foreach (object listItem in list)
            {
                if (!(listItem is NWN2PropertyListItem)) throw new ArgumentException();
                Add((NWN2PropertyListItem)listItem);
            }
        }

        public NWN2PropertyListItem this[string itemName]
        {
            get
            {
                NWN2PropertyListItem result = null;

                foreach (NWN2PropertyListItem item in this)
                {
                    if (item.Name == itemName) result = item;
                }

                return result;
            }
        }

        #region IComparer<NWN2PropertyListItem> Members

        public static int Compare(NWN2PropertyListItem x, NWN2PropertyListItem y)
        {
            return string.Compare(x.Name, y.Name);            
        }

        #endregion
    }

    [Serializable]
    public class NWN2ClassFeatsListItem : NWN2PropertyListItem
    {
        private bool onMenu;
        private uint gainLevel;

        public bool OnMenu
        {
            get 
            {
                return onMenu; 
            }
            set 
            {
                onMenu = value; 
            }
        }

        public uint GainLevel
        {
            get 
            {
                return gainLevel; 
            }
            set
            {
                gainLevel = value; 
            }
        }

        public NWN2ClassFeatsListItem(NWN2PropertyListItem feat, int gainLevel) : base(feat)
        {
            this.gainLevel = (uint)gainLevel;
        }

        public NWN2ClassFeatsListItem(NWN2PropertyListItem feat, int gainLevel, bool onMenu) : this(feat, gainLevel)
        {
            this.onMenu = onMenu;
        }

    }

    [Serializable]
    public class NWN2ClassFeatsList : NWN2PropertyList
    {
        public new NWN2ClassFeatsListItem this[int index]
        {
            get
            {
                return (NWN2ClassFeatsListItem)base[index];
            }
            set
            {
                base[index] = value;
            }
        }

        public void Add(NWN2ClassFeatsListItem item)
        {
            base.Add(item);
        }

        public void Insert(NWN2ClassFeatsListItem item, int index)
        {
            base.Insert(index, item);
        }

        public void Remove(NWN2ClassFeatsListItem item)
        {
            base.Remove(item);
        }        
    }

    [Serializable]
    public class NWN2SkillReqListItem : NWN2PropertyListItem
    {
        private uint reqLevel;

        public int ReqLevel
        {
            get 
            {
                return (int)reqLevel; 
            }
            set
            {
                if (value < 0) throw new ArgumentException("value must be greater or equal to zero");
                reqLevel = (uint)value; 
            }
        }

        public NWN2SkillReqListItem(NWN2PropertyListItem item, int reqLevel) : base(item)
        {
            if (reqLevel < 0) throw new ArgumentException("reqLevel must be greater or equal to zero");

            this.reqLevel = (uint)reqLevel;
        }
    }

    [Serializable]
    public class NWN2SkillReqList : NWN2PropertyList
    {
        public void Add(NWN2SkillReqListItem item)
        {
            base.Add(item);
        }

        public void Insert(NWN2SkillReqListItem item, int index)
        {
            base.Insert(index, item);
        }

        public void Remove(NWN2SkillReqListItem item)
        {
            base.Remove(item);
        }
    }

    [Serializable]
    public class NWN2Package : NWN2PropertyListItem
    {
        public TwoDATable SpellPref2DA = null;
        public TwoDATable FeatPref2DA = null;
        public TwoDATable SkillPref2DA = null;
        public Ability Attribute;

        public string PackageLabel = "";
        public string PackageName = "";
        public int PackageNameStrRef = -1;
        public string PackageDescription = "";
        public int PackageDescriptionStrRef = -1;
        public short ClassID = -1;
        public short Gold = 0;
        public short School = -1;
        public short Domain1 = -1;
        public short Domain2 = -1;
        public short Associate = -1;        

        public NWN2Package(string label) : base(0)
        {
            this.PackageLabel = label;
        }

        public int ImportIn2DA(TwoDATable packages2DA)
        {
            int index;

            if (ClassID < 0) throw new ArgumentOutOfRangeException("ClassID must be greater than zero");

            packages2DA.Add();
            index = packages2DA.RowCount - 1;
            packages2DA[index, "Label"] = PackageLabel;

            if (PackageNameStrRef >= 0) packages2DA[index, "Name"] = PackageNameStrRef.ToString();
            if (PackageDescriptionStrRef >= 0) packages2DA[index, "Description"] = PackageDescriptionStrRef.ToString();

            packages2DA[index, "ClassID"] = ClassID.ToString();
            packages2DA[index, "Attribute"] = Attribute.ToString().ToUpper();
            packages2DA[index, "Gold"] = Gold.ToString();

            if (School >= 0) packages2DA[index, "School"] = School.ToString();
            if (Domain1 >= 0) packages2DA[index, "Domain1"] = Domain1.ToString();
            if (Domain2 >= 0) packages2DA[index, "Domain2"] = Domain2.ToString();
            if (Associate >= 0) packages2DA[index, "Associate"] = Associate.ToString();

            if (SpellPref2DA != null) packages2DA[index, "SpellPref2DA"] = SpellPref2DA.TableName;
            if (FeatPref2DA != null) packages2DA[index, "FeatPref2DA"] = FeatPref2DA.TableName;
            if (SkillPref2DA != null) packages2DA[index, "SkillPref2DA"] = SkillPref2DA.TableName;

            packages2DA[index, "Soundset"] = "0";
            packages2DA[index, "PlayerClass"] = "1";

            return index;
        }

        public override string ToString()
        {
            return PackageLabel;
        }
    }

    [Serializable]
    public class NWN2FeatReq : NWN2PropertyListItem
    {
        private bool orFeat;

        public bool OrFeat
        {
            get { return orFeat; }
            set { orFeat = value; }
        }

        public NWN2FeatReq(NWN2PropertyListItem item) : base(item)
        {
            orFeat = false;
        }
    }

    [Serializable]
    public struct NWN2ClassName
    {
        public string Label;
        public string LocalizedName; //Localized
        public string Plural;
        public string Lower;
        public int NameStrRef;
        public int PluralStrRef;
        public int LowerStrRef;

        public NWN2ClassName(string label)
        {
            Label = label;            
            LocalizedName = "";
            Plural = "";
            Lower = "";
            NameStrRef = -1;
            PluralStrRef = -1;
            LowerStrRef = -1;
        }

        public NWN2ClassName(string label, string name, string plural, string lower) : this(label)
        {
            Label = label;
            LocalizedName = name;
            Plural = plural;
            Lower = lower;
        }
    }

    [Serializable]
    public struct DefaultAbility
    {
        public byte AbilityPointsCount;
        public byte Str;
        public byte Dex;
        public byte Con;
        public byte Int;
        public byte Wis;
        public byte Cha;
    }

    public static class TwoDAValidator
    {
        public static bool IsClasses2DA(TwoDATable classes2DA)
        {
            if (classes2DA == null) throw new NullReferenceException();
            if (classes2DA.ContainColumn("HitDie") && classes2DA.ContainColumn("PlayerClass") && classes2DA.ContainColumn("CharGen_Chest")) return true;

            return false;
        }

        public static bool IsFeat2DA(TwoDATable feat2DA)
        {
            if (feat2DA == null) throw new NullReferenceException();
            if (feat2DA.ContainColumn("FEAT") && feat2DA.ContainColumn("MINATTACKBONUS") && feat2DA.ContainColumn("DMFeat")) return true;

            return false;
        }

        public static bool IsSkills2DA(TwoDATable skills2DA)
        {
            if (skills2DA == null) throw new NullReferenceException();
            if (skills2DA.ContainColumn("KeyAbility") && skills2DA.ContainColumn("ArmorCheckPenalty") && skills2DA.ContainColumn("IsAnActiveSkill")) return true;

            return false;
        }

        public static bool IsSpells2DA(TwoDATable spells2DA)
        {
            if (spells2DA == null) throw new NullReferenceException();
            if (spells2DA.ContainColumn("SpellDesc") && spells2DA.ContainColumn("CastTime") && spells2DA.ContainColumn("UseConcentration")) return true;

            return false;
        }
    }
}
