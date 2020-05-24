using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        double first;
        double second;
        double final;
        string operation;

 
        public Form1()
        {
            InitializeComponent();
        }

        private void Entrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR")
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "1";
            Resultado_previo.Text = Resultado_previo.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR")
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "2";
            Resultado_previo.Text = Resultado_previo.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR")
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "3";
            Resultado_previo.Text = Resultado_previo.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR" || Entrada.Text == final.ToString())
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "4";
            Resultado_previo.Text = Resultado_previo.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR" || Entrada.Text == final.ToString())
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "5";
            Resultado_previo.Text = Resultado_previo.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR" || Entrada.Text == final.ToString())
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "6";
            Resultado_previo.Text = Resultado_previo.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR" || Entrada.Text == final.ToString())
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "7";
            Resultado_previo.Text = Resultado_previo.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR" || Entrada.Text == final.ToString())
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "8";
            Resultado_previo.Text = Resultado_previo.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR" || Entrada.Text == final.ToString())
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "9";
            Resultado_previo.Text = Resultado_previo.Text + "9";
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR" || Entrada.Text == "Math ERROR" )
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + ",";
            Resultado_previo.Text = Resultado_previo.Text + ",";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "Syntax ERROR")
            {
                Entrada.Clear();
            }
            Entrada.Text = Entrada.Text + "0";
            Resultado_previo.Text = Resultado_previo.Text + "0";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            Entrada.Clear();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operation = "+";
            int cont = 0;
            foreach (var letra in Entrada.Text)
            {
                if (letra == ',')
                {
                    cont++;
                }

            }
            if (cont > 1)
            {
                Entrada.Text = "Syntax ERROR";

            }
            else
            {
                first = Convert.ToDouble(Entrada.Text);
                Entrada.Clear();
                Resultado_previo.Text = Resultado_previo.Text + "+";
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operation = "-";
            int cont = 0;
            foreach (var letra in Entrada.Text)
            {
                if (letra == ',')
                {
                    cont++;
                }

            }
            if (cont > 1)
            {
                Entrada.Text = "Syntax ERROR";
                
            }
            else 
            {
                first = Convert.ToDouble(Entrada.Text);
                Entrada.Clear();
                Resultado_previo.Text = Resultado_previo.Text + "-";
            }
;
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            operation = "*";
            first = Convert.ToDouble(Entrada.Text);
            Entrada.Clear();
            Resultado_previo.Text = Resultado_previo.Text + "*";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operation = "/";
            first = Convert.ToDouble(Entrada.Text);
            Entrada.Clear();
            Resultado_previo.Text = Resultado_previo.Text + "/";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
  

            second = double.Parse(Entrada.Text);
            
            if (operation == "+")
            {

                Resultado_previo.Text = final.ToString();
                final = first + second;
                Entrada.Clear();
                Entrada.Text = final.ToString();
                //Resultado_previo.Text = final.ToString();
            }
            else if (operation == "*")
            {
                Resultado_previo.Text = final.ToString();
                final = first * second;
                Entrada.Clear();
                Entrada.Text = final.ToString();
            }
            else if (operation == "/")
            {
                if (second == 0)
                {
                    Entrada.Text = "Math ERROR";
                }
                else 
                {
                    Resultado_previo.Text = final.ToString();
                    final = first / second;
                    Entrada.Clear();
                    Entrada.Text = final.ToString();

                }

            }
            else if (operation == "-")
            {
                Resultado_previo.Text = final.ToString();
                final = first - second;
                Entrada.Clear();
                Entrada.Text = final.ToString();
            }
            Resultado_previo.Text = "";






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Entrada.Text != "")
            {
                int cont = 0;
                foreach (char letra in Entrada.Text)
                {
                    cont++;

                }
                Entrada.Text = Entrada.Text.Remove(cont - 1);
                //Resultado_previo.Text = Resultado_previo.Text.Remove(cont - 1);
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Entrada.Text = final.ToString();
        }
    }
}
