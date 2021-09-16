
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.btn_buscar_trans = new System.Windows.Forms.Button();
            this.lbl_trans_finds = new System.Windows.Forms.Label();
            this.moviTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.moviTableAdapter();
            this.grp_fechas = new System.Windows.Forms.GroupBox();
            this.grp_fecha = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_monto = new System.Windows.Forms.GroupBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.grp_resultado = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.grp_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            this.grp_fechas.SuspendLayout();
            this.grp_fecha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grp_monto.SuspendLayout();
            this.grp_resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_desde
            // 
            this.dtp_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_desde.Location = new System.Drawing.Point(26, 49);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_desde.TabIndex = 0;
            // 
            // lbl_desde
            // 
            this.lbl_desde.BackColor = System.Drawing.Color.Silver;
            this.lbl_desde.Location = new System.Drawing.Point(26, 33);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(200, 13);
            this.lbl_desde.TabIndex = 1;
            this.lbl_desde.Text = "desde:";
            this.lbl_desde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.BackColor = System.Drawing.Color.Silver;
            this.lbl_hasta.Location = new System.Drawing.Point(246, 33);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(197, 13);
            this.lbl_hasta.TabIndex = 3;
            this.lbl_hasta.Text = "hasta:";
            this.lbl_hasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Location = new System.Drawing.Point(246, 49);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(197, 20);
            this.dtp_hasta.TabIndex = 2;
            // 
            // grp_busqueda
            // 
            this.grp_busqueda.BackColor = System.Drawing.SystemColors.Window;
            this.grp_busqueda.Controls.Add(this.cbx_tipo);
            this.grp_busqueda.Location = new System.Drawing.Point(21, 22);
            this.grp_busqueda.Name = "grp_busqueda";
            this.grp_busqueda.Size = new System.Drawing.Size(471, 57);
            this.grp_busqueda.TabIndex = 4;
            this.grp_busqueda.TabStop = false;
            this.grp_busqueda.Text = "Tipo de transacción a buscar";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "-- AMBOS --",
            "-- DEPOSITOS --",
            "-- EXTRACCIONES --"});
            this.cbx_tipo.Location = new System.Drawing.Point(159, 21);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(148, 23);
            this.cbx_tipo.TabIndex = 5;
            this.cbx_tipo.Text = "-- AMBOS --";
            // 
            // check_fecha
            // 
            this.check_fecha.AutoSize = true;
            this.check_fecha.Location = new System.Drawing.Point(251, 307);
            this.check_fecha.Name = "check_fecha";
            this.check_fecha.Size = new System.Drawing.Size(15, 14);
            this.check_fecha.TabIndex = 11;
            this.check_fecha.UseVisualStyleBackColor = true;
            this.check_fecha.CheckStateChanged += new System.EventHandler(this.Checks_CheckStateChanged);
            // 
            // check_fechas
            // 
            this.check_fechas.AutoSize = true;
            this.check_fechas.Location = new System.Drawing.Point(251, 186);
            this.check_fechas.Name = "check_fechas";
            this.check_fechas.Size = new System.Drawing.Size(15, 14);
            this.check_fechas.TabIndex = 10;
            this.check_fechas.UseVisualStyleBackColor = true;
            this.check_fechas.CheckStateChanged += new System.EventHandler(this.Checks_CheckStateChanged);
            // 
            // dtp_exacta
            // 
            this.dtp_exacta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_exacta.Location = new System.Drawing.Point(135, 49);
            this.dtp_exacta.Name = "dtp_exacta";
            this.dtp_exacta.Size = new System.Drawing.Size(200, 20);
            this.dtp_exacta.TabIndex = 7;
            // 
            // lbl_exacta
            // 
            this.lbl_exacta.BackColor = System.Drawing.Color.Silver;
            this.lbl_exacta.Location = new System.Drawing.Point(135, 33);
            this.lbl_exacta.Name = "lbl_exacta";
            this.lbl_exacta.Size = new System.Drawing.Size(200, 13);
            this.lbl_exacta.TabIndex = 8;
            this.lbl_exacta.Text = "fecha exacta:";
            this.lbl_exacta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.moviBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(508, 22);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(482, 221);
            this.dgv.TabIndex = 5;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "F";
            dataGridViewCellStyle10.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.btn_buscar_trans.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_buscar_trans.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_buscar_trans.FlatAppearance.BorderSize = 2;
            this.btn_buscar_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_trans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_buscar_trans.Location = new System.Drawing.Point(808, 433);
            this.btn_buscar_trans.Name = "btn_buscar_trans";
            this.btn_buscar_trans.Size = new System.Drawing.Size(106, 28);
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
            this.lbl_trans_finds.Location = new System.Drawing.Point(6, 21);
            this.lbl_trans_finds.Name = "lbl_trans_finds";
            this.lbl_trans_finds.Size = new System.Drawing.Size(470, 23);
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
            this.grp_fechas.Location = new System.Drawing.Point(36, 103);
            this.grp_fechas.Name = "grp_fechas";
            this.grp_fechas.Size = new System.Drawing.Size(471, 92);
            this.grp_fechas.TabIndex = 6;
            this.grp_fechas.TabStop = false;
            this.grp_fechas.Text = "Buscar en un rango de fechas";
            // 
            // grp_fecha
            // 
            this.grp_fecha.BackColor = System.Drawing.SystemColors.Window;
            this.grp_fecha.Controls.Add(this.lbl_exacta);
            this.grp_fecha.Controls.Add(this.dtp_exacta);
            this.grp_fecha.Location = new System.Drawing.Point(36, 224);
            this.grp_fecha.Name = "grp_fecha";
            this.grp_fecha.Size = new System.Drawing.Size(471, 92);
            this.grp_fecha.TabIndex = 6;
            this.grp_fecha.TabStop = false;
            this.grp_fecha.Text = "Buscar en una fecha en particular";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.grp_monto);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.grp_resultado);
            this.panel1.Controls.Add(this.check_fecha);
            this.panel1.Controls.Add(this.check_fechas);
            this.panel1.Controls.Add(this.grp_busqueda);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 404);
            this.panel1.TabIndex = 12;
            // 
            // grp_monto
            // 
            this.grp_monto.BackColor = System.Drawing.SystemColors.Window;
            this.grp_monto.Controls.Add(this.txt_monto);
            this.grp_monto.Location = new System.Drawing.Point(21, 329);
            this.grp_monto.Name = "grp_monto";
            this.grp_monto.Size = new System.Drawing.Size(471, 57);
            this.grp_monto.TabIndex = 6;
            this.grp_monto.TabStop = false;
            this.grp_monto.Text = "Buscar por monto";
            // 
            // txt_monto
            // 
            this.txt_monto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_monto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(186, 21);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 23);
            this.txt_monto.TabIndex = 14;
            this.txt_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_total.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(793, 252);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(197, 23);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.Text = "Total:  $";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_resultado
            // 
            this.grp_resultado.Controls.Add(this.lbl_trans_finds);
            this.grp_resultado.Location = new System.Drawing.Point(508, 330);
            this.grp_resultado.Name = "grp_resultado";
            this.grp_resultado.Size = new System.Drawing.Size(482, 57);
            this.grp_resultado.TabIndex = 12;
            this.grp_resultado.TabStop = false;
            this.grp_resultado.Text = "Resultados de la búsqueda";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar.Location = new System.Drawing.Point(920, 433);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 28);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Log
            // 
            this.AcceptButton = this.btn_buscar_trans;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1041, 471);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.grp_fecha);
            this.Controls.Add(this.grp_fechas);
            this.Controls.Add(this.btn_buscar_trans);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de transacciones";
            this.Load += new System.EventHandler(this.Log_Load);
            this.grp_busqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            this.grp_fechas.ResumeLayout(false);
            this.grp_fecha.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_monto.ResumeLayout(false);
            this.grp_monto.PerformLayout();
            this.grp_resultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.GroupBox grp_busqueda;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_buscar_trans;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label lbl_trans_finds;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.moviTableAdapter moviTableAdapter1;
        private System.Windows.Forms.BindingSource moviBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
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
    }
}