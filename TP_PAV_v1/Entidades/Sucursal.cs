using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class Sucursal
    {
        private int Nro_Sucursal;
        private int Id_Provincia;

        public int NroSucursal
        {
            get => Nro_Sucursal;
            set => Nro_Sucursal = value;
        }
        public int IdProvinciaSucursal
        {
            get => Id_Provincia;
            set => Id_Provincia = value;
        }

    }
}
