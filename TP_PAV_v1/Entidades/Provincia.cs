using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class Provincia
    {
        private string NombreProvincia;
        private int IdProvincia;
        private string CodigoPostal;

        public Provincia(string nombreProvincia, int idProvincia, string codigoPostal)
        {
            NombreProvincia = nombreProvincia;
            IdProvincia = idProvincia;
            CodigoPostal = codigoPostal;
        }

        public Provincia()
        {

        }

        public string NombreDeLaProvincia
        {
            get => NombreProvincia;
            set => NombreProvincia = value;
        }

        public int IdDeLaProvincia
        {
            get => IdProvincia;
            set => IdProvincia = value;
        }

        public string CodigoPostalDeLaProvincia
        {
            get => CodigoPostal;
            set => CodigoPostal = value;
        }
    }
}
