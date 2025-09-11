using System;
using System.Windows.Forms;

namespace GestorTareas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Plantilla .NET 8
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}