using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Principal;
using System.Security.AccessControl;

namespace Windows_Booster.Compoments
{
    class Security
    {
        public static void SetFolderPermission(string folderPath)
        {
            var directoryInfo = new DirectoryInfo(folderPath);
            var directorySecurity = directoryInfo.GetAccessControl();
            var currentUserIdentity = WindowsIdentity.GetCurrent();
            var fileSystemRule = new FileSystemAccessRule(currentUserIdentity.Name,
                                                        FileSystemRights.FullControl,
                                                        InheritanceFlags.ObjectInherit |
                                                        InheritanceFlags.ContainerInherit,
                                                        PropagationFlags.None,
                                                        AccessControlType.Allow);
            directorySecurity.AddAccessRule(fileSystemRule);
            directoryInfo.SetAccessControl(directorySecurity);
        }
        public static void SetAttributesToNormal(string path)
        {
            FileAttributes file_attributes = File.GetAttributes(path);
            if (file_attributes == FileAttributes.ReadOnly)
            {
                file_attributes = FileAttributes.Normal;
                File.SetAttributes(path, file_attributes);
            }
        }
    }
}
