namespace CajaDeAhorro
{
    partial class DetNota
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
            System.Windows.Forms.Label fec_creaLabel;
            System.Windows.Forms.Label fec_modifLabel;
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_crea = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.notasTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.notasTableAdapter();
            this.c_AHORRO_NEW_DS = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaTextBox = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            fec_creaLabel = new System.Windows.Forms.Label();
            fec_modifLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fec_creaLabel
            // 
            fec_creaLabel.AutoSize = true;
            fec_creaLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fec_creaLabel.Location = new System.Drawing.Point(24, 202);
            fec_creaLabel.Name = "fec_creaLabel";
            fec_creaLabel.Size = new System.Drawing.Size(45, 15);
            fec_creaLabel.TabIndex = 25;
            fec_creaLabel.Text = "creada:";
            // 
            // fec_modifLabel
            // 
            fec_modifLabel.AutoSize = true;
            fec_modifLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fec_modifLabel.Location = new System.Drawing.Point(24, 228);
            fec_modifLabel.Name = "fec_modifLabel";
            fec_modifLabel.Size = new System.Drawing.Size(50, 15);
            fec_modifLabel.TabIndex = 26;
            fec_modifLabel.Text = "modific:";
            // 
            // label4
            // 
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "fec_modif", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.label4.Location = new System.Drawing.Point(80, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 28;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_crea
            // 
            this.lbl_crea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "fec_crea", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lbl_crea.Location = new System.Drawing.Point(80, 202);
            this.lbl_crea.Name = "lbl_crea";
            this.lbl_crea.Size = new System.Drawing.Size(222, 13);
            this.lbl_crea.TabIndex = 27;
            this.lbl_crea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(240, 268);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 29;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // c_AHORRO_NEW_DS1
            // 
            this.c_AHORRO_NEW_DS1.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasTableAdapter1
            // 
            this.notasTableAdapter1.ClearBeforeFill = true;
            // 
            // c_AHORRO_NEW_DS
            // 
            this.c_AHORRO_NEW_DS.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.c_AHORRO_NEW_DS;
            // 
            // notaTextBox
            // 
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "nota", true));
            this.notaTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.notaTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaTextBox.Location = new System.Drawing.Point(0, 0);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(327, 179);
            this.notaTextBox.TabIndex = 30;
            // 
            // lbl_name
            // 
            this.lbl_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "titulo", true));
            this.lbl_name.Location = new System.Drawing.Point(12, 279);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(132, 13);
            this.lbl_name.TabIndex = 31;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DetNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 301);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_crea);
            this.Controls.Add(fec_creaLabel);
            this.Controls.Add(fec_modifLabel);
            this.Name = "DetNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Texto de la nota";
            this.Load += new System.EventHandler(this.DetNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_crea;
        private System.Windows.Forms.Button btn_aceptar;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.notasTableAdapter notasTableAdapter1;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private System.Windows.Forms.Label notaTextBox;
        private System.Windows.Forms.Label lbl_name;
    }
}