using System;
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
        double opacity = 0.6;
        public double WinOpacity { get; set; }

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
            this.Text = Auxiliar.getAppName() + "Registro de transacciones del usuario [ " + LoggedUserName + " ]";
            this.lbl_exacta.Enabled = false;
            this.lbl_desde.Enabled = false;
            this.lbl_hasta.Enabled = false;
            this.lbl_total.Visible = false;
            this.lbl_concepto.Visible = false;
            DisOrEnablingPickers(false);
            this.grp_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))); // 217, 230, 255 // 241, 246, 255 // 245, 245, 245
            try
            {
                this.moviTableAdapter1.FillByLoggedAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged);
            }
            catch (Exception)
            { }

            this.lbl_trans_finds.Visible = false;
            AjustarCamposDGV();
        }

        public void AjustarCamposDGV()
        {
            this.dgv.Columns[0].Width = 100;

            if (this.c_AHORRO_NEW_DS1.movi.Rows.Count > 10)
            {
                this.dgv.Columns[1].Width = 307;      // 3 -    282
                this.dgv.Columns[2].Width = 195;     // 6 4 1  99-5
                this.dgv.Columns[3].Width = 240;    // 6 8 2  97-10
            }
            else
            {
                this.dgv.Columns[1].Width = 310;    //282
                this.dgv.Columns[2].Width = 200;     //99
                this.dgv.Columns[3].Width = 250;     //97
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

        public bool CheckedNoVacioYMayorQueCero()  // modificado
        {
            return this.check_monto.Checked && this.txt_monto.TextLength > 0 && Convert.ToInt32(Monto()) > 0;
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

        // logica para la búsqueda por fechas
        private void LogicCheckFechas(DateTime dtDesde, DateTime dtHasta)   // busca en un período
        {
            if (this.cbx_tipo.SelectedItem.Equals("____AMBOS"))
            {
                if (CheckedNoVacioYMayorQueCero())
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
            else if (this.cbx_tipo.SelectedItem.Equals("____DEPOSITOS")) // working here
            {
                if (CheckedNoVacioYMayorQueCero())
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
                if (CheckedNoVacioYMayorQueCero())
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

            if (this.cbx_tipo.SelectedItem.Equals("____AMBOS"))
            {
                if (CheckedNoVacioYMayorQueCero())
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
            else if (this.cbx_tipo.SelectedItem.Equals("____DEPOSITOS"))             // working here
            {
                if (CheckedNoVacioYMayorQueCero())
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
                if (CheckedNoVacioYMayorQueCero())
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
            if (this.cbx_tipo.SelectedItem.Equals("____AMBOS"))
            {
                if (CheckedNoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByMontoAmbos(c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, Monto());
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByMontoAmbos(c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, Monto()));
                    MostrarSumatoriaMonto();
                }
                else if (check_busc_msg.Checked)    // working here 17/10/21 4:03 => terminated
                {
                    this.moviTableAdapter1.FillByGetTransByMsg(c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, this.txt_busc_msg.Text);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByGetTransByMsg(c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged, this.txt_busc_msg.Text));
                    MostrarSumatoriaMonto();
                }
                else
                {
                    this.moviTableAdapter1.FillByLoggedAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByLoggedAmbos(this.c_AHORRO_NEW_DS1.movi, Auxiliar.id_logged));
                    MostrarSumatoriaMonto();
                }
            }
            else if (this.cbx_tipo.SelectedItem.Equals("____DEPOSITOS")) // en esta parte tengo que agregar la búsqueda por monto
            {

                if (CheckedNoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByMontoTrans(c_AHORRO_NEW_DS1.movi, Monto(), "deposito", Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByMontoTrans(c_AHORRO_NEW_DS1.movi, Monto(), "deposito", Auxiliar.id_logged));
                    MostrarSumatoriaMonto();
                }
                else
                {
                    this.moviTableAdapter1.FillByLogged(this.c_AHORRO_NEW_DS1.movi, "deposito", Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByLogged(this.c_AHORRO_NEW_DS1.movi, "deposito", Auxiliar.id_logged));
                    MostrarSumatoriaMonto();
                }
            }
            else
            {
                if (CheckedNoVacioYMayorQueCero())
                {
                    this.moviTableAdapter1.FillByMontoTrans(c_AHORRO_NEW_DS1.movi, Monto(), "extracción", Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByMontoTrans(c_AHORRO_NEW_DS1.movi, Monto(), "extracción", Auxiliar.id_logged));
                    MostrarSumatoriaMonto();
                }
                else
                {
                    this.moviTableAdapter1.FillByLogged(this.c_AHORRO_NEW_DS1.movi, "extracción", Auxiliar.id_logged);
                    AjustarCamposDGV();
                    this.dgv.DataSource = this.c_AHORRO_NEW_DS1.movi;
                    this.lbl_trans_finds.Text = this.TransEncontr(this.moviTableAdapter1.FillByLogged(this.c_AHORRO_NEW_DS1.movi, "extracción", Auxiliar.id_logged));
                }
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
            this.lbl_concepto.Visible = false;
            FiltrarResultadosBusqueda();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Checks_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Name == "check_fechas")
            {
                if (check.CheckState==CheckState.Checked)
                {
                    this.dtp_desde.Enabled = true;
                    this.dtp_hasta.Enabled = true;
                    this.lbl_desde.Enabled = true;
                    this.lbl_hasta.Enabled = true;
                    this.lbl_exacta.Enabled = false;
                    this.lbl_total.Visible = false;
                    grp_fechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
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
                    grp_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                    check_fechas.CheckState = CheckState.Unchecked;
                    this.dtp_desde.Enabled = false;
                    this.dtp_hasta.Enabled = false;
                    grp_fechas.BackColor = Color.White;
                }
            }
            else if (check.Name == "check_monto")
            {
                if (check.CheckState == CheckState.Checked)
                {
                    grp_monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                    txt_monto.BackColor = Color.White;
                    txt_monto.Focus();
                }
                else
                {
                    grp_monto.BackColor = Color.White;
                    txt_monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                }
            }
            else if (check.Name == "check_busc_msg")
            {
                if (check.CheckState == CheckState.Checked)
                {
                    grp_busc_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                    txt_busc_msg.BackColor = Color.White;
                    txt_busc_msg.Focus();
                }
                else
                {
                    grp_busc_msg.BackColor = Color.White;
                    txt_busc_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                }
            }


            if (!check_fechas.Checked && !check_fecha.Checked)
            {
                grp_fechas.BackColor = Color.White;
                grp_fecha.BackColor = Color.White;
                this.lbl_exacta.Enabled = false;
                this.lbl_desde.Enabled = false;
                this.lbl_hasta.Enabled = false;
                DisOrEnablingPickers(false);

                if (!check_monto.Checked)
                {
                    cbx_tipo.SelectedIndex = 0;
                }
            }
        }

        private void DisOrEnablingPickers(bool state)
        {
            this.dtp_desde.Enabled = state;
            this.dtp_hasta.Enabled = state;
            this.dtp_exacta.Enabled = state;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int movi_id = Convert.ToInt32(this.dgv.CurrentRow.Cells["id"].Value);
            if (this.mensajeTableAdapter1.FillByMessage(this.c_AHORRO_NEW_DS1.mensaje, movi_id)==1)
            {
                this.lbl_concepto.Visible = true;
                this.lbl_concepto.Text = this.c_AHORRO_NEW_DS1.mensaje.Rows[0].Field<string>("mensaje").ToString();
            }
            else
            {
                this.lbl_concepto.Visible = false;
            }
        }

        private void btn_crea_nota_Click(object sender, EventArgs e)
        {
            this.WinOpacity = this.opacity;
            Notas notas = new Notas();
            notas.Show(this);
        }

        private void Log_Activated(object sender, EventArgs e)
        {

        }

        private void Log_Deactivate(object sender, EventArgs e)
        {

        }

        private void btn_edit_msg_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = new Mensaje();
            mensaje.Show(this);
        }
    }
}
