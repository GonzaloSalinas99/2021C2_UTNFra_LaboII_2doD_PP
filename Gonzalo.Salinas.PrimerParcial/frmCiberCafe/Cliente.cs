using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCiberCafe
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        private short edad;

        public Cliente(string nombre, string apellido, string dni, short edad)
        {
            Nombre= nombre;
            Apellido = apellido;
            Dni = dni;
            Edad= edad;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set 
            {
                if(value is not null || value != "")
                {
                    this.nombre = value;
                }
            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (value is not null || value != "")
                {
                    this.apellido = value;
                }
            }
        }

        public string Dni
        {
            get { return this.dni; }
            set
            {
                if ((value is not null || value != "" ) && value.Length == 10)
                {
                    this.dni = value;
                }
            }
        }

        public short Edad
        {
            get { return this.edad; }
            set
            {
                if (value> 0 && value <100)
                {
                    this.edad = value;
                }
            }
        }
    }
}
