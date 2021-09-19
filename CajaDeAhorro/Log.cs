﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaDeAhorro
{
    public partial class Log : Form
    {
        public string LoggedUserName { get; set; }
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            // code for test
            //  DateTime dtE = this.dtp_hasta.Value;
            //  string sfecha_time2 = dtE.Day.ToString() + "/" + dtE.Month.ToString() + "/" + dtE.Year.ToString() + " 23:59:59";   // dd/mm/yyyy
            //  MessageBox.Show(sfecha_time2);
            // ends code for test
            // TODO: This line of code loads data into the 'cAJA_AHORRODataSet.movi' table. You can move, or remove it, as needed.
            this.Text += " del usuario [ " + LoggedUserName + " ]";
            this.lbl_exacta.Enabled = false;
            this.lbl_desde.Enabled = false;
            this.lbl_hasta.Enabled = false;
            this.lbl_total.Visible = false;
            DisOrEnablingPickers(false);
            this.grp_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(255))))); // 217, 230, 255 // 241, 246, 255
            try
            {
                this.moviTableAdapter1.FillByLoggedAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged);
            }
            catch (Exception)
            {

            }

            this.lbl_trans_finds.Visible = false;
            AjustarCamposDGV();
        }

        public void AjustarCamposDGV()
        {
            if (this.c_AHORRO_NEW_DS1.movi.Rows.Count > 9)
            {
                this.dgv.Columns[0].Width = 282;      // 3 -
                this.dgv.Columns[1].Width = 99-5;     // 6 4 1
                this.dgv.Columns[2].Width = 97-10;    // 6 8 2
            }
            else
            {
                this.dgv.Columns[0].Width = 282;
                this.dgv.Columns[1].Width = 99;
                this.dgv.Columns[2].Width = 97;
            }
        }

        public string TransEncontr(int exp)
        {
            string mensaje="";
            if (exp==1)
                mensaje= "[" + exp + "]  transacción encontrada.";
            else
                mensaje = "[" + exp + "]  transacciones encontradas.";
            return mensaje;
        }

        public string SumarMonto()
        {
            int suma=0, rows=this.c_AHORRO_NEW_DS1.movi.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                suma += Convert.ToInt32(this.c_AHORRO_NEW_DS1.movi.Rows[i].Field<int>("monto").ToString());
            }
            return "Total:  $" + String.Format("{0:N2}",suma);
        }

        public bool NoVacioYMayorQueCero()
        {
            return this.txt_monto.TextLength > 0 && Convert.ToInt32(Monto()) > 0;
        }

        public int Monto()
        {
            return Convert.ToInt32(this.txt_monto.Text);
        }

        public void MostrarSumatoriaMonto()
        {
            this.lbl_total.Visible = true;
            this.lbl_total.Text = SumarMonto();
        }

        private void LogicCheckFechas(DateTime dtDesde, DateTime dtHasta)   // busca en un período
        {
            if (this.cbx_tipo.SelectedItem.Equals("-- AMBOS --"))
            {
                if (NoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByFechaMontoAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, dtDesde, dtHasta, Monto());
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = TransEncontr(this.moviTableAdapter1.FillByFechaMontoAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, dtDesde, dtHasta, Monto()));
                }
                else
                {
                    this.moviTableAdapter1.FillByFechaAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, dtDesde, dtHasta);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = TransEncontr(this.moviTableAdapter1.FillByFechaAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, dtDesde, dtHasta));
                }

            }
            else if (this.cbx_tipo.SelectedItem.Equals("-- DEPOSITOS --")) // working here
            {
                if (NoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByFechaMonto(this.c_AHORRO_NEW_DS1.movi, "deposito", dtDesde, dtHasta, Auxiliar.id_logged, Monto());
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFechaMonto(this.c_AHORRO_NEW_DS1.movi, "deposito", dtDesde, dtHasta, Auxiliar.id_logged, Monto()));
                    MostrarSumatoriaMonto();
                }
                else
                {
                    this.moviTableAdapter1.FillByFecha(this.c_AHORRO_NEW_DS1.movi, "deposito", dtDesde, dtHasta, Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFecha(this.c_AHORRO_NEW_DS1.movi, "deposito", dtDesde, dtHasta, Auxiliar.id_logged));
                    MostrarSumatoriaMonto();
                }
            }
            else
            {
                if (NoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByFechaMonto(this.c_AHORRO_NEW_DS1.movi, "extracción", dtDesde, dtHasta, Auxiliar.id_logged, Monto());
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFechaMonto(this.c_AHORRO_NEW_DS1.movi, "extracción", dtDesde, dtHasta, Auxiliar.id_logged, Monto()));
                    MostrarSumatoriaMonto();
                }
                else
                {
                    this.moviTableAdapter1.FillByFecha(this.c_AHORRO_NEW_DS1.movi, "extracción", dtDesde, dtHasta, Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFecha(this.c_AHORRO_NEW_DS1.movi, "extracción", dtDesde, dtHasta, Auxiliar.id_logged));
                    MostrarSumatoriaMonto();
                }
            }
        }

        private void LogicCheckFecha(DateTime dtExacta)     // busca en una fecha exacta
        {
            string sfecha_time1 = dtExacta.Day.ToString() + "/" + dtExacta.Month.ToString() + "/" + dtExacta.Year.ToString() + " 00:00:00"; // begin of the day
            string sfecha_time2 = dtExacta.Day.ToString() + "/" + dtExacta.Month.ToString() + "/" + dtExacta.Year.ToString() + " 23:59:59"; // finish of the day
            DateTime fecha_time1 = DateTime.Parse(sfecha_time1);
            DateTime fecha_time2 = DateTime.Parse(sfecha_time2);

            if (this.cbx_tipo.SelectedItem.Equals("-- AMBOS --"))
            {
                if (NoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByFechaExactaMontoAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, fecha_time1, fecha_time2, Monto());
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFechaExactaMontoAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, fecha_time1, fecha_time2, Monto()));
                }
                else
                {
                    this.moviTableAdapter1.FillByFechaExactaAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, fecha_time1, fecha_time2);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFechaExactaAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, fecha_time1, fecha_time2));
                }
            }
            else if (this.cbx_tipo.SelectedItem.Equals("-- DEPOSITOS --"))             // working here
            {
                if (NoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByFechaExactaMonto(this.c_AHORRO_NEW_DS1.movi, "deposito", fecha_time1, fecha_time2, Auxiliar.id_logged, Monto());
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFechaExactaMonto(this.c_AHORRO_NEW_DS1.movi, "deposito", fecha_time1, fecha_time2, Auxiliar.id_logged, Monto()));
                    MostrarSumatoriaMonto();
                }
                else
                {
                    this.moviTableAdapter1.FillByFechaExacta(this.c_AHORRO_NEW_DS1.movi, "deposito", fecha_time1, fecha_time2, Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFechaExacta(this.c_AHORRO_NEW_DS1.movi, "deposito", fecha_time1, fecha_time2, Auxiliar.id_logged));
                    MostrarSumatoriaMonto();

                }
            }
            else
            {
                if (NoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByFechaExactaMonto(this.c_AHORRO_NEW_DS1.movi, "extracción", fecha_time1, fecha_time2, Auxiliar.id_logged, Monto());
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFechaExactaMonto(this.c_AHORRO_NEW_DS1.movi, "extracción", fecha_time1, fecha_time2, Auxiliar.id_logged, Monto()));
                    MostrarSumatoriaMonto();
                }
                else
                {
                    this.moviTableAdapter1.FillByFechaExacta(this.c_AHORRO_NEW_DS1.movi, "extracción", fecha_time1, fecha_time2, Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByFechaExacta(this.c_AHORRO_NEW_DS1.movi, "extracción", fecha_time1, fecha_time2, Auxiliar.id_logged));
                    MostrarSumatoriaMonto();
                }
            }
        }

        private void LogicBuscarSinFechas()     // busca sin fechas
        {
            if (this.cbx_tipo.SelectedItem.Equals("-- AMBOS --"))
            {
                this.moviTableAdapter1.FillByLoggedAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged);
                AjustarCamposDGV();
                this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByLoggedAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged));
            }
            else if (this.cbx_tipo.SelectedItem.Equals("-- DEPOSITOS --"))
            {
                this.moviTableAdapter1.FillByLogged(this.c_AHORRO_NEW_DS1.movi, "deposito", Auxiliar.id_logged);
                AjustarCamposDGV();
                this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByLogged(this.c_AHORRO_NEW_DS1.movi, "deposito", Auxiliar.id_logged));
            }
            else
            {
                this.moviTableAdapter1.FillByLogged(this.c_AHORRO_NEW_DS1.movi, "extracción", Auxiliar.id_logged);
                AjustarCamposDGV();
                this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByLogged(this.c_AHORRO_NEW_DS1.movi, "extracción", Auxiliar.id_logged));
            }
        }

        public void FiltrarResultadosBusqueda()
        {
            DateTime dtDesde = this.dtp_desde.Value;
            DateTime dtHasta = this.dtp_hasta.Value;
            DateTime dtExacta = this.dtp_exacta.Value;
            this.lbl_trans_finds.Visible = true;

            if (!check_fechas.Checked && !check_fecha.Checked)
                LogicBuscarSinFechas();
            else if (check_fechas.Checked)
                LogicCheckFechas(dtDesde, dtHasta);
            else if (check_fecha.Checked)
                LogicCheckFecha(dtExacta);
        }

        private void btn_buscar_trans_Click(object sender, EventArgs e)
        {
            FiltrarResultadosBusqueda();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Checks_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Name== "check_fechas")
            {
                if (check.CheckState==CheckState.Checked)
                {
                    this.dtp_desde.Enabled = true;
                    this.dtp_hasta.Enabled = true;
                    this.lbl_desde.Enabled = true;
                    this.lbl_hasta.Enabled = true;
                    this.lbl_exacta.Enabled = false;
                    this.lbl_total.Visible = false;
                    grp_fechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
                    check_fecha.CheckState = CheckState.Unchecked; // 217, 230, 255 // 241, 246, 255
                    this.dtp_exacta.Enabled = false;
                    grp_fecha.BackColor = Color.White;
                }
            }
            else if (check.Name == "check_fecha")
            {
                if (check.CheckState == CheckState.Checked)
                {
                    this.dtp_exacta.Enabled = true;
                    this.lbl_exacta.Enabled = true;
                    this.lbl_desde.Enabled = false;
                    this.lbl_hasta.Enabled = false;
                    this.lbl_total.Visible = false;
                    grp_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
                    check_fechas.CheckState = CheckState.Unchecked;
                    this.dtp_desde.Enabled = false;
                    this.dtp_hasta.Enabled = false;
                    grp_fechas.BackColor = Color.White;
                }
            }

            if (!check_fechas.Checked && !check_fecha.Checked)
            {
                cbx_tipo.SelectedIndex = 0;
                grp_fechas.BackColor = Color.White;
                grp_fecha.BackColor = Color.White;
                this.lbl_exacta.Enabled = false;
                this.lbl_desde.Enabled = false;
                this.lbl_hasta.Enabled = false;
                DisOrEnablingPickers(false);
            }
        }

        private void DisOrEnablingPickers(bool state)
        {
            this.dtp_desde.Enabled = state;
            this.dtp_hasta.Enabled = state;
            this.dtp_exacta.Enabled = state;
        }

        //private void fillByMontoToolStripButton_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.moviTableAdapter1.FillByMonto(this.c_AHORRO_NEW_DS1.movi, new System.Nullable<int>(((int)(System.Convert.ChangeType(montoToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}