using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Windows_Booster.Compoments
{
    class SystemInfo
    {
        public string os = getOSName();

        public static string getOSName()
        {
            RegistryKey os_key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
            string os_ver = os_key.GetValue("CurrentVersion").ToString();
            return os_key.GetValue("ProductName").ToString();
        }
    }
}
