using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GestorTareas
{
    partial class MainForm
    {
        private IContainer components = null;

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblFecha;
        private Label lblLugar;
        private Label lblEstado;

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private DateTimePicker dtpFecha;
        private TextBox txtLugar;
        private ComboBox cbEstado;

        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;

        private DataGridView dgvTareas;

        // Panel de búsqueda
        private Panel panelBusqueda;
        private Label lblBuscarCodigo;
        private TextBox txtBuscarCodigo;
        private Label lblBuscarFecha;
        private DateTimePicker dtpBuscarDesde;
        private DateTimePicker dtpBuscarHasta;
        private Label lblBuscarEstado;
        private ComboBox cbBuscarEstado;
        private Button btnBuscar;
        private Button btnRestablecer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblFecha = new Label();
            lblLugar = new Label();
            lblEstado = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            dtpFecha = new DateTimePicker();
            txtLugar = new TextBox();
            cbEstado = new ComboBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvTareas = new DataGridView();
            panelBusqueda = new Panel();
            lblBuscarCodigo = new Label();
            txtBuscarCodigo = new TextBox();
            lblBuscarFecha = new Label();
            dtpBuscarDesde = new DateTimePicker();
            dtpBuscarHasta = new DateTimePicker();
            lblBuscarEstado = new Label();
            cbBuscarEstado = new ComboBox();
            btnBuscar = new Button();
            btnRestablecer = new Button();
            ((ISupportInitialize)dgvTareas).BeginInit();
            panelBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(13, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(111, 37);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 37);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(-4, 107);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(161, 37);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 201);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(91, 37);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            // 
            // lblLugar
            // 
            lblLugar.AutoSize = true;
            lblLugar.Location = new Point(13, 245);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(90, 37);
            lblLugar.TabIndex = 8;
            lblLugar.Text = "Lugar:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(3, 307);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(103, 37);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.InactiveCaption;
            txtCodigo.Location = new Point(139, 15);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(281, 43);
            txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(139, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(287, 43);
            txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.InactiveCaption;
            txtDescripcion.Location = new Point(163, 110);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(263, 77);
            txtDescripcion.TabIndex = 5;
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarMonthBackground = SystemColors.InactiveCaption;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(109, 196);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 43);
            dtpFecha.TabIndex = 7;
            // 
            // txtLugar
            // 
            txtLugar.BackColor = SystemColors.InactiveCaption;
            txtLugar.Location = new Point(109, 250);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(300, 43);
            txtLugar.TabIndex = 9;
            // 
            // cbEstado
            // 
            cbEstado.BackColor = SystemColors.InactiveCaption;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Items.AddRange(new object[] { "No Realizada", "En Proceso", "Terminada" });
            cbEstado.Location = new Point(109, 299);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(308, 45);
            cbEstado.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(76, 175, 80);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(62, 397);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(148, 69);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(33, 150, 243);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(253, 397);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 69);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(244, 67, 54);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(62, 484);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(148, 73);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(253, 484);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 73);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvTareas
            // 
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.BackgroundColor = SystemColors.ActiveCaption;
            dgvTareas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.EnableHeadersVisualStyles = false;
            dgvTareas.Location = new Point(450, 12);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersWidth = 82;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.Size = new Size(911, 511);
            dgvTareas.TabIndex = 16;
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(230, 230, 230);
            panelBusqueda.BorderStyle = BorderStyle.FixedSingle;
            panelBusqueda.Controls.Add(lblBuscarCodigo);
            panelBusqueda.Controls.Add(txtBuscarCodigo);
            panelBusqueda.Controls.Add(lblBuscarFecha);
            panelBusqueda.Controls.Add(dtpBuscarDesde);
            panelBusqueda.Controls.Add(dtpBuscarHasta);
            panelBusqueda.Controls.Add(lblBuscarEstado);
            panelBusqueda.Controls.Add(cbBuscarEstado);
            panelBusqueda.Controls.Add(btnBuscar);
            panelBusqueda.Controls.Add(btnRestablecer);
            panelBusqueda.Location = new Point(450, 530);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(770, 111);
            panelBusqueda.TabIndex = 17;
            // 
            // lblBuscarCodigo
            // 
            lblBuscarCodigo.AutoSize = true;
            lblBuscarCodigo.Location = new Point(3, 8);
            lblBuscarCodigo.Name = "lblBuscarCodigo";
            lblBuscarCodigo.Size = new Size(111, 37);
            lblBuscarCodigo.TabIndex = 0;
            lblBuscarCodigo.Text = "Código:";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(103, 8);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(118, 43);
            txtBuscarCodigo.TabIndex = 1;
            // 
            // lblBuscarFecha
            // 
            lblBuscarFecha.AutoSize = true;
            lblBuscarFecha.Location = new Point(227, -1);
            lblBuscarFecha.Name = "lblBuscarFecha";
            lblBuscarFecha.Size = new Size(91, 37);
            lblBuscarFecha.TabIndex = 2;
            lblBuscarFecha.Text = "Fecha:";
            // 
            // dtpBuscarDesde
            // 
            dtpBuscarDesde.Format = DateTimePickerFormat.Short;
            dtpBuscarDesde.Location = new Point(315, -1);
            dtpBuscarDesde.Name = "dtpBuscarDesde";
            dtpBuscarDesde.Size = new Size(224, 43);
            dtpBuscarDesde.TabIndex = 3;
            // 
            // dtpBuscarHasta
            // 
            dtpBuscarHasta.Format = DateTimePickerFormat.Short;
            dtpBuscarHasta.Location = new Point(545, 3);
            dtpBuscarHasta.Name = "dtpBuscarHasta";
            dtpBuscarHasta.Size = new Size(224, 43);
            dtpBuscarHasta.TabIndex = 4;
            // 
            // lblBuscarEstado
            // 
            lblBuscarEstado.AutoSize = true;
            lblBuscarEstado.Location = new Point(76, 58);
            lblBuscarEstado.Name = "lblBuscarEstado";
            lblBuscarEstado.Size = new Size(103, 37);
            lblBuscarEstado.TabIndex = 5;
            lblBuscarEstado.Text = "Estado:";
            // 
            // cbBuscarEstado
            // 
            cbBuscarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscarEstado.Items.AddRange(new object[] { "Todos", "No Realizada", "En Proceso", "Terminada" });
            cbBuscarEstado.Location = new Point(185, 42);
            cbBuscarEstado.Name = "cbBuscarEstado";
            cbBuscarEstado.Size = new Size(120, 45);
            cbBuscarEstado.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(76, 175, 80);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(311, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(224, 61);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnRestablecer
            // 
            btnRestablecer.BackColor = Color.Gray;
            btnRestablecer.FlatStyle = FlatStyle.Flat;
            btnRestablecer.ForeColor = Color.White;
            btnRestablecer.Location = new Point(541, 50);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(224, 52);
            btnRestablecer.TabIndex = 8;
            btnRestablecer.Text = "Restablecer";
            btnRestablecer.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1391, 653);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblLugar);
            Controls.Add(txtLugar);
            Controls.Add(lblEstado);
            Controls.Add(cbEstado);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvTareas);
            Controls.Add(panelBusqueda);
            Font = new Font("Segoe UI", 10F);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Tareas - ToDo List";
            ((ISupportInitialize)dgvTareas).EndInit();
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}