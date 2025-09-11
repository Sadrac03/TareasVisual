using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace GestorTareas
{
    public partial class MainForm : Form
    {
        private BindingList<Tarea> tareas;
        private string archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tareas.json");

        public MainForm()
        {
            InitializeComponent();
            CargarTareas();
            dgvTareas.DataSource = tareas;
            ConfigurarEventos();
        }

        private void CargarTareas()
        {
            if (File.Exists(archivo))
            {
                try
                {
                    string json = File.ReadAllText(archivo);
                    var lista = JsonSerializer.Deserialize<BindingList<Tarea>>(json);
                    tareas = lista ?? new BindingList<Tarea>();
                }
                catch
                {
                    tareas = new BindingList<Tarea>();
                }
            }
            else
            {
                tareas = new BindingList<Tarea>();
            }
        }

        private void GuardarTareas()
        {
            string json = JsonSerializer.Serialize(tareas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivo, json);
        }

        private void ConfigurarEventos()
        {
            btnAgregar.Click += (s, e) => AgregarTarea();
            btnActualizar.Click += (s, e) => ActualizarTarea();
            btnEliminar.Click += (s, e) => EliminarTarea();
            btnLimpiar.Click += (s, e) => LimpiarFormulario();
            dgvTareas.SelectionChanged += (s, e) => CargarSeleccion();

            // Eventos de búsqueda
            btnBuscar.Click += BtnBuscar_Click;
            btnRestablecer.Click += BtnRestablecer_Click;
        }

        private void AgregarTarea()
        {
            try
            {
                // Validación para evitar que el código esté vacío
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("El código de la tarea es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de campos
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                {
                    MessageBox.Show("El código debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tarea = new Tarea
                {
                    Codigo = codigo,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Fecha = dtpFecha.Value,
                    Lugar = txtLugar.Text,
                    Estado = cbEstado.SelectedItem.ToString()
                };

                tareas.Add(tarea);
                GuardarTareas();
                LimpiarFormulario();
                // Actualizar la vista después de agregar
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTarea()
        {
            if (dgvTareas.CurrentRow != null)
            {
                var tarea = dgvTareas.CurrentRow.DataBoundItem as Tarea;
                if (tarea != null)
                {
                    try
                    {
                        if (!int.TryParse(txtCodigo.Text, out int codigo))
                        {
                            MessageBox.Show("El código debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        tarea.Codigo = codigo;
                        tarea.Nombre = txtNombre.Text;
                        tarea.Descripcion = txtDescripcion.Text;
                        tarea.Fecha = dtpFecha.Value;
                        tarea.Lugar = txtLugar.Text;
                        tarea.Estado = cbEstado.SelectedItem.ToString();

                        dgvTareas.Refresh();
                        GuardarTareas();
                        // Actualizar la vista después de actualizar
                        ActualizarDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EliminarTarea()
        {
            if (dgvTareas.CurrentRow != null)
            {
                var tarea = dgvTareas.CurrentRow.DataBoundItem as Tarea;
                if (tarea != null)
                {
                    tareas.Remove(tarea);
                    GuardarTareas();
                    // Actualizar la vista después de eliminar
                    ActualizarDataGridView();
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLugar.Clear();
            dtpFecha.Value = DateTime.Today;
            cbEstado.SelectedIndex = 0;
            dgvTareas.ClearSelection();
        }

        private void CargarSeleccion()
        {
            if (dgvTareas.CurrentRow != null)
            {
                var tarea = dgvTareas.CurrentRow.DataBoundItem as Tarea;
                if (tarea != null)
                {
                    txtCodigo.Text = tarea.Codigo.ToString();
                    txtNombre.Text = tarea.Nombre;
                    txtDescripcion.Text = tarea.Descripcion;
                    dtpFecha.Value = tarea.Fecha;
                    txtLugar.Text = tarea.Lugar;
                    cbEstado.SelectedItem = tarea.Estado;
                }
            }
        }

        // ==============================
        // BÚSQUEDA
        // ==============================

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var resultados = tareas.AsEnumerable();

            // Filtrar por Código
            if (!string.IsNullOrWhiteSpace(txtBuscarCodigo.Text) &&
                int.TryParse(txtBuscarCodigo.Text, out int codigo))
            {
                resultados = resultados.Where(t => t.Codigo == codigo);
            }

            // Filtrar por Fechas
            if (dtpBuscarDesde.Value.Date != dtpBuscarHasta.Value.Date)
            {
                resultados = resultados.Where(t => t.Fecha.Date >= dtpBuscarDesde.Value.Date && t.Fecha.Date <= dtpBuscarHasta.Value.Date);
            }

            // Filtrar por Estado (si no es "Todos")
            if (cbBuscarEstado.SelectedIndex > 0)
            {
                string estadoSeleccionado = cbBuscarEstado.SelectedItem.ToString();
                resultados = resultados.Where(t => t.Estado == estadoSeleccionado);
            }

            dgvTareas.DataSource = new BindingList<Tarea>(resultados.ToList());
        }

        private void BtnRestablecer_Click(object sender, EventArgs e)
        {
            txtBuscarCodigo.Clear();
            cbBuscarEstado.SelectedIndex = 0;
            dtpBuscarDesde.Value = DateTime.Today;
            dtpBuscarHasta.Value = DateTime.Today;

            // Restablece la fuente de datos al original y limpia la selección
            ActualizarDataGridView();
        }

        // Método para actualizar la vista de la tabla
        private void ActualizarDataGridView()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = tareas;
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}