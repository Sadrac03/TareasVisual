using System;
using System.Windows.Forms;

namespace VisorImagenes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // .NET 6+ WinForms template
            Application.Run(new Form1());
        }
    }
}
