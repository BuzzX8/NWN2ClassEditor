using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2SpellGainDialogForm : Form
    {
        public NWN2SpellGainDialogForm()
        {
            InitializeComponent();
        }

        public TwoDATable Create2DATable()
        {
            return SpellTable.CreateTwoDA();
        }
    }

    public class NWN2SpellKnownDialogForm : NWN2SpellGainDialogForm
    {
        public NWN2SpellKnownDialogForm() : base()
        {
            Controls.Remove(SpellTable);
            SpellTable.Dispose();
            SpellTable = new NWN2SpellTable();
            SpellTable.Location = new Point(0, 0);
            SpellTable.Size = new Size(475, 260);
            SpellTable.Anchor = AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Top;
            mainPanel.Controls.Add(SpellTable);
        }
    }
}