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
    public partial class DetNota : Form
    {
        public DetNota()
        {
            InitializeComponent();
        }

        public Point WinLocation { get; set; }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetNota_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS.notas' table. You can move, or remove it, as needed.
                this.notasTableAdapter1.FillByTextoNota(this.c_AHORRO_NEW_DS.notas,Auxiliar.id_note);
            
            }
            catch (Exception) { }

            this.lbl_name.Visible = false;
            this.Text = lbl_name.Text;
            this.Location = WinLocation;
        }
    }
}
