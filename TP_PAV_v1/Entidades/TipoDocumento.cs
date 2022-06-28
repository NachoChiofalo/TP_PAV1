using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class TipoDocumento
    {
        public int IdTipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }


        public TipoDocumento(int idTipoDoc, string nombre)
        {
            IdTipoDocumento = idTipoDoc;
            NombreTipoDocumento = nombre;
        }
        public TipoDocumento()
        {

        }
    }
}
