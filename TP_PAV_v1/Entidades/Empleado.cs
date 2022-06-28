using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class Empleado
    {
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Legajo { get; set; }
        public int CUIL { get; set; }
        public int IdBarrio { get; set; }
        public string Calle { get; set; }
        public int NumeroCalle { get; set; }
        public bool Gerente { get; set; }

        

        public Empleado()
        {

        }

        public Empleado(string legajoDeEmpleado, string nroDocEmpleado)
        {
        }
    }
}
