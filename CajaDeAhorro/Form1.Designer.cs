
namespace CajaDeAhorro
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_caja_titulo = new System.Windows.Forms.Label();
            this.lbl_caja_valor = new System.Windows.Forms.Label();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.btn_extraccion = new System.Windows.Forms.Button();
            this.btn_registro = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_dios_desmolde = new System.Windows.Forms.Label();
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.loginTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.loginTableAdapter();
            this.btn_sesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_editar_nota = new System.Windows.Forms.Button();
            this.btn_ver_notas = new System.Windows.Forms.Button();
            this.btn_crear_nota = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_edit_msg = new System.Windows.Forms.Button();
            this.lbl_name_logged = new System.Windows.Forms.Label();
            this.pbx_act_sess = new System.Windows.Forms.PictureBox();
            this.sesionTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.sesionTableAdapter();
            this.lbl_saldo_disponible = new System.Windows.Forms.Label();
            this.lbl_fecha_portada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviTableAdapter = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.moviTableAdapter();
            this.notasTableAdapter = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.notasTableAdapter();
            this.fKmensajemoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensajeTableAdapter = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.mensajeTableAdapter();
            this.flp_note = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_act_sess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKmensajemoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_caja_titulo
            // 
            this.lbl_caja_titulo.BackColor = System.Drawing.Color.White;
            this.lbl_caja_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_caja_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caja_titulo.ForeColor = System.Drawing.Color.Green;
            this.lbl_caja_titulo.Location = new System.Drawing.Point(194, 105);
            this.lbl_caja_titulo.Name = "lbl_caja_titulo";
            this.lbl_caja_titulo.Size = new System.Drawing.Size(684, 531);
            this.lbl_caja_titulo.TabIndex = 0;
            this.lbl_caja_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_caja_valor
            // 
            this.lbl_caja_valor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_caja_valor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_caja_valor.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caja_valor.Location = new System.Drawing.Point(253, 477);
            this.lbl_caja_valor.Name = "lbl_caja_valor";
            this.lbl_caja_valor.Size = new System.Drawing.Size(605, 139);
            this.lbl_caja_valor.TabIndex = 1;
            this.lbl_caja_valor.Text = "$0.00";
            this.lbl_caja_valor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_deposito
            // 
            this.btn_deposito.BackColor = System.Drawing.Color.White;
            this.btn_deposito.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_deposito.FlatAppearance.BorderSize = 2;
            this.btn_deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_deposito.Image = global::CajaDeAhorro.Properties.Resources._1889200_bag_coins_finance_saving_bank_icon__2_;
            this.btn_deposito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deposito.Location = new System.Drawing.Point(3, 3);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(189, 46);
            this.btn_deposito.TabIndex = 8;
            this.btn_deposito.Text = "Depósito $";
            this.btn_deposito.UseVisualStyleBackColor = false;
            this.btn_deposito.Click += new System.EventHandler(this.btn_deposito_Click);
            // 
            // btn_extraccion
            // 
            this.btn_extraccion.BackColor = System.Drawing.Color.White;
            this.btn_extraccion.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_extraccion.FlatAppearance.BorderSize = 2;
            this.btn_extraccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_extraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_extraccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_extraccion.Image = global::CajaDeAhorro.Properties.Resources._1889199_coins_hand_loan_loan_money_money_icon__2_;
            this.btn_extraccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_extraccion.Location = new System.Drawing.Point(3, 51);
            this.btn_extraccion.Name = "btn_extraccion";
            this.btn_extraccion.Size = new System.Drawing.Size(189, 46);
            this.btn_extraccion.TabIndex = 9;
            this.btn_extraccion.Text = "Extracción $";
            this.btn_extraccion.UseVisualStyleBackColor = false;
            this.btn_extraccion.Click += new System.EventHandler(this.btn_extraccion_Click);
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.White;
            this.btn_registro.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_registro.FlatAppearance.BorderSize = 2;
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registro.Image = global::CajaDeAhorro.Properties.Resources.Database_Active_icon;
            this.btn_registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registro.Location = new System.Drawing.Point(3, 99);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(189, 46);
            this.btn_registro.TabIndex = 11;
            this.btn_registro.Text = "Reg Trans";
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 454);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lbl_dios_desmolde
            // 
            this.lbl_dios_desmolde.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl_dios_desmolde.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_dios_desmolde.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dios_desmolde.Location = new System.Drawing.Point(0, 0);
            this.lbl_dios_desmolde.Name = "lbl_dios_desmolde";
            this.lbl_dios_desmolde.Size = new System.Drawing.Size(878, 105);
            this.lbl_dios_desmolde.TabIndex = 13;
            this.lbl_dios_desmolde.Text = "ISMA - EL DIOS DEL DESMOLDE";
            this.lbl_dios_desmolde.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // btn_sesion
            // 
            this.btn_sesion.BackColor = System.Drawing.Color.White;
            this.btn_sesion.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_sesion.FlatAppearance.BorderSize = 2;
            this.btn_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sesion.Image = global::CajaDeAhorro.Properties.Resources.Lock_PadLock_icon;
            this.btn_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sesion.Location = new System.Drawing.Point(3, 147);
            this.btn_sesion.Name = "btn_sesion";
            this.btn_sesion.Size = new System.Drawing.Size(189, 46);
            this.btn_sesion.TabIndex = 14;
            this.btn_sesion.Text = "Cerrar Sesión";
            this.btn_sesion.UseVisualStyleBackColor = false;
            this.btn_sesion.Click += new System.EventHandler(this.btn_sesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btn_editar_nota);
            this.panel1.Controls.Add(this.btn_ver_notas);
            this.panel1.Controls.Add(this.btn_crear_nota);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_edit_msg);
            this.panel1.Controls.Add(this.btn_sesion);
            this.panel1.Controls.Add(this.btn_registro);
            this.panel1.Controls.Add(this.btn_deposito);
            this.panel1.Controls.Add(this.lbl_name_logged);
            this.panel1.Controls.Add(this.btn_extraccion);
            this.panel1.Controls.Add(this.pbx_act_sess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 531);
            this.panel1.TabIndex = 15;
            // 
            // btn_editar_nota
            // 
            this.btn_editar_nota.BackColor = System.Drawing.Color.White;
            this.btn_editar_nota.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_editar_nota.FlatAppearance.BorderSize = 2;
            this.btn_editar_nota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_nota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_editar_nota.Image = global::CajaDeAhorro.Properties.Resources._17369_edit_file_icon;
            this.btn_editar_nota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar_nota.Location = new System.Drawing.Point(3, 291);
            this.btn_editar_nota.Name = "btn_editar_nota";
            this.btn_editar_nota.Size = new System.Drawing.Size(189, 46);
            this.btn_editar_nota.TabIndex = 22;
            this.btn_editar_nota.Text = "Editar Nota";
            this.btn_editar_nota.UseVisualStyleBackColor = false;
            this.btn_editar_nota.Click += new System.EventHandler(this.btn_editar_nota_Click);
            // 
            // btn_ver_notas
            // 
            this.btn_ver_notas.BackColor = System.Drawing.Color.White;
            this.btn_ver_notas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_ver_notas.FlatAppearance.BorderSize = 2;
            this.btn_ver_notas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_notas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ver_notas.Image = global::CajaDeAhorro.Properties.Resources._17332_binoculars_icon;
            this.btn_ver_notas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_notas.Location = new System.Drawing.Point(3, 339);
            this.btn_ver_notas.Name = "btn_ver_notas";
            this.btn_ver_notas.Size = new System.Drawing.Size(189, 46);
            this.btn_ver_notas.TabIndex = 21;
            this.btn_ver_notas.Text = "Ver Notas";
            this.btn_ver_notas.UseVisualStyleBackColor = false;
            // 
            // btn_crear_nota
            // 
            this.btn_crear_nota.BackColor = System.Drawing.Color.White;
            this.btn_crear_nota.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_crear_nota.FlatAppearance.BorderSize = 2;
            this.btn_crear_nota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_nota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_crear_nota.Image = global::CajaDeAhorro.Properties.Resources._17368_add_file_icon;
            this.btn_crear_nota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crear_nota.Location = new System.Drawing.Point(3, 243);
            this.btn_crear_nota.Name = "btn_crear_nota";
            this.btn_crear_nota.Size = new System.Drawing.Size(189, 46);
            this.btn_crear_nota.TabIndex = 20;
            this.btn_crear_nota.Text = "Crear Nota";
            this.btn_crear_nota.UseVisualStyleBackColor = false;
            this.btn_crear_nota.Click += new System.EventHandler(this.btn_crear_nota_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::CajaDeAhorro.Properties.Resources.Trafficlight_green_icon;
            this.pictureBox1.Location = new System.Drawing.Point(105, 475);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_edit_msg
            // 
            this.btn_edit_msg.BackColor = System.Drawing.Color.White;
            this.btn_edit_msg.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_edit_msg.FlatAppearance.BorderSize = 2;
            this.btn_edit_msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_msg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit_msg.Image = global::CajaDeAhorro.Properties.Resources._17399_blog_edit_message_pencil_sms_icon__2_;
            this.btn_edit_msg.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_edit_msg.Location = new System.Drawing.Point(3, 195);
            this.btn_edit_msg.Name = "btn_edit_msg";
            this.btn_edit_msg.Size = new System.Drawing.Size(189, 46);
            this.btn_edit_msg.TabIndex = 15;
            this.btn_edit_msg.Text = "Editar Mensaje";
            this.btn_edit_msg.UseVisualStyleBackColor = false;
            // 
            // lbl_name_logged
            // 
            this.lbl_name_logged.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_logged.Location = new System.Drawing.Point(24, 498);
            this.lbl_name_logged.Name = "lbl_name_logged";
            this.lbl_name_logged.Size = new System.Drawing.Size(146, 19);
            this.lbl_name_logged.TabIndex = 18;
            this.lbl_name_logged.Text = "usuario";
            this.lbl_name_logged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbx_act_sess
            // 
            this.pbx_act_sess.Image = global::CajaDeAhorro.Properties.Resources._6358078_account_avatar_man_people_person_icon;
            this.pbx_act_sess.Location = new System.Drawing.Point(73, 440);
            this.pbx_act_sess.Name = "pbx_act_sess";
            this.pbx_act_sess.Size = new System.Drawing.Size(48, 50);
            this.pbx_act_sess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_act_sess.TabIndex = 17;
            this.pbx_act_sess.TabStop = false;
            // 
            // sesionTableAdapter1
            // 
            this.sesionTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_saldo_disponible
            // 
            this.lbl_saldo_disponible.AutoSize = true;
            this.lbl_saldo_disponible.BackColor = System.Drawing.Color.White;
            this.lbl_saldo_disponible.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo_disponible.ForeColor = System.Drawing.Color.Black;
            this.lbl_saldo_disponible.Location = new System.Drawing.Point(713, 442);
            this.lbl_saldo_disponible.Name = "lbl_saldo_disponible";
            this.lbl_saldo_disponible.Size = new System.Drawing.Size(142, 21);
            this.lbl_saldo_disponible.TabIndex = 16;
            this.lbl_saldo_disponible.Text = "Saldo Disponible";
            this.lbl_saldo_disponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fecha_portada
            // 
            this.lbl_fecha_portada.AutoSize = true;
            this.lbl_fecha_portada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_fecha_portada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_portada.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha_portada.Location = new System.Drawing.Point(380, 48);
            this.lbl_fecha_portada.Name = "lbl_fecha_portada";
            this.lbl_fecha_portada.Size = new System.Drawing.Size(119, 18);
            this.lbl_fecha_portada.TabIndex = 20;
            this.lbl_fecha_portada.Text = "Saldo Disponible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(246, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Últimos Movimientos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moviBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(253, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(304, 207);
            this.dataGridView1.TabIndex = 22;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "G";
            dataGridViewCellStyle7.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 130;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 80;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Width = 90;
            // 
            // moviBindingSource
            // 
            this.moviBindingSource.DataMember = "movi";
            this.moviBindingSource.DataSource = this.c_AHORRO_NEW_DS1;
            // 
            // moviTableAdapter
            // 
            this.moviTableAdapter.ClearBeforeFill = true;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // fKmensajemoviBindingSource
            // 
            this.fKmensajemoviBindingSource.DataMember = "FK_mensaje_movi";
            this.fKmensajemoviBindingSource.DataSource = this.moviBindingSource;
            // 
            // mensajeTableAdapter
            // 
            this.mensajeTableAdapter.ClearBeforeFill = true;
            // 
            // flp_note
            // 
            this.flp_note.BackColor = System.Drawing.Color.White;
            this.flp_note.Location = new System.Drawing.Point(594, 152);
            this.flp_note.Name = "flp_note";
            this.flp_note.Size = new System.Drawing.Size(264, 207);
            this.flp_note.TabIndex = 23;
            this.flp_note.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flp_note_ControlAdded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(606, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Últimas Notas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(878, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flp_note);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fecha_portada);
            this.Controls.Add(this.lbl_saldo_disponible);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_caja_valor);
            this.Controls.Add(this.lbl_caja_titulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_dios_desmolde);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-- CAJA DE AHORRO --";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_act_sess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKmensajemoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_caja_titulo;
        private System.Windows.Forms.Label lbl_caja_valor;
        private System.Windows.Forms.Button btn_deposito;
        private System.Windows.Forms.Button btn_extraccion;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_dios_desmolde;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.loginTableAdapter loginTableAdapter1;
        private System.Windows.Forms.Button btn_sesion;
        private System.Windows.Forms.Panel panel1;
        private C_AHORRO_NEW_DSTableAdapters.sesionTableAdapter sesionTableAdapter1;
        private System.Windows.Forms.Label lbl_saldo_disponible;
        private System.Windows.Forms.PictureBox pbx_act_sess;
        private System.Windows.Forms.Label lbl_name_logged;
        private System.Windows.Forms.Label lbl_fecha_portada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource moviBindingSource;
        private C_AHORRO_NEW_DSTableAdapters.moviTableAdapter moviTableAdapter;
        private C_AHORRO_NEW_DSTableAdapters.notasTableAdapter notasTableAdapter;
        private System.Windows.Forms.Button btn_edit_msg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource fKmensajemoviBindingSource;
        private C_AHORRO_NEW_DSTableAdapters.mensajeTableAdapter mensajeTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flp_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_ver_notas;
        private System.Windows.Forms.Button btn_crear_nota;
        private System.Windows.Forms.Button btn_editar_nota;
    }
}

