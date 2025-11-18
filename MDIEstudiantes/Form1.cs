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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            var formExistente = MdiChildren.FirstOrDefault(f => f is T);
            if (formExistente != null)
            {
                formExistente.Activate();
            }
            else
            {
                var form = new T();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
