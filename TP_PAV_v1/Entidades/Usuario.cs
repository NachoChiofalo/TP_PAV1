using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_v1.Entidades
{
    public class Usuario
    {
        private string Legajo;
        private string Pass;
        
        //Constructor
        public Usuario(string legajo, string password)
        {
            Legajo = legajo;
            Pass = password;
        }

        public string LegajoUsu
        {
            get => Legajo;
            set => Legajo = value;   
        }

        public string Password
        { get => Pass; 
          set => Pass = value;
        }

    }
}
