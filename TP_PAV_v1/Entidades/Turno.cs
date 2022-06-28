using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class Turno
    {
        private int IdTurno;
        private string Descripcion;

        public int IdDelTurno
        {
            get => IdTurno;
            set => IdTurno = value;
        }

        public string DescripcionTurno
        {
            get => Descripcion;
            set => Descripcion = value;
        }
    }
}
