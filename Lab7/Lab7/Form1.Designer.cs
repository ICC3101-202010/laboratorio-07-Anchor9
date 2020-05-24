namespace Lab7
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
            this.Entrada = new System.Windows.Forms.TextBox();
            this.Resultado_previo = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_decimal = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entrada
            // 
            this.Entrada.Location = new System.Drawing.Point(12, 12);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(442, 20);
            this.Entrada.TabIndex = 0;
            this.Entrada.TextChanged += new System.EventHandler(this.Entrada_TextChanged);
            // 
            // Resultado_previo
            // 
            this.Resultado_previo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Resultado_previo.Location = new System.Drawing.Point(122, 51);
            this.Resultado_previo.Name = "Resultado_previo";
            this.Resultado_previo.Size = new System.Drawing.Size(317, 27);
            this.Resultado_previo.TabIndex = 1;
            this.Resultado_previo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Resultado_previo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.Location = new System.Drawing.Point(12, 91);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(104, 40);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Yellow;
            this.btn2.Location = new System.Drawing.Point(122, 91);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(104, 40);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Yellow;
            this.btn3.Location = new System.Drawing.Point(232, 91);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(104, 40);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Yellow;
            this.btn4.Location = new System.Drawing.Point(12, 161);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(104, 40);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Yellow;
            this.btn5.Location = new System.Drawing.Point(122, 161);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(104, 40);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Yellow;
            this.btn6.Location = new System.Drawing.Point(232, 161);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(104, 40);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Yellow;
            this.btn7.Location = new System.Drawing.Point(12, 228);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(104, 40);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Yellow;
            this.btn8.Location = new System.Drawing.Point(122, 228);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(104, 40);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Yellow;
            this.btn9.Location = new System.Drawing.Point(232, 228);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(104, 40);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Yellow;
            this.btn0.Location = new System.Drawing.Point(122, 297);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(104, 40);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn_suma
            // 
            this.btn_suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_suma.Location = new System.Drawing.Point(350, 91);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(104, 40);
            this.btn_suma.TabIndex = 12;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = false;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_resta.Location = new System.Drawing.Point(350, 137);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(104, 40);
            this.btn_resta.TabIndex = 13;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = false;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_mult.Location = new System.Drawing.Point(350, 183);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(104, 40);
            this.btn_mult.TabIndex = 14;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = false;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_div.Location = new System.Drawing.Point(350, 228);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(104, 40);
            this.btn_div.TabIndex = 15;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_CE.Location = new System.Drawing.Point(232, 297);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(104, 40);
            this.btn_CE.TabIndex = 16;
            this.btn_CE.Text = "C E";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_igual.Location = new System.Drawing.Point(350, 330);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(104, 40);
            this.btn_igual.TabIndex = 17;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_decimal
            // 
            this.btn_decimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decimal.Location = new System.Drawing.Point(12, 297);
            this.btn_decimal.Name = "btn_decimal";
            this.btn_decimal.Size = new System.Drawing.Size(104, 40);
            this.btn_decimal.TabIndex = 18;
            this.btn_decimal.Text = ".";
            this.btn_decimal.UseVisualStyleBackColor = false;
            this.btn_decimal.Click += new System.EventHandler(this.btn_decimal_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnswer.Location = new System.Drawing.Point(350, 274);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(104, 40);
            this.btnAnswer.TabIndex = 19;
            this.btnAnswer.Text = "ANS";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(12, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 40);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DEL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btn_decimal);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Resultado_previo);
            this.Controls.Add(this.Entrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Entrada;
        private System.Windows.Forms.Label Resultado_previo;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_decimal;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnDelete;
    }
}

