namespace program.visual_practica_2
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
            this.control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ctestatura = new System.Windows.Forms.TextBox();
            this.ctpeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbunidad = new System.Windows.Forms.ComboBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // control
            // 
            this.control.Controls.Add(this.tabPage1);
            this.control.Controls.Add(this.tabPage2);
            this.control.Controls.Add(this.tabPage3);
            this.control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control.Location = new System.Drawing.Point(0, 0);
            this.control.Name = "control";
            this.control.SelectedIndex = 0;
            this.control.Size = new System.Drawing.Size(800, 450);
            this.control.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ctestatura);
            this.tabPage1.Controls.Add(this.ctpeso);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IMC";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "CALCULAR PESO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctestatura
            // 
            this.ctestatura.Location = new System.Drawing.Point(143, 53);
            this.ctestatura.Name = "ctestatura";
            this.ctestatura.Size = new System.Drawing.Size(100, 20);
            this.ctestatura.TabIndex = 3;
            this.ctestatura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ctpeso
            // 
            this.ctpeso.Location = new System.Drawing.Point(143, 98);
            this.ctpeso.Name = "ctpeso";
            this.ctpeso.Size = new System.Drawing.Size(100, 20);
            this.ctpeso.TabIndex = 2;
            this.ctpeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "estatura (en Metros)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "peso (en KG)";
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleName = "";
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.lblContador);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contador clicks";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "CONTADOR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Black;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContador.Location = new System.Drawing.Point(328, 107);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(61, 25);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "       ";
            this.lblContador.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lblresultado);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cmbunidad);
            this.tabPage3.Controls.Add(this.txtvalor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conversor de temperaturas";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "RESULTADOS DE CONVERSION";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.Color.Transparent;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.Black;
            this.lblresultado.Location = new System.Drawing.Point(446, 99);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 20);
            this.lblresultado.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "CONVERTIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccione la unidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el valor";
            // 
            // cmbunidad
            // 
            this.cmbunidad.FormattingEnabled = true;
            this.cmbunidad.Location = new System.Drawing.Point(193, 101);
            this.cmbunidad.Name = "cmbunidad";
            this.cmbunidad.Size = new System.Drawing.Size(121, 21);
            this.cmbunidad.TabIndex = 1;
            this.cmbunidad.SelectedIndexChanged += new System.EventHandler(this.cmbunidad_SelectedIndexChanged);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(193, 43);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 0;
            this.txtvalor.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.control);
            this.Name = "Form1";
            this.Text = "Form1";
            this.control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ctestatura;
        private System.Windows.Forms.TextBox ctpeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button button2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbunidad;
        private System.Windows.Forms.Label label5;
    }
}

