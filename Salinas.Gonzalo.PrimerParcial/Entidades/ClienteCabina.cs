using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerados;
namespace Entidades
{
    public class ClienteCabina : Cliente
    {
        private string numeroTelefono;
        private Enumerados.TipoTelefono tipoTelefono;

        /// <summary>
        /// Constructor de Cliente Cabina
        /// </summary>
        /// <param name="nombre">Nombre del cliente a asignar</param>
        /// <param name="apellido">Apellido del cliente a asignar</param>
        /// <param name="dni">DNI del cliente a asignar</param>
        /// <param name="edad">Edad del cliente a asignar</param>
        /// <param name="tipoTelefono">Tipo del telefono que solicita</param>
        /// <param name="numeroTelefono">numero de telefono a donde va a llamar el cliente </param>
        public ClienteCabina(string nombre, string apellido, string dni, string edad,TipoTelefono tipoTelefono,string numeroTelefono)
            :base(nombre,apellido,dni,edad)
        {
            TipoTelefono = tipoTelefono;
            NumeroTelefono = numeroTelefono;

        }
        /// <summary>
        /// Propiedad TipoTelefono de lectura y asignacion del atributo tipo telefono
        /// </summary>
        public Enumerados.TipoTelefono TipoTelefono
        {
            get { return this.tipoTelefono; }
            set { this.tipoTelefono = value; }
        }
        /// <summary>
        /// Propiedad NumeroTelefono de lectura y asignacion del atributo Numero Telefono
        /// </summary>
        public string NumeroTelefono
        {
            get { return this.numeroTelefono; }
            set
            {
                if (ValidadorDeInformacion.ValidarNumeroTelefono(value))
                {
                    this.numeroTelefono = value;
                } 
            }
        }

        /// <summary>
        /// Escribes los datos del cliente y las especificaciones del telefono solicitado
        /// </summary>
        /// <returns>Retorna los datos escritos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendLine("DATOS TELEFONO.  ");
            sb.AppendLine($"Tipo Telefono: {TipoTelefono}  ");
            sb.AppendLine($"Numero Telefono: {NumeroTelefono}  ");
            

            return sb.ToString();
        }

        

    }
}
