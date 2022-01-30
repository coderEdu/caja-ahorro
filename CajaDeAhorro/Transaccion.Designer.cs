
namespace CajaDeAhorro
{
    partial class Transaccion
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
            this.btn_trans = new System.Windows.Forms.Button();
            this.lbl_trans = new System.Windows.Forms.Label();
            this.txt_trans_monto = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.moviTableAdapter2 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.moviTableAdapter();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.loginTableAdapter();
            this.mensajeTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.mensajeTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_container = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_trans
            // 
            this.btn_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btn_trans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(51)))));
            this.btn_trans.FlatAppearance.BorderSize = 2;
            this.btn_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_trans.Location = new System.Drawing.Point(337, 195);
            this.btn_trans.Name = "btn_trans";
            this.btn_trans.Size = new System.Drawing.Size(86, 29);
            this.btn_trans.TabIndex = 2;
            this.btn_trans.Text = "Efectuar";
            this.btn_trans.UseVisualStyleBackColor = false;
            this.btn_trans.Click += new System.EventHandler(this.btn_trans_Click);
            // 
            // lbl_trans
            // 
            this.lbl_trans.BackColor = System.Drawing.Color.White;
            this.lbl_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trans.Location = new System.Drawing.Point(170, 9);
            this.lbl_trans.Name = "lbl_trans";
            this.lbl_trans.Size = new System.Drawing.Size(140, 18);
            this.lbl_trans.TabIndex = 1;
            this.lbl_trans.Text = "Monto:";
            this.lbl_trans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_trans_monto
            // 
            this.txt_trans_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trans_monto.Location = new System.Drawing.Point(170, 31);
            this.txt_trans_monto.MaxLength = 6;
            this.txt_trans_monto.Multiline = true;
            this.txt_trans_monto.Name = "txt_trans_monto";
            this.txt_trans_monto.Size = new System.Drawing.Size(237, 28);
            this.txt_trans_monto.TabIndex = 0;
            this.txt_trans_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_trans_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trans_monto_KeyPress);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(10, 204);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 3;
            // 
            // c_AHORRO_NEW_DS1
            // 
            this.c_AHORRO_NEW_DS1.DataSetName = "C_AHORRO_NEW_DS";
            this.c_AHORRO_NEW_DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviTableAdapter2
            // 
            this.moviTableAdapter2.ClearBeforeFill = true;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_concepto.Location = new System.Drawing.Point(178, 96);
            this.txt_concepto.MaxLength = 148;
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(237, 77);
            this.txt_concepto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Concepto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // mensajeTableAdapter1
            // 
            this.mensajeTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::CajaDeAhorro.Properties.Resources.atm;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.White;
            this.pnl_container.Controls.Add(this.pictureBox1);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.txt_trans_monto);
            this.pnl_container.Controls.Add(this.lbl_trans);
            this.pnl_container.Location = new System.Drawing.Point(10, 9);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(413, 180);
            this.pnl_container.TabIndex = 0;
            // 
            // Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(433, 233);
            this.Controls.Add(this.txt_concepto);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btn_trans);
            this.Controls.Add(this.pnl_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposito";
            this.Load += new System.EventHandler(this.Transaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_trans;
        private System.Windows.Forms.Label lbl_trans;
        private System.Windows.Forms.TextBox txt_trans_monto;
        private System.Windows.Forms.DateTimePicker dtp;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.loginTableAdapter loginTableAdapter1;
        private C_AHORRO_NEW_DSTableAdapters.moviTableAdapter moviTableAdapter2;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label1;
        private C_AHORRO_NEW_DSTableAdapters.mensajeTableAdapter mensajeTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_container;
    }
}