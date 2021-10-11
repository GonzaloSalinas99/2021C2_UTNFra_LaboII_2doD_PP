using System;
using System.Text;

namespace Entidades
{
    public abstract class Sesion
    {
        private static int idSiguiente = 0;
        private int idSesion;
        private Puesto puesto;
        private Cliente cliente;
        private int duracionSesion;
        protected double costoSesion;
        protected DateTime tiempoInicio;
        protected DateTime tiempoFinal;

        /// <summary>
        /// Constructor de Sesion.
        /// </summary>
        /// <param name="puesto">Puesto a asignar a la sesion</param>
        /// <param name="cliente">Cliente a asignar a la sesion</param>
        public Sesion(Puesto puesto,Cliente cliente)
        {

            this.cliente = cliente;
            this.cliente.EstadoCliente = Enumerados.EstadoCliente.Asignado;
            this.puesto = puesto;
            Puesto.EstadoPuesto = Enumerados.EstadoPuesto.EnUso;
            this.costoSesion = 0;
            this.duracionSesion = 0;
            this.idSesion = idSiguiente;
            this.tiempoInicio = DateTime.Now;
            this.tiempoFinal = default(DateTime);
            
            idSiguiente++;
        }

        /// <summary>
        /// Propiedad IDSesion de lectura del atributo Id Sesion
        /// </summary>
        public int IdSesion
        {
            get { return this.idSesion; }
        }
        /// <summary>
        /// Propiedad Cliente de lectura y asignacion del atributo Cliente
        /// </summary>
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        /// <summary>
        /// Propiedad Puesto de lectura y asignacion del atributo Puesto
        /// </summary>
        public Puesto Puesto
        {
            get { return this.puesto; }
            set { this.puesto = value; }
        }
        /// <summary>
        /// Propiedad TiempoInicio de lectura y asignacion del atributo TiempoInicio
        /// </summary>
        public DateTime TiempoInicio
        {
            get { return this.tiempoInicio; }
            set { this.tiempoInicio = value; }
        }
        /// <summary>
        /// Propiedad TiempoFinal de lectura y asignacion del atributo TiempoFinal
        /// </summary>
        public DateTime TiempoFinal
        {
            get { return this.tiempoFinal; }
            set { this.tiempoFinal = value; }
        }
        /// <summary>
        /// Propiedad Duracionsesion de lectura y asignacion del atributo Duracion Sesion
        /// </summary>
        public int DuracionSesion
        {
            get { return  CalcularDuracionSesion(); }
            set {
                this.DuracionSesion = value;
                 }
        }
        /// <summary>
        /// Calcula la duracion de la sesion
        /// </summary>
        /// <returns>Retorna la duracion de la sesion</returns>
        public int CalcularDuracionSesion()
        {
            double var= (this.tiempoFinal - this.tiempoInicio).TotalSeconds;

            return (int)var;
        }

        public abstract double CostoSesion { get; set; }
        /// <summary>
        /// Escribe los datos de la Sesion
        /// </summary>
        /// <returns>Retorna los datos escritos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id de sesión: {this.IdSesion}.");
            
            sb.AppendLine($"Hora de inicio: {this.TiempoInicio}.");
            sb.AppendLine(Cliente.ToString());
            
            if (this.TiempoFinal != DateTime.MinValue)
            {
                sb.AppendLine($"Hora de final: {this.TiempoFinal}.");
                sb.AppendLine($"Duracion Sesion: {this.DuracionSesion}.");
                sb.AppendLine($"Costo Final Mas IVA: {this.CostoSesion}.");
            }
            sb.AppendLine($"Puesto:{Puesto.ToString()}");
            return sb.ToString();
        }
    }
}
