using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class Barrio
    {
        private int Id_Barrio;
        private string nombre;
        private int Id_Localidad;

        public int IdBarrio
        {
            get => Id_Barrio;
            set => Id_Barrio = value;
        }

        public string NombreBarrio
        {
            get => nombre;
            set => nombre = value;
        }

        public int IdLocalidadBarrio
        {
            get => Id_Localidad;
            set => Id_Localidad = value;
        }
    }
}
