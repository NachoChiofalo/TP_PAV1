using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class Estacion
    {
        private string CUIT;
        private string NombreEstacion;
        private int IdSucursal;
        private string Calle;
        private int Altura;
        private int IdProvincia;
        private string LegajoGerente;
        private string Planta;

        public Estacion(string cuit, string nombreEstacion, int idSucursal, string calle, int altura, int idProvincia, string legajoGerente, string planta)
        {
            CUIT = cuit;
            NombreEstacion = nombreEstacion;
            IdSucursal = idSucursal;
            Calle = calle;
            Altura = altura;
            IdProvincia = idProvincia;
            LegajoGerente = legajoGerente;
            Planta = planta;
        }

        public Estacion()
        {

        }

        public string CUITEstacion
        {
            get => CUIT;
            set => CUIT = value;
        }

        public string NombreEstaciones
        {
            get => NombreEstacion;
            set => NombreEstacion = value;
        }

        public int IdSucursalEstacion
        {
            get => IdSucursal;
            set => IdSucursal = value;
        }

        public string CalleEstacion
        {
            get => Calle;
            set => Calle = value;
        }
        public int AlturaEstacion
        {
            get => Altura;
            set => Altura = value;
        }

        public int IdProvinciaEstacion
        {
            get => IdProvincia;
            set => IdProvincia = value;
        }

        public string LegajoGerenteEstacion
        {
            get => LegajoGerente;
            set => LegajoGerente = value;
        }

        public string PlantaEstacion
        {
            get => Planta;
            set => Planta = value;
        }
    }
}

