
namespace CajaDeAhorro
{
    partial class Administrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.btn_eliminar_usuario = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabPrefer = new System.Windows.Forms.TabPage();
            this.moviTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.moviTableAdapter();
            this.loginTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.loginTableAdapter();
            this.btn_salir = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabUsuarios);
            this.MainTab.Controls.Add(this.TabPrefer);
            this.MainTab.Location = new System.Drawing.Point(18, 21);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(905, 388);
            this.MainTab.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.btn_eliminar_usuario);
            this.tabUsuarios.Controls.Add(this.dataGridView2);
            this.tabUsuarios.Controls.Add(this.dataGridView1);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(897, 362);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_usuario
            // 
            this.btn_eliminar_usuario.Location = new System.Drawing.Point(21, 26);
            this.btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            this.btn_eliminar_usuario.Size = new System.Drawing.Size(117, 30);
            this.btn_eliminar_usuario.TabIndex = 2;
            this.btn_eliminar_usuario.Text = "Eliminar";
            this.btn_eliminar_usuario.UseVisualStyleBackColor = true;
            this.btn_eliminar_usuario.Click += new System.EventHandler(this.btn_eliminar_usuario_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.moviBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(382, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(494, 263);
            this.dataGridView2.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "F";
            dataGridViewCellStyle3.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 250;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 70;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.usuarioDataGridViewTextBoxColumn,
            this.contraDataGridViewTextBoxColumn,
            this.cajaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.usuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraDataGridViewTextBoxColumn
            // 
            this.contraDataGridViewTextBoxColumn.DataPropertyName = "contra";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.contraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.contraDataGridViewTextBoxColumn.HeaderText = "contraseña";
            this.contraDataGridViewTextBoxColumn.Name = "contraDataGridViewTextBoxColumn";
            this.contraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajaDataGridViewTextBoxColumn
            // 
            this.cajaDataGridViewTextBoxColumn.DataPropertyName = "caja";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.cajaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.cajaDataGridViewTextBoxColumn.HeaderText = "caja";
            this.cajaDataGridViewTextBoxColumn.Name = "cajaDataGridViewTextBoxColumn";
            this.cajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.c_AHORRO_NEW_DS1;
            // 
            // TabPrefer
            // 
            this.TabPrefer.Location = new System.Drawing.Point(4, 22);
            this.TabPrefer.Name = "TabPrefer";
            this.TabPrefer.Padding = new System.Windows.Forms.Padding(3);
            this.TabPrefer.Size = new System.Drawing.Size(897, 362);
            this.TabPrefer.TabIndex = 1;
            this.TabPrefer.Text = "Preferencias";
            this.TabPrefer.UseVisualStyleBackColor = true;
            // 
            // moviTableAdapter1
            // 
            this.moviTableAdapter1.ClearBeforeFill = true;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(827, 418);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(92, 31);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 465);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.MainTab);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAJA DE AHORRO - Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrador_FormClosing);
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.MainTab.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage TabPrefer;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.moviTableAdapter moviTableAdapter1;
        private C_AHORRO_NEW_DSTableAdapters.loginTableAdapter loginTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource moviBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajaDataGridViewTextBoxColumn;
    }
}