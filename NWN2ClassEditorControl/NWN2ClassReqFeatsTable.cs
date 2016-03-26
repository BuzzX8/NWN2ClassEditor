using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2ClassReqFeatsTable : UserControl
    {
        public NWN2ClassReqFeatsTable()
        {
            InitializeComponent();
        }

        public NWN2PropertyList FeatsList
        {
            set
            {
                for (int i = 0; i < value.Count; i++)
                {
                    AddFeat(value[i], false, false);
                }
            }
        }

        public List<NWN2FeatReq> ReqFeats
        {
            get
            {
                List<NWN2FeatReq> result = new List<NWN2FeatReq>();
                NWN2FeatReq item;

                for (int i = 0; i < featsDataGridView.RowCount; i++)
                {
                    if ((bool)featsDataGridView["reqFeatColumn", i].Value == false || featsDataGridView["reqFeatColumn", i] == null) continue;

                    item = new NWN2FeatReq((NWN2PropertyListItem)featsDataGridView["featNameColumn", i].Value);

                    if ((bool)featsDataGridView["orFeatColumn", i].Value == true) item.OrFeat = true;

                    result.Add(item);
                }

                return result;
            }
        }

        public void AddFeat(NWN2PropertyListItem feat, bool require, bool orFeat)
        {
            featsDataGridView.Rows.Add(require, feat, orFeat);
        }
     }
}
