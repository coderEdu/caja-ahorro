﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaDeAhorro
{
    public partial class Form1 : Form
    {
        //public bool RefrescarCaja { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lbl_dios_desmolde.Visible = true;
            ConnectToDB();

            // ********************* some test lines ***************

            //lbl_dios_desmolde.Text = "ISMA - EL DIOS DEL DESMOLDE"; //**** este texto tenía originalmente ****
            DateTime dT;
            dT = DateTime.Now;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.Enabled = true;
        }

        private void ConnectToDB()      // modificar todo este método
        {
            // código nuevo 24/6/2021 - desde el nuevo dataset
            this.loginTableAdapter1.FillByIdLogged(this.c_AHORRO_NEW_DS1.login, Auxiliar.id_logged);
            // capturo el nombre del usuario logueado y lo adjunto al texto del lbl_dios_desmolde
            Auxiliar.LoggUserName = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<string>(1).ToString();
            Auxiliar.LoggUserName = Auxiliar.LoggUserName.Replace(" ", "");   // quito los espacios en blanco del final
            lbl_dios_desmolde.Text = "usuario activo = [ " + Auxiliar.LoggUserName + " ]";

            // capturo el valor caja del row del usuario logueado
            this.lbl_caja_valor.Text = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3).ToString();
            // capturo el nombre del usuario logueado y lo adjunto al texto del form
            //this.Text = "  CAJA DE AHORRO - USUARIO ACTIVO = " + this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<string>(1).ToString();
            // capturo el valor de caja del usuario activo
            this.lbl_caja_valor.Text = "$" + IfItHasAPointWithParam(this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3).ToString());
            // capturo el valor de caja del usuario activo y lo guardo en Auxiliar
            Auxiliar.dineroEnCaja = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(3);
        }

        public static String IfItHasAPointWithParam(String caja)
        {
            double s = double.Parse(caja);
            return String.Format("{0:N2}", s);
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            MostrarVentTrans(sender);
        }

        private void btn_extraccion_Click(object sender, EventArgs e)
        {
            MostrarVentTrans(sender);
        }

        public void MostrarVentTrans(object sender)
        {
            Transaccion transaccion = new Transaccion();
            Button button = (Button)sender;
            if (button.Equals(btn_deposito))
                transaccion.Text = "Realizar un depósito";
            else
                transaccion.Text = "Realizar una extracción";
            transaccion.ShowDialog();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //this.Refresh();
            //ConnectToDB();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.LoggedUserName = Auxiliar.LoggUserName;
            log.ShowDialog();
        }

        private void btn_sesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auxiliar.login.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Auxiliar.form1.Hide();
            Auxiliar.login.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ConnectToDB();
        }
    }
}
