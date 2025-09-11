using System;

namespace GestorTareas
{
    public class Tarea
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Today;
        public string Lugar { get; set; } = string.Empty;
        public string Estado { get; set; } = "No Realizada";
    }
}