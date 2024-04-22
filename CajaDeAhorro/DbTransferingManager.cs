using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaDeAhorro
{
    internal class DbTransferingManager
    {
        public static void ImportingDBFromCloud()
        {
            string fileName = string.Empty;
            string destFile = string.Empty;
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string shortName = userName.Substring(userName.IndexOf('\\') + 1);
            string sourcePath = "c:\\Users\\" + shortName + "\\OneDrive\\caja_ahorro_bd_copy";
            string targetPath = "c:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEDU\\MSSQL\\DATA\\Wallet";
 
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist. 
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
        }

        public static void ExportingDBToCloud()
        {
            
            string fileName = string.Empty;
            string destFile = string.Empty;
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string shortName = userName.Substring(userName.IndexOf('\\') + 1);
            string sourcePath = "c:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEDU\\MSSQL\\DATA\\Wallet";
            string targetPath = "c:\\Users\\" + shortName + "\\OneDrive\\caja_ahorro_bd_copy";

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist. 
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
        }
    }
}
