using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CajaDeAhorro
{
    internal class FileManager
    {
        public static string ReadFile(string filename)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string shortName = userName.Substring(userName.IndexOf('\\') + 1);
            string filePath = "c:\\Users\\" + shortName + "\\WalletDbState\\" + filename;
            string fileContent = "";
            StreamReader file;

            try
            {
                int counter = 0;
                string line;
                file = new StreamReader(filePath);

                while ((line = file.ReadLine()) != null)
                {
                    fileContent = line;
                    counter++;
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return fileContent;
        }

        public static void WriteFile(string filename, string text)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string shortName = userName.Substring(userName.IndexOf('\\') + 1);
            string filePath = "c:\\Users\\" + shortName + "\\WalletDbState\\" + filename;

            try
            {
                // Writes specified text on the specified file.
                //using (StreamWriter sw = File.CreateText(filePath))
                //{
                //    sw.WriteLine(text);
                //}
                StreamWriter sw = File.CreateText(filePath);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception e) { Console.Write(e); }
        }
    }
}
