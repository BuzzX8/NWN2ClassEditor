using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2SpellTable : UserControl
    {
        public NWN2SpellTable()
        {
            InitializeComponent();
        }

        internal ushort LevelCount
        {
            set
            {
                spellGainDataGridView.Rows.Clear();

                for (int i = 1; i <= value; i++)
                {
                    spellGainDataGridView.Rows.Add(i, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                }
            }
        }

        public int[,] Table
        {
            get
            {
                int[,] result = new int[spellGainDataGridView.RowCount, spellGainDataGridView.ColumnCount];

                for (int i = 0; i < spellGainDataGridView.RowCount; i++)
                    for (int j = 0; j < spellGainDataGridView.ColumnCount; j++) result[i, j] = (int)spellGainDataGridView[j, i].Value;

                return result;
            }
            set
            {
                if (value == null) return;

                for (int i = 0; i < spellGainDataGridView.RowCount; i++)
                    for (int j = 0; j < spellGainDataGridView.ColumnCount; j++)  spellGainDataGridView[j, i].Value = value[i, j];
            }
        }

        public virtual TwoDATable CreateTwoDA()
        {
            TwoDATable result = new TwoDATable("Level", "SpellLevel0", "SpellLevel1", "SpellLevel2", "SpellLevel3", "SpellLevel4", "SpellLevel5", "SpellLevel6", "SpellLevel7", "SpellLevel8", "SpellLevel9");

            CreateTwoDA(result);            

            return result;
        }

        protected void CreateTwoDA(TwoDATable table)
        {
            int level, value;

            for (int i = 0; i < spellGainDataGridView.RowCount; i++)
            {
                table.Add();
                level = i + 1;
                table[i, "Level"] = level.ToString();

                for (int j = 0; j < 10; j++)
                {
                    value = (int)spellGainDataGridView.Rows[i].Cells[j + 1].Value;

                    if (value == 0) table[i, "SpellLevel" + j.ToString()] = "";
                    else table[i, "SpellLevel" + j.ToString()] = value.ToString();
                }
            }
        }

        private void plus1ToSpellLevelButton_Click(object sender, EventArgs e)
        {            
            int columnIndex = spellGainDataGridView.SelectedCells[0].ColumnIndex;
            int rowIndex = spellGainDataGridView.SelectedCells[0].RowIndex;
            int value;

            if (columnIndex == 0) return;

            for (int i = rowIndex; i < spellGainDataGridView.RowCount; i++)
            {
                value = (int)spellGainDataGridView.Rows[i].Cells[columnIndex].Value;
                value++;
                spellGainDataGridView.Rows[i].Cells[columnIndex].Value = value;
            }
        }

        private void minus1ToSpellLevel_Click(object sender, EventArgs e)
        {            
            int columnIndex = spellGainDataGridView.SelectedCells[0].ColumnIndex;
            int rowIndex = spellGainDataGridView.SelectedCells[0].RowIndex;
            int value;

            if (columnIndex == 0) return;

            for (int i = rowIndex; i < spellGainDataGridView.RowCount; i++)
            {
                value = (int)spellGainDataGridView.Rows[i].Cells[columnIndex].Value;
                
                if (value > 0)
                {
                    value--;
                    spellGainDataGridView.Rows[i].Cells[columnIndex].Value = value;
                }
            }
        }

        private void plus1ToClassLevelButton_Click(object sender, EventArgs e)
        {
            int columnIndex = spellGainDataGridView.SelectedCells[0].ColumnIndex;
            int rowIndex = spellGainDataGridView.SelectedCells[0].RowIndex;
            int value;

            for (int i = 1; i < spellGainDataGridView.ColumnCount; i++)
            {
                value = (int)spellGainDataGridView.Rows[rowIndex].Cells[i].Value;

                if (value == 0) break;

                value++;
                spellGainDataGridView.Rows[rowIndex].Cells[i].Value = value;
            }
        }

        private void minus1ToClassLevelButton_Click(object sender, EventArgs e)
        {
            int columnIndex = spellGainDataGridView.SelectedCells[0].ColumnIndex;
            int rowIndex = spellGainDataGridView.SelectedCells[0].RowIndex;
            int value;

            for (int i = 1; i < spellGainDataGridView.ColumnCount; i++)
            {
                value = (int)spellGainDataGridView.Rows[rowIndex].Cells[i].Value;

                if (value == 0) break;

                if (value > 0)
                {
                    value--;
                    spellGainDataGridView.Rows[rowIndex].Cells[i].Value = value;
                }
            }
        }
    }

    public class NWN2SpellGainTable : NWN2SpellTable
    {
        public override TwoDATable CreateTwoDA()
        {
            TwoDATable result = new TwoDATable("Level", "NumSpellLevels", "SpellLevel0", "SpellLevel1", "SpellLevel2", "SpellLevel3", "SpellLevel4", "SpellLevel5", "SpellLevel6", "SpellLevel7", "SpellLevel8", "SpellLevel9");

            CreateTwoDA(result);

            for (int i = 0; i < result.RowCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (result[i, "SpellLevel" + j.ToString()] == "")
                    {
                        result[i, "NumSpellLevels"] = j.ToString();
                        break;
                    }
                }
            }

            return result;
        }
    }
}
