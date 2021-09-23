using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public abstract class Usuario
    {
        protected string nombre;
        protected string dni;

        public abstract string Nombre { get; set; }
        public abstract string Dni { get; set; }


    }
}
