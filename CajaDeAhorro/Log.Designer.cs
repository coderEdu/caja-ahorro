
namespace CajaDeAhorro
{
    partial class Log
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.grp_busqueda = new System.Windows.Forms.GroupBox();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.check_fecha = new System.Windows.Forms.CheckBox();
            this.check_fechas = new System.Windows.Forms.CheckBox();
            this.dtp_exacta = new System.Windows.Forms.DateTimePicker();
            this.lbl_exacta = new System.Windows.Forms.Label();
            this.moviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.btn_buscar_trans = new System.Windows.Forms.Button();
            this.lbl_trans_finds = new System.Windows.Forms.Label();
            this.moviTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.moviTableAdapter();
            this.grp_fechas = new System.Windows.Forms.GroupBox();
            this.grp_fecha = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check_busc_msg = new System.Windows.Forms.CheckBox();
            this.grp_busc_msg = new System.Windows.Forms.GroupBox();
            this.txt_busc_msg = new System.Windows.Forms.TextBox();
            this.check_monto = new System.Windows.Forms.CheckBox();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.grp_monto = new System.Windows.Forms.GroupBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.grp_resultado = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.mensajeTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.mensajeTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_edit_msg = new System.Windows.Forms.Button();
            this.btn_crea_nota = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.c_AHORRO_NEW_DS2 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_row_index = new System.Windows.Forms.Label();
            this.grp_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.grp_fechas.SuspendLayout();
            this.grp_fecha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grp_busc_msg.SuspendLayout();
            this.grp_monto.SuspendLayout();
            this.grp_resultado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_desde
            // 
            this.dtp_desde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_desde.Location = new System.Drawing.Point(26, 45);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(200, 22);
            this.dtp_desde.TabIndex = 0;
            // 
            // lbl_desde
            // 
            this.lbl_desde.BackColor = System.Drawing.Color.Silver;
            this.lbl_desde.Location = new System.Drawing.Point(26, 29);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(200, 13);
            this.lbl_desde.TabIndex = 1;
            this.lbl_desde.Text = "desde:";
            this.lbl_desde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.BackColor = System.Drawing.Color.Silver;
            this.lbl_hasta.Location = new System.Drawing.Point(26, 82);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(200, 13);
            this.lbl_hasta.TabIndex = 3;
            this.lbl_hasta.Text = "hasta:";
            this.lbl_hasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hasta.Location = new System.Drawing.Point(26, 98);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_hasta.TabIndex = 2;
            // 
            // grp_busqueda
            // 
            this.grp_busqueda.BackColor = System.Drawing.SystemColors.Window;
            this.grp_busqueda.Controls.Add(this.cbx_tipo);
            this.grp_busqueda.Location = new System.Drawing.Point(21, 22);
            this.grp_busqueda.Name = "grp_busqueda";
            this.grp_busqueda.Size = new System.Drawing.Size(249, 57);
            this.grp_busqueda.TabIndex = 4;
            this.grp_busqueda.TabStop = false;
            this.grp_busqueda.Text = "tipo de transacción a buscar";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "AMBOS",
            "DEPOSITOS",
            "EXTRACCIONES"});
            this.cbx_tipo.Location = new System.Drawing.Point(26, 21);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(200, 26);
            this.cbx_tipo.TabIndex = 5;
            this.cbx_tipo.TabStop = false;
            this.cbx_tipo.Text = "AMBOS";
            // 
            // check_fecha
            // 
            this.check_fecha.AutoSize = true;
            this.check_fecha.Location = new System.Drawing.Point(5, 257);
            this.check_fecha.Name = "check_fecha";
            this.check_fecha.Size = new System.Drawing.Size(15, 14);
            this.check_fecha.TabIndex = 11;
            this.check_fecha.UseVisualStyleBackColor = true;
            this.check_fecha.CheckStateChanged += new System.EventHandler(this.Checks_CheckStateChanged);
            // 
            // check_fechas
            // 
            this.check_fechas.AutoSize = true;
            this.check_fechas.Location = new System.Drawing.Point(5, 93);
            this.check_fechas.Name = "check_fechas";
            this.check_fechas.Size = new System.Drawing.Size(15, 14);
            this.check_fechas.TabIndex = 10;
            this.check_fechas.UseVisualStyleBackColor = true;
            this.check_fechas.CheckStateChanged += new System.EventHandler(this.Checks_CheckStateChanged);
            // 
            // dtp_exacta
            // 
            this.dtp_exacta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_exacta.Location = new System.Drawing.Point(26, 46);
            this.dtp_exacta.Name = "dtp_exacta";
            this.dtp_exacta.Size = new System.Drawing.Size(200, 22);
            this.dtp_exacta.TabIndex = 7;
            // 
            // lbl_exacta
            // 
            this.lbl_exacta.BackColor = System.Drawing.Color.Silver;
            this.lbl_exacta.Location = new System.Drawing.Point(26, 30);
            this.lbl_exacta.Name = "lbl_exacta";
            this.lbl_exacta.Size = new System.Drawing.Size(200, 13);
            this.lbl_exacta.TabIndex = 8;
            this.lbl_exacta.Text = "fecha exacta:";
            this.lbl_exacta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moviBindingSource
            // 
            this.moviBindingSource.DataMember = "movi";
            this.moviBindingSource.DataSource = this.c_AHORRO_NEW_DS1;
            // 
            // c_AHORRO_NEW_DS1
            // 
            this.c_AHORRO_NEW_DS1.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_buscar_trans
            // 
            this.btn_buscar_trans.BackColor = System.Drawing.Color.White;
            this.btn_buscar_trans.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_buscar_trans.FlatAppearance.BorderSize = 2;
            this.btn_buscar_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_trans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscar_trans.Location = new System.Drawing.Point(769, 623);
            this.btn_buscar_trans.Name = "btn_buscar_trans";
            this.btn_buscar_trans.Size = new System.Drawing.Size(106, 30);
            this.btn_buscar_trans.TabIndex = 6;
            this.btn_buscar_trans.TabStop = false;
            this.btn_buscar_trans.Text = "Buscar";
            this.btn_buscar_trans.UseVisualStyleBackColor = false;
            this.btn_buscar_trans.Click += new System.EventHandler(this.btn_buscar_trans_Click);
            // 
            // lbl_trans_finds
            // 
            this.lbl_trans_finds.BackColor = System.Drawing.Color.White;
            this.lbl_trans_finds.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trans_finds.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_trans_finds.Location = new System.Drawing.Point(7, 21);
            this.lbl_trans_finds.Name = "lbl_trans_finds";
            this.lbl_trans_finds.Size = new System.Drawing.Size(244, 23);
            this.lbl_trans_finds.TabIndex = 7;
            this.lbl_trans_finds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moviTableAdapter1
            // 
            this.moviTableAdapter1.ClearBeforeFill = true;
            // 
            // grp_fechas
            // 
            this.grp_fechas.BackColor = System.Drawing.SystemColors.Window;
            this.grp_fechas.Controls.Add(this.lbl_desde);
            this.grp_fechas.Controls.Add(this.dtp_desde);
            this.grp_fechas.Controls.Add(this.dtp_hasta);
            this.grp_fechas.Controls.Add(this.lbl_hasta);
            this.grp_fechas.Location = new System.Drawing.Point(36, 108);
            this.grp_fechas.Name = "grp_fechas";
            this.grp_fechas.Size = new System.Drawing.Size(249, 143);
            this.grp_fechas.TabIndex = 6;
            this.grp_fechas.TabStop = false;
            this.grp_fechas.Text = "buscar en un período";
            // 
            // grp_fecha
            // 
            this.grp_fecha.BackColor = System.Drawing.SystemColors.Window;
            this.grp_fecha.Controls.Add(this.lbl_exacta);
            this.grp_fecha.Controls.Add(this.dtp_exacta);
            this.grp_fecha.Location = new System.Drawing.Point(36, 272);
            this.grp_fecha.Name = "grp_fecha";
            this.grp_fecha.Size = new System.Drawing.Size(249, 88);
            this.grp_fecha.TabIndex = 6;
            this.grp_fecha.TabStop = false;
            this.grp_fecha.Text = "buscar en una fecha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.check_fecha);
            this.panel1.Controls.Add(this.check_fechas);
            this.panel1.Controls.Add(this.grp_busqueda);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 367);
            this.panel1.TabIndex = 12;
            // 
            // check_busc_msg
            // 
            this.check_busc_msg.AutoSize = true;
            this.check_busc_msg.Location = new System.Drawing.Point(6, 113);
            this.check_busc_msg.Name = "check_busc_msg";
            this.check_busc_msg.Size = new System.Drawing.Size(15, 14);
            this.check_busc_msg.TabIndex = 17;
            this.check_busc_msg.UseVisualStyleBackColor = true;
            this.check_busc_msg.CheckStateChanged += new System.EventHandler(this.Checks_CheckStateChanged);
            // 
            // grp_busc_msg
            // 
            this.grp_busc_msg.BackColor = System.Drawing.SystemColors.Window;
            this.grp_busc_msg.Controls.Add(this.txt_busc_msg);
            this.grp_busc_msg.Location = new System.Drawing.Point(22, 113);
            this.grp_busc_msg.Name = "grp_busc_msg";
            this.grp_busc_msg.Size = new System.Drawing.Size(225, 75);
            this.grp_busc_msg.TabIndex = 16;
            this.grp_busc_msg.TabStop = false;
            this.grp_busc_msg.Text = "buscar en los mensajes";
            // 
            // txt_busc_msg
            // 
            this.txt_busc_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txt_busc_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_busc_msg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busc_msg.Location = new System.Drawing.Point(17, 27);
            this.txt_busc_msg.Multiline = true;
            this.txt_busc_msg.Name = "txt_busc_msg";
            this.txt_busc_msg.Size = new System.Drawing.Size(192, 27);
            this.txt_busc_msg.TabIndex = 14;
            this.txt_busc_msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check_monto
            // 
            this.check_monto.AutoSize = true;
            this.check_monto.Location = new System.Drawing.Point(6, 22);
            this.check_monto.Name = "check_monto";
            this.check_monto.Size = new System.Drawing.Size(15, 14);
            this.check_monto.TabIndex = 15;
            this.check_monto.UseVisualStyleBackColor = true;
            this.check_monto.CheckStateChanged += new System.EventHandler(this.Checks_CheckStateChanged);
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.lbl_concepto.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_concepto.Location = new System.Drawing.Point(6, 7);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(552, 137);
            this.lbl_concepto.TabIndex = 14;
            this.lbl_concepto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_concepto.VisibleChanged += new System.EventHandler(this.lbl_concepto_VisibleChanged);
            // 
            // grp_monto
            // 
            this.grp_monto.BackColor = System.Drawing.SystemColors.Window;
            this.grp_monto.Controls.Add(this.txt_monto);
            this.grp_monto.Location = new System.Drawing.Point(22, 22);
            this.grp_monto.Name = "grp_monto";
            this.grp_monto.Size = new System.Drawing.Size(225, 75);
            this.grp_monto.TabIndex = 6;
            this.grp_monto.TabStop = false;
            this.grp_monto.Text = "buscar por monto";
            // 
            // txt_monto
            // 
            this.txt_monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_monto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(17, 27);
            this.txt_monto.Multiline = true;
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(192, 27);
            this.txt_monto.TabIndex = 14;
            this.txt_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_total.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(26, 96);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(241, 51);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.Text = "Total:  $";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_resultado
            // 
            this.grp_resultado.Controls.Add(this.lbl_trans_finds);
            this.grp_resultado.Location = new System.Drawing.Point(18, 26);
            this.grp_resultado.Name = "grp_resultado";
            this.grp_resultado.Size = new System.Drawing.Size(257, 57);
            this.grp_resultado.TabIndex = 12;
            this.grp_resultado.TabStop = false;
            this.grp_resultado.Text = "coincidencias";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(51)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(944, 431);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 28);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // mensajeTableAdapter1
            // 
            this.mensajeTableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.grp_monto);
            this.panel2.Controls.Add(this.check_busc_msg);
            this.panel2.Controls.Add(this.check_monto);
            this.panel2.Controls.Add(this.grp_busc_msg);
            this.panel2.Location = new System.Drawing.Point(312, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 211);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.btn_edit_msg);
            this.panel3.Controls.Add(this.btn_crea_nota);
            this.panel3.Controls.Add(this.grp_resultado);
            this.panel3.Controls.Add(this.lbl_total);
            this.panel3.Location = new System.Drawing.Point(585, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 211);
            this.panel3.TabIndex = 15;
            // 
            // btn_edit_msg
            // 
            this.btn_edit_msg.BackColor = System.Drawing.Color.White;
            this.btn_edit_msg.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edit_msg.FlatAppearance.BorderSize = 2;
            this.btn_edit_msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_msg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit_msg.Location = new System.Drawing.Point(150, 158);
            this.btn_edit_msg.Name = "btn_edit_msg";
            this.btn_edit_msg.Size = new System.Drawing.Size(116, 30);
            this.btn_edit_msg.TabIndex = 18;
            this.btn_edit_msg.TabStop = false;
            this.btn_edit_msg.Text = "Editar concepto";
            this.btn_edit_msg.UseVisualStyleBackColor = false;
            this.btn_edit_msg.Click += new System.EventHandler(this.btn_edit_msg_Click);
            // 
            // btn_crea_nota
            // 
            this.btn_crea_nota.BackColor = System.Drawing.Color.White;
            this.btn_crea_nota.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_crea_nota.FlatAppearance.BorderSize = 2;
            this.btn_crea_nota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crea_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crea_nota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_crea_nota.Location = new System.Drawing.Point(28, 158);
            this.btn_crea_nota.Name = "btn_crea_nota";
            this.btn_crea_nota.Size = new System.Drawing.Size(116, 30);
            this.btn_crea_nota.TabIndex = 17;
            this.btn_crea_nota.TabStop = false;
            this.btn_crea_nota.Text = "Crear nota";
            this.btn_crea_nota.UseVisualStyleBackColor = false;
            this.btn_crea_nota.Click += new System.EventHandler(this.btn_crea_nota_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.lbl_concepto);
            this.panel4.Location = new System.Drawing.Point(312, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 150);
            this.panel4.TabIndex = 16;
            // 
            // c_AHORRO_NEW_DS2
            // 
            this.c_AHORRO_NEW_DS2.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.moviBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(15, 388);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 47;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(861, 222);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.Enter += new System.EventHandler(this.dgv_Enter);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "F";
            dataGridViewCellStyle4.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 460;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 140;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Width = 200;
            // 
            // lbl_row_index
            // 
            this.lbl_row_index.AutoSize = true;
            this.lbl_row_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_row_index.Location = new System.Drawing.Point(12, 631);
            this.lbl_row_index.Name = "lbl_row_index";
            this.lbl_row_index.Size = new System.Drawing.Size(75, 15);
            this.lbl_row_index.TabIndex = 17;
            this.lbl_row_index.Text = "RowIndex = ";
            // 
            // Log
            // 
            this.AcceptButton = this.btn_buscar_trans;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(887, 665);
            this.Controls.Add(this.lbl_row_index);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.grp_fecha);
            this.Controls.Add(this.grp_fechas);
            this.Controls.Add(this.btn_buscar_trans);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de transacciones";
            this.Load += new System.EventHandler(this.Log_Load);
            this.grp_busqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            this.grp_fechas.ResumeLayout(false);
            this.grp_fecha.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_busc_msg.ResumeLayout(false);
            this.grp_busc_msg.PerformLayout();
            this.grp_monto.ResumeLayout(false);
            this.grp_monto.PerformLayout();
            this.grp_resultado.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.GroupBox grp_busqueda;
        private System.Windows.Forms.Button btn_buscar_trans;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label lbl_trans_finds;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.moviTableAdapter moviTableAdapter1;
        private System.Windows.Forms.BindingSource moviBindingSource;
        private System.Windows.Forms.DateTimePicker dtp_exacta;
        private System.Windows.Forms.Label lbl_exacta;
        private System.Windows.Forms.CheckBox check_fecha;
        private System.Windows.Forms.CheckBox check_fechas;
        private System.Windows.Forms.GroupBox grp_fechas;
        private System.Windows.Forms.GroupBox grp_fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox grp_resultado;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.GroupBox grp_monto;
        private System.Windows.Forms.Label lbl_concepto;
        private C_AHORRO_NEW_DSTableAdapters.mensajeTableAdapter mensajeTableAdapter1;
        private System.Windows.Forms.CheckBox check_monto;
        private System.Windows.Forms.CheckBox check_busc_msg;
        private System.Windows.Forms.GroupBox grp_busc_msg;
        private System.Windows.Forms.TextBox txt_busc_msg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_crea_nota;
        private System.Windows.Forms.Button btn_edit_msg;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_row_index;
    }
}