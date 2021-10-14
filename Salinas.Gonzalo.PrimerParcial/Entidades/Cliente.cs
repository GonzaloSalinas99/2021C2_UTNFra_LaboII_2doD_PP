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
        /// <summary>
        /// Constructor de Cliente 
        /// </summary>
        /// <param name="nombre">Nombre del cliente a asignar</param>
        /// <param name="apellido">Apellido del cliente a asignar</param>
        /// <param name="dni">DNI del cliente a asignar</param>
        /// <param name="edad">Edad del cliente a asignar</param>
        public Cliente(string nombre, string apellido, string dni, string edad)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
            this.edad = edad;
            this.estadoCliente = EstadoCliente.Esperando;
        }
        /// <summary>
        /// Propiedad Nombre de lectura y asignacion del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (value is not null && ValidadorDeInformacion.ValidarStringTexto(value))
                {
                    this.nombre = value;
                }
            }
        }
        /// <summary>
        /// Propiedad Nombre de lectura y asignacion del atributo nombre
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (value is not null && ValidadorDeInformacion.ValidarStringTexto(value))
                {
                    this.apellido = value;
                }
            }
        }
        /// <summary>
        /// Propiedad EstadoCliente de lectura y asignacion del atributo Estado Cliente
        /// </summary>
        public EstadoCliente EstadoCliente
        {
            get { return this.estadoCliente; }
            set { this.estadoCliente = value; }
        }
        /// <summary>
        /// Propiedad DNI de lectura y asignacion del atributo dni
        /// </summary>
        public string Dni
        {
            get { return this.dni; }
            set
            {
                if (value is not null && ValidadorDeInformacion.ValidarDocumento(value))
                {
                    this.dni = value;
                }
            }
        }

        /// <summary>
        /// Escribe los datos del cliente
        /// </summary>
        /// <returns>Retorna los datos del cliente</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DATOS CLIENTE.");
            sb.AppendLine($"Nombre: {Nombre}.   ");
            sb.AppendLine($"Apellido: {Apellido}.   ");
            sb.AppendLine($"Dni: {Dni}.   ");
            sb.AppendLine($"Edad: {edad}.   ");
            sb.AppendLine($"Estado: {EstadoCliente}.   ");
            return sb.ToString();
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if ((c1 is not null && c2 is not null) && (c1.GetHashCode() == c2.GetHashCode()) && (c1.Equals(c1) && c2.Equals(c2)))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj is not null && obj is Cliente)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return int.Parse(Dni);
        }
    }
}

