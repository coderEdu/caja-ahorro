using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaDeAhorro
{
    public partial class Transaccion : Form
    {
        public Transaccion()
        {
            InitializeComponent();
        }

        private void Transaccion_Load(object sender, EventArgs e)
        {
            c_AHORRO_NEW_DS1.Clear();
            try
            {
                this.moviTableAdapter2.Fill(this.c_AHORRO_NEW_DS1.movi);  // cargo el dataset con info
            }
            catch (Exception) { }

            this.dtp.Visible = false;

            if (this.Text.EndsWith("ito"))
            {
                this.lbl_trans.Text = "Monto en pesos($):";
                this.btn_trans.Text = "Depositar";
            }
            else
            {
                this.lbl_trans.Text = "Monto en pesos($):";
                this.btn_trans.Text = "Extraer";
            }
        }

        private void btn_trans_Click(object sender, EventArgs e)
        {
            if (txt_trans_monto.Text == "" || txt_trans_monto.Text == null)
            {
                return;
            }

            DateTime dateTime;
            dateTime = this.dtp.Value;

            int montoFromTextbox = 0;
            _ = Int32.TryParse(this.txt_trans_monto.Text, out montoFromTextbox);

            if (montoFromTextbox <= 0)
                return;

            int dineroEnCaja = Auxiliar.getDineroEnCaja();

            DialogResult dR;
            dR = MessageBox.Show("Confirma la transacción?", "Caja de ahorro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == DialogResult.No)
            {
                this.txt_trans_monto.Clear();
                return;
            }

            int id = Convert.ToInt32(this.moviTableAdapter2.MaxIdScalarQuery()) + 1;

            if (this.Text.EndsWith("ito"))
            {
                dineroEnCaja += montoFromTextbox;
                MessageBox.Show("Depósito realizado con éxito!.","Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    // nuevo registro de transacción de depósito
                    this.moviTableAdapter2.InsertQuery(id, dateTime, "deposito", montoFromTextbox, Auxiliar.id_logged);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (montoFromTextbox > dineroEnCaja)
                {
                    if (dineroEnCaja == 0)
                        MessageBox.Show("Error: no dispone de saldo!", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Error: no dispone de saldo suficiente!", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                } 
                else
                {
                    dineroEnCaja -= montoFromTextbox;
                    MessageBox.Show("Extracción realizada con éxito!.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        // nuevo registro de transacción de extracción
                        this.moviTableAdapter2.InsertQuery(id, dateTime, "extracción", montoFromTextbox, Auxiliar.id_logged);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            this.loginTableAdapter1.UpdateQuery(dineroEnCaja, Auxiliar.id_logged, Auxiliar.id_logged);
            // ************************************************************************************************   working here   *************************
            if (this.txt_concepto.TextLength > 0)
            {
                if (this.txt_concepto.Text == "$correctivo")
                    this.mensajeTableAdapter1.MessageInsertQuery(id, Auxiliar.getTextCorrective());
                else
                    this.mensajeTableAdapter1.MessageInsertQuery(id, this.txt_concepto.Text);
            }
            this.Close();
            // ************************************************************************************************   working here   *************************
        }

        private void txt_trans_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
                this.btn_trans.PerformClick();
        }

    }
}
