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
        public Mensaje()
        {
            InitializeComponent();
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            this.rich_txt_msg.Enabled = false;
            this.btn_guardar.Enabled = false;
        }
    }
}
