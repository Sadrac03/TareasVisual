using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VisorImagenes
{
    public partial class Form1 : Form
    {
        private FileInfo[] imageFiles = new FileInfo[0];
        private int currentIndex = -1;
        private bool grayscaleMode = false;
        private Image currentImageOriginal = null;
        private Image currentImageDisplayed = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string defaultFolder = @"C:\imagenes";
            LoadImagesFromFolder(defaultFolder);
            if (imageFiles.Length > 0)
            {
                ShowImageAtIndex(0);
            }
            UpdateVisionMenuAndTool();
            UpdateSizeMenuAndTool();
        }

        private void LoadImagesFromFolder(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    imageFiles = new FileInfo[0];
                    comboBoxImages.Items.Clear();
                    statusLabel.Text = "Carpeta no existe: " + folderPath;
                    return;
                }

                DirectoryInfo di = new DirectoryInfo(folderPath);
                var exts = new[] { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff" };
                imageFiles = di.GetFiles()
                               .Where(f => exts.Contains(f.Extension.ToLower()))
                               .OrderBy(f => f.Name)
                               .ToArray();

                comboBoxImages.Items.Clear();
                foreach (var f in imageFiles)
                    comboBoxImages.Items.Add(f.Name);

                if (imageFiles.Length == 0)
                {
                    statusLabel.Text = "No se encontraron imágenes en: " + folderPath;
                    pictureBox1.Image = null;
                    currentIndex = -1;
                }
                else
                {
                    statusLabel.Text = imageFiles[0].FullName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error leyendo carpeta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowImageAtIndex(int index)
        {
            if (imageFiles == null || imageFiles.Length == 0) return;
            if (index < 0 || index >= imageFiles.Length) return;

            currentIndex = index;

            if (currentImageOriginal != null)
            {
                currentImageOriginal.Dispose();
                currentImageOriginal = null;
            }
            if (currentImageDisplayed != null)
            {
                currentImageDisplayed.Dispose();
                currentImageDisplayed = null;
            }

            try
            {
                using (var fs = new FileStream(imageFiles[currentIndex].FullName, FileMode.Open, FileAccess.Read))
                {
                    currentImageOriginal = Image.FromStream(fs).Clone() as Image;
                }

                ApplyDisplayTransforms();
                comboBoxImages.SelectedIndex = currentIndex;
                statusLabel.Text = imageFiles[currentIndex].FullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDisplayTransforms()
        {
            if (currentImageOriginal == null) return;

            if (currentImageDisplayed != null)
            {
                currentImageDisplayed.Dispose();
                currentImageDisplayed = null;
            }

            currentImageDisplayed = (Image)currentImageOriginal.Clone();

            if (grayscaleMode)
            {
                var bmp = ConvertToGrayscale(new Bitmap(currentImageDisplayed));
                currentImageDisplayed.Dispose();
                currentImageDisplayed = bmp;
            }

            if (pictureBox1.Image != null)
            {
                var old = pictureBox1.Image;
                pictureBox1.Image = null;
                old.Dispose();
            }

            pictureBox1.Image = (Image)currentImageDisplayed.Clone();
        }

        private Bitmap ConvertToGrayscale(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                var cm = new ColorMatrix(new float[][]
                {
                    new float[] {0.299f, 0.299f, 0.299f, 0, 0},
                    new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                    new float[] {0.114f, 0.114f, 0.114f, 0, 0},
                    new float[] {0,      0,      0,      1, 0},
                    new float[] {0,      0,      0,      0, 1}
                });
                using (var ia = new ImageAttributes())
                {
                    ia.SetColorMatrix(cm);
                    g.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height),
                        0, 0, source.Width, source.Height, GraphicsUnit.Pixel, ia);
                }
            }
            source.Dispose();
            return bmp;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (imageFiles.Length == 0) return;
            int ni = currentIndex - 1;
            if (ni < 0) ni = imageFiles.Length - 1;
            ShowImageAtIndex(ni);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageFiles.Length == 0) return;
            int ni = currentIndex + 1;
            if (ni >= imageFiles.Length) ni = 0;
            ShowImageAtIndex(ni);
        }

        private void comboBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxImages.SelectedIndex >= 0)
            {
                ShowImageAtIndex(comboBoxImages.SelectedIndex);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentImageDisplayed == null)
            {
                MessageBox.Show("No hay imagen para guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
                sfd.FileName = imageFiles.Length > 0 ? Path.GetFileNameWithoutExtension(imageFiles[currentIndex].Name) + "_mod" : "imagen_modificada";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat fmt = ImageFormat.Png;
                    switch (Path.GetExtension(sfd.FileName).ToLower())
                    {
                        case ".jpg": fmt = ImageFormat.Jpeg; break;
                        case ".bmp": fmt = ImageFormat.Bmp; break;
                        case ".png": fmt = ImageFormat.Png; break;
                    }
                    currentImageDisplayed.Save(sfd.FileName, fmt);
                }
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grayscaleMode = false;
            ApplyDisplayTransforms();
            UpdateVisionMenuAndTool();
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grayscaleMode = true;
            ApplyDisplayTransforms();
            UpdateVisionMenuAndTool();
        }

        private void UpdateVisionMenuAndTool()
        {
            normalToolStripMenuItem.Checked = !grayscaleMode;
            escalaDeGrisesToolStripMenuItem.Checked = grayscaleMode;

            toolStripButtonNormal.Checked = !grayscaleMode;
            toolStripButtonGrayscale.Checked = grayscaleMode;
        }

        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            UpdateSizeMenuAndTool();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            UpdateSizeMenuAndTool();
        }

        private void stretchImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateSizeMenuAndTool();
        }

        private void UpdateSizeMenuAndTool()
        {
            centerImageToolStripMenuItem.Checked = pictureBox1.SizeMode == PictureBoxSizeMode.CenterImage;
            zoomToolStripMenuItem.Checked = pictureBox1.SizeMode == PictureBoxSizeMode.Zoom;
            stretchImageToolStripMenuItem.Checked = pictureBox1.SizeMode == PictureBoxSizeMode.StretchImage;

            toolStripButtonCenter.Checked = centerImageToolStripMenuItem.Checked;
            toolStripButtonZoom.Checked = zoomToolStripMenuItem.Checked;
            toolStripButtonStretch.Checked = stretchImageToolStripMenuItem.Checked;
        }

        // Rotar izquierda
        private void rotarIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateCurrentImage(RotateFlipType.Rotate270FlipNone);
        }

        // Rotar derecha
        private void rotarDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateCurrentImage(RotateFlipType.Rotate90FlipNone);
        }

        // ✅ CORREGIDO
        private void RotateCurrentImage(RotateFlipType rotateFlipType)
        {
            if (currentImageOriginal == null) return;

            // Crear un Bitmap editable desde la original
            Bitmap bmp = new Bitmap(currentImageOriginal);
            bmp.RotateFlip(rotateFlipType);

            // Liberar las anteriores
            currentImageOriginal.Dispose();
            currentImageDisplayed?.Dispose();
            pictureBox1.Image?.Dispose();

            // Guardar la nueva imagen como original y mostrarla
            currentImageOriginal = (Image)bmp.Clone();
            currentImageDisplayed = (Image)bmp.Clone();

            // Si está en escala de grises, aplicar filtro
            if (grayscaleMode)
            {
                var gray = ConvertToGrayscale(new Bitmap(currentImageDisplayed));
                currentImageDisplayed.Dispose();
                currentImageDisplayed = gray;
            }

            pictureBox1.Image = (Image)currentImageDisplayed.Clone();
            pictureBox1.Refresh();
        }


        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            try
            {
                Clipboard.SetImage(pictureBox1.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo copiar al portapapeles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonNormal_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonGrayscale_Click(object sender, EventArgs e)
        {
            escalaDeGrisesToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonCenter_Click(object sender, EventArgs e)
        {
            centerImageToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonZoom_Click(object sender, EventArgs e)
        {
            zoomToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonStretch_Click(object sender, EventArgs e)
        {
            stretchImageToolStripMenuItem_Click(sender, e);
        }

        private void abrirCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Seleccione la carpeta con imágenes";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    LoadImagesFromFolder(fbd.SelectedPath);
                    if (imageFiles.Length > 0)
                        ShowImageAtIndex(0);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (currentImageOriginal != null) currentImageOriginal.Dispose();
            if (currentImageDisplayed != null) currentImageDisplayed.Dispose();
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
        }
    }
}
