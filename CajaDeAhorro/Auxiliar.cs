﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CajaDeAhorro
{
    class Auxiliar
    {
        public static int dineroEnCaja;
        public static int id_logged;
        public static string LoggUserName;
        public static Form form1;
        public static Form login;
        public static Form admin;

        public static int getDineroEnCaja()
        {
            return dineroEnCaja;
        }

    }
}
