using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2PreReqTableDialogForm : Form
    {
        private TwoDATable featTable;
        private TwoDATable skillTable;
        private TwoDATable racialSubTypeTable;

        public NWN2PreReqTableDialogForm()
        {
            InitializeComponent();
        }

        public TwoDATable FeatsList
        {
            set
            {
                if (!TwoDAValidator.IsFeat2DA(value)) throw new ArgumentException("Table is not feat list 2da");

                featTable = value;
                reqFeatsTable.FeatsList = value.ConvertToList("FEAT", "DESCRIPTION", "REMOVED", "1");
            }
        }

        public TwoDATable SkillsList
        {
            set
            {
                if (!TwoDAValidator.IsSkills2DA(value)) throw new ArgumentException("Table is not skills list 2da");

                skillTable = value;
                reqSkillsRankDataGridView.SkillsList = value.ConvertToList("Name", "Description", "REMOVED", "1");
            }
        }

        public TwoDATable RacialSubTypesList
        {
            set
            {
                racialSubTypeTable = value;
                allowedRacesList.PropertyList = value.ConvertToList("Name", "Description", "PlayerRace", "0");
                allowedRacesList.CheckAllItems(true);
            }
        }

        public List<NWN2FeatReq> ClassReqFeats
        {
            get
            {
                return reqFeatsTable.ReqFeats;
            }
        }

        public NWN2SkillReqList ClassReqSkills
        {
            get
            {                
                return reqSkillsRankDataGridView.ReqSkills;
            }
        }

        public TwoDATable Create2DA()
        {
            TwoDATable result = new TwoDATable("LABEL", "ReqType", "ReqParam1", "ReqParam2");

            result.TableName = "cls_pres_";
            //Attack bonus req
            if (baseABNumericUpDown.Value > 0)
            {
                result.Add();
                result[result.RowCount - 1, "LABEL"] = "Base_Attack";
                result[result.RowCount - 1, "ReqType"] = "BAB";
                result[result.RowCount - 1, "ReqParam1"] = baseABNumericUpDown.Value.ToString();
            }

            //Feats req
            foreach (NWN2FeatReq item in reqFeatsTable.ReqFeats)
            {
                result.Add();
                result[result.RowCount - 1, "LABEL"] = featTable[item.PropertyID, "LABEL"];

                if (item.OrFeat) result[result.RowCount - 1, "ReqType"] = "FEATOR";
                else result[result.RowCount - 1, "ReqType"] = "FEAT";

                result[result.RowCount - 1, "ReqParam1"] = item.PropertyID.ToString();
            }

            //Spellcaster req
            if (reqSpellCastingCheckBox.Checked)
            {
                result.Add();

                if (arcSpellsRadioButton.Checked)
                {
                    result[result.RowCount - 1, "LABEL"] = "Arcane";
                    result[result.RowCount - 1, "ReqType"] = "ARCSPELL";
                    result[result.RowCount - 1, "ReqParam1"] = spellsLevelNumericUpDown.Value.ToString();
                }

                if (divSpellsRadioButton.Checked)
                {
                    if (arcSpellsRadioButton.Checked)
                    {
                        result[result.RowCount - 1, "LABEL"] = "Divine";
                        result[result.RowCount - 1, "ReqType"] = "DIVSPELL";
                        result[result.RowCount - 1, "ReqParam1"] = spellsLevelNumericUpDown.Value.ToString();
                    }
                }

                if (wizSpecialistCheckBox.Checked)
                {
                    result.Add();
                    result[result.RowCount - 1, "LABEL"] = "Specialist_Wizard";
                    result[result.RowCount - 1, "ReqType"] = "SPECIALIST";                    
                }
            }

            //Skills req
            foreach (NWN2SkillReqListItem item in reqSkillsRankDataGridView.ReqSkills)
            {
                if (item.ReqLevel == 0) continue;

                result.Add();
                result[result.RowCount - 1, "LABEL"] = skillTable[item.PropertyID, "Label"];
                result[result.RowCount - 1, "ReqType"] = "SKILL";
                result[result.RowCount - 1, "ReqParam1"] = item.PropertyID.ToString();
                result[result.RowCount - 1, "ReqParam2"] = item.ReqLevel.ToString();
            }
          
            //Save throws
            if (fortiduteNumericUpDown.Value > 0)
            {
                result.Add();
                result[result.RowCount - 1, "LABEL"] = "MinBaseFortSave";
                result[result.RowCount - 1, "ReqType"] = "SAVE";
                result[result.RowCount - 1, "ReqParam1"] = "1";
                result[result.RowCount - 1, "ReqParam2"] = fortiduteNumericUpDown.Value.ToString();
            }
            if (reflexNumericUpDown.Value > 0)
            {
                result.Add();
                result[result.RowCount - 1, "LABEL"] = "MinBaseReflexSave";
                result[result.RowCount - 1, "ReqType"] = "SAVE";
                result[result.RowCount - 1, "ReqParam1"] = "2";
                result[result.RowCount - 1, "ReqParam2"] = reflexNumericUpDown.Value.ToString();
            }
            if (willNumericUpDown.Value > 0)
            {
                result.Add();
                result[result.RowCount - 1, "LABEL"] = "MinBaseWillSave";
                result[result.RowCount - 1, "ReqType"] = "SAVE";
                result[result.RowCount - 1, "ReqParam1"] = "3";
                result[result.RowCount - 1, "ReqParam2"] = willNumericUpDown.Value.ToString();
            }

            //Racial subtypes
            if (allowedRacesList.SelectedItems.Count != allowedRacesList.PropertyList.Count)
            {
                foreach (NWN2PropertyListItem item in allowedRacesList.SelectedItems)
                {
                    result.Add();
                    result[result.RowCount - 1, "LABEL"] = racialSubTypeTable[item.PropertyID, "Label"];
                    result[result.RowCount - 1, "ReqType"] = "RACE";
                    result[result.RowCount - 1, "ReqParam1"] = item.PropertyID.ToString();                    
                }
            }

            return result;
        }

        private void reqSpellCastingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            reqSpellcastingPanel.Enabled = reqSpellCastingCheckBox.Checked;
        }

        private void arcSpellsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            wizSpecialistCheckBox.Enabled = arcSpellsRadioButton.Checked;
        }
    }
}