using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIEstudiantes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();

            foreach (var est in DatosCompartidos.ListaEstudiantes)
            {
                dgvDatos.Rows.Add(est.Carnet, est.Nombre, est.Promedio().ToString("0.00"));
            }
        }
    }
}
