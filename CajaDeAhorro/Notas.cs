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
    enum MyTabs
    {
        NUEVO,
        EDITAR,
        ELIMINAR
    }
    public partial class Notas : Form
    {
        public int EditarTab { get; set; }
        MyTabs myTab;
        public Notas()
        {
            InitializeComponent();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            this.dtp_notas.Visible = false;
            this.btn_guardar.Enabled = true;
            // TODO: This line of code loads data into the 'c_AHORRO_NEW_DS.notas' table. You can move, or remove it, as needed.
            try
            {
                this.notasTableAdapter.FillByNotasById_log(this.c_AHORRO_NEW_DS.notas,Auxiliar.id_logged);
            }
            catch (Exception)
            { }
            
            if (EditarTab==1)
            {
                this.tab_notas.SelectedTab = tabP_editar;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (myTab == MyTabs.NUEVO)
            {
                int id = Convert.ToInt32(this.notasTableAdapter.MaxIdScalarQuery()) + 1;

                if (this.txt_titulo_nota.TextLength > 0 && this.txt_texto_nota.TextLength > 0)
                {
                    this.notasTableAdapter.NoteInsertQuery(id, this.txt_titulo_nota.Text, this.txt_texto_nota.Text, this.dtp_notas.Value, this.dtp_notas.Value, Auxiliar.id_logged);
                    MessageBox.Show("Nota guardada con éxito!.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_guardar.Enabled = false;
                }
            }
            
            if (myTab == MyTabs.EDITAR)
            {
                DateTime fModif = this.dtp_notas.Value;
                int id = Convert.ToInt32(idTextBox.Text);
                this.notasTableAdapter.NotaUpdateQuery(tituloTextBox.Text, notaTextBox.Text, fModif, id, id);
                MessageBox.Show("Nota actualizada con éxito!.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selected_id = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);
                this.notasTableAdapter1.FillByTextoNota(c_AHORRO_NEW_DS1.notas, selected_id);
            }
            catch (Exception) { }
        }

        private void tab_notas_Selected(object sender, TabControlEventArgs e)
        {
            if (tab_notas.SelectedTab == tabP_nuevo)
            {
                myTab = MyTabs.NUEVO;
                this.btn_guardar.Enabled=true;
            }
            else if (tab_notas.SelectedTab == tabP_editar)
            {
                myTab = MyTabs.EDITAR;
                this.btn_guardar.Enabled = true;
            }
            else
            {
                myTab = MyTabs.ELIMINAR;
                this.btn_guardar.Enabled=false;
            }
        }
    }
}
