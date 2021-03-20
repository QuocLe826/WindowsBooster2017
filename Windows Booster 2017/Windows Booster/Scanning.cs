using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows_Booster.Compoments;

namespace Windows_Booster
{
    public partial class Scanning : Form
    {
        public Scanning()
        {
            InitializeComponent();
        }

        SystemCleanup sysclean = new SystemCleanup();
        SystemServices srv = new SystemServices();

        public void ReturnToSysCleanup(ref ListView lst, ref Label TotalSize)
        {
            
        }
        public void ReturnToSysServices(ref ListView lst)
        {
            
        }
        private void Scanning_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Stop();
                this.Close();
            }
        }

        private void btnExitAnalyze_Click(object sender, EventArgs e)
        {

        }
    }
}
