using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class Tanques
    {
        private string CUIT;
        private int NroTanque;
        private int VolMax;
        private int VolMin;
        private int CodTipoCombustible;

        public Tanques(string cuit, int nroTanque, int volMax, int volMin, int codTipoCombustible)
        {
            CUIT = cuit;
            NroTanque = nroTanque;
            VolMax = volMax;
            VolMin = volMin;
            CodTipoCombustible = codTipoCombustible;
        }

        public Tanques()
        {

        }


        public string CUITTanque
        {
            get => CUIT;
            set => CUIT = value;
        }

        public int NroTanques
        {
            get => NroTanque;
            set => NroTanque = value;
        }

        public int VolMaxTanque
        {
            get => VolMax;
            set => VolMax = value;
        }

        public int VolMinTanque
        {
            get => VolMin;
            set => VolMin = value;
        }

        public int CodTipoCombustibleTanque
        {
            get => CodTipoCombustible;
            set => CodTipoCombustible = value;
        }
    }
}
