namespace VisorImagenes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirCarpetaToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            visionToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            escalaDeGrisesToolStripMenuItem = new ToolStripMenuItem();
            tamañoToolStripMenuItem = new ToolStripMenuItem();
            centerImageToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            stretchImageToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButtonNormal = new ToolStripButton();
            toolStripButtonGrayscale = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonCenter = new ToolStripButton();
            toolStripButtonZoom = new ToolStripButton();
            toolStripButtonStretch = new ToolStripButton();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rotarIzquierdaToolStripMenuItem = new ToolStripMenuItem();
            rotarDerechaToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            comboBoxImages = new ComboBox();
            btnPrev = new Button();
            btnNext = new Button();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, visionToolStripMenuItem, tamañoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1108, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirCarpetaToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(114, 36);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirCarpetaToolStripMenuItem
            // 
            abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
            abrirCarpetaToolStripMenuItem.Size = new Size(333, 44);
            abrirCarpetaToolStripMenuItem.Text = "Abrir carpeta...";
            abrirCarpetaToolStripMenuItem.Click += abrirCarpetaToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(333, 44);
            guardarToolStripMenuItem.Text = "Guardar imagen...";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(333, 44);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // visionToolStripMenuItem
            // 
            visionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, escalaDeGrisesToolStripMenuItem });
            visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            visionToolStripMenuItem.Size = new Size(99, 36);
            visionToolStripMenuItem.Text = "Visión";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(312, 44);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            escalaDeGrisesToolStripMenuItem.Size = new Size(312, 44);
            escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            escalaDeGrisesToolStripMenuItem.Click += escalaDeGrisesToolStripMenuItem_Click;
            // 
            // tamañoToolStripMenuItem
            // 
            tamañoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centerImageToolStripMenuItem, zoomToolStripMenuItem, stretchImageToolStripMenuItem });
            tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            tamañoToolStripMenuItem.Size = new Size(117, 36);
            tamañoToolStripMenuItem.Text = "Tamaño";
            // 
            // centerImageToolStripMenuItem
            // 
            centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            centerImageToolStripMenuItem.Size = new Size(287, 44);
            centerImageToolStripMenuItem.Text = "CenterImage";
            centerImageToolStripMenuItem.Click += centerImageToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(287, 44);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click;
            // 
            // stretchImageToolStripMenuItem
            // 
            stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
            stretchImageToolStripMenuItem.Size = new Size(287, 44);
            stretchImageToolStripMenuItem.Text = "StretchImage";
            stretchImageToolStripMenuItem.Click += stretchImageToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNormal, toolStripButtonGrayscale, toolStripSeparator1, toolStripButtonCenter, toolStripButtonZoom, toolStripButtonStretch });
            toolStrip1.Location = new Point(0, 40);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1108, 42);
            toolStrip1.TabIndex = 1;
            // 
            // toolStripButtonNormal
            // 
            toolStripButtonNormal.CheckOnClick = true;
            toolStripButtonNormal.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonNormal.Name = "toolStripButtonNormal";
            toolStripButtonNormal.Size = new Size(97, 36);
            toolStripButtonNormal.Text = "Normal";
            toolStripButtonNormal.Click += toolStripButtonNormal_Click;
            // 
            // toolStripButtonGrayscale
            // 
            toolStripButtonGrayscale.CheckOnClick = true;
            toolStripButtonGrayscale.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonGrayscale.Name = "toolStripButtonGrayscale";
            toolStripButtonGrayscale.Size = new Size(81, 36);
            toolStripButtonGrayscale.Text = "Grises";
            toolStripButtonGrayscale.Click += toolStripButtonGrayscale_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // toolStripButtonCenter
            // 
            toolStripButtonCenter.CheckOnClick = true;
            toolStripButtonCenter.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonCenter.Name = "toolStripButtonCenter";
            toolStripButtonCenter.Size = new Size(89, 36);
            toolStripButtonCenter.Text = "Center";
            toolStripButtonCenter.Click += toolStripButtonCenter_Click;
            // 
            // toolStripButtonZoom
            // 
            toolStripButtonZoom.CheckOnClick = true;
            toolStripButtonZoom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonZoom.Name = "toolStripButtonZoom";
            toolStripButtonZoom.Size = new Size(81, 36);
            toolStripButtonZoom.Text = "Zoom";
            toolStripButtonZoom.Click += toolStripButtonZoom_Click;
            // 
            // toolStripButtonStretch
            // 
            toolStripButtonStretch.CheckOnClick = true;
            toolStripButtonStretch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonStretch.Name = "toolStripButtonStretch";
            toolStripButtonStretch.Size = new Size(92, 36);
            toolStripButtonStretch.Text = "Stretch";
            toolStripButtonStretch.Click += toolStripButtonStretch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Location = new Point(12, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(930, 416);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { rotarIzquierdaToolStripMenuItem, rotarDerechaToolStripMenuItem, copiarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(328, 118);
            // 
            // rotarIzquierdaToolStripMenuItem
            // 
            rotarIzquierdaToolStripMenuItem.Name = "rotarIzquierdaToolStripMenuItem";
            rotarIzquierdaToolStripMenuItem.Size = new Size(327, 38);
            rotarIzquierdaToolStripMenuItem.Text = "Rotar 90° izquierda";
            rotarIzquierdaToolStripMenuItem.Click += rotarIzquierdaToolStripMenuItem_Click;
            // 
            // rotarDerechaToolStripMenuItem
            // 
            rotarDerechaToolStripMenuItem.Name = "rotarDerechaToolStripMenuItem";
            rotarDerechaToolStripMenuItem.Size = new Size(327, 38);
            rotarDerechaToolStripMenuItem.Text = "Rotar 90° derecha";
            rotarDerechaToolStripMenuItem.Click += rotarDerechaToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(327, 38);
            copiarToolStripMenuItem.Text = "Copiar al portapapeles";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // comboBoxImages
            // 
            comboBoxImages.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxImages.FormattingEnabled = true;
            comboBoxImages.Location = new Point(12, 507);
            comboBoxImages.Name = "comboBoxImages";
            comboBoxImages.Size = new Size(600, 40);
            comboBoxImages.TabIndex = 3;
            comboBoxImages.SelectedIndexChanged += comboBoxImages_SelectedIndexChanged;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(630, 505);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(110, 42);
            btnPrev.TabIndex = 4;
            btnPrev.Text = "Anterior";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(746, 505);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(126, 42);
            btnNext.TabIndex = 5;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 715);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1108, 42);
            statusStrip1.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(76, 32);
            statusLabel.Text = "status";
            // 
            // Form1
            // 
            ClientSize = new Size(1108, 757);
            Controls.Add(statusStrip1);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(comboBoxImages);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Visor de Imágenes - Práctica 3";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxImages;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rotarIzquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton toolStripButtonNormal;
        private System.Windows.Forms.ToolStripButton toolStripButtonGrayscale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCenter;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoom;
        private System.Windows.Forms.ToolStripButton toolStripButtonStretch;

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchImageToolStripMenuItem;
    }
}
