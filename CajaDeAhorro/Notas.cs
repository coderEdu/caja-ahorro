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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS.notas' table. You can move, or remove it, as needed.
            try
            {
                this.notasTableAdapter.FillByNotasById_log(this.c_AHORRO_NEW_DS.notas,Auxiliar.id_logged);
            }
            catch (Exception)
            { }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.notasTableAdapter.MaxIdScalarQuery()) + 1;

            if (this.txt_titulo_nota.TextLength > 0 && this.txt_texto_nota.TextLength > 0)
            {
                this.notasTableAdapter.NoteInsertQuery(id, this.txt_titulo_nota.Text, this.txt_titulo_nota.Text, Auxiliar.id_logged);
                MessageBox.Show("Nota guardada con éxito!.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
