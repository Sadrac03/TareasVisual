using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.visual_practica_2
{
    public partial class Form1 : Form
    {

        private int contadorClicks = 0;
        public Form1()
        {
            InitializeComponent();
            cmbunidad.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
            cmbunidad.SelectedIndex = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float peso, estatura;

            peso = 0.3f;
            estatura = 0.3f;

            if (float.TryParse(ctpeso.Text, out peso) &&
                float.TryParse(ctestatura.Text, out estatura))
            {
                float imc = peso / (estatura * estatura);

                string clasificacion;
                if (imc < 18.5)
                    clasificacion = "Bajo peso";
                else if (imc < 25)
                    clasificacion = "Normal";
                else if (imc < 30)
                    clasificacion = "Sobrepeso";
                else if (imc < 35)
                    clasificacion = "Obesidad grado I";
                else if (imc < 40)
                    clasificacion = "Obesidad grado II";
                else
                    clasificacion = "Obesidad grado III";

                MessageBox.Show($"Su IMC es {imc:F2}.\nClasificación: {clasificacion}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorClicks++;

            lblContador.Text = "Clicks:"+ contadorClicks.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbunidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = double.Parse(txtvalor.Text);
                string unidad = cmbunidad.SelectedItem.ToString();

                double celsius, fahrenheit, kelvin;

               
                if (unidad == "Celsius")
                {
                    celsius = valor;
                    fahrenheit = (valor * 9 / 5) + 32;
                    kelvin = valor + 273.15;
                }
                else if (unidad == "Fahrenheit")
                {
                    celsius = (valor - 32) * 5 / 9;
                    fahrenheit = valor;
                    kelvin = celsius + 273.15;
                }
                else
                {
                    celsius = valor - 273.15;
                    fahrenheit = (celsius * 9 / 5) + 32;
                    kelvin = valor;
                }

                
                lblresultado.Text = ($"Celsius: {celsius:F2} °C\n" +
                                    $"Fahrenheit: {fahrenheit:F2} °F\n" +
                                    $"Kelvin: {kelvin:F2} K");
            }
            catch
            {
                MessageBox.Show("ingrese un valor numerico valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}