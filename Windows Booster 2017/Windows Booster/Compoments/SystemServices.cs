using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Windows_Booster.Compoments
{
    class SystemServices
    {
        //===========================================Windows 7===========================================
        //Bluetooth Support Service: bthserv
        //Computer Browser: Browser
        //Fax: Fax
        //Smart card: SCardSvr
        //Tablet PC Input Service: TabletInputService	
        //Offline Files: CscService
        //Parental Control: WPCSvc	
        //Remote Registry: RemoteRegistry
        //Windows Defender: WinDefend
        //WER: WerSvc
        //Windows Time: W32Time

        //===========================================Windows 10===========================================
        //Bluetooth Support Service: bthserv
        //Computer Browser: Browser
        //Fax: Fax
        //Smart card: SCardSvr
        //Offline Files: CscService
        //Remote Registry: RemoteRegistry
        //WER: WerSvc
        //Windows Time: W32Time
        //===========================================Windows 10===========================================

        //private static List<string> svc_name_Win7 = new List<string>() { "bthserv", "Browser", "Fax", "SCardSvr", "TabletInputService", "CscService", "WPCSvc", "RemoteRegistry", "WinDefend", "WerSvc", "W32Time" };
        //string[] lst_win7 = { "Bluetooth Support Service", "Computer Browser", "Fax", "Smart Card", "Tablet PC Input Service", "Offline Files", "Parental Control", "Remote Registry", "Windows Defender", "Windows Error Reporting", "Windows Time" };
        private static List<string> svc_name_Win = new List<string>() { "bthserv", "Browser", "Fax", "SCardSvr", "CscService", "RemoteRegistry", "WerSvc", "W32Time" };
        string[] lst_win = { "Bluetooth Support Service", "Computer Browser", "Fax", "Smart Card", "Offline Files", "Remote Registry", "Windows Error Reporting", "Windows Time" };
       

        public string Get_Describe_Of_Service(ListView lst)
        {
            string str = string.Empty;
            int index = lst.FocusedItem.Index;
            switch (index)
            {
                case 0:
                    str = "Dùng để kết nối Bluetooth.";
                    break;
                case 1:
                    str = "Theo dõi những máy tính kết nối vào máy bạn thông qua mạng chia sẻ.";
                    break;
                case 2:
                    str = "Hỗ trợ gửi và nhận Fax.";
                    break;
                case 3:
                    str = "Dùng để quản lý và đọc thẻ thông minh từ máy tính.";
                    break;
                case 4:
                    str = "Dùng để truy cập các tập tin được lưu trên mạng ngay cả khi offiline.";
                    break;
                case 5:
                    str = "Điều khiển Registry từ xa.";
                    break;
                case 6:
                    str = "Dùng để báo lỗi cho Microsoft và nhận sửa chữa tự động.";
                    break;
                case 7:
                    str = "Dùng để đồng bộ thời gian khi có kết nối Internet.";
                    break;
            }
            return str;
        }
        public void GetStartup_Type_SVC_Win(ref ListView lst)
        {
            RegistryKey key = null;
            int start = 0;
            
            for (int i = 0; i < lst_win.Length; i++)
            {
                key = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\" + svc_name_Win[i], false);
                start = int.Parse(key.GetValue("Start", null).ToString());
                switch (start)
                {
                    case 2:
                        lst.Items[i].SubItems[1].Text = "Automatic";
                        break;
                    case 3:
                        lst.Items[i].SubItems[1].Text = "Manual";
                        break;
                    case 4:
                        lst.Items[i].SubItems[1].Text = "Disabled";
                        break;
                } 
            }
        }
        public void DisableSvc(string name)
        {
            Process.Start("sc.exe", "stop " + name);
            Process.Start("sc.exe", " config " + name + " start= disabled");
        }
        public static void DisableSvc(int index)
        {
            Process.Start("sc.exe", "stop " + svc_name_Win[index]);
            Process.Start("sc.exe", " config " + svc_name_Win[index] + " start= disabled");
        }
        public void Excute_DisableSvc(ListView lst)
        {
            foreach (ListViewItem item in lst.CheckedItems)
            {
                if (lst.Items[item.Index].SubItems[1].Text != "Disabled")
                {
                    switch (item.Index)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                            DisableSvc(item.Index);
                            break;
                    }
                }
            }
        }

        public void Free()
        {
            svc_name_Win = null;
            lst_win = null;
        }
    }
}
