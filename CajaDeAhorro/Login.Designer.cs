﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasegna = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.loginTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.loginTableAdapter();
            this.estadoTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.estadoTableAdapter();
            this.btn_crea_usuario = new System.Windows.Forms.Button();
            this.txt_nombre_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nuevo_usuario = new System.Windows.Forms.Label();
            this.lbl_pass_nuevo_usuario = new System.Windows.Forms.Label();
            this.txt_pass_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.btn_guardar_nvo_usuario = new System.Windows.Forms.Button();
            this.btn_cancelar_nvo_usuario = new System.Windows.Forms.Button();
            this.tmr_exp_contr = new System.Windows.Forms.Timer(this.components);
            this.flp_sess = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbx_login = new System.Windows.Forms.PictureBox();
            this.pbx_action = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_sesion = new System.Windows.Forms.TabControl();
            this.tabP_inicio = new System.Windows.Forms.TabPage();
            this.tabP_nuevo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.sesionTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.sesionTableAdapter();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.creadoTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.creadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_action)).BeginInit();
            this.tab_sesion.SuspendLayout();
            this.tabP_inicio.SuspendLayout();
            this.tabP_nuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(58, 98);
            this.txt_usuario.MaxLength = 25;
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(256, 26);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_usuario.GotFocus += new System.EventHandler(this.TextBoxes_GotFocus);
            // 
            // txt_contrasegna
            // 
            this.txt_contrasegna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.txt_contrasegna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasegna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasegna.ForeColor = System.Drawing.Color.Black;
            this.txt_contrasegna.Location = new System.Drawing.Point(58, 164);
            this.txt_contrasegna.MaxLength = 25;
            this.txt_contrasegna.Multiline = true;
            this.txt_contrasegna.Name = "txt_contrasegna";
            this.txt_contrasegna.PasswordChar = '#';
            this.txt_contrasegna.Size = new System.Drawing.Size(256, 26);
            this.txt_contrasegna.TabIndex = 1;
            this.txt_contrasegna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contrasegna.GotFocus += new System.EventHandler(this.TextBoxes_GotFocus);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
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
            this.txt_nombre_nuevo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
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
            this.lbl_nuevo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_nuevo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevo_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nuevo_usuario.Location = new System.Drawing.Point(58, 81);
            this.lbl_nuevo_usuario.Name = "lbl_nuevo_usuario";
            this.lbl_nuevo_usuario.Size = new System.Drawing.Size(256, 16);
            this.lbl_nuevo_usuario.TabIndex = 9;
            this.lbl_nuevo_usuario.Text = "Nombre:";
            this.lbl_nuevo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pass_nuevo_usuario
            // 
            this.lbl_pass_nuevo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_pass_nuevo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass_nuevo_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_pass_nuevo_usuario.Location = new System.Drawing.Point(58, 147);
            this.lbl_pass_nuevo_usuario.Name = "lbl_pass_nuevo_usuario";
            this.lbl_pass_nuevo_usuario.Size = new System.Drawing.Size(256, 16);
            this.lbl_pass_nuevo_usuario.TabIndex = 11;
            this.lbl_pass_nuevo_usuario.Text = "Contraseña:";
            this.lbl_pass_nuevo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pass_nuevo_usuario
            // 
            this.txt_pass_nuevo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
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
            this.btn_guardar_nvo_usuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guardar_nvo_usuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_guardar_nvo_usuario.FlatAppearance.BorderSize = 2;
            this.btn_guardar_nvo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_nvo_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btn_cancelar_nvo_usuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelar_nvo_usuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_cancelar_nvo_usuario.FlatAppearance.BorderSize = 2;
            this.btn_cancelar_nvo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_nvo_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.flp_sess.Location = new System.Drawing.Point(404, 77);
            this.flp_sess.Name = "flp_sess";
            this.flp_sess.Size = new System.Drawing.Size(441, 480);
            this.flp_sess.TabIndex = 14;
            this.flp_sess.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flp_sess_ControlAdded);
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
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(58, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(58, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbx_login
            // 
            this.pbx_login.Image = ((System.Drawing.Image)(resources.GetObject("pbx_login.Image")));
            this.pbx_login.Location = new System.Drawing.Point(81, 47);
            this.pbx_login.Name = "pbx_login";
            this.pbx_login.Size = new System.Drawing.Size(240, 220);
            this.pbx_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_login.TabIndex = 18;
            this.pbx_login.TabStop = false;
            // 
            // pbx_action
            // 
            this.pbx_action.Image = ((System.Drawing.Image)(resources.GetObject("pbx_action.Image")));
            this.pbx_action.Location = new System.Drawing.Point(280, 56);
            this.pbx_action.Name = "pbx_action";
            this.pbx_action.Size = new System.Drawing.Size(32, 32);
            this.pbx_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_action.TabIndex = 19;
            this.pbx_action.TabStop = false;
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
            this.label4.Text = "NUEVA CUENTA";
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
            this.tabP_nuevo.Text = "Nueva cuenta";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(404, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 41);
            this.label5.TabIndex = 21;
            this.label5.Text = "CUENTAS CON SESIONES ACTIVAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sesionTableAdapter1
            // 
            this.sesionTableAdapter1.ClearBeforeFill = true;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 565);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(859, 3);
            this.progress.TabIndex = 22;
            // 
            // creadoTableAdapter1
            // 
            this.creadoTableAdapter1.ClearBeforeFill = true;
            // 
            // estadoTableAdapter1
            // 
            this.estadoTableAdapter1.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(859, 624);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tab_sesion);
            this.Controls.Add(this.pbx_action);
            this.Controls.Add(this.pbx_login);
            this.Controls.Add(this.flp_sess);
            this.Controls.Add(this.btn_crea_usuario);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SAFE - LOGIN";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_action)).EndInit();
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
        private System.Windows.Forms.PictureBox pbx_action;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tab_sesion;
        private System.Windows.Forms.TabPage tabP_inicio;
        private System.Windows.Forms.TabPage tabP_nuevo;
        private System.Windows.Forms.Label label5;
        private C_AHORRO_NEW_DSTableAdapters.sesionTableAdapter sesionTableAdapter1;
        private System.Windows.Forms.ProgressBar progress;
        private C_AHORRO_NEW_DSTableAdapters.creadoTableAdapter creadoTableAdapter1;
        private C_AHORRO_NEW_DSTableAdapters.estadoTableAdapter estadoTableAdapter1;
    }
}