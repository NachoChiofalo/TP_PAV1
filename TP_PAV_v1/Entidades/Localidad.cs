using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
   public class Localidad
    {
        private string NombreLocalidad;
        private int IdLocalidad;
        private int Provincia;

        public Localidad(string nombreLocalidad, int idLocalidad, int provincia)
        {
            NombreLocalidad = nombreLocalidad;
            IdLocalidad = idLocalidad;
            Provincia = provincia;
        }

        public Localidad()
        {

        }

        public string NombreDeLaLocalidad
        {
            get => NombreLocalidad;
            set => NombreLocalidad = value;
        }

        public int IdDeLaLocalidad
        {
            get => IdLocalidad;
            set => IdLocalidad = value;
        }

        public int ProvinciaDeLaLocalidad
        {
            get => Provincia;
            set => Provincia = value;
        }
    }
}
