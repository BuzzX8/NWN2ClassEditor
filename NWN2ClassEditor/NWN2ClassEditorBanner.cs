using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using NWN2Toolset;

namespace BuzzX8.NWN2ClassEditor
{
    public partial class NWN2LoadBanner : Form
    {
        private Thread logoThread;

        public NWN2LoadBanner()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public new void  Show()
        {
            logoThread = new Thread(new ThreadStart(bannerThread));
            //logoThread.IsBackground = true;
            logoThread.Start();
        }

        public new void Close()
        {
            logoThread.Abort();
        }

        public void bannerThread()
        {
            try
            {
                base.ShowDialog();                
            }
            catch(ThreadAbortException)
            {                
                base.Close();                
            }
        }
    }
}