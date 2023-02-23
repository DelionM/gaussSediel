namespace gaussSediel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.txt_x3 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ValX = new System.Windows.Forms.TextBox();
            this.txt_ValY = new System.Windows.Forms.TextBox();
            this.txt_ValZ = new System.Windows.Forms.TextBox();
            this.txtErrorMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtErrorZ = new System.Windows.Forms.TextBox();
            this.txtErrorY = new System.Windows.Forms.TextBox();
            this.txtErrorX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Gplano = new System.Windows.Forms.PictureBox();
            this.lblG = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gplano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_x1
            // 
            this.txt_x1.BackColor = System.Drawing.Color.Black;
            this.txt_x1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x1.ForeColor = System.Drawing.Color.White;
            this.txt_x1.Location = new System.Drawing.Point(121, 82);
            this.txt_x1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(507, 30);
            this.txt_x1.TabIndex = 2;
            // 
            // txt_x2
            // 
            this.txt_x2.BackColor = System.Drawing.Color.Black;
            this.txt_x2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x2.ForeColor = System.Drawing.Color.White;
            this.txt_x2.Location = new System.Drawing.Point(121, 154);
            this.txt_x2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.Size = new System.Drawing.Size(510, 30);
            this.txt_x2.TabIndex = 6;
            // 
            // txt_x3
            // 
            this.txt_x3.BackColor = System.Drawing.Color.Black;
            this.txt_x3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x3.ForeColor = System.Drawing.Color.White;
            this.txt_x3.Location = new System.Drawing.Point(121, 229);
            this.txt_x3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_x3.Name = "txt_x3";
            this.txt_x3.Size = new System.Drawing.Size(507, 30);
            this.txt_x3.TabIndex = 10;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Black;
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(423, 305);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 38);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Valor aproximado para X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 448);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor aproximado para Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 519);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valor aproximado para Z";
            // 
            // txt_ValX
            // 
            this.txt_ValX.BackColor = System.Drawing.Color.Black;
            this.txt_ValX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ValX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValX.ForeColor = System.Drawing.Color.White;
            this.txt_ValX.Location = new System.Drawing.Point(135, 412);
            this.txt_ValX.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValX.Name = "txt_ValX";
            this.txt_ValX.ReadOnly = true;
            this.txt_ValX.Size = new System.Drawing.Size(81, 23);
            this.txt_ValX.TabIndex = 16;
            // 
            // txt_ValY
            // 
            this.txt_ValY.BackColor = System.Drawing.Color.Black;
            this.txt_ValY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ValY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValY.ForeColor = System.Drawing.Color.White;
            this.txt_ValY.Location = new System.Drawing.Point(135, 484);
            this.txt_ValY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValY.Name = "txt_ValY";
            this.txt_ValY.ReadOnly = true;
            this.txt_ValY.Size = new System.Drawing.Size(81, 23);
            this.txt_ValY.TabIndex = 17;
            // 
            // txt_ValZ
            // 
            this.txt_ValZ.BackColor = System.Drawing.Color.Black;
            this.txt_ValZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ValZ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValZ.ForeColor = System.Drawing.Color.White;
            this.txt_ValZ.Location = new System.Drawing.Point(135, 558);
            this.txt_ValZ.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValZ.Name = "txt_ValZ";
            this.txt_ValZ.ReadOnly = true;
            this.txt_ValZ.Size = new System.Drawing.Size(81, 23);
            this.txt_ValZ.TabIndex = 18;
            // 
            // txtErrorMinimo
            // 
            this.txtErrorMinimo.BackColor = System.Drawing.Color.Black;
            this.txtErrorMinimo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorMinimo.ForeColor = System.Drawing.Color.White;
            this.txtErrorMinimo.Location = new System.Drawing.Point(423, 20);
            this.txtErrorMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorMinimo.Name = "txtErrorMinimo";
            this.txtErrorMinimo.Size = new System.Drawing.Size(80, 30);
            this.txtErrorMinimo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(187, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Porcentaje Error permitido";
            // 
            // txtErrorZ
            // 
            this.txtErrorZ.BackColor = System.Drawing.Color.Black;
            this.txtErrorZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrorZ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorZ.ForeColor = System.Drawing.Color.White;
            this.txtErrorZ.Location = new System.Drawing.Point(487, 558);
            this.txtErrorZ.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorZ.Name = "txtErrorZ";
            this.txtErrorZ.ReadOnly = true;
            this.txtErrorZ.Size = new System.Drawing.Size(81, 23);
            this.txtErrorZ.TabIndex = 21;
            this.txtErrorZ.TextChanged += new System.EventHandler(this.txtErrorZ_TextChanged);
            // 
            // txtErrorY
            // 
            this.txtErrorY.BackColor = System.Drawing.Color.Black;
            this.txtErrorY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrorY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorY.ForeColor = System.Drawing.Color.White;
            this.txtErrorY.Location = new System.Drawing.Point(487, 484);
            this.txtErrorY.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorY.Name = "txtErrorY";
            this.txtErrorY.ReadOnly = true;
            this.txtErrorY.Size = new System.Drawing.Size(81, 23);
            this.txtErrorY.TabIndex = 20;
            // 
            // txtErrorX
            // 
            this.txtErrorX.BackColor = System.Drawing.Color.Black;
            this.txtErrorX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrorX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorX.ForeColor = System.Drawing.Color.White;
            this.txtErrorX.Location = new System.Drawing.Point(487, 412);
            this.txtErrorX.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorX.Name = "txtErrorX";
            this.txtErrorX.ReadOnly = true;
            this.txtErrorX.Size = new System.Drawing.Size(81, 23);
            this.txtErrorX.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(420, 519);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 22);
            this.label14.TabIndex = 33;
            this.label14.Text = "Error aproximado para Z";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(420, 448);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "Error aproximado para Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(420, 382);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 22);
            this.label16.TabIndex = 31;
            this.label16.Text = "Error aproximado para X";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.BackColor = System.Drawing.Color.Black;
            this.txtIteraciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIteraciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteraciones.ForeColor = System.Drawing.Color.White;
            this.txtIteraciones.Location = new System.Drawing.Point(321, 644);
            this.txtIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.ReadOnly = true;
            this.txtIteraciones.Size = new System.Drawing.Size(81, 23);
            this.txtIteraciones.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(269, 608);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 22);
            this.label17.TabIndex = 37;
            this.label17.Text = "Iteraciones realizadas";
            // 
            // Gplano
            // 
            this.Gplano.BackColor = System.Drawing.Color.Black;
            this.Gplano.Location = new System.Drawing.Point(720, 69);
            this.Gplano.Margin = new System.Windows.Forms.Padding(4);
            this.Gplano.Name = "Gplano";
            this.Gplano.Size = new System.Drawing.Size(533, 492);
            this.Gplano.TabIndex = 39;
            this.Gplano.TabStop = false;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.ForeColor = System.Drawing.Color.White;
            this.lblG.Location = new System.Drawing.Point(961, 11);
            this.lblG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(70, 22);
            this.lblG.TabIndex = 40;
            this.lblG.Text = "Grafica";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(685, 558);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 31);
            this.label19.TabIndex = 42;
            this.label19.Text = "y";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(685, 556);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 31);
            this.label20.TabIndex = 43;
            this.label20.Text = "x";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = global::gaussSediel.Properties.Resources.Borrar;
            this.btnClear.Location = new System.Drawing.Point(275, 305);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 52);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClear.TabIndex = 44;
            this.btnClear.TabStop = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(487, 412);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(81, 23);
            this.textBox4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(326, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ecuacion 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(326, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ecuacion 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(326, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Ecuacion 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1289, 690);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtErrorZ);
            this.Controls.Add(this.txtErrorY);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtErrorX);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtErrorMinimo);
            this.Controls.Add(this.txt_ValZ);
            this.Controls.Add(this.txt_ValY);
            this.Controls.Add(this.txt_ValX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txt_x3);
            this.Controls.Add(this.txt_x2);
            this.Controls.Add(this.txt_x1);
            this.Controls.Add(this.Gplano);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gplano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.TextBox txt_x3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ValX;
        private System.Windows.Forms.TextBox txt_ValY;
        private System.Windows.Forms.TextBox txt_ValZ;
        private System.Windows.Forms.TextBox txtErrorMinimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtErrorZ;
        private System.Windows.Forms.TextBox txtErrorY;
        private System.Windows.Forms.TextBox txtErrorX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox Gplano;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

