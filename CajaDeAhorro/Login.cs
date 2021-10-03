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
    public enum Estados { exp, con, mov1, mov2 }
    public partial class Login : Form
    {
        public Estados ExpOrContr { get; set; }    
        private int height=364;
        private int scrDimH;
        private int scrDimV;
        // static vars
        static int increase;
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // ...
            //LoadingModules();     
            
        }

        public void LoadingModules()
        {
            Auxiliar.form1 = new Form1();
            Auxiliar.admin = new Administrador();
            Auxiliar.login = this;
            //this.btn_check_admin.Visible = false;
            //this.tmr_exp_contr.Interval = 1;
            //this.Size = new Size(509, 364);
            //EstadoPanelNuevoUsuario(false);
            scrDimH = Screen.PrimaryScreen.Bounds.Width;
            scrDimV = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(scrDimH / 2 - this.ClientRectangle.Width / 2, scrDimV / 2 - this.ClientRectangle.Height / 2);
            //MessageBox.Show(scrDimH.ToString() + " " + scrDimV.ToString());
            this.btn_crea_usuario.Visible = false;
            this.pbx_add.Visible = false;
            increase = 0;
            this.flp_sess.Controls.Clear();
            GetActiveSessions();
        }

        public void GetActiveSessions()
        {
            int count = this.sesionTableAdapter1.Fill(this.c_AHORRO_NEW_DS1.sesion);
            DataGridView dataGrid = new DataGridView();
            this.loginTableAdapter1.Fill(this.c_AHORRO_NEW_DS1.login);  // ay q llenar el ds p/poder obt los datos
            this.sesionTableAdapter1.Fill(this.c_AHORRO_NEW_DS1.sesion); // acá igual ...
            for (int i = 0; i < count; i++)
            {
                if (this.c_AHORRO_NEW_DS1.Tables["sesion"].Rows[i].Field<int>(1)==1)
                {
                    Session session = new Session();
                    string loggName = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[i].Field<string>(1).Replace(" ", "");
                    this.flp_sess.Controls.Add(session.CreateNewEnemyWAttribs(loggName));
                }                
            }
        }

        private void TextBoxes_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.TextLength > 0)
            {
                textBox.SelectAll();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (this.txt_usuario.Text=="admin" && this.txt_contrasegna.Text=="12345")
            {
                Auxiliar.admin.Show();
                Auxiliar.login.Hide();
            }           
            else if (this.loginTableAdapter1.LogScalarQuery(this.txt_usuario.Text, this.txt_contrasegna.Text) == 1)
            {
                // obtener el valor del id del usuario logueado y guardarlo en Auxiliar
                this.loginTableAdapter1.FillByWhoIsLogged(c_AHORRO_NEW_DS1.login, this.txt_usuario.Text, this.txt_contrasegna.Text);
                Auxiliar.id_logged = c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(0);
                this.sesionTableAdapter1.ChangeSessStateUpQuery(1, Auxiliar.id_logged, Auxiliar.id_logged);

                Auxiliar.form1.Show();
                Auxiliar.login.Hide();
            }
        }

        private void bnt_crea_usuario_Click(object sender, EventArgs e) // botón de arriba (top form)
        {
            this.ExpOrContr = Estados.exp;
            this.tmr_exp_contr.Start(); // timer start
            // código movido a tick 
        }

        private void EstadoPanelNuevoUsuario(bool estado)
        {
            //this.lbl_crea_nvo_usuario.Visible = estado;
            this.lbl_nuevo_usuario.Visible = estado;
            this.lbl_pass_nuevo_usuario.Visible = estado;
            this.txt_nombre_nuevo_usuario.Visible = estado;
            this.txt_pass_nuevo_usuario.Visible = estado;
            this.btn_guardar_nvo_usuario.Visible = estado;
            this.btn_cancelar_nvo_usuario.Visible = estado;
        }

        private void btn_guardar_nvo_usuario_Click(object sender, EventArgs e)
        {
            // Código para guardar un nuevo usuario en la tabla login
            if (this.txt_nombre_nuevo_usuario.TextLength > 0 && this.txt_pass_nuevo_usuario.TextLength > 0)
            {
                DialogResult Dr;
                Dr= MessageBox.Show("Confirma la creación del nuevo usuario?", "Caja de ahorro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.No)
                    return;
                if (this.loginTableAdapter1.CheckUserScalarQuery(this.txt_nombre_nuevo_usuario.Text) == 1)
                {
                    MessageBox.Show("Error: ya existe un usuario con el mismo nombre.\nPor favor, ingrese un nombre diferente.",
                        "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_nombre_nuevo_usuario.Focus();
                    this.txt_nombre_nuevo_usuario.SelectAll();
                }
                else
                {
                    try
                    {
                        int biggestId = Convert.ToInt32(this.loginTableAdapter1.BiggestIdScalarQuery());
                        int newUserId = biggestId + 1;
                        this.loginTableAdapter1.InsertQuery(newUserId, this.txt_nombre_nuevo_usuario.Text, this.txt_pass_nuevo_usuario.Text, 0);
                        MessageBox.Show("Nuevo usuario creado.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.ExpOrContr = Estados.mov2;
                        //this.tmr_exp_contr.Start();
                        this.sesionTableAdapter1.NewSessInsertQuery(newUserId, 0);
                    }
                    catch (Exception) { }
                }
            }
        }

        private void btn_cancelar_nvo_usuario_Click(object sender, EventArgs e)
        {
            this.ExpOrContr = Estados.mov2;
            this.txt_nombre_nuevo_usuario.Clear();
            this.txt_pass_nuevo_usuario.Clear();
            MessageBox.Show("Alta de nuevo usuario cancelada.",
                        "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.txt_usuario.Focus();
            //this.tmr_exp_contr.Start();
        }

        private void PrepContraerForm()
        {
            this.txt_nombre_nuevo_usuario.Text = "";
            this.txt_pass_nuevo_usuario.Text = "";
            EstadoPanelNuevoUsuario(false);
        }

        private void EstadoExp()
        {
            if (ExpOrContr == Estados.exp)
            {
                if (this.height <= 617)
                {
                    this.Size = new Size(this.Size.Width, this.height);
                    this.Location = new Point(scrDimH / 2 - this.ClientRectangle.Width / 2, scrDimV / 2 - this.height / 2);
                    this.height += 4;
                }
                else
                {
                    this.tmr_exp_contr.Stop();
                    // begin - codigo para setear location x 
                    this.lbl_nuevo_usuario.Location = new Point(-256, this.lbl_nuevo_usuario.Location.Y);
                    this.lbl_pass_nuevo_usuario.Location = new Point(-256, this.lbl_pass_nuevo_usuario.Location.Y);
                    this.txt_nombre_nuevo_usuario.Location = new Point(-256, this.txt_nombre_nuevo_usuario.Location.Y);
                    this.txt_pass_nuevo_usuario.Location = new Point(-256, this.txt_pass_nuevo_usuario.Location.Y);
                    //// finish - codigo para setear location x
                    EstadoPanelNuevoUsuario(true);
                    EstadoLblsAndTxtsNvoUser(false);
                    this.ExpOrContr = Estados.mov1;
                    this.tmr_exp_contr.Start();
                    this.txt_usuario.Text = "";
                    this.txt_usuario.Enabled = false;
                    this.txt_contrasegna.Text = "";
                    this.txt_contrasegna.Enabled = false;
                    this.Size = new Size(509, 617);
                    this.btn_crea_usuario.Enabled = false;
                    this.txt_nombre_nuevo_usuario.Focus();
                }
            }
        }

        private void EstadoCon()
        {
            tmr_exp_contr.Interval = 1;
            tmr_exp_contr.Start();
            if (ExpOrContr == Estados.con)
            {
                PrepContraerForm(); // borra cont textBoxes y oculta panel nvo user
                if (this.height >= 364)
                {
                    this.Size = new Size(this.Size.Width, this.height);
                    this.Location = new Point(scrDimH / 2 - this.ClientRectangle.Width / 2, scrDimV / 2 - this.height / 2);
                    this.height -= 4;
                }
                else
                {
                    this.tmr_exp_contr.Stop();
                    this.Size = new Size(509, 364);
                    this.txt_usuario.Enabled = true;
                    this.txt_contrasegna.Enabled = true;
                    this.btn_crea_usuario.Enabled = true;
                    this.txt_usuario.Focus();
                }
            }
        }

        private void SetElemLocation(int step)
        {
            this.lbl_nuevo_usuario.Location = new Point(this.lbl_nuevo_usuario.Location.X + step, this.lbl_nuevo_usuario.Location.Y);
            this.lbl_pass_nuevo_usuario.Location = new Point(lbl_pass_nuevo_usuario.Location.X + step, this.lbl_pass_nuevo_usuario.Location.Y);
            this.txt_nombre_nuevo_usuario.Location = new Point(txt_nombre_nuevo_usuario.Location.X + step, this.txt_nombre_nuevo_usuario.Location.Y);
            this.txt_pass_nuevo_usuario.Location = new Point(txt_pass_nuevo_usuario.Location.X + step, this.txt_pass_nuevo_usuario.Location.Y);
        }

        private void EstadoLblsAndTxtsNvoUser(bool estado)
        {
            //this.lbl_crea_nvo_usuario.Visible = estado;
            this.btn_guardar_nvo_usuario.Visible = estado;
            this.btn_cancelar_nvo_usuario.Visible = estado;
        }

        private void EstadoMov1()   // de izq al centro
        {
            if (ExpOrContr == Estados.mov1)
            {
                this.tmr_exp_contr.Interval = 1;
                this.tmr_exp_contr.Start();
                if (this.lbl_nuevo_usuario.Location.X <= 118)
                {
                    SetElemLocation(8);
                }
                else
                {
                    this.tmr_exp_contr.Stop();
                    EstadoLblsAndTxtsNvoUser(true);
                }
            }
        }

        private void EstadoMov2()   // del centro hacia la der
        {
            if (ExpOrContr == Estados.mov2)
            {
                EstadoLblsAndTxtsNvoUser(false);
                if (this.lbl_nuevo_usuario.Location.X <= 500)
                {
                    SetElemLocation(8);
                }
                else
                {
                    ExpOrContr = Estados.con;
                    tmr_exp_contr.Interval = 1;
                }
            }
        }

        private void tmr_exp_contr_Tick(object sender, EventArgs e)     // timer's tick
        {
            if (this.progress.Value<100)
            {
                this.progress.Value += 1;
            }
            
            if (this.progress.Value == 100)
            {
                tmr_exp_contr.Stop();
                this.progress.Value = 0;
                Auxiliar.form1.Show();
                Auxiliar.login.Hide();
            }

            //switch (ExpOrContr)
            //{
            //    case Estados.exp:
            //        EstadoExp();
            //        break;
            //    case Estados.con:
            //        EstadoCon();
            //        break;
            //    case Estados.mov1:
            //        EstadoMov1();
            //        break;
            //    case Estados.mov2:
            //        EstadoMov2();
            //        break;
            //}
        }

        private void tab_sesion_Selected(object sender, TabControlEventArgs e)
        {
            if (this.tab_sesion.SelectedTab==tabP_nuevo)
            {
                this.pbx_add.Visible = true;
            }
            else
            {
                this.pbx_add.Visible = false;
            }
        }

        private void flp_sess_ControlAdded(object sender, ControlEventArgs e)
        {
            Button btn = (Button)this.flp_sess.Controls[increase];
            btn.Click += Btn_session_click;
            ++increase;
 
        }

        private void Btn_session_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //MessageBox.Show("Hiciste click en la sesión " + button.Text);

            // obtengo el id del usuario logueado según su nombre y lo guardo en Auxiliar
            this.loginTableAdapter1.FillByWhoIsActiveByName(c_AHORRO_NEW_DS1.login, button.Text);
            Auxiliar.id_logged = c_AHORRO_NEW_DS1.Tables["login"].Rows[0].Field<int>(0);

            this.tmr_exp_contr.Interval = 1;
            this.tmr_exp_contr.Start();

        }

        private void Login_Activated(object sender, EventArgs e)
        {
            LoadingModules();
        }
    }
}
