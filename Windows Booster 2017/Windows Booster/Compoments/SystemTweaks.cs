using System;
using System.Collections.Generic;

using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Diagnostics;

namespace Windows_Booster.Compoments
{
    class SystemTweaks
    {
        private static RegistryKey key;
        public List<int> list_index_of_checkbox = new List<int>();
        public static void DisableSystemRestore()
        {
            key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore", true);
            if (key == null)
                key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore");
            try
            {
                key.SetValue("DisableSR", 00000001, RegistryValueKind.DWord);
            }
            catch
            {
                MessageBox.Show("Không thể vô hiệu hóa System Restore!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            key.Close();
        }
        public static void DisableCDBurningDFeatures()
        {
            key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
            if (key == null)
                key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            key.SetValue("NoCDBurning", 00000001, RegistryValueKind.DWord);
            key.Close();
        }
        public static void DisableHibernate()
        {
            key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power", true);
            if (key == null)
                key = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power");
            try
            {
                key.SetValue("HibernateEnabled", 0000000, RegistryValueKind.DWord);
            }
            catch
            {
                MessageBox.Show("Không thể vô hiệu hóa Hibernate!", "Windows Booster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            key.Close();
        }
        public static void DisableUAC()
        {
            key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            if (key == null)
                key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            try
            {
                key.SetValue("EnableLUA", 00000000, RegistryValueKind.DWord);
            }
            catch
            {
                MessageBox.Show("Không thể vô hiệu hóa UAC!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            key.Close();
        }
        public static void TurnOff_ShorcutTo()
        {
            key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", true);
            if (key == null)
                Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer");
            try
            {
                key.SetValue("link", new byte[] {00,00,00,00 }, RegistryValueKind.Binary);
            }
            catch
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Turn_Off_SysFaiture()
        {
            key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\CrashControl",true);
            if (key == null)
                key = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\CrashControl");
            key.SetValue("AutoReboot", 0000, RegistryValueKind.DWord);
            key.Close();
        }
        public void RestartExplorer()
        {
            Process.Start("cmd.exe", "/c taskkill /f /im explorer.exe");
            System.Threading.Thread.Sleep(1000);
            Process.Start("cmd.exe", "/c start explorer.exe");
        }

        public void ExcuteTweaks()
        {
            int i = 0;
            while (i < list_index_of_checkbox.Count)
            {
                int index = list_index_of_checkbox[i];
                switch (index)
                {
                    case 0:
                        DisableSystemRestore();
                        break;
                    case 1:
                        DisableCDBurningDFeatures();
                        break;
                    case 2:
                        DisableHibernate();
                        break;
                    case 3:
                        DisableUAC();
                        break;
                    case 4:
                        TurnOff_ShorcutTo();
                        break;
                    case 5:
                        Turn_Off_SysFaiture(); break;
                }
                i++;
            }
            RestartExplorer();
        }

        public void Free()
        {
            key = null;
            list_index_of_checkbox = null;
        }
    }
}
