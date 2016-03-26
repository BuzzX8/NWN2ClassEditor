using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class OneDimArrayEditorForm : Form
    {
        public OneDimArrayEditorForm()
        {
            InitializeComponent();
        }

        public int this[int index]
        {
            get
            {
                return (int)arrayDataGridView["valueColumn", index].Value;
            }
            set
            {
                arrayDataGridView.Rows[index].Cells["valueColumn"].Value = value;
            }
        }

        public int ArrayLength
        {
            get
            {
                return arrayDataGridView.RowCount;
            }
            set
            {
                arrayDataGridView.Rows.Clear();

                for (int i = 0; i < value; i++)
                {
                    arrayDataGridView.Rows.Add(i, 0);
                }
            }
        }

        public string ValueHeaderTitle
        {
            get
            {
                return arrayDataGridView.Columns["valueColumn"].HeaderText;
            }
            set
            {
                arrayDataGridView.Columns["valueColumn"].HeaderText = value;
            }
        }

        public int[] ValueArray
        {
            get
            {
                List<int> result = new List<int>();

                for (int i = 0; i < arrayDataGridView.RowCount; i++)
                {
                    result.Add((int)arrayDataGridView.Rows[i].Cells["valueColumn"].Value);
                }

                return result.ToArray();
            }
            set
            {                
                if (value == null)
                {                    
                    for (int i = 0; i < arrayDataGridView.RowCount; i++)
                    {
                        arrayDataGridView["valueColumn", i].Value = 0;
                    }

                    return;
                }

                arrayDataGridView.Rows.Clear();

                for (int i = 0; i < value.Length; i++)
                {
                    arrayDataGridView.Rows.Add(i, ((object)value[i]));
                }
            }
        }

        protected virtual void Create2DA(TwoDATable table, string valueColumnTitle)
        {
            for (int i = 0; i < arrayDataGridView.RowCount; i++)
            {
                table.Add();
                table[i, valueColumnTitle] = arrayDataGridView["valueColumn", i].Value.ToString();
            }            
        }

        private void arrayDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.DataGridView.HitTestInfo hitInfo = arrayDataGridView.HitTest(e.X, e.Y);
            int value = (int)arrayDataGridView["valueColumn", hitInfo.RowIndex].Value;

            if (hitInfo.ColumnIndex != arrayDataGridView.Columns["valueColumn"].Index || hitInfo.ColumnIndex < 0) return;
            if (e.Button == MouseButtons.Left) value++;
            if (e.Button == MouseButtons.Right && value > 0) value--;

            arrayDataGridView["valueColumn", hitInfo.RowIndex].Value = value;
        }        
    }

    public class EffectiveCRLevelEditorForm : OneDimArrayEditorForm
    {
        public EffectiveCRLevelEditorForm() : base()
        {
            ArrayLength = 20;
            ValueHeaderTitle = "EffCRLvl";

            for (int i = 1; i <= ArrayLength; i++)
            {
                this[i - 1] = i;
            }
        }
    }

    public class BonusSpellcasterLevelEditorForm : OneDimArrayEditorForm
    {
        public BonusSpellcasterLevelEditorForm() : base()
        {
            ArrayLength = 50;
            ValueHeaderTitle = "GrantsBonusSpellcasterLevel";
        }

        public TwoDATable Create2DA()
        {
            TwoDATable result = new TwoDATable("GrantsBonusSpellcasterLevel", "");

            result.TableName = "cls_bsplvl_";
            base.Create2DA(result, "GrantsBonusSpellcasterLevel");

            return result;
        }
    }

    public class BonusFeatsEditorForm : OneDimArrayEditorForm
    {
        private DataGridViewCheckBoxColumn normalColumn;

        public BonusFeatsEditorForm() : base()
        {
            ArrayLength = 60;
            ValueHeaderTitle = "Bonus";

            normalColumn = new DataGridViewCheckBoxColumn();
            normalColumn.HeaderText = "Epic";
            normalColumn.Name = "normalColumn";
            normalColumn.ValueType = typeof(bool);
            normalColumn.TrueValue = true;
            normalColumn.FalseValue = false;
            arrayDataGridView.Columns.Add(normalColumn);            
        }

        public TwoDATable Create2DA()
        {
            TwoDATable result = new TwoDATable("Bonus", "Normal");
            result.TableName = "cls_bfeat_";
            base.Create2DA(result, "Bonus");
            
            for (int i = 0; i < arrayDataGridView.RowCount; i++)
            {
                if (arrayDataGridView["normalColumn", i].Value == null)
                {
                    result[i, "Normal"] = "0";
                    continue;
                }

                result[i, "Normal"] = ((IConvertible)arrayDataGridView["normalColumn", i].Value).ToByte(null).ToString();
            }

            return result;
        }
    }
}