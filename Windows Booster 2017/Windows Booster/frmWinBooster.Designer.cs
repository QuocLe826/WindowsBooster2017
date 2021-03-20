namespace Windows_Booster
{
    partial class frmWinBooster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Temporary Files",
            ""}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Temporary Internet Files",
            ""}, 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Windows Temp Folder",
            ""}, 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Prefetch Data",
            ""}, 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Recent Items",
            ""}, 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cookies",
            ""}, 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Internet History",
            ""}, 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Windows Error Reporting",
            ""}, 7);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Recycle Bin",
            ""}, 8);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWinBooster));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bluetooth Support Service",
            ""}, 9);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Computer Browser",
            ""}, 9);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Fax",
            ""}, 9);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Smart Card",
            ""}, 9);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Offiline Files",
            ""}, 9);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Remote Registry ",
            ""}, 9);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Windows Error Reporting",
            ""}, 9);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Windows Time ",
            ""}, 9);
            this.Tab = new System.Windows.Forms.TabControl();
            this.SysCleanup_Tab = new System.Windows.Forms.TabPage();
            this.lbTotalSize = new System.Windows.Forms.Label();
            this.btnSelectAll_SysCleanup = new System.Windows.Forms.Button();
            this.lb_tdl = new System.Windows.Forms.Label();
            this.gp_MoTa = new System.Windows.Forms.GroupBox();
            this.lb_MoTaDonDep = new System.Windows.Forms.Label();
            this.lst_SystemCleanup = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lb_Banhaychonnhungmuccanxoa = new System.Windows.Forms.Label();
            this.SysSrv_Tab = new System.Windows.Forms.TabPage();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectAll_Services = new System.Windows.Forms.Button();
            this.gpDescribeSrv = new System.Windows.Forms.GroupBox();
            this.lbDescribeSrv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_Services = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SysTweaks_Tab = new System.Windows.Forms.TabPage();
            this.cbxDisableSysRestore = new System.Windows.Forms.CheckBox();
            this.cbxDisableCDBurning = new System.Windows.Forms.CheckBox();
            this.cbxTurnOffSysFailture = new System.Windows.Forms.CheckBox();
            this.cbxDisableHibernate = new System.Windows.Forms.CheckBox();
            this.cbxRemoveShorcutToText = new System.Windows.Forms.CheckBox();
            this.cbxDisableUAC = new System.Windows.Forms.CheckBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SystemMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Infomation_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToiUu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.SysCleanup_Tab.SuspendLayout();
            this.gp_MoTa.SuspendLayout();
            this.SysSrv_Tab.SuspendLayout();
            this.gpDescribeSrv.SuspendLayout();
            this.SysTweaks_Tab.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.Controls.Add(this.SysCleanup_Tab);
            this.Tab.Controls.Add(this.SysSrv_Tab);
            this.Tab.Controls.Add(this.SysTweaks_Tab);
            this.Tab.Location = new System.Drawing.Point(13, 27);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(429, 342);
            this.Tab.TabIndex = 0;
            // 
            // SysCleanup_Tab
            // 
            this.SysCleanup_Tab.Controls.Add(this.lbTotalSize);
            this.SysCleanup_Tab.Controls.Add(this.btnSelectAll_SysCleanup);
            this.SysCleanup_Tab.Controls.Add(this.lb_tdl);
            this.SysCleanup_Tab.Controls.Add(this.gp_MoTa);
            this.SysCleanup_Tab.Controls.Add(this.lst_SystemCleanup);
            this.SysCleanup_Tab.Controls.Add(this.lb_Banhaychonnhungmuccanxoa);
            this.SysCleanup_Tab.Location = new System.Drawing.Point(4, 22);
            this.SysCleanup_Tab.Name = "SysCleanup_Tab";
            this.SysCleanup_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.SysCleanup_Tab.Size = new System.Drawing.Size(421, 316);
            this.SysCleanup_Tab.TabIndex = 0;
            this.SysCleanup_Tab.Text = "Dọn dẹp";
            this.SysCleanup_Tab.UseVisualStyleBackColor = true;
            // 
            // lbTotalSize
            // 
            this.lbTotalSize.AutoSize = true;
            this.lbTotalSize.Location = new System.Drawing.Point(362, 291);
            this.lbTotalSize.Name = "lbTotalSize";
            this.lbTotalSize.Size = new System.Drawing.Size(27, 13);
            this.lbTotalSize.TabIndex = 8;
            this.lbTotalSize.Text = "Size";
            this.lbTotalSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectAll_SysCleanup
            // 
            this.btnSelectAll_SysCleanup.Location = new System.Drawing.Point(337, 219);
            this.btnSelectAll_SysCleanup.Name = "btnSelectAll_SysCleanup";
            this.btnSelectAll_SysCleanup.Size = new System.Drawing.Size(79, 23);
            this.btnSelectAll_SysCleanup.TabIndex = 7;
            this.btnSelectAll_SysCleanup.Text = "Chọn tất cả";
            this.btnSelectAll_SysCleanup.UseVisualStyleBackColor = true;
            this.btnSelectAll_SysCleanup.Click += new System.EventHandler(this.btnSelectAll_SysCleanup_Click);
            // 
            // lb_tdl
            // 
            this.lb_tdl.AutoSize = true;
            this.lb_tdl.BackColor = System.Drawing.Color.White;
            this.lb_tdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tdl.Location = new System.Drawing.Point(259, 291);
            this.lb_tdl.Name = "lb_tdl";
            this.lb_tdl.Size = new System.Drawing.Size(107, 13);
            this.lb_tdl.TabIndex = 5;
            this.lb_tdl.Text = "Tổng dung lượng:";
            // 
            // gp_MoTa
            // 
            this.gp_MoTa.Controls.Add(this.lb_MoTaDonDep);
            this.gp_MoTa.Location = new System.Drawing.Point(10, 239);
            this.gp_MoTa.Name = "gp_MoTa";
            this.gp_MoTa.Size = new System.Drawing.Size(405, 49);
            this.gp_MoTa.TabIndex = 3;
            this.gp_MoTa.TabStop = false;
            this.gp_MoTa.Text = "Mô tả";
            // 
            // lb_MoTaDonDep
            // 
            this.lb_MoTaDonDep.AutoSize = true;
            this.lb_MoTaDonDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_MoTaDonDep.Location = new System.Drawing.Point(6, 16);
            this.lb_MoTaDonDep.Name = "lb_MoTaDonDep";
            this.lb_MoTaDonDep.Size = new System.Drawing.Size(0, 13);
            this.lb_MoTaDonDep.TabIndex = 0;
            // 
            // lst_SystemCleanup
            // 
            this.lst_SystemCleanup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_SystemCleanup.CheckBoxes = true;
            this.lst_SystemCleanup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_SystemCleanup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lst_SystemCleanup.FullRowSelect = true;
            this.lst_SystemCleanup.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            this.lst_SystemCleanup.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lst_SystemCleanup.Location = new System.Drawing.Point(10, 33);
            this.lst_SystemCleanup.Name = "lst_SystemCleanup";
            this.lst_SystemCleanup.RightToLeftLayout = true;
            this.lst_SystemCleanup.Size = new System.Drawing.Size(406, 180);
            this.lst_SystemCleanup.SmallImageList = this.imageList;
            this.lst_SystemCleanup.TabIndex = 2;
            this.lst_SystemCleanup.UseCompatibleStateImageBehavior = false;
            this.lst_SystemCleanup.View = System.Windows.Forms.View.Details;
            this.lst_SystemCleanup.SelectedIndexChanged += new System.EventHandler(this.lst_SystemCleanup_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dữ liệu";
            this.columnHeader1.Width = 301;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dung lượng";
            this.columnHeader2.Width = 80;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "temporary-files.png");
            this.imageList.Images.SetKeyName(1, "temporary-internet-files.png");
            this.imageList.Images.SetKeyName(2, "windows-temp-folder.png");
            this.imageList.Images.SetKeyName(3, "prefetch.png");
            this.imageList.Images.SetKeyName(4, "recent-items.png");
            this.imageList.Images.SetKeyName(5, "cookies.png");
            this.imageList.Images.SetKeyName(6, "Internet-history.png");
            this.imageList.Images.SetKeyName(7, "win-error-reporting.png");
            this.imageList.Images.SetKeyName(8, "recycle-bin.png");
            this.imageList.Images.SetKeyName(9, "services.png");
            // 
            // lb_Banhaychonnhungmuccanxoa
            // 
            this.lb_Banhaychonnhungmuccanxoa.AutoSize = true;
            this.lb_Banhaychonnhungmuccanxoa.Location = new System.Drawing.Point(7, 17);
            this.lb_Banhaychonnhungmuccanxoa.Name = "lb_Banhaychonnhungmuccanxoa";
            this.lb_Banhaychonnhungmuccanxoa.Size = new System.Drawing.Size(184, 13);
            this.lb_Banhaychonnhungmuccanxoa.TabIndex = 1;
            this.lb_Banhaychonnhungmuccanxoa.Text = "Bạn hãy chọn những dữ liệu cần xóa:";
            // 
            // SysSrv_Tab
            // 
            this.SysSrv_Tab.Controls.Add(this.btnLammoi);
            this.SysSrv_Tab.Controls.Add(this.label5);
            this.SysSrv_Tab.Controls.Add(this.btnSelectAll_Services);
            this.SysSrv_Tab.Controls.Add(this.gpDescribeSrv);
            this.SysSrv_Tab.Controls.Add(this.label2);
            this.SysSrv_Tab.Controls.Add(this.lst_Services);
            this.SysSrv_Tab.Location = new System.Drawing.Point(4, 22);
            this.SysSrv_Tab.Name = "SysSrv_Tab";
            this.SysSrv_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.SysSrv_Tab.Size = new System.Drawing.Size(421, 316);
            this.SysSrv_Tab.TabIndex = 1;
            this.SysSrv_Tab.Text = "Dịch vụ";
            this.SysSrv_Tab.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(251, 219);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(79, 23);
            this.btnLammoi.TabIndex = 7;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Các dịch vụ được chọn sẽ bị vô hiệu hóa.";
            // 
            // btnSelectAll_Services
            // 
            this.btnSelectAll_Services.Location = new System.Drawing.Point(336, 219);
            this.btnSelectAll_Services.Name = "btnSelectAll_Services";
            this.btnSelectAll_Services.Size = new System.Drawing.Size(79, 23);
            this.btnSelectAll_Services.TabIndex = 4;
            this.btnSelectAll_Services.Text = "Chọn tất cả";
            this.btnSelectAll_Services.UseVisualStyleBackColor = true;
            this.btnSelectAll_Services.Click += new System.EventHandler(this.btnSelectAll_Services_Click);
            // 
            // gpDescribeSrv
            // 
            this.gpDescribeSrv.Controls.Add(this.lbDescribeSrv);
            this.gpDescribeSrv.Location = new System.Drawing.Point(9, 240);
            this.gpDescribeSrv.Name = "gpDescribeSrv";
            this.gpDescribeSrv.Size = new System.Drawing.Size(406, 49);
            this.gpDescribeSrv.TabIndex = 3;
            this.gpDescribeSrv.TabStop = false;
            this.gpDescribeSrv.Text = "Mô tả";
            // 
            // lbDescribeSrv
            // 
            this.lbDescribeSrv.AutoSize = true;
            this.lbDescribeSrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDescribeSrv.Location = new System.Drawing.Point(6, 16);
            this.lbDescribeSrv.Name = "lbDescribeSrv";
            this.lbDescribeSrv.Size = new System.Drawing.Size(0, 15);
            this.lbDescribeSrv.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bạn hãy chọn những dịch vụ cần tối ưu:";
            // 
            // lst_Services
            // 
            this.lst_Services.CheckBoxes = true;
            this.lst_Services.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lst_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lst_Services.FullRowSelect = true;
            this.lst_Services.GridLines = true;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.StateImageIndex = 0;
            this.lst_Services.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17});
            this.lst_Services.Location = new System.Drawing.Point(9, 33);
            this.lst_Services.Name = "lst_Services";
            this.lst_Services.Size = new System.Drawing.Size(406, 180);
            this.lst_Services.SmallImageList = this.imageList;
            this.lst_Services.TabIndex = 0;
            this.lst_Services.UseCompatibleStateImageBehavior = false;
            this.lst_Services.View = System.Windows.Forms.View.Details;
            this.lst_Services.SelectedIndexChanged += new System.EventHandler(this.lst_Services_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên dịch vụ";
            this.columnHeader3.Width = 272;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kiểu khởi động";
            this.columnHeader4.Width = 108;
            // 
            // SysTweaks_Tab
            // 
            this.SysTweaks_Tab.Controls.Add(this.cbxDisableSysRestore);
            this.SysTweaks_Tab.Controls.Add(this.cbxDisableCDBurning);
            this.SysTweaks_Tab.Controls.Add(this.cbxTurnOffSysFailture);
            this.SysTweaks_Tab.Controls.Add(this.cbxDisableHibernate);
            this.SysTweaks_Tab.Controls.Add(this.cbxRemoveShorcutToText);
            this.SysTweaks_Tab.Controls.Add(this.cbxDisableUAC);
            this.SysTweaks_Tab.Location = new System.Drawing.Point(4, 22);
            this.SysTweaks_Tab.Name = "SysTweaks_Tab";
            this.SysTweaks_Tab.Size = new System.Drawing.Size(421, 316);
            this.SysTweaks_Tab.TabIndex = 2;
            this.SysTweaks_Tab.Text = "Tinh chỉnh";
            this.SysTweaks_Tab.UseVisualStyleBackColor = true;
            // 
            // cbxDisableSysRestore
            // 
            this.cbxDisableSysRestore.AutoSize = true;
            this.cbxDisableSysRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxDisableSysRestore.Location = new System.Drawing.Point(14, 16);
            this.cbxDisableSysRestore.Name = "cbxDisableSysRestore";
            this.cbxDisableSysRestore.Size = new System.Drawing.Size(180, 19);
            this.cbxDisableSysRestore.TabIndex = 0;
            this.cbxDisableSysRestore.Text = "Vô hiệu hóa System Restore";
            this.cbxDisableSysRestore.UseVisualStyleBackColor = true;
            this.cbxDisableSysRestore.CheckedChanged += new System.EventHandler(this.cbxDisableSysRestore_CheckedChanged_1);
            // 
            // cbxDisableCDBurning
            // 
            this.cbxDisableCDBurning.AutoSize = true;
            this.cbxDisableCDBurning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxDisableCDBurning.Location = new System.Drawing.Point(14, 39);
            this.cbxDisableCDBurning.Name = "cbxDisableCDBurning";
            this.cbxDisableCDBurning.Size = new System.Drawing.Size(208, 19);
            this.cbxDisableCDBurning.TabIndex = 1;
            this.cbxDisableCDBurning.Text = "Vô hiệu hóa CD Burning Features";
            this.cbxDisableCDBurning.UseVisualStyleBackColor = true;
            this.cbxDisableCDBurning.CheckedChanged += new System.EventHandler(this.cbxDisableCDBurning_CheckedChanged_1);
            // 
            // cbxTurnOffSysFailture
            // 
            this.cbxTurnOffSysFailture.AutoSize = true;
            this.cbxTurnOffSysFailture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxTurnOffSysFailture.Location = new System.Drawing.Point(14, 135);
            this.cbxTurnOffSysFailture.Name = "cbxTurnOffSysFailture";
            this.cbxTurnOffSysFailture.Size = new System.Drawing.Size(228, 19);
            this.cbxTurnOffSysFailture.TabIndex = 5;
            this.cbxTurnOffSysFailture.Text = "Tắt tự khởi động lại khi hệ thống bị lỗi";
            this.cbxTurnOffSysFailture.UseVisualStyleBackColor = true;
            this.cbxTurnOffSysFailture.CheckedChanged += new System.EventHandler(this.cbxTurnOffSysFailture_CheckedChanged_1);
            // 
            // cbxDisableHibernate
            // 
            this.cbxDisableHibernate.AutoSize = true;
            this.cbxDisableHibernate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxDisableHibernate.Location = new System.Drawing.Point(14, 62);
            this.cbxDisableHibernate.Name = "cbxDisableHibernate";
            this.cbxDisableHibernate.Size = new System.Drawing.Size(148, 19);
            this.cbxDisableHibernate.TabIndex = 2;
            this.cbxDisableHibernate.Text = "Vô hiệu hóa Hibernate";
            this.cbxDisableHibernate.UseVisualStyleBackColor = true;
            this.cbxDisableHibernate.CheckedChanged += new System.EventHandler(this.cbxDisableHibernate_CheckedChanged_1);
            // 
            // cbxRemoveShorcutToText
            // 
            this.cbxRemoveShorcutToText.AutoSize = true;
            this.cbxRemoveShorcutToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxRemoveShorcutToText.Location = new System.Drawing.Point(14, 110);
            this.cbxRemoveShorcutToText.Name = "cbxRemoveShorcutToText";
            this.cbxRemoveShorcutToText.Size = new System.Drawing.Size(204, 19);
            this.cbxRemoveShorcutToText.TabIndex = 4;
            this.cbxRemoveShorcutToText.Text = "Xóa \"Shortcut to\" khi tạo Shortcut";
            this.cbxRemoveShorcutToText.UseVisualStyleBackColor = true;
            this.cbxRemoveShorcutToText.CheckedChanged += new System.EventHandler(this.cbxRemoveShorcutToText_CheckedChanged_1);
            // 
            // cbxDisableUAC
            // 
            this.cbxDisableUAC.AutoSize = true;
            this.cbxDisableUAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxDisableUAC.Location = new System.Drawing.Point(14, 87);
            this.cbxDisableUAC.Name = "cbxDisableUAC";
            this.cbxDisableUAC.Size = new System.Drawing.Size(203, 19);
            this.cbxDisableUAC.TabIndex = 3;
            this.cbxDisableUAC.Text = "Vô hiệu hóa User Access Control";
            this.cbxDisableUAC.UseVisualStyleBackColor = true;
            this.cbxDisableUAC.CheckedChanged += new System.EventHandler(this.cbxDisableUAC_CheckedChanged_1);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemMenuStrip});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(452, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menu";
            // 
            // SystemMenuStrip
            // 
            this.SystemMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.SystemMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SystemMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Infomation_MenuItem,
            this.Exit_MenuItem});
            this.SystemMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SystemMenuStrip.Name = "SystemMenuStrip";
            this.SystemMenuStrip.Size = new System.Drawing.Size(69, 20);
            this.SystemMenuStrip.Text = "Hệ thống";
            // 
            // Infomation_MenuItem
            // 
            this.Infomation_MenuItem.Image = global::Windows_Booster.Properties.Resources.information;
            this.Infomation_MenuItem.Name = "Infomation_MenuItem";
            this.Infomation_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Infomation_MenuItem.Size = new System.Drawing.Size(168, 22);
            this.Infomation_MenuItem.Text = "Thông tin";
            this.Infomation_MenuItem.Click += new System.EventHandler(this.Infomation_MenuItem_Click);
            // 
            // Exit_MenuItem
            // 
            this.Exit_MenuItem.Image = global::Windows_Booster.Properties.Resources.exit;
            this.Exit_MenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.Exit_MenuItem.Name = "Exit_MenuItem";
            this.Exit_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Exit_MenuItem.Size = new System.Drawing.Size(168, 22);
            this.Exit_MenuItem.Text = "Thoát";
            this.Exit_MenuItem.Click += new System.EventHandler(this.Exit_MenuItem_Click);
            // 
            // btnToiUu
            // 
            this.btnToiUu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnToiUu.Location = new System.Drawing.Point(192, 375);
            this.btnToiUu.Name = "btnToiUu";
            this.btnToiUu.Size = new System.Drawing.Size(127, 25);
            this.btnToiUu.TabIndex = 6;
            this.btnToiUu.Text = "Tối ưu";
            this.btnToiUu.UseVisualStyleBackColor = true;
            this.btnToiUu.Click += new System.EventHandler(this.btnToiUu_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(325, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWinBooster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(452, 412);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToiUu);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmWinBooster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Booster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWinBooster_FormClosed);
            this.Load += new System.EventHandler(this.frmWinBooster_Load);
            this.Tab.ResumeLayout(false);
            this.SysCleanup_Tab.ResumeLayout(false);
            this.SysCleanup_Tab.PerformLayout();
            this.gp_MoTa.ResumeLayout(false);
            this.gp_MoTa.PerformLayout();
            this.SysSrv_Tab.ResumeLayout(false);
            this.SysSrv_Tab.PerformLayout();
            this.gpDescribeSrv.ResumeLayout(false);
            this.gpDescribeSrv.PerformLayout();
            this.SysTweaks_Tab.ResumeLayout(false);
            this.SysTweaks_Tab.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage SysCleanup_Tab;
        private System.Windows.Forms.ListView lst_SystemCleanup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lb_Banhaychonnhungmuccanxoa;
        private System.Windows.Forms.TabPage SysTweaks_Tab;
        private System.Windows.Forms.GroupBox gp_MoTa;
        private System.Windows.Forms.Button btnSelectAll_Services;
        private System.Windows.Forms.GroupBox gpDescribeSrv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lst_Services;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lb_tdl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SystemMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Infomation_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_MenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_MoTaDonDep;
        private System.Windows.Forms.Button btnToiUu;
        private System.Windows.Forms.Label lbDescribeSrv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnSelectAll_SysCleanup;
        private System.Windows.Forms.CheckBox cbxDisableSysRestore;
        private System.Windows.Forms.CheckBox cbxDisableCDBurning;
        private System.Windows.Forms.CheckBox cbxTurnOffSysFailture;
        private System.Windows.Forms.CheckBox cbxDisableHibernate;
        private System.Windows.Forms.CheckBox cbxRemoveShorcutToText;
        private System.Windows.Forms.CheckBox cbxDisableUAC;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lbTotalSize;
        private System.Windows.Forms.TabPage SysSrv_Tab;
    }
}