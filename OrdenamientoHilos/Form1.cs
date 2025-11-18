
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace OrdenamientoMultihilo
{
    public partial class Form1 : Form
    {
        private List<int> listaOriginal;
        private List<int> listaBurbuja;
        private List<int> listaQuick;
        private List<int> listaMerge;
        private List<int> listaSelection;

        private Thread hiloBurbuja;
        private volatile bool cancelarBurbuja = false;

        private Stopwatch relojBurbuja = new Stopwatch();
        private Stopwatch relojQuick = new Stopwatch();
        private Stopwatch relojMerge = new Stopwatch();
        private Stopwatch relojSelection = new Stopwatch();

        // Logs for each algorithm (we record periodic reports)
        private List<string> logBurbuja = new List<string>();
        private List<string> logQuick = new List<string>();
        private List<string> logMerge = new List<string>();
        private List<string> logSelection = new List<string>();

        public Form1()
        {
            InitializeComponent();
            // Configure BackgroundWorkers to report progress and support cancellation
            backgroundWorkerQuickSort.WorkerReportsProgress = true;
            backgroundWorkerQuickSort.WorkerSupportsCancellation = true;

            backgroundWorkerMergeSort.WorkerReportsProgress = true;
            backgroundWorkerMergeSort.WorkerSupportsCancellation = true;

            backgroundWorkerSelectionSort.WorkerReportsProgress = true;
            backgroundWorkerSelectionSort.WorkerSupportsCancellation = true;

            txtCantidad.Text = "100000";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad = 100000;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese un número válido de elementos.");
                return;
            }

            Random rnd = new Random();
            listaOriginal = new List<int>(cantidad);
            for (int i = 0; i < cantidad; i++)
                listaOriginal.Add(rnd.Next(0, 1000000));

            MessageBox.Show($"Lista generada correctamente con {cantidad} números.");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (listaOriginal == null || listaOriginal.Count == 0)
            {
                MessageBox.Show("Primero genera los datos.");
                return;
            }

            // Reset logs and UI
            logBurbuja.Clear(); logQuick.Clear(); logMerge.Clear(); logSelection.Clear();
            progressBurbuja.Value = 0; progressQuickSort.Value = 0; progressMerge.Value = 0; progressSelection.Value = 0;
            lblBurbuja.Text = "Burbuja: 0%";
            lblQuickSort.Text = "QuickSort: 0%";
            lblMerge.Text = "Merge: 0%";
            lblSelection.Text = "Selection: 0%";

            // Copiamos la lista para cada algoritmo
            listaBurbuja = new List<int>(listaOriginal);
            listaQuick = new List<int>(listaOriginal);
            listaMerge = new List<int>(listaOriginal);
            listaSelection = new List<int>(listaOriginal);

            // Start Bubble Sort in a Thread
            cancelarBurbuja = false;
            hiloBurbuja = new Thread(new ThreadStart(OrdenarBurbuja));
            hiloBurbuja.IsBackground = true;
            hiloBurbuja.Start();

            // Start BackgroundWorkers
            backgroundWorkerQuickSort.RunWorkerAsync(listaQuick);
            backgroundWorkerMergeSort.RunWorkerAsync(listaMerge);
            backgroundWorkerSelectionSort.RunWorkerAsync(listaSelection);

            btnIniciar.Enabled = false;
            btnGenerar.Enabled = false;
            btnDetener.Enabled = true;
            btnGuardarWord.Enabled = false;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            // Request cancellation
            cancelarBurbuja = true;
            backgroundWorkerQuickSort.CancelAsync();
            backgroundWorkerMergeSort.CancelAsync();
            backgroundWorkerSelectionSort.CancelAsync();
            btnDetener.Enabled = false;
        }

        private void OrdenarBurbuja()
        {
            relojBurbuja.Restart();
            int n = listaBurbuja.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (cancelarBurbuja) break;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listaBurbuja[j] > listaBurbuja[j + 1])
                    {
                        int temp = listaBurbuja[j];
                        listaBurbuja[j] = listaBurbuja[j + 1];
                        listaBurbuja[j + 1] = temp;
                    }
                }

                // Reportar progreso (cada 1000 iteraciones o al final)
                if (i % 1000 == 0 || i == n - 2)
                {
                    int progreso = (int)((i / (float)n) * 100);
                    logBurbuja.Add($"Iter {i}: {progreso}%");
                    this.Invoke(new Action(() =>
                    {
                        progressBurbuja.Value = Math.Min(progreso, 100);
                        lblBurbuja.Text = $"Burbuja: {progreso}%";
                    }));
                }
            }

            relojBurbuja.Stop();
            this.Invoke(new Action(() =>
            {
                progressBurbuja.Value = 100;
                lblBurbuja.Text = cancelarBurbuja ? $"Burbuja: Cancelado en {relojBurbuja.ElapsedMilliseconds} ms" : $"Burbuja: Completado en {relojBurbuja.ElapsedMilliseconds} ms";
                VerificarFinalizado();
            }));
        }

        #region QuickSort (BackgroundWorker)
        private void QuickSort(List<int> lista, int izquierda, int derecha, BackgroundWorker worker, List<string> log)
        {
            if (worker.CancellationPending) return;
            if (izquierda < derecha)
            {
                int pivot = Particionar(lista, izquierda, derecha);
                QuickSort(lista, izquierda, pivot - 1, worker, log);
                QuickSort(lista, pivot + 1, derecha, worker, log);
            }

            if (derecha % 1000 == 0)
            {
                int progreso = (int)((derecha / (float)lista.Count) * 100);
                log.Add($"Pos {derecha}: {progreso}%");
                worker.ReportProgress(Math.Min(progreso, 100));
            }
        }

        private int Particionar(List<int> lista, int izquierda, int derecha)
        {
            int pivote = lista[derecha];
            int i = izquierda - 1;
            for (int j = izquierda; j < derecha; j++)
            {
                if (lista[j] <= pivote)
                {
                    i++;
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
            int temp2 = lista[i + 1];
            lista[i + 1] = lista[derecha];
            lista[derecha] = temp2;
            return i + 1;
        }

        private void backgroundWorkerQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojQuick.Restart();
            List<int> lista = (List<int>)e.Argument;
            QuickSort(lista, 0, lista.Count - 1, backgroundWorkerQuickSort, logQuick);
            relojQuick.Stop();
            e.Result = relojQuick.ElapsedMilliseconds;
        }

        private void backgroundWorkerQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressQuickSort.Value = e.ProgressPercentage;
            lblQuickSort.Text = $"QuickSort: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblQuickSort.Text = "QuickSort: Cancelado";
            }
            else if (e.Error != null)
            {
                lblQuickSort.Text = "QuickSort: Error";
            }
            else
            {
                lblQuickSort.Text = $"QuickSort: Completado en {e.Result} ms";
                progressQuickSort.Value = 100;
            }
            VerificarFinalizado();
        }
        #endregion

        #region MergeSort (BackgroundWorker)
        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>(left.Count + right.Count);
            int i = 0, j = 0;
            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j]) { result.Add(left[i]); i++; }
                else { result.Add(right[j]); j++; }
            }
            while (i < left.Count) { result.Add(left[i]); i++; }
            while (j < right.Count) { result.Add(right[j]); j++; }
            return result;
        }

        private List<int> MergeSortAlgorithm(List<int> lista, BackgroundWorker worker, List<string> log)
        {
            if (worker.CancellationPending) return lista;
            if (lista.Count <= 1) return lista;
            int mid = lista.Count / 2;
            var left = MergeSortAlgorithm(lista.GetRange(0, mid), worker, log);
            var right = MergeSortAlgorithm(lista.GetRange(mid, lista.Count - mid), worker, log);
            var merged = Merge(left, right);

            if (merged.Count % 1000 == 0)
            {
                int progreso = (int)((merged.Count / (float)lista.Count) * 100);
                log.Add($"Merged {merged.Count}: {progreso}%");
                worker.ReportProgress(Math.Min(progreso, 100));
            }
            return merged;
        }

        private void backgroundWorkerMergeSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojMerge.Restart();
            List<int> lista = (List<int>)e.Argument;
            var sorted = MergeSortAlgorithm(lista, backgroundWorkerMergeSort, logMerge);
            // replace content with sorted (optional)
            listaMerge = sorted;
            relojMerge.Stop();
            e.Result = relojMerge.ElapsedMilliseconds;
        }

        private void backgroundWorkerMergeSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressMerge.Value = e.ProgressPercentage;
            lblMerge.Text = $"Merge: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerMergeSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) lblMerge.Text = "Merge: Cancelado";
            else if (e.Error != null) lblMerge.Text = "Merge: Error";
            else
            {
                lblMerge.Text = $"Merge: Completado en {e.Result} ms";
                progressMerge.Value = 100;
            }
            VerificarFinalizado();
        }
        #endregion

        #region SelectionSort (BackgroundWorker)
        private void SelectionSort(List<int> lista, BackgroundWorker worker, List<string> log)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (worker.CancellationPending) return;
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (lista[j] < lista[min]) min = j;
                }
                int tmp = lista[min];
                lista[min] = lista[i];
                lista[i] = tmp;

                if (i % 1000 == 0)
                {
                    int progreso = (int)((i / (float)n) * 100);
                    log.Add($"Iter {i}: {progreso}%");
                    worker.ReportProgress(Math.Min(progreso, 100));
                }
            }
        }

        private void backgroundWorkerSelectionSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojSelection.Restart();
            List<int> lista = (List<int>)e.Argument;
            SelectionSort(lista, backgroundWorkerSelectionSort, logSelection);
            relojSelection.Stop();
            e.Result = relojSelection.ElapsedMilliseconds;
        }

        private void backgroundWorkerSelectionSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressSelection.Value = e.ProgressPercentage;
            lblSelection.Text = $"Selection: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerSelectionSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) lblSelection.Text = "Selection: Cancelado";
            else if (e.Error != null) lblSelection.Text = "Selection: Error";
            else
            {
                lblSelection.Text = $"Selection: Completado en {e.Result} ms";
                progressSelection.Value = 100;
            }
            VerificarFinalizado();
        }
        #endregion

        private void VerificarFinalizado()
        {
            // If all workers/threads finished or canceled, enable save button
            bool quickBusy = backgroundWorkerQuickSort.IsBusy;
            bool mergeBusy = backgroundWorkerMergeSort.IsBusy;
            bool selBusy = backgroundWorkerSelectionSort.IsBusy;
            bool burbujaAlive = hiloBurbuja != null && hiloBurbuja.IsAlive;

            if (!quickBusy && !mergeBusy && !selBusy && !burbujaAlive)
            {
                btnIniciar.Enabled = true;
                btnGenerar.Enabled = true;
                btnDetener.Enabled = false;
                btnGuardarWord.Enabled = true;

                // Update chart with times
                chartTimes.Series["Tiempos"].Points.Clear();
                try
                {
                    long tb = relojBurbuja.ElapsedMilliseconds;
                    long tq = relojQuick.ElapsedMilliseconds;
                    long tm = relojMerge.ElapsedMilliseconds;
                    long ts = relojSelection.ElapsedMilliseconds;
                    chartTimes.Series["Tiempos"].Points.AddXY("Burbuja", tb);
                    chartTimes.Series["Tiempos"].Points.AddXY("QuickSort", tq);
                    chartTimes.Series["Tiempos"].Points.AddXY("MergeSort", tm);
                    chartTimes.Series["Tiempos"].Points.AddXY("Selection", ts);
                }
                catch { }
            }
        }

        private void btnGuardarWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt";
            sfd.FileName = "ResultadosOrdenamiento.rtf";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            // Build RTF content (simple)
            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                sw.WriteLine(@"{\rtf1\ansi");
                sw.WriteLine(@"\b Ordenamiento - Resultados\b0\par");
                sw.WriteLine($"Burbuja - {lblBurbuja.Text}\\par");
                sw.WriteLine($"QuickSort - {lblQuickSort.Text}\\par");
                sw.WriteLine($"Merge - {lblMerge.Text}\\par");
                sw.WriteLine($"Selection - {lblSelection.Text}\\par");
                sw.WriteLine(@"\par");

                sw.WriteLine(@"\b Logs Burbuja\b0\par");
                foreach (var l in logBurbuja) sw.WriteLine(l + "\\par");
                sw.WriteLine(@"\par \b Logs QuickSort\b0\par");
                foreach (var l in logQuick) sw.WriteLine(l + "\\par");
                sw.WriteLine(@"\par \b Logs Merge\b0\par");
                foreach (var l in logMerge) sw.WriteLine(l + "\\par");
                sw.WriteLine(@"\par \b Logs Selection\b0\par");
                foreach (var l in logSelection) sw.WriteLine(l + "\\par");

                sw.WriteLine("}");
            }

            MessageBox.Show("Resultados guardados.");
        }
    }
}
