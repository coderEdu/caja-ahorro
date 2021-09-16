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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            this.loginTableAdapter1.Fill(c_AHORRO_NEW_DS1.login);
            this.moviTableAdapter1.Fill(c_AHORRO_NEW_DS1.movi);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int id_user = 0;
            try
            {
                id_user = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.moviTableAdapter1.FillById_log(c_AHORRO_NEW_DS1.movi, id_user);
                dataGridView2.DataSource = c_AHORRO_NEW_DS1.movi;
            }
            catch (Exception) { }
        }

        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Auxiliar.admin.Hide();
            Auxiliar.login.Show();
        }
    }
}
