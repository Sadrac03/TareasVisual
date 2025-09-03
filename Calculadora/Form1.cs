using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_basica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "000";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {
                textBox1.Text = Math.Sqrt(valor).ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
           if(textBox1.TextLength == 1 ) textBox1.Text = "0";
           else textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength-1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);

            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        MessageBox.Show("No se puede dividir entre cero");
                    break;
                case "pow":
                    resultado = Math.Pow(num1, num2);
                    break;
            }
            textBox1.Text = resultado.ToString();
            operador = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "00";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + ")";
        }

        double memoria = 0;
        private void btnM1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {
                memoria += valor;
                textBox1.Clear();
            }
        }


        private void btnExp_Click(object sender, EventArgs e)
        {
            string[] valores = textBox1.Text.Split('^');
            if (double.TryParse(textBox1.Text, out num1))
            {
                operador = "pow";
                textBox1.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "(";
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {
                memoria -= valor;
                textBox1.Clear();
            }
        }

        private void btnM3_Click(object sender, EventArgs e)
        {
            memoria = 0;
            textBox1.Clear();
        }

        private void btnM4_Click(object sender, EventArgs e)
        {
            textBox1.Text = memoria.ToString();
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor) && valor > 0)
            {
                textBox1.Text = Math.Log10(valor).ToString();
            }
        }
    }
}