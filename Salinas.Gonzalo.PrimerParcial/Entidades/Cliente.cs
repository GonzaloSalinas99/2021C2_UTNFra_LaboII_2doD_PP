using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerados;
namespace Entidades
{
    public abstract class Cliente 
    {
        private string nombre;
        private string dni;
        private string apellido;
        private string edad;
        private EstadoCliente estadoCliente;
        public Cliente(string nombre, string apellido, string dni, string edad)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
            this.edad = edad;
            this.estadoCliente = EstadoCliente.Esperando;
        }

        public string Nombre
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

        public EstadoCliente EstadoCliente
        {
            get { return this.estadoCliente; }
            set { this.estadoCliente = value; }
        }
        public string Dni
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
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DATOS CLIENTE.");
            sb.AppendLine($"Nombre: {this.nombre}.   ");
            sb.AppendLine($"Apellido: {this.apellido}.   ");
            sb.AppendLine($"Dni: {this.dni}.   ");
            sb.AppendLine($"Edad: {this.edad}.   ");
            sb.AppendLine($"Estado: {this.estadoCliente}.   ");
            return sb.ToString();
        }


    }
}
