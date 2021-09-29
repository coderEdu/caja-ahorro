
namespace CajaDeAhorro
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasegna = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.loginTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.loginTableAdapter();
            this.btn_crea_usuario = new System.Windows.Forms.Button();
            this.txt_nombre_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nuevo_usuario = new System.Windows.Forms.Label();
            this.lbl_pass_nuevo_usuario = new System.Windows.Forms.Label();
            this.txt_pass_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.btn_guardar_nvo_usuario = new System.Windows.Forms.Button();
            this.btn_cancelar_nvo_usuario = new System.Windows.Forms.Button();
            this.tmr_exp_contr = new System.Windows.Forms.Timer(this.components);
            this.flp_sess = new System.Windows.Forms.FlowLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbx_login = new System.Windows.Forms.PictureBox();
            this.pbx_add = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_sesion = new System.Windows.Forms.TabControl();
            this.tabP_inicio = new System.Windows.Forms.TabPage();
            this.tabP_nuevo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.flp_sess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_add)).BeginInit();
            this.tab_sesion.SuspendLayout();
            this.tabP_inicio.SuspendLayout();
            this.tabP_nuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(58, 98);
            this.txt_usuario.MaxLength = 25;
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(256, 26);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_usuario.GotFocus += new System.EventHandler(this.TextBoxes_GotFocus);
            // 
            // txt_contrasegna
            // 
            this.txt_contrasegna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_contrasegna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasegna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasegna.ForeColor = System.Drawing.Color.Black;
            this.txt_contrasegna.Location = new System.Drawing.Point(58, 164);
            this.txt_contrasegna.MaxLength = 25;
            this.txt_contrasegna.Multiline = true;
            this.txt_contrasegna.Name = "txt_contrasegna";
            this.txt_contrasegna.PasswordChar = '#';
            this.txt_contrasegna.Size = new System.Drawing.Size(256, 26);
            this.txt_contrasegna.TabIndex = 3;
            this.txt_contrasegna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contrasegna.GotFocus += new System.EventHandler(this.TextBoxes_GotFocus);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Image = global::CajaDeAhorro.Properties.Resources.enter_icon_icons_com_71207;
            this.btn_login.Location = new System.Drawing.Point(0, 571);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(859, 53);
            this.btn_login.TabIndex = 5;
            this.btn_login.TabStop = false;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // c_AHORRO_NEW_DS1
            // 
            this.c_AHORRO_NEW_DS1.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_crea_usuario
            // 
            this.btn_crea_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.btn_crea_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_crea_usuario.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_crea_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crea_usuario.Location = new System.Drawing.Point(0, 0);
            this.btn_crea_usuario.Name = "btn_crea_usuario";
            this.btn_crea_usuario.Size = new System.Drawing.Size(859, 15);
            this.btn_crea_usuario.TabIndex = 6;
            this.btn_crea_usuario.TabStop = false;
            this.btn_crea_usuario.UseVisualStyleBackColor = false;
            this.btn_crea_usuario.Click += new System.EventHandler(this.bnt_crea_usuario_Click);
            // 
            // txt_nombre_nuevo_usuario
            // 
            this.txt_nombre_nuevo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nombre_nuevo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_nuevo_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_nuevo_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_nombre_nuevo_usuario.Location = new System.Drawing.Point(58, 98);
            this.txt_nombre_nuevo_usuario.MaxLength = 25;
            this.txt_nombre_nuevo_usuario.Multiline = true;
            this.txt_nombre_nuevo_usuario.Name = "txt_nombre_nuevo_usuario";
            this.txt_nombre_nuevo_usuario.Size = new System.Drawing.Size(256, 26);
            this.txt_nombre_nuevo_usuario.TabIndex = 8;
            this.txt_nombre_nuevo_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nuevo_usuario
            // 
            this.lbl_nuevo_usuario.BackColor = System.Drawing.Color.Chocolate;
            this.lbl_nuevo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevo_usuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_nuevo_usuario.Location = new System.Drawing.Point(58, 81);
            this.lbl_nuevo_usuario.Name = "lbl_nuevo_usuario";
            this.lbl_nuevo_usuario.Size = new System.Drawing.Size(256, 16);
            this.lbl_nuevo_usuario.TabIndex = 9;
            this.lbl_nuevo_usuario.Text = "Nombre:";
            this.lbl_nuevo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pass_nuevo_usuario
            // 
            this.lbl_pass_nuevo_usuario.BackColor = System.Drawing.Color.Chocolate;
            this.lbl_pass_nuevo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass_nuevo_usuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_pass_nuevo_usuario.Location = new System.Drawing.Point(58, 147);
            this.lbl_pass_nuevo_usuario.Name = "lbl_pass_nuevo_usuario";
            this.lbl_pass_nuevo_usuario.Size = new System.Drawing.Size(256, 16);
            this.lbl_pass_nuevo_usuario.TabIndex = 11;
            this.lbl_pass_nuevo_usuario.Text = "Contraseña:";
            this.lbl_pass_nuevo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pass_nuevo_usuario
            // 
            this.txt_pass_nuevo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_pass_nuevo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass_nuevo_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_nuevo_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_pass_nuevo_usuario.Location = new System.Drawing.Point(58, 164);
            this.txt_pass_nuevo_usuario.MaxLength = 25;
            this.txt_pass_nuevo_usuario.Multiline = true;
            this.txt_pass_nuevo_usuario.Name = "txt_pass_nuevo_usuario";
            this.txt_pass_nuevo_usuario.Size = new System.Drawing.Size(256, 26);
            this.txt_pass_nuevo_usuario.TabIndex = 10;
            this.txt_pass_nuevo_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_guardar_nvo_usuario
            // 
            this.btn_guardar_nvo_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.btn_guardar_nvo_usuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(131)))), ((int)(((byte)(176)))));
            this.btn_guardar_nvo_usuario.FlatAppearance.BorderSize = 2;
            this.btn_guardar_nvo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_nvo_usuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_guardar_nvo_usuario.Location = new System.Drawing.Point(226, 213);
            this.btn_guardar_nvo_usuario.Name = "btn_guardar_nvo_usuario";
            this.btn_guardar_nvo_usuario.Size = new System.Drawing.Size(70, 23);
            this.btn_guardar_nvo_usuario.TabIndex = 12;
            this.btn_guardar_nvo_usuario.Text = "Guardar";
            this.btn_guardar_nvo_usuario.UseVisualStyleBackColor = false;
            this.btn_guardar_nvo_usuario.Click += new System.EventHandler(this.btn_guardar_nvo_usuario_Click);
            // 
            // btn_cancelar_nvo_usuario
            // 
            this.btn_cancelar_nvo_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar_nvo_usuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(131)))), ((int)(((byte)(176)))));
            this.btn_cancelar_nvo_usuario.FlatAppearance.BorderSize = 2;
            this.btn_cancelar_nvo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_nvo_usuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_cancelar_nvo_usuario.Location = new System.Drawing.Point(302, 213);
            this.btn_cancelar_nvo_usuario.Name = "btn_cancelar_nvo_usuario";
            this.btn_cancelar_nvo_usuario.Size = new System.Drawing.Size(70, 23);
            this.btn_cancelar_nvo_usuario.TabIndex = 13;
            this.btn_cancelar_nvo_usuario.Text = "Cancelar";
            this.btn_cancelar_nvo_usuario.UseVisualStyleBackColor = false;
            this.btn_cancelar_nvo_usuario.Click += new System.EventHandler(this.btn_cancelar_nvo_usuario_Click);
            // 
            // tmr_exp_contr
            // 
            this.tmr_exp_contr.Tick += new System.EventHandler(this.tmr_exp_contr_Tick);
            // 
            // flp_sess
            // 
            this.flp_sess.BackColor = System.Drawing.Color.White;
            this.flp_sess.Controls.Add(this.btn1);
            this.flp_sess.Controls.Add(this.button1);
            this.flp_sess.Controls.Add(this.button2);
            this.flp_sess.Controls.Add(this.button3);
            this.flp_sess.Controls.Add(this.button4);
            this.flp_sess.Location = new System.Drawing.Point(404, 77);
            this.flp_sess.Name = "flp_sess";
            this.flp_sess.Size = new System.Drawing.Size(441, 480);
            this.flp_sess.TabIndex = 14;
            // 
            // btn1
            // 
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Image = global::CajaDeAhorro.Properties.Resources.User_icon_64;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(141, 90);
            this.btn1.TabIndex = 24;
            this.btn1.Text = "gotech";
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "INICIAR SESIÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(58, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(58, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbx_login
            // 
            this.pbx_login.Image = global::CajaDeAhorro.Properties.Resources.login;
            this.pbx_login.Location = new System.Drawing.Point(88, 60);
            this.pbx_login.Name = "pbx_login";
            this.pbx_login.Size = new System.Drawing.Size(220, 195);
            this.pbx_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_login.TabIndex = 18;
            this.pbx_login.TabStop = false;
            // 
            // pbx_add
            // 
            this.pbx_add.Image = global::CajaDeAhorro.Properties.Resources.add_1_icon;
            this.pbx_add.Location = new System.Drawing.Point(273, 63);
            this.pbx_add.Name = "pbx_add";
            this.pbx_add.Size = new System.Drawing.Size(32, 32);
            this.pbx_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_add.TabIndex = 19;
            this.pbx_add.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(58, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "NUEVO USUARIO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tab_sesion
            // 
            this.tab_sesion.Controls.Add(this.tabP_inicio);
            this.tab_sesion.Controls.Add(this.tabP_nuevo);
            this.tab_sesion.Location = new System.Drawing.Point(12, 288);
            this.tab_sesion.Name = "tab_sesion";
            this.tab_sesion.SelectedIndex = 0;
            this.tab_sesion.Size = new System.Drawing.Size(386, 269);
            this.tab_sesion.TabIndex = 21;
            this.tab_sesion.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_sesion_Selected);
            // 
            // tabP_inicio
            // 
            this.tabP_inicio.BackColor = System.Drawing.Color.White;
            this.tabP_inicio.Controls.Add(this.label1);
            this.tabP_inicio.Controls.Add(this.txt_usuario);
            this.tabP_inicio.Controls.Add(this.txt_contrasegna);
            this.tabP_inicio.Controls.Add(this.lbl_nuevo_usuario);
            this.tabP_inicio.Controls.Add(this.lbl_pass_nuevo_usuario);
            this.tabP_inicio.Location = new System.Drawing.Point(4, 22);
            this.tabP_inicio.Name = "tabP_inicio";
            this.tabP_inicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_inicio.Size = new System.Drawing.Size(378, 243);
            this.tabP_inicio.TabIndex = 0;
            this.tabP_inicio.Text = "Iniciar sesión";
            // 
            // tabP_nuevo
            // 
            this.tabP_nuevo.BackColor = System.Drawing.Color.White;
            this.tabP_nuevo.Controls.Add(this.txt_nombre_nuevo_usuario);
            this.tabP_nuevo.Controls.Add(this.label4);
            this.tabP_nuevo.Controls.Add(this.txt_pass_nuevo_usuario);
            this.tabP_nuevo.Controls.Add(this.btn_guardar_nvo_usuario);
            this.tabP_nuevo.Controls.Add(this.btn_cancelar_nvo_usuario);
            this.tabP_nuevo.Controls.Add(this.label2);
            this.tabP_nuevo.Controls.Add(this.label3);
            this.tabP_nuevo.Location = new System.Drawing.Point(4, 22);
            this.tabP_nuevo.Name = "tabP_nuevo";
            this.tabP_nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_nuevo.Size = new System.Drawing.Size(378, 243);
            this.tabP_nuevo.TabIndex = 1;
            this.tabP_nuevo.Text = "Nuevo usuario";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(399, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 41);
            this.label5.TabIndex = 21;
            this.label5.Text = "SESIONES ACTIVAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CajaDeAhorro.Properties.Resources.User_icon_64;
            this.button1.Location = new System.Drawing.Point(150, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 90);
            this.button1.TabIndex = 25;
            this.button1.Text = "edu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::CajaDeAhorro.Properties.Resources.User_icon_64;
            this.button2.Location = new System.Drawing.Point(297, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 90);
            this.button2.TabIndex = 26;
            this.button2.Text = "alovero";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::CajaDeAhorro.Properties.Resources.User_icon_64;
            this.button3.Location = new System.Drawing.Point(3, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 90);
            this.button3.TabIndex = 27;
            this.button3.Text = "marce";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::CajaDeAhorro.Properties.Resources.User_icon_64;
            this.button4.Location = new System.Drawing.Point(150, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 90);
            this.button4.TabIndex = 28;
            this.button4.Text = "desbloqueos";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(859, 624);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tab_sesion);
            this.Controls.Add(this.pbx_add);
            this.Controls.Add(this.pbx_login);
            this.Controls.Add(this.flp_sess);
            this.Controls.Add(this.btn_crea_usuario);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CAJA DE AHORRO - LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            this.flp_sess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_add)).EndInit();
            this.tab_sesion.ResumeLayout(false);
            this.tabP_inicio.ResumeLayout(false);
            this.tabP_inicio.PerformLayout();
            this.tabP_nuevo.ResumeLayout(false);
            this.tabP_nuevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrasegna;
        private System.Windows.Forms.Button btn_login;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.loginTableAdapter loginTableAdapter1;
        private System.Windows.Forms.Button btn_crea_usuario;
        private System.Windows.Forms.TextBox txt_nombre_nuevo_usuario;
        private System.Windows.Forms.Label lbl_nuevo_usuario;
        private System.Windows.Forms.Label lbl_pass_nuevo_usuario;
        private System.Windows.Forms.TextBox txt_pass_nuevo_usuario;
        private System.Windows.Forms.Button btn_guardar_nvo_usuario;
        private System.Windows.Forms.Button btn_cancelar_nvo_usuario;
        private System.Windows.Forms.Timer tmr_exp_contr;
        private System.Windows.Forms.FlowLayoutPanel flp_sess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbx_login;
        private System.Windows.Forms.PictureBox pbx_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tab_sesion;
        private System.Windows.Forms.TabPage tabP_inicio;
        private System.Windows.Forms.TabPage tabP_nuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}