using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Windows_Booster.Compoments;

namespace Windows_Booster
{
    public partial class frmWinBooster : Form
    {
        
        private void Analyze()
        {
            Application.Run(new Scanning());
        }
       
        public frmWinBooster()
        {
                Thread t = new Thread(new ThreadStart(Analyze));
                t.Start();
                Thread.Sleep(3000);
                InitializeComponent();
                t.Abort();
        }

        SystemCleanup syscleanup = new SystemCleanup();
        SystemServices syssrv = new SystemServices();
        SystemTweaks systweaks = new SystemTweaks();

        private void frmWinBooster_Load(object sender, EventArgs e)
        {
            syscleanup.SetSize(ref lst_SystemCleanup);
            lbTotalSize.Text = syscleanup.GetTotalSize();
            syssrv.GetStartup_Type_SVC_Win(ref lst_Services);
        }

        //System Cleanup
        private void btnSelectAll_SysCleanup_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lst_SystemCleanup.Items)
                item.Checked = true;
        }
        private void lst_SystemCleanup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_MoTaDonDep.Text = syscleanup.GetDescribe(lst_SystemCleanup);
        }

        //System Services
        private void lst_Services_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDescribeSrv.Text = syssrv.Get_Describe_Of_Service(lst_Services);
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            syssrv.GetStartup_Type_SVC_Win(ref lst_Services);
        }
        private void btnSelectAll_Services_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lst_Services.Items)
                item.Checked = true;
        }

        //System Tweaks
        private void cbxDisableSysRestore_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxDisableSysRestore.Checked == true)
                systweaks.list_index_of_checkbox.Add(cbxDisableSysRestore.TabIndex);
            else
                systweaks.list_index_of_checkbox.Remove(cbxDisableSysRestore.TabIndex);
        }
        private void cbxDisableCDBurning_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxDisableCDBurning.Checked == true)
                systweaks.list_index_of_checkbox.Add(cbxDisableCDBurning.TabIndex);
            else
                systweaks.list_index_of_checkbox.Remove(cbxDisableCDBurning.TabIndex);
        }
        private void cbxDisableHibernate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxDisableHibernate.Checked == true)
                systweaks.list_index_of_checkbox.Add(cbxDisableHibernate.TabIndex);
            else
                systweaks.list_index_of_checkbox.Remove(cbxDisableHibernate.TabIndex);
        }
        private void cbxDisableUAC_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxDisableUAC.Checked == true)
                systweaks.list_index_of_checkbox.Add(cbxDisableUAC.TabIndex);
            else
                systweaks.list_index_of_checkbox.Remove(cbxDisableUAC.TabIndex);
        }
        private void cbxRemoveShorcutToText_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxRemoveShorcutToText.Checked == true)
                systweaks.list_index_of_checkbox.Add(cbxRemoveShorcutToText.TabIndex);
            else
                systweaks.list_index_of_checkbox.Remove(cbxRemoveShorcutToText.TabIndex);
        }
        private void cbxTurnOffSysFailture_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxTurnOffSysFailture.Checked == true)
                systweaks.list_index_of_checkbox.Add(cbxTurnOffSysFailture.TabIndex);
            else
                systweaks.list_index_of_checkbox.Remove(cbxTurnOffSysFailture.TabIndex);
        }

        private void btnToiUu_Click(object sender, EventArgs e)
        {
            if (lst_SystemCleanup.CheckedItems.Count > 0)
            {
                    syscleanup.ExcuteCleanup(lst_SystemCleanup);
                    syscleanup.SetSize(ref lst_SystemCleanup);
                    lbTotalSize.Text = syscleanup.GetTotalSize();
            }
            if (lst_Services.CheckedItems.Count > 0)
            {
                syssrv.Excute_DisableSvc(lst_Services);
                Thread.Sleep(500);
                syssrv.GetStartup_Type_SVC_Win(ref lst_Services);
            }
            if (systweaks.list_index_of_checkbox.Count > 0)
                systweaks.ExcuteTweaks();
            //MessageBox.Show("Tối ưu thành công!", Application.ProductName, MessageBoxButtons.OK);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            syscleanup.Free();
            syssrv.Free();
            systweaks.Free();
            Application.Exit();     
        }

        private void frmWinBooster_FormClosed(object sender, FormClosedEventArgs e)
        {
            syscleanup.Free();
            syssrv.Free();
            systweaks.Free();
        }

        //Menu Items
        private void Infomation_MenuItem_Click(object sender, EventArgs e)
        {
            About frm_About = new About();
            frm_About.ShowDialog();
        }
        private void Exit_MenuItem_Click(object sender, EventArgs e)
        {
            syscleanup.Free();
            syssrv.Free();
            systweaks.Free();
            Application.Exit();
           
        }
    }
}
