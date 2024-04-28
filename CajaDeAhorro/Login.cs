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
using System.Windows.Interop;

namespace CajaDeAhorro
{
    public enum Estados { exp, con, mov1, mov2 }
    
    public partial class Login : Form
    {
        public Estados ExpOrContr { get; set; }    
        private int scrDimH;
        private int scrDimV;
        private int barProgCounter;
        // static vars
        static int increase;
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // ...
            DbTransferingManager.ImportingDBFromCloud();
        }

        public void LoadingModules()
        {
            Auxiliar.form1 = new Form1();
            Auxiliar.admin = new Administrador();
            Auxiliar.login = this;
            scrDimH = Screen.PrimaryScreen.Bounds.Width;
            scrDimV = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(scrDimH / 2 - this.ClientRectangle.Width / 2, scrDimV / 2 - this.ClientRectangle.Height / 2);
            this.btn_crea_usuario.Visible = false;
            this.pbx_action.Visible = true;
            this.pbx_action.Image = global::CajaDeAhorro.Properties.Resources.Lock_Lock_icon;
            increase = 0;
            this.txt_usuario.Clear();
            this.txt_contrasegna.Clear();
            this.txt_usuario.Focus();
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
                    if (this.flp_sess.Controls.Count < 15)
                    {
                        Session session = new Session();
                        string loggName = this.c_AHORRO_NEW_DS1.Tables["login"].Rows[i].Field<string>(1).Replace(" ", "");
                        Button button = new Button();
                        button = session.CreateNewSessionWithAttribs(loggName);
                        button.BackColor = Color.White;
                        button.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
                        button.FlatAppearance.BorderSize = 3;
                        this.flp_sess.Controls.Add(button);
                    }
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

                this.tmr_exp_contr.Interval = 1;
                this.tmr_exp_contr.Start();
            }
        }

        private void bnt_crea_usuario_Click(object sender, EventArgs e) // botón de arriba (top form)
        {
            this.ExpOrContr = Estados.exp;
            this.tmr_exp_contr.Start(); // timer start
            // código movido a tick 
        }

        private void btn_guardar_nvo_usuario_Click(object sender, EventArgs e)
        {
            // Código para guardar un nuevo usuario en la tabla login
            if (this.txt_nombre_nuevo_usuario.TextLength > 0 && this.txt_pass_nuevo_usuario.TextLength > 0)
            {
                DialogResult Dr;
                Dr = MessageBox.Show("Confirma la creación de la nueva cuenta?", "Caja de ahorro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.No)
                    return;
                if (this.loginTableAdapter1.CheckUserScalarQuery(this.txt_nombre_nuevo_usuario.Text) == 1)  
                {
                    MessageBox.Show("Error: ya existe una cuenta con el mismo nombre.\nPor favor, ingrese un nombre diferente.",
                        "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_nombre_nuevo_usuario.Focus();
                    this.txt_nombre_nuevo_usuario.SelectAll();
                }
                else
                {
                    try
                    {
                        int newUserId = Convert.ToInt32(this.loginTableAdapter1.BiggestIdScalarQuery()) + 1;    // working here 24/12/2021 05:30
                        this.loginTableAdapter1.InsertQuery(newUserId, this.txt_nombre_nuevo_usuario.Text, this.txt_pass_nuevo_usuario.Text, 0);
                        try
                        {
                            this.creadoTableAdapter1.FecCreaInsertQuery(newUserId, DateTime.Now);
                        }
                        catch (Exception) { }

                        MessageBox.Show("Nueva cuenta creada.", "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.ExpOrContr = Estados.mov2;
                        //this.tmr_exp_contr.Start();
                        this.sesionTableAdapter1.NewSessInsertQuery(newUserId, 0);
                        Auxiliar.DataBaseUpdated = true;
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
            MessageBox.Show("Alta de nueva cuenta cancelada.",
                        "Caja de ahorro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.txt_usuario.Focus();
            //this.tmr_exp_contr.Start();
        }

        private void tmr_exp_contr_Tick(object sender, EventArgs e)     // timer's tick
        {
            if (this.progress.Value<100)
            {
                this.progress.Value += 10;
            }
            
            if (this.progress.Value == 100)
            {
                if (this.barProgCounter == 45)
                {
                    tmr_exp_contr.Stop();
                    this.barProgCounter = 0;
                    this.progress.Value = 0;
                    Auxiliar.form1.Show();
                    Auxiliar.login.Hide();
                }
                else
                {
                    barProgCounter++;
                }        
            } 
        }

        private void tab_sesion_Selected(object sender, TabControlEventArgs e)
        {
            if (this.tab_sesion.SelectedTab==tabP_nuevo)
            {
                this.pbx_action.Image = global::CajaDeAhorro.Properties.Resources.add_user_icon;
            }
            else
            {
                this.pbx_action.Image = global::CajaDeAhorro.Properties.Resources.Lock_Lock_icon;
            }
        }

        private void flp_sess_ControlAdded(object sender, ControlEventArgs e)
        {
            Button btn = (Button)flp_sess.Controls[increase];
            btn.Click += Btn_session_click;
            ++increase;
 
        }

        private void Btn_session_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Auxiliar.DataBaseUpdated)
            {
                MessageBox.Show("Nueva actividad registrada. ¡¡No olvide exportar la Base de Datos!!.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
