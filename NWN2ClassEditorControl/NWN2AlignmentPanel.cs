using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2AlignmentPanel : UserControl
    {
        private byte alignRestrict = 0;
        private byte alignRestrictType = 0;
        private bool inverted = false;

        public NWN2AlignmentPanel()
        {
            InitializeComponent();
        }

        public Alignment[] SelectedAlignments
        {
            get
            {
                List<Alignment> selectedAlignments = new List<Alignment>();

                if (lgAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.LawfulGood);
                if (lnAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.LawfulNeutral);
                if (leAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.LawfulEvil);

                if (ngAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.NeutralGood);
                if (tnAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.TrueNeutral);
                if (neAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.NeutralEvil);

                if (cgAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.ChaoticGood);
                if (cnAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.ChaoticNeutral);
                if (ceAlignmentCheckBox.Checked) selectedAlignments.Add(Alignment.ChaoticEvil);

                return selectedAlignments.ToArray();
            }

            set
            {
                lgAlignmentCheckBox.Checked = false;
                lnAlignmentCheckBox.Checked = false;
                leAlignmentCheckBox.Checked = false;

                ngAlignmentCheckBox.Checked = false;
                tnAlignmentCheckBox.Checked = false;
                neAlignmentCheckBox.Checked = false;

                cgAlignmentCheckBox.Checked = false;
                cnAlignmentCheckBox.Checked = false;
                ceAlignmentCheckBox.Checked = false;

                foreach (Alignment alignment in value)
                {
                    switch (alignment)
                    {
                        case Alignment.LawfulGood:
                            lgAlignmentCheckBox.Checked = true;
                            break;

                        case Alignment.LawfulNeutral:
                            lnAlignmentCheckBox.Checked = true;
                            break;

                        case Alignment.LawfulEvil:
                            leAlignmentCheckBox.Checked = true;
                            break;

                        case Alignment.NeutralGood:
                            ngAlignmentCheckBox.Checked = true;
                            break;

                        case Alignment.TrueNeutral:
                            tnAlignmentCheckBox.Checked = true;
                            break;

                        case Alignment.NeutralEvil:
                            neAlignmentCheckBox.Checked = true;
                            break;

                        case Alignment.ChaoticGood:
                            cgAlignmentCheckBox.Checked = true;
                            break;

                        case Alignment.ChaoticNeutral:
                            cnAlignmentCheckBox.Checked = true;
                            break;

                        case Alignment.ChaoticEvil:
                            ceAlignmentCheckBox.Checked = true;
                            break;
                    }
                }
            }
        }

        public string GetAlignmentRestrictString()
        {
            return "0x00";
        }

        public string GetAlignmentRestrictTypeString()
        {
            return "0x0";
        }

        public bool InvertedRestrict
        {
            get
            {
                return false;
            }
        }

        public string Title
        {
            get
            {
                return titleLabel.Text;
            }
            set
            {
                titleLabel.Text = value;
            }
        }

        internal void UpdateLabels()
        {
            if (NWN2PropertyListItem.TalkTable == null) return;

            lgAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[112];
            lnAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[113];
            leAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[114];
            ngAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[115];
            tnAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[116];
            neAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[117];
            cgAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[118];
            cnAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[119];
            ceAlignmentCheckBox.Text = NWN2PropertyListItem.TalkTable[120];
        }

        private void updateCheckboxes(CheckBox align1, CheckBox align2, CheckBox align3, CheckBox mainAlign)
        {
            if (align1.Checked && align2.Checked && align3.Checked)
            {
                mainAlign.Checked = true;
                return;
            }
            if (align1.Checked == false && align2.Checked == false && align3.Checked == false)
            {
                mainAlign.Checked = false;
                return;
            }
            mainAlign.CheckState = CheckState.Indeterminate;
        }

        private void updateLawfulCheckBoxes()
        {
            updateCheckboxes(lgAlignmentCheckBox, lnAlignmentCheckBox, leAlignmentCheckBox, lawfulAlignmentsCheckBox);
        }

        private void updateNeutralLCCheckBoxes()
        {
            updateCheckboxes(ngAlignmentCheckBox, tnAlignmentCheckBox, neAlignmentCheckBox, neutralLCAlignmentsCheckBox);
        }

        public void updateChaoticCheckBoxes()
        {
            updateCheckboxes(cgAlignmentCheckBox, cnAlignmentCheckBox, ceAlignmentCheckBox, chaoticAlignmentsCheckBox);
        }

        public void updateGoodCheckBoxes()
        {
            updateCheckboxes(lgAlignmentCheckBox, ngAlignmentCheckBox, cgAlignmentCheckBox, goodAlignmentsCheckBox);
        }

        public void updateNeutralGECheckBoxes()
        {
            updateCheckboxes(lnAlignmentCheckBox, tnAlignmentCheckBox, cnAlignmentCheckBox, neutralGEAlignmentsCheckBox);
        }

        public void updateEvilCheckBoxes()
        {
            updateCheckboxes(leAlignmentCheckBox, neAlignmentCheckBox, ceAlignmentCheckBox, evilAlignmentsCheckBox);
        }

        private void goodAlignmentsCheckBox_Click(object sender, EventArgs e)
        {
            lgAlignmentCheckBox.Checked = ngAlignmentCheckBox.Checked = cgAlignmentCheckBox.Checked = goodAlignmentsCheckBox.Checked;
            updateLawfulCheckBoxes();
            updateNeutralLCCheckBoxes();
            updateChaoticCheckBoxes();
        }

        private void neutralGEAlignmentsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lnAlignmentCheckBox.Checked = tnAlignmentCheckBox.Checked = cnAlignmentCheckBox.Checked = neutralGEAlignmentsCheckBox.Checked;
            updateLawfulCheckBoxes();
            updateNeutralLCCheckBoxes();
            updateChaoticCheckBoxes();
        }

        private void evilAlignmentsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            leAlignmentCheckBox.Checked = neAlignmentCheckBox.Checked = ceAlignmentCheckBox.Checked = evilAlignmentsCheckBox.Checked;
            updateLawfulCheckBoxes();
            updateNeutralLCCheckBoxes();
            updateChaoticCheckBoxes();
        }

        private void lawfulAlignmentsCheckBox_Click(object sender, EventArgs e)
        {
            lgAlignmentCheckBox.Checked = lnAlignmentCheckBox.Checked = leAlignmentCheckBox.Checked = lawfulAlignmentsCheckBox.Checked;
            updateGoodCheckBoxes();
            updateNeutralGECheckBoxes();
            updateEvilCheckBoxes();
        }

        private void neutralLCAlignmentsCheckBox_Click(object sender, EventArgs e)
        {
            ngAlignmentCheckBox.Checked = tnAlignmentCheckBox.Checked = neAlignmentCheckBox.Checked = neutralLCAlignmentsCheckBox.Checked;
            updateGoodCheckBoxes();
            updateNeutralGECheckBoxes();
            updateEvilCheckBoxes();
        }

        private void chaoticAlignmentsCheckBox_Click(object sender, EventArgs e)
        {
            cgAlignmentCheckBox.Checked = cnAlignmentCheckBox.Checked = ceAlignmentCheckBox.Checked = chaoticAlignmentsCheckBox.Checked;
            updateGoodCheckBoxes();
            updateNeutralGECheckBoxes();
            updateEvilCheckBoxes();
        }        
    }
}
