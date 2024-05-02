namespace CajaDeAhorro
{
    partial class Notas
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label notaLabel;
            System.Windows.Forms.Label id_logLabel;
            System.Windows.Forms.Label fec_creaLabel;
            System.Windows.Forms.Label fec_modifLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_notas = new System.Windows.Forms.TabControl();
            this.tabP_nuevo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_texto_nota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titulo_nota = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabP_editar = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.lbl_crea = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.id_logTextBox = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tabP_eliminar = new System.Windows.Forms.TabPage();
            this.lbl_texto_nota = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar_id = new System.Windows.Forms.Button();
            this.lbl_id_elim = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dtp_notas = new System.Windows.Forms.DateTimePicker();
            this.notasTableAdapter = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.notasTableAdapter();
            this.notasTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.notasTableAdapter();
            this.tableAdapterManager = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.TableAdapterManager();
            this.c_AHORRO_NEW_DS_Notas = new CajaDeAhorro.C_AHORRO_NEW_DS();
            idLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            id_logLabel = new System.Windows.Forms.Label();
            fec_creaLabel = new System.Windows.Forms.Label();
            fec_modifLabel = new System.Windows.Forms.Label();
            this.tab_notas.SuspendLayout();
            this.tabP_nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabP_editar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS)).BeginInit();
            this.tabP_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS_Notas)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(339, 113);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 4;
            idLabel.Text = "id:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(339, 139);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(32, 13);
            tituloLabel.TabIndex = 6;
            tituloLabel.Text = "titulo:";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new System.Drawing.Point(339, 168);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(31, 13);
            notaLabel.TabIndex = 8;
            notaLabel.Text = "nota:";
            // 
            // id_logLabel
            // 
            id_logLabel.AutoSize = true;
            id_logLabel.Location = new System.Drawing.Point(339, 289);
            id_logLabel.Name = "id_logLabel";
            id_logLabel.Size = new System.Drawing.Size(35, 13);
            id_logLabel.TabIndex = 10;
            id_logLabel.Text = "id log:";
            // 
            // fec_creaLabel
            // 
            fec_creaLabel.AutoSize = true;
            fec_creaLabel.Location = new System.Drawing.Point(339, 316);
            fec_creaLabel.Name = "fec_creaLabel";
            fec_creaLabel.Size = new System.Drawing.Size(43, 13);
            fec_creaLabel.TabIndex = 12;
            fec_creaLabel.Text = "creada:";
            // 
            // fec_modifLabel
            // 
            fec_modifLabel.AutoSize = true;
            fec_modifLabel.Location = new System.Drawing.Point(339, 342);
            fec_modifLabel.Name = "fec_modifLabel";
            fec_modifLabel.Size = new System.Drawing.Size(43, 13);
            fec_modifLabel.TabIndex = 14;
            fec_modifLabel.Text = "modific:";
            // 
            // tab_notas
            // 
            this.tab_notas.Controls.Add(this.tabP_nuevo);
            this.tab_notas.Controls.Add(this.tabP_editar);
            this.tab_notas.Controls.Add(this.tabP_eliminar);
            this.tab_notas.Location = new System.Drawing.Point(9, 21);
            this.tab_notas.Name = "tab_notas";
            this.tab_notas.SelectedIndex = 0;
            this.tab_notas.Size = new System.Drawing.Size(663, 413);
            this.tab_notas.TabIndex = 0;
            this.tab_notas.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_notas_Selected);
            // 
            // tabP_nuevo
            // 
            this.tabP_nuevo.Controls.Add(this.label2);
            this.tabP_nuevo.Controls.Add(this.txt_texto_nota);
            this.tabP_nuevo.Controls.Add(this.label1);
            this.tabP_nuevo.Controls.Add(this.txt_titulo_nota);
            this.tabP_nuevo.Controls.Add(this.pictureBox1);
            this.tabP_nuevo.Location = new System.Drawing.Point(4, 22);
            this.tabP_nuevo.Name = "tabP_nuevo";
            this.tabP_nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_nuevo.Size = new System.Drawing.Size(655, 387);
            this.tabP_nuevo.TabIndex = 0;
            this.tabP_nuevo.Text = "Nuevo";
            this.tabP_nuevo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto:";
            // 
            // txt_texto_nota
            // 
            this.txt_texto_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_texto_nota.Location = new System.Drawing.Point(329, 117);
            this.txt_texto_nota.Multiline = true;
            this.txt_texto_nota.Name = "txt_texto_nota";
            this.txt_texto_nota.Size = new System.Drawing.Size(296, 234);
            this.txt_texto_nota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título:";
            // 
            // txt_titulo_nota
            // 
            this.txt_titulo_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo_nota.Location = new System.Drawing.Point(329, 48);
            this.txt_titulo_nota.Name = "txt_titulo_nota";
            this.txt_titulo_nota.Size = new System.Drawing.Size(296, 26);
            this.txt_titulo_nota.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CajaDeAhorro.Properties.Resources._314233_note_list_icon_512;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabP_editar
            // 
            this.tabP_editar.AutoScroll = true;
            this.tabP_editar.Controls.Add(this.label5);
            this.tabP_editar.Controls.Add(this.label4);
            this.tabP_editar.Controls.Add(this.lbl_crea);
            this.tabP_editar.Controls.Add(idLabel);
            this.tabP_editar.Controls.Add(this.idTextBox);
            this.tabP_editar.Controls.Add(tituloLabel);
            this.tabP_editar.Controls.Add(this.tituloTextBox);
            this.tabP_editar.Controls.Add(notaLabel);
            this.tabP_editar.Controls.Add(this.notaTextBox);
            this.tabP_editar.Controls.Add(id_logLabel);
            this.tabP_editar.Controls.Add(this.id_logTextBox);
            this.tabP_editar.Controls.Add(fec_creaLabel);
            this.tabP_editar.Controls.Add(fec_modifLabel);
            this.tabP_editar.Controls.Add(this.dgv);
            this.tabP_editar.Controls.Add(this.label3);
            this.tabP_editar.Controls.Add(this.textBox3);
            this.tabP_editar.Controls.Add(this.btn_buscar);
            this.tabP_editar.Location = new System.Drawing.Point(4, 22);
            this.tabP_editar.Name = "tabP_editar";
            this.tabP_editar.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_editar.Size = new System.Drawing.Size(655, 387);
            this.tabP_editar.TabIndex = 1;
            this.tabP_editar.Text = "Editar";
            this.tabP_editar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "valor:";
            // 
            // label4
            // 
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource1, "fec_modif", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.label4.Location = new System.Drawing.Point(395, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 16;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notasBindingSource1
            // 
            this.notasBindingSource1.DataMember = "notas";
            this.notasBindingSource1.DataSource = this.c_AHORRO_NEW_DS1;
            // 
            // c_AHORRO_NEW_DS1
            // 
            this.c_AHORRO_NEW_DS1.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_crea
            // 
            this.lbl_crea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource1, "fec_crea", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lbl_crea.Location = new System.Drawing.Point(395, 316);
            this.lbl_crea.Name = "lbl_crea";
            this.lbl_crea.Size = new System.Drawing.Size(222, 13);
            this.lbl_crea.TabIndex = 15;
            this.lbl_crea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource1, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(395, 110);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(222, 20);
            this.idTextBox.TabIndex = 5;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource1, "titulo", true));
            this.tituloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.Location = new System.Drawing.Point(395, 136);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(222, 26);
            this.tituloTextBox.TabIndex = 7;
            // 
            // notaTextBox
            // 
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource1, "nota", true));
            this.notaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaTextBox.Location = new System.Drawing.Point(395, 168);
            this.notaTextBox.Multiline = true;
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(222, 112);
            this.notaTextBox.TabIndex = 9;
            // 
            // id_logTextBox
            // 
            this.id_logTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource1, "id_log", true));
            this.id_logTextBox.Location = new System.Drawing.Point(395, 286);
            this.id_logTextBox.Name = "id_logTextBox";
            this.id_logTextBox.ReadOnly = true;
            this.id_logTextBox.Size = new System.Drawing.Size(222, 20);
            this.id_logTextBox.TabIndex = 11;
            this.id_logTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.notasBindingSource;
            this.dgv.Location = new System.Drawing.Point(31, 110);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(276, 248);
            this.dgv.TabIndex = 3;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 55;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 220;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.c_AHORRO_NEW_DS;
            // 
            // c_AHORRO_NEW_DS
            // 
            this.c_AHORRO_NEW_DS.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Todas las notas:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(463, 20);
            this.textBox3.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(539, 40);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(78, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // tabP_eliminar
            // 
            this.tabP_eliminar.Controls.Add(this.lbl_texto_nota);
            this.tabP_eliminar.Controls.Add(this.btn_eliminar);
            this.tabP_eliminar.Controls.Add(this.btn_buscar_id);
            this.tabP_eliminar.Controls.Add(this.lbl_id_elim);
            this.tabP_eliminar.Controls.Add(this.txt_id);
            this.tabP_eliminar.Controls.Add(this.pictureBox2);
            this.tabP_eliminar.Location = new System.Drawing.Point(4, 22);
            this.tabP_eliminar.Name = "tabP_eliminar";
            this.tabP_eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_eliminar.Size = new System.Drawing.Size(655, 387);
            this.tabP_eliminar.TabIndex = 2;
            this.tabP_eliminar.Text = "Eliminar";
            this.tabP_eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_texto_nota
            // 
            this.lbl_texto_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.lbl_texto_nota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_texto_nota.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto_nota.Location = new System.Drawing.Point(328, 63);
            this.lbl_texto_nota.Name = "lbl_texto_nota";
            this.lbl_texto_nota.Size = new System.Drawing.Size(316, 237);
            this.lbl_texto_nota.TabIndex = 7;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(555, 303);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(89, 31);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar_id
            // 
            this.btn_buscar_id.Location = new System.Drawing.Point(569, 29);
            this.btn_buscar_id.Name = "btn_buscar_id";
            this.btn_buscar_id.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_id.TabIndex = 4;
            this.btn_buscar_id.Text = "buscar";
            this.btn_buscar_id.UseVisualStyleBackColor = true;
            this.btn_buscar_id.Click += new System.EventHandler(this.btn_buscar_id_Click);
            // 
            // lbl_id_elim
            // 
            this.lbl_id_elim.AutoSize = true;
            this.lbl_id_elim.Location = new System.Drawing.Point(464, 34);
            this.lbl_id_elim.Name = "lbl_id_elim";
            this.lbl_id_elim.Size = new System.Drawing.Size(19, 13);
            this.lbl_id_elim.TabIndex = 3;
            this.lbl_id_elim.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(489, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(74, 20);
            this.txt_id.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CajaDeAhorro.Properties.Resources._314282_trash_can_icon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(582, 440);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(87, 33);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dtp_notas
            // 
            this.dtp_notas.Location = new System.Drawing.Point(475, 2);
            this.dtp_notas.Name = "dtp_notas";
            this.dtp_notas.Size = new System.Drawing.Size(200, 20);
            this.dtp_notas.TabIndex = 4;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // notasTableAdapter1
            // 
            this.notasTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.creadoTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.mensajeTableAdapter = null;
            this.tableAdapterManager.moviTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.prestamoTableAdapter = null;
            this.tableAdapterManager.sesionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // c_AHORRO_NEW_DS_Notas
            // 
            this.c_AHORRO_NEW_DS_Notas.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS_Notas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 481);
            this.Controls.Add(this.dtp_notas);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tab_notas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            this.tab_notas.ResumeLayout(false);
            this.tabP_nuevo.ResumeLayout(false);
            this.tabP_nuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabP_editar.ResumeLayout(false);
            this.tabP_editar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS)).EndInit();
            this.tabP_eliminar.ResumeLayout(false);
            this.tabP_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS_Notas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabP_nuevo;
        private System.Windows.Forms.TabPage tabP_editar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TabPage tabP_eliminar;
        private System.Windows.Forms.TextBox txt_titulo_nota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_texto_nota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private C_AHORRO_NEW_DSTableAdapters.notasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DateTimePicker dtp_notas;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.notasTableAdapter notasTableAdapter1;
        private C_AHORRO_NEW_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource notasBindingSource1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox notaTextBox;
        private System.Windows.Forms.TextBox id_logTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_crea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tab_notas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar_id;
        private System.Windows.Forms.Label lbl_id_elim;
        private System.Windows.Forms.TextBox txt_id;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS_Notas;
        private System.Windows.Forms.Label lbl_texto_nota;
    }
}