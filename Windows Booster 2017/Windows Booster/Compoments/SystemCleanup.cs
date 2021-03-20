using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using Shell32;
using System.Windows.Forms;
using System.ComponentModel;


namespace Windows_Booster.Compoments
{
    class SystemCleanup:Security
    {
        #region Properties
        //================Empty Recycle Bin========================//
        enum RecycleFlags : uint
        {
            SHRB_NOCONFIRMATION = 0x00000001,
            SHRB_NOPROGRESSUI = 0x00000002,
            SHRB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        //================Empty Recycle Bin========================//

        private static string getOS = SystemInfo.getOSName();
        private static string TempFolder = Environment.ExpandEnvironmentVariables("%TEMP%");
        private static string Temporary_Internet_Files_Win7 = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Local\\Microsoft\\Windows\\Temporary Internet Files\\Content.IE5");
        private static string Temporary_Internet_Files_Win10 = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE");
        private static string TempWindows = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%\\Temp");
        private static string Prefetch = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%\\Prefetch");
        private static string Recent = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\Microsoft\\Windows\\Recent");
        private static string Cookies = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
        private static string InternetHistory = Environment.GetFolderPath(Environment.SpecialFolder.History);
        private static string WinErrorReproting = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Local\\Microsoft\\Windows\\WER");
        public List<double> list_size_of_data = new List<double>();
      
        public class RecycleBin
        {
            public static double GetSizeItemsInRecycleBin(FolderItem folderItem)
             {
                 if (!folderItem.IsFolder)
                     return (double)folderItem.Size;
                 Folder folder = (Folder)folderItem.GetFolder;
                 double size = 0;
                 foreach (FolderItem2 f in folder.Items())
                     size += GetSizeItemsInRecycleBin(f);
                 return size;
             }
            public static double GetSizeRecycleBin()
            {
                double size = 0;
                try
                {
                    Shell shell = new Shell();
                    Folder recycleBin = shell.NameSpace(10);
                    foreach (FolderItem2 f in recycleBin.Items())
                        size += RecycleBin.GetSizeItemsInRecycleBin(f);
                    Marshal.FinalReleaseComObject(shell);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Error accessing the Recycle Bin: {0}", ex.Message));
                }
                return size;
            }
        }
        #endregion

        public SystemCleanup() { }

        //=====================CLEAN DATA=====================//
        public void EmptyContentOfDirectory(string DirName)
        {
            DirectoryInfo dir = new DirectoryInfo(DirName);
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
            foreach (DirectoryInfo folder in dir.GetDirectories())
            {
                try
                {
                    folder.Delete(true);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
        }
        public void EmptyRecycleBin()
        {
            try
            {
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
        //=====================CLEAN DATA=====================//


        //===================GET SIZE OF DATA===================//    
        public double GetSizeOfDirectory(string DirectoryName)
        {
            string[] a = Directory.GetFiles(DirectoryName);
            double size = 0;
            foreach (string name in a)
            {
                FileInfo info = new FileInfo(name);
                size += info.Length;
            }
            return size;
        }
        public double GetSize_TempFolder()
        {
            double size = 0;
            foreach (var items in Directory.GetDirectories(TempFolder))
                size += GetSizeOfDirectory(items);
            size += GetSizeOfDirectory(TempFolder);
            return size;
        }
        public double GetSize_TmpInternetFiles()
        {
            double size = 0;
            try
            {
                if (getOS.Contains("Windows 7"))
                {
                    foreach (var folder in Directory.GetDirectories(Temporary_Internet_Files_Win7))
                        size += GetSizeOfDirectory(folder);
                    size += GetSizeOfDirectory(Temporary_Internet_Files_Win7);
                }
                else if (getOS.Contains("Windows 10"))
                {
                    foreach (var folder in Directory.GetDirectories(Temporary_Internet_Files_Win10))
                        size += GetSizeOfDirectory(folder);
                    size += GetSizeOfDirectory(Temporary_Internet_Files_Win10);
                }
            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
            }
            return size;
        }
        public double GetSize_TempWindows()
        {
            double size = 0;
            foreach (var folder in Directory.GetDirectories(TempWindows))
                size += GetSizeOfDirectory(folder);
            size += GetSizeOfDirectory(TempWindows);
            return size;
        }
        public double GetSize_PrefetchData()
        {
            double size = 0;
            foreach (var folder in Directory.GetDirectories(Prefetch))
                size += GetSizeOfDirectory(folder);
            size += GetSizeOfDirectory(Prefetch);
            return size;
        }
        public double GetSize_RecentItems()
        {
            double size = 0;
            foreach (var folder in Directory.GetDirectories(Recent))
                size += GetSizeOfDirectory(folder);
            size += GetSizeOfDirectory(Recent);
            return size;
        }
        public double GetSize_Cookies()
        {
            double size = 0;
            foreach (var folder in Directory.GetDirectories(Recent))
                size += GetSizeOfDirectory(folder);
            size += GetSizeOfDirectory(Cookies);
            return size;
        }
        public double GetSize_InternetHistory()
        {
            double size = 0;
            foreach (var folder in Directory.GetDirectories(InternetHistory))
                size += GetSizeOfDirectory(folder);
            size += GetSizeOfDirectory(InternetHistory);
            return size;
        }
        public double GetSize_WinError()
        {
            Security.SetAttributesToNormal(WinErrorReproting);
            double size = 0;
            foreach (var folder in Directory.GetDirectories(WinErrorReproting))
                size += GetSizeOfDirectory(folder);
            size += GetSizeOfDirectory(WinErrorReproting);
            return size;
        }        
        public double GetSize_RecycleBin()
        {
            double size = 0;
            size = RecycleBin.GetSizeRecycleBin();
            return size;
        }
        public void Analyze()
        {
            list_size_of_data.Add(GetSize_TempFolder());
            list_size_of_data.Add(GetSize_TmpInternetFiles());
            list_size_of_data.Add(GetSize_TempWindows());
            list_size_of_data.Add(GetSize_PrefetchData());
            list_size_of_data.Add(GetSize_RecentItems());
            list_size_of_data.Add(GetSize_Cookies());
            list_size_of_data.Add(GetSize_InternetHistory());
            list_size_of_data.Add(GetSize_WinError());
            list_size_of_data.Add(RecycleBin.GetSizeRecycleBin());
        }
        public string GetTotalSize()
        {
            string str = string.Empty;
            double result = 0;
            for (int i = 0; i < list_size_of_data.Count; i++)
                result += list_size_of_data[i];
            str = Return_Unit_of_Size(result).ToString();
            return str;
        }
        //===================GET SIZE OF DATA===================//

        public string Return_Unit_of_Size(double n)
        {
            string str = string.Empty;
            string[] suffix = { "Bytes", "KB", "MB", "GB", "TB" };
            int idx = 0;
            do
            {
                n /= 1024;
                idx++;
            } while (n >= 1024);
            str = String.Format("{0:0.00} {1}", n, suffix[idx]);
            return str;
        }
        public void SetSize(ref ListView lst)
        {
            Analyze();
            int i = 0;
            while(i < lst.Items.Count)
            {
                lst.Items[i].SubItems[1].Text = Return_Unit_of_Size(list_size_of_data[i]).ToString();
                i++;
            }
        }
        public string GetDescribe(ListView lst)
        {
            string describe = string.Empty;
            int index = lst.FocusedItem.Index;
            switch (index)
            {
                case 0:
                    describe = "Đây là nơi lưu trữ các thư mục hoặc tập tin tạm của các chương trình sử dụng trên\nWindows.";
                    break;
                case 1:
                    describe = "Đây là nơi lưu trữ bộ nhớ đệm trình duyệt. Nó cho phép truy cập nhanh hơn vào lần\ntruy cập tiếp theo.";
                    break;
                case 2:
                    describe = "Đây là nơi lưu trữ các tập tin tạm của hệ thống.";
                    break;
                case 3:
                    describe = "Đây là thư mục truy xuất nhanh chứa các shortcut của các chương trình được sử\ndụng trong hệ thống.";
                    break;
                case 4:
                    describe = "Đây là nơi để giúp bạn biết được các tập tin mà bạn đã mở gần đây.";
                    break;
                case 5:
                    describe = "Đây là nơi lưu trữ các thông tin duyệt web của bạn.";
                    break;
                case 6:
                    describe = "Đây là nơi lưu trữ các lịch sử truy cập Website.";
                    break;
                case 7:
                    describe = "Đây là nơi chứa các bản ghi lỗi hệ thống.";
                    break;
                case 8:
                    describe = "Đây là nơi chứa các tập tin hoặc thư mục đã bị xóa.";
                    break;
            }
            return describe;
        }
        public void ExcuteCleanup(ListView lst)
        {
            foreach (ListViewItem items in lst.CheckedItems)
            {
                int index = items.Index;
                switch (index)
                {
                    case 0:
                        EmptyContentOfDirectory(TempFolder);
                        break;
                    case 1:
                        if (getOS.Contains("Windows 7"))
                            EmptyContentOfDirectory(Temporary_Internet_Files_Win7);
                        else if (getOS.Contains("Windows 10"))
                            EmptyContentOfDirectory(Temporary_Internet_Files_Win10);
                        break;
                    case 2:
                        EmptyContentOfDirectory(TempWindows); 
                        break;
                    case 3:
                        EmptyContentOfDirectory(Prefetch); 
                        break;
                    case 4:
                        EmptyContentOfDirectory(Recent); 
                        break;
                    case 5:
                        EmptyContentOfDirectory(Cookies); 
                        break;
                    case 6:
                        EmptyContentOfDirectory(InternetHistory); 
                        break;
                    case 7:
                        EmptyContentOfDirectory(WinErrorReproting);
                        break;
                    case 8:
                        EmptyRecycleBin(); 
                        break;
                }
            }
            list_size_of_data.Clear();
        }
        public void Free()
        {
            getOS = null;
            TempFolder = null;
            Temporary_Internet_Files_Win7 = null;
            Temporary_Internet_Files_Win10 = null;
            Prefetch = null;
            TempWindows = null;
            Recent = null;
            Cookies = null;
            InternetHistory = null;
            WinErrorReproting = null;
            list_size_of_data = null;
        }
    }
}