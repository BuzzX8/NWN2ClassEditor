using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2SpontaneousConversationForm : Form
    {
        private NWN2IconChooserForm iconChooser;        
        private TwoDATable spellList;

        public NWN2SpontaneousConversationForm()
        {
            InitializeComponent();
            
            conversationSpellColumn.ValueType = typeof(NWN2PropertyList);
            conversationSpellColumn.ValueMember = "Name";

            for (int i = 0; i < 10; i++)
            {
                spellConversationDataGridView.Rows.Add((object)i);//.ToString(), "-1", "INVALID_SPELL_ID", "****");
                altSpellConversationDataGridView.Rows.Add((object)i);//.ToString(), "-1", "INVALID_SPELL_ID", "****");
            }
        }

        public TwoDATable SpellsList
        {
            set
            {
                spellList = value;
                conversationSpellColumn.DataSource = value.ConvertToList("Name", "SpellDesc");
                altSpellConversationColumn.DataSource = value.ConvertToList("Name", "SpellDesc");
            }
        }

        public NWN2IconChooserForm IconChooserDialog
        {
            get
            {
                return iconChooser;
            }
            set
            {
                iconChooser = value;
            }
        }

        public TwoDATable Create2DATable()
        {            
            TwoDATable result = new TwoDATable("Level", "SpellId", "SpellName", "OverlayIcon", "AltSpellId", "AltSpellName", "AltOverlayIcon");
            int spellIndex;

            //Debugger.Launch();
            for (int i = 0; i < 10; i++)
            {
                result.Add();
                result[i, "Level"] = i.ToString();
                                
                if (spellConversationDataGridView.Rows[i].Cells["conversationSpellColumn"].Value == null)
                {
                    result[i, "SpellId"] = "-1";
                    result[i, "SpellName"] = "INVALID_SPELL_ID";
                    result[i, "OverlayIcon"] = "****";
                }
                else
                {
                    spellIndex = ((NWN2PropertyList)conversationSpellColumn.DataSource)[(string)spellConversationDataGridView.Rows[i].Cells["conversationSpellColumn"].Value].PropertyID;                    
                    result[i, "SpellId"] = spellIndex.ToString();
                    result[i, "SpellName"] = spellList[spellIndex, "Label"];
                    result[i, "OverlayIcon"] = (string)spellConversationDataGridView.Rows[i].Cells["overlayIconColumn"].Tag;
                }

                //Fill alternative conversations
                if (!altSpellsCheckBox.Checked || altSpellConversationDataGridView.Rows[i].Cells[""].Value == null)
                {
                    result[i, "AltSpellId"] = "-1";
                    result[i, "AltSpellName"] = "INVALID_SPELL_ID";
                    result[i, "AltOverlayIcon"] = "****";
                }
                else
                {
                    spellIndex = ((NWN2PropertyList)altSpellConversationColumn.DataSource)[(string)altSpellConversationDataGridView.Rows[i].Cells["altSpellConversationColumn"].Value].PropertyID;
                    result[i, "AltSpellId"] = spellIndex.ToString();
                    result[i, "AltSpellName"] = spellList[spellIndex, "Label"];
                    result[i, "AltOverlayIcon"] = (string)altSpellOverlayIconColumn.Tag;
                }
            }

            result.TableName = "cls_spon_";

            return result;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageCell iconButton = spellConversationDataGridView.SelectedCells[0] as DataGridViewImageCell;

            if (iconButton == null || iconChooser == null) return;

            iconChooser.Location = Cursor.Position;
            if (iconChooser.ShowDialog(this) == DialogResult.OK)
            {
                iconButton.Value = iconChooser.SelectedIcon;
                iconButton.Tag = iconChooser.ImageResource.ResRef.Value;
            }
        }

        private void altSpellsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !altSpellsCheckBox.Checked;
        }

        private void altSpellConversationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageCell iconButton = altSpellConversationDataGridView.SelectedCells[0] as DataGridViewImageCell;

            if (iconButton == null || iconChooser == null) return;

            iconChooser.Location = Cursor.Position;
            if (iconChooser.ShowDialog(this) == DialogResult.OK)
            {
                iconButton.Value = iconChooser.SelectedIcon;
                iconButton.Tag = iconChooser.ImageResource.ResRef.Value;
            }
        }
    }
}