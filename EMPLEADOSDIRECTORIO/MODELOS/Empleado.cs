using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLEADOSDIRECTORIO.MODELOS
{
    internal class Empleado
    {
        private string documentos;
        private string nombres;
        private string apellidos;
        private string fecha;
        private string hora;

        public Empleado()
        {
            this.documentos= "";
            this.nombres= "";
            this.apellidos= "";
            this.fecha= "";
            this.hora = "";
        }
        public string Documentos { get => documentos; set => documentos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
