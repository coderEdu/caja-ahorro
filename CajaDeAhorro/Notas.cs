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
        public bool EditarTab { get; set; }
        public bool EliminTab { get; set; }
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
            
            if (EditarTab)
            {
                this.tab_notas.SelectedTab = tabP_editar;
            }

            if (EliminTab)
            {
                this.tab_notas.SelectedTab = tabP_eliminar;
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
                    FileManager.WriteFile("Updated.txt", "1");
                }
            }
            
            if (myTab == MyTabs.EDITAR)
            {
                DateTime fModif = this.dtp_notas.Value;
                int id = Convert.ToInt32(idTextBox.Text);
                this.notasTableAdapter.NotaUpdateQuery(tituloTextBox.Text, notaTextBox.Text, fModif, id, id);
                MessageBox.Show("Nota actualizada con éxito!.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileManager.WriteFile("Updated.txt", "1");
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

        private void btn_buscar_id_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.txt_id.Text);
            Auxiliar.id_note_to_delete = id;    

            if (this.txt_id.TextLength > 0)
            {
                if (Convert.ToInt32(notasTableAdapter1.NotasScalarQuery(Auxiliar.id_note_to_delete, Auxiliar.id_logged)) == 1)
                {
                    try { this.notasTableAdapter1.FillByTextoNota(c_AHORRO_NEW_DS_Notas.notas, Auxiliar.id_note_to_delete); }
                    catch (Exception) { }
                    lbl_texto_nota.ForeColor = Color.Black;
                    lbl_texto_nota.Text = this.c_AHORRO_NEW_DS_Notas.Tables["notas"].Rows[0].Field<string>("nota");
                } 
                else
                {
                    lbl_texto_nota.ForeColor = Color.Gray;
                    lbl_texto_nota.Text = "-- Nota Inexistente --";
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Está seguro?", "SAFE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (r == DialogResult.OK)
            {
                try { this.notasTableAdapter1.NotasDeleteQuery(Auxiliar.id_note_to_delete); MessageBox.Show("Nota eliminada!.", "SAFE", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                catch (Exception) { MessageBox.Show("Nota no eliminada!. ", "SAFE", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                this.notasTableAdapter1.NotasDeleteQuery(Auxiliar.id_note_to_delete);
                FileManager.WriteFile("Updated.txt", "1");
            }
        }
    }
}
