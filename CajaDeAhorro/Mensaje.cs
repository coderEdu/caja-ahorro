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
    public partial class Mensaje : Form
    {
        public string Message { get; set; }
        public int MessageId { get; set; }

        public Mensaje()
        {
            InitializeComponent();
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            this.rich_txt_msg.Text = this.Message;
            this.rich_txt_msg.Enabled = true;
            this.btn_guardar.Enabled = true;            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.mensajeTableAdapter1.MessageUpdateQuery(this.rich_txt_msg.Text, this.MessageId);
        }
    }
}
