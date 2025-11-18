using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MDIEstudiantes
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            if (DatosCompartidos.ListaEstudiantes.Count == 0)
            {
                MessageBox.Show("No hay estudiantes registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear serie
            Series serie = new Series("Promedios");
            serie.ChartType = SeriesChartType.Column; // tipo de gráfico (barras verticales)
            serie.IsValueShownAsLabel = true; // muestra valores encima de las barras

            // Agregar serie al chart
            chart1.Series.Add(serie);

            // Agregar datos
            foreach (var est in DatosCompartidos.ListaEstudiantes.OrderByDescending(i => i.Promedio()).Take(10))
            {
                serie.Points.AddXY(est.Nombre, est.Promedio());
            }

            // Opcional: título y ejes
            chart1.Titles.Clear();
            chart1.Titles.Add("Promedios de Estudiantes");
            chart1.ChartAreas[0].AxisX.Title = "Estudiantes";
            chart1.ChartAreas[0].AxisY.Title = "Promedio";
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }
    }
}
