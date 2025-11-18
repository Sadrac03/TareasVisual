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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Estudiante estudiante = new Estudiante
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text
            };

            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null)
                {
                    estudiante.Asignaturas.Add(new Asignatura
                    {
                        Nombre = fila.Cells[0].Value.ToString(),
                        Nota = Convert.ToDouble(fila.Cells[1].Value)
                    });
                }
            }

            DatosCompartidos.ListaEstudiantes.Add(estudiante);
            MessageBox.Show("Estudiante guardado correctamente.");
            this.Close();
        }
    }
}
