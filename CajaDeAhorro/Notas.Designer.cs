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
            this.tab_notas = new System.Windows.Forms.TabControl();
            this.tabP_nuevo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_texto_nota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titulo_nota = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabP_editar = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tabP_eliminar = new System.Windows.Forms.TabPage();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.notasTableAdapter = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.notasTableAdapter();
            this.tab_notas.SuspendLayout();
            this.tabP_nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabP_editar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_notas
            // 
            this.tab_notas.Controls.Add(this.tabP_nuevo);
            this.tab_notas.Controls.Add(this.tabP_editar);
            this.tab_notas.Controls.Add(this.tabP_eliminar);
            this.tab_notas.Location = new System.Drawing.Point(12, 21);
            this.tab_notas.Name = "tab_notas";
            this.tab_notas.SelectedIndex = 0;
            this.tab_notas.Size = new System.Drawing.Size(663, 369);
            this.tab_notas.TabIndex = 1;
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
            this.tabP_nuevo.Size = new System.Drawing.Size(655, 343);
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
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto de la nota:";
            // 
            // txt_texto_nota
            // 
            this.txt_texto_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_texto_nota.Location = new System.Drawing.Point(329, 117);
            this.txt_texto_nota.Multiline = true;
            this.txt_texto_nota.Name = "txt_texto_nota";
            this.txt_texto_nota.Size = new System.Drawing.Size(296, 199);
            this.txt_texto_nota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìtulo de la nota:";
            // 
            // txt_titulo_nota
            // 
            this.txt_titulo_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo_nota.Location = new System.Drawing.Point(331, 45);
            this.txt_titulo_nota.Name = "txt_titulo_nota";
            this.txt_titulo_nota.Size = new System.Drawing.Size(294, 21);
            this.txt_titulo_nota.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CajaDeAhorro.Properties.Resources._2620509_employee_job_note_seeker_unemployee_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(40, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabP_editar
            // 
            this.tabP_editar.Controls.Add(this.richTextBox1);
            this.tabP_editar.Controls.Add(this.label4);
            this.tabP_editar.Controls.Add(this.dataGridView1);
            this.tabP_editar.Controls.Add(this.label3);
            this.tabP_editar.Controls.Add(this.textBox3);
            this.tabP_editar.Controls.Add(this.btn_buscar);
            this.tabP_editar.Location = new System.Drawing.Point(4, 22);
            this.tabP_editar.Name = "tabP_editar";
            this.tabP_editar.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_editar.Size = new System.Drawing.Size(655, 343);
            this.tabP_editar.TabIndex = 1;
            this.tabP_editar.Text = "Editar";
            this.tabP_editar.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(323, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 242);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Texto de la nota:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(274, 242);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 45;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 120;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultados de búsqueda:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(418, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(574, 6);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // tabP_eliminar
            // 
            this.tabP_eliminar.Location = new System.Drawing.Point(4, 22);
            this.tabP_eliminar.Name = "tabP_eliminar";
            this.tabP_eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_eliminar.Size = new System.Drawing.Size(655, 343);
            this.tabP_eliminar.TabIndex = 2;
            this.tabP_eliminar.Text = "Eliminar";
            this.tabP_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(584, 396);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(87, 33);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 438);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_notas;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private C_AHORRO_NEW_DSTableAdapters.notasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
    }
}