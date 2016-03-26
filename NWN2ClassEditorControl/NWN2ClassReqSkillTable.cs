using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ClassReqSkillTable : UserControl
    {
        private TextBox descriptionTextBox;

        public NWN2ClassReqSkillTable()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        public NWN2PropertyList SkillsList
        {
            set
            {
                skillsReqGrid.Rows.Clear();

                foreach (NWN2PropertyListItem item in value)
                {
                    skillsReqGrid.Rows.Add(item, 0);
                }
            }
        }

        [Browsable(false)]
        public NWN2SkillReqList ReqSkills
        {
            get
            {
                NWN2SkillReqList list = new NWN2SkillReqList();

                foreach (DataGridViewRow row in this.skillsReqGrid.Rows)
                {
                    list.Add(new NWN2SkillReqListItem((NWN2PropertyListItem)row.Cells["SkillName"].Value, (int)row.Cells["ReqSkillLevel"].Value));
                }

                return list;
            }
        }

        public TextBox DescriptionTextBox
        {
            get
            {
                return descriptionTextBox;
            }
            set
            {
                descriptionTextBox = value;
            }
        }
    }
}
