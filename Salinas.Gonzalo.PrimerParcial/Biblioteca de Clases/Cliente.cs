using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Cliente : Usuario
    {
        private string apellido;
        private string edad;

        public Cliente(string nombre, string apellido, string dni, string edad)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
            this.edad = edad;
        }

        public override string Nombre
        {
            get { return this.nombre; }
            set 
            {
                if(value is not null && value !="")
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

        




        public string mostrar()
        {
            return $"{this.nombre} {this.apellido} {this.dni} {this.edad}";
        }



    }
}
