using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CajaDeAhorro
{
    enum WaysToLog
    {
        BY_PASS,
        BY_LOGIN
    }
    class Auxiliar
    {
        public static int dineroEnCaja;
        public static int id_logged;
        public static int id_note;
        public static int id_note_to_delete;
        public static string LoggUserName;
        public static Form form1;
        public static Form login;
        public static Form admin;
        public static Dictionary<int, string> dic = new Dictionary<int, string>();
        
        public static int getDineroEnCaja()
        {
            return dineroEnCaja;
        }

        public static string getAppName()
        {
            return "CAJA DE AHORRO -";
        }

        public static string getTextCorrective()
        {
            return "*/ Este texto se crea automáticamente cada vez que usted realiza un depósito o una extracción en modo correctivo mediante el código < $correctivo > /*";
        }
    }
}
