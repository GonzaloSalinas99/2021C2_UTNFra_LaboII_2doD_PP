using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    class Administrador : Usuario
    {
        public override string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (value is not null && value != "")
                {
                    this.nombre = value;
                }
            }
        }

        public override string Dni
        {
            get { return this.dni; }
            set
            {
                if (value is not null && value != "")
                {
                    this.dni = value;
                }
            }
        }



    }
}
