
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
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.c_AHORRO_NEW_DS1 = new CajaDeAhorro.C_AHORRO_NEW_DS();
            this.moviTableAdapter2 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.moviTableAdapter();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.loginTableAdapter();
            this.mensajeTableAdapter1 = new CajaDeAhorro.C_AHORRO_NEW_DSTableAdapters.mensajeTableAdapter();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txt_trans_monto = new System.Windows.Forms.Label();
            this.btn_correctivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c_AHORRO_NEW_DS1)).BeginInit();
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
            this.btn_trans.Location = new System.Drawing.Point(266, 220);
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
            this.lbl_trans.Location = new System.Drawing.Point(15, 9);
            this.lbl_trans.Name = "lbl_trans";
            this.lbl_trans.Size = new System.Drawing.Size(184, 18);
            this.lbl_trans.TabIndex = 1;
            this.lbl_trans.Text = "Monto:";
            this.lbl_trans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(10, 223);
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
            this.txt_concepto.Location = new System.Drawing.Point(18, 103);
            this.txt_concepto.MaxLength = 148;
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(182, 77);
            this.txt_concepto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
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
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.White;
            this.pnl_container.Controls.Add(this.btn_correctivo);
            this.pnl_container.Controls.Add(this.btnDel);
            this.pnl_container.Controls.Add(this.btn0);
            this.pnl_container.Controls.Add(this.btn3);
            this.pnl_container.Controls.Add(this.btn2);
            this.pnl_container.Controls.Add(this.btn1);
            this.pnl_container.Controls.Add(this.btn6);
            this.pnl_container.Controls.Add(this.btn5);
            this.pnl_container.Controls.Add(this.btn4);
            this.pnl_container.Controls.Add(this.btn9);
            this.pnl_container.Controls.Add(this.btn8);
            this.pnl_container.Controls.Add(this.btn7);
            this.pnl_container.Controls.Add(this.txt_concepto);
            this.pnl_container.Controls.Add(this.txt_trans_monto);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.lbl_trans);
            this.pnl_container.Location = new System.Drawing.Point(10, 9);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(342, 199);
            this.pnl_container.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(293, 148);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(32, 32);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "←";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(215, 147);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 32);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(293, 110);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(32, 32);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(253, 110);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(32, 32);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(215, 109);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(32, 32);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(293, 72);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(32, 32);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(253, 72);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(32, 32);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(215, 71);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(32, 32);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(293, 34);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(32, 32);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(253, 34);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(32, 32);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(215, 33);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(32, 32);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            // 
            // txt_trans_monto
            // 
            this.txt_trans_monto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_trans_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trans_monto.Location = new System.Drawing.Point(15, 35);
            this.txt_trans_monto.Name = "txt_trans_monto";
            this.txt_trans_monto.Size = new System.Drawing.Size(184, 31);
            this.txt_trans_monto.TabIndex = 7;
            this.txt_trans_monto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_correctivo
            // 
            this.btn_correctivo.BackColor = System.Drawing.Color.Crimson;
            this.btn_correctivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_correctivo.ForeColor = System.Drawing.Color.White;
            this.btn_correctivo.Location = new System.Drawing.Point(174, 76);
            this.btn_correctivo.Name = "btn_correctivo";
            this.btn_correctivo.Size = new System.Drawing.Size(25, 25);
            this.btn_correctivo.TabIndex = 20;
            this.btn_correctivo.Text = "C";
            this.btn_correctivo.UseVisualStyleBackColor = false;
            this.btn_correctivo.Click += new System.EventHandler(this.btn_correctivo_Click);
            // 
            // Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(363, 262);
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
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_trans;
        private System.Windows.Forms.Label lbl_trans;
        private System.Windows.Forms.DateTimePicker dtp;
        private C_AHORRO_NEW_DS c_AHORRO_NEW_DS1;
        private C_AHORRO_NEW_DSTableAdapters.loginTableAdapter loginTableAdapter1;
        private C_AHORRO_NEW_DSTableAdapters.moviTableAdapter moviTableAdapter2;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label1;
        private C_AHORRO_NEW_DSTableAdapters.mensajeTableAdapter mensajeTableAdapter1;
        private System.Windows.Forms.Panel pnl_container;
        private System.Windows.Forms.Label txt_trans_monto;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn_correctivo;
    }
}