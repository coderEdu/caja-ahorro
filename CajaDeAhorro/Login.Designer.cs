
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contrasegna = new System.Windows.Forms.Label();
            this.txt_contrasegna = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.loginTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.loginTableAdapter();
            this.btn_crea_usuario = new System.Windows.Forms.Button();
            this.lbl_crea_nvo_usuario = new System.Windows.Forms.Label();
            this.txt_nombre_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nuevo_usuario = new System.Windows.Forms.Label();
            this.lbl_pass_nuevo_usuario = new System.Windows.Forms.Label();
            this.txt_pass_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.btn_guardar_nvo_usuario = new System.Windows.Forms.Button();
            this.btn_cancelar_nvo_usuario = new System.Windows.Forms.Button();
            this.tmr_exp_contr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_usuario.Location = new System.Drawing.Point(222, 127);
            this.txt_usuario.MaxLength = 25;
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(216, 26);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_usuario.GotFocus += new System.EventHandler(this.TextBoxes_GotFocus);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_usuario.Location = new System.Drawing.Point(219, 107);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(58, 16);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_contrasegna
            // 
            this.lbl_contrasegna.AutoSize = true;
            this.lbl_contrasegna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contrasegna.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_contrasegna.Location = new System.Drawing.Point(219, 170);
            this.lbl_contrasegna.Name = "lbl_contrasegna";
            this.lbl_contrasegna.Size = new System.Drawing.Size(80, 16);
            this.lbl_contrasegna.TabIndex = 4;
            this.lbl_contrasegna.Text = "Contraseña:";
            // 
            // txt_contrasegna
            // 
            this.txt_contrasegna.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_contrasegna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasegna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasegna.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_contrasegna.Location = new System.Drawing.Point(222, 190);
            this.txt_contrasegna.MaxLength = 25;
            this.txt_contrasegna.Multiline = true;
            this.txt_contrasegna.Name = "txt_contrasegna";
            this.txt_contrasegna.PasswordChar = '#';
            this.txt_contrasegna.Size = new System.Drawing.Size(216, 24);
            this.txt_contrasegna.TabIndex = 3;
            this.txt_contrasegna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contrasegna.GotFocus += new System.EventHandler(this.TextBoxes_GotFocus);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CajaDeAhorro.Properties.Resources.Login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(54, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Image = global::CajaDeAhorro.Properties.Resources.enter_icon_icons_com_71207;
            this.btn_login.Location = new System.Drawing.Point(0, 525);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(493, 53);
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
            this.btn_crea_usuario.Image = global::CajaDeAhorro.Properties.Resources.iconfinder_23632_add_add_user_group_new_user_icon_32px;
            this.btn_crea_usuario.Location = new System.Drawing.Point(0, 0);
            this.btn_crea_usuario.Name = "btn_crea_usuario";
            this.btn_crea_usuario.Size = new System.Drawing.Size(493, 50);
            this.btn_crea_usuario.TabIndex = 6;
            this.btn_crea_usuario.TabStop = false;
            this.btn_crea_usuario.UseVisualStyleBackColor = false;
            this.btn_crea_usuario.Click += new System.EventHandler(this.bnt_crea_usuario_Click);
            // 
            // lbl_crea_nvo_usuario
            // 
            this.lbl_crea_nvo_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_crea_nvo_usuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_crea_nvo_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crea_nvo_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_crea_nvo_usuario.Location = new System.Drawing.Point(0, 272);
            this.lbl_crea_nvo_usuario.Name = "lbl_crea_nvo_usuario";
            this.lbl_crea_nvo_usuario.Size = new System.Drawing.Size(493, 253);
            this.lbl_crea_nvo_usuario.TabIndex = 7;
            this.lbl_crea_nvo_usuario.Text = "\r\nDatos del nuevo usuario";
            this.lbl_crea_nvo_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_nombre_nuevo_usuario
            // 
            this.txt_nombre_nuevo_usuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre_nuevo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_nuevo_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_nuevo_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_nombre_nuevo_usuario.Location = new System.Drawing.Point(118, 359);
            this.txt_nombre_nuevo_usuario.MaxLength = 25;
            this.txt_nombre_nuevo_usuario.Multiline = true;
            this.txt_nombre_nuevo_usuario.Name = "txt_nombre_nuevo_usuario";
            this.txt_nombre_nuevo_usuario.Size = new System.Drawing.Size(256, 26);
            this.txt_nombre_nuevo_usuario.TabIndex = 8;
            this.txt_nombre_nuevo_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nuevo_usuario
            // 
            this.lbl_nuevo_usuario.BackColor = System.Drawing.Color.Silver;
            this.lbl_nuevo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevo_usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_nuevo_usuario.Location = new System.Drawing.Point(118, 341);
            this.lbl_nuevo_usuario.Name = "lbl_nuevo_usuario";
            this.lbl_nuevo_usuario.Size = new System.Drawing.Size(256, 16);
            this.lbl_nuevo_usuario.TabIndex = 9;
            this.lbl_nuevo_usuario.Text = "Nombre:";
            this.lbl_nuevo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pass_nuevo_usuario
            // 
            this.lbl_pass_nuevo_usuario.BackColor = System.Drawing.Color.Silver;
            this.lbl_pass_nuevo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass_nuevo_usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_pass_nuevo_usuario.Location = new System.Drawing.Point(118, 413);
            this.lbl_pass_nuevo_usuario.Name = "lbl_pass_nuevo_usuario";
            this.lbl_pass_nuevo_usuario.Size = new System.Drawing.Size(256, 16);
            this.lbl_pass_nuevo_usuario.TabIndex = 11;
            this.lbl_pass_nuevo_usuario.Text = "Contraseña:";
            this.lbl_pass_nuevo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pass_nuevo_usuario
            // 
            this.txt_pass_nuevo_usuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_pass_nuevo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass_nuevo_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_nuevo_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_pass_nuevo_usuario.Location = new System.Drawing.Point(118, 431);
            this.txt_pass_nuevo_usuario.MaxLength = 25;
            this.txt_pass_nuevo_usuario.Multiline = true;
            this.txt_pass_nuevo_usuario.Name = "txt_pass_nuevo_usuario";
            this.txt_pass_nuevo_usuario.Size = new System.Drawing.Size(256, 26);
            this.txt_pass_nuevo_usuario.TabIndex = 10;
            this.txt_pass_nuevo_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_guardar_nvo_usuario
            // 
            this.btn_guardar_nvo_usuario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_guardar_nvo_usuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_guardar_nvo_usuario.FlatAppearance.BorderSize = 2;
            this.btn_guardar_nvo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_nvo_usuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_guardar_nvo_usuario.Location = new System.Drawing.Point(168, 478);
            this.btn_guardar_nvo_usuario.Name = "btn_guardar_nvo_usuario";
            this.btn_guardar_nvo_usuario.Size = new System.Drawing.Size(75, 25);
            this.btn_guardar_nvo_usuario.TabIndex = 12;
            this.btn_guardar_nvo_usuario.Text = "Guardar";
            this.btn_guardar_nvo_usuario.UseVisualStyleBackColor = false;
            this.btn_guardar_nvo_usuario.Click += new System.EventHandler(this.btn_guardar_nvo_usuario_Click);
            // 
            // btn_cancelar_nvo_usuario
            // 
            this.btn_cancelar_nvo_usuario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cancelar_nvo_usuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancelar_nvo_usuario.FlatAppearance.BorderSize = 2;
            this.btn_cancelar_nvo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_nvo_usuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cancelar_nvo_usuario.Location = new System.Drawing.Point(249, 478);
            this.btn_cancelar_nvo_usuario.Name = "btn_cancelar_nvo_usuario";
            this.btn_cancelar_nvo_usuario.Size = new System.Drawing.Size(75, 25);
            this.btn_cancelar_nvo_usuario.TabIndex = 13;
            this.btn_cancelar_nvo_usuario.Text = "Cancelar";
            this.btn_cancelar_nvo_usuario.UseVisualStyleBackColor = false;
            this.btn_cancelar_nvo_usuario.Click += new System.EventHandler(this.btn_cancelar_nvo_usuario_Click);
            // 
            // tmr_exp_contr
            // 
            this.tmr_exp_contr.Tick += new System.EventHandler(this.tmr_exp_contr_Tick);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(493, 578);
            this.Controls.Add(this.btn_cancelar_nvo_usuario);
            this.Controls.Add(this.btn_guardar_nvo_usuario);
            this.Controls.Add(this.lbl_pass_nuevo_usuario);
            this.Controls.Add(this.txt_pass_nuevo_usuario);
            this.Controls.Add(this.lbl_nuevo_usuario);
            this.Controls.Add(this.txt_nombre_nuevo_usuario);
            this.Controls.Add(this.btn_crea_usuario);
            this.Controls.Add(this.lbl_contrasegna);
            this.Controls.Add(this.txt_contrasegna);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_crea_nvo_usuario);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CAJA DE AHORRO - LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contrasegna;
        private System.Windows.Forms.TextBox txt_contrasegna;
        private System.Windows.Forms.Button btn_login;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.loginTableAdapter loginTableAdapter1;
        private System.Windows.Forms.Button btn_crea_usuario;
        private System.Windows.Forms.Label lbl_crea_nvo_usuario;
        private System.Windows.Forms.TextBox txt_nombre_nuevo_usuario;
        private System.Windows.Forms.Label lbl_nuevo_usuario;
        private System.Windows.Forms.Label lbl_pass_nuevo_usuario;
        private System.Windows.Forms.TextBox txt_pass_nuevo_usuario;
        private System.Windows.Forms.Button btn_guardar_nvo_usuario;
        private System.Windows.Forms.Button btn_cancelar_nvo_usuario;
        private System.Windows.Forms.Timer tmr_exp_contr;
    }
}