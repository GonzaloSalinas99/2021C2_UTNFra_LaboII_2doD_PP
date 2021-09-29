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
        public Sesion(Puesto puesto,Cliente cliente)
        {
            this.cliente = cliente;
            this.puesto = puesto;
            this.costoSesion = 0;
            this.duracionSesion = 0;
            this.idSesion = idSiguiente;
            this.tiempoInicio = DateTime.Now;
            this.tiempoFinal = default(DateTime);
            
            idSiguiente++;
        }


        public int IdSesion
        {
            get { return this.idSesion; }
        }
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        public Puesto Puesto
        {
            get { return this.puesto; }
            set { this.puesto = value; }
        }

        public DateTime TiempoInicio
        {
            get { return this.tiempoInicio; }
            set { this.tiempoInicio = value; }
        }

        public DateTime TiempoFinal
        {
            get { return this.tiempoFinal; }
            set { this.tiempoFinal = value; }
        }

        public int DuracionSesion
        {
            get { return this.duracionSesion; }
            set { this.duracionSesion = value; }
        }

        public abstract double CostoSesion { get; set; }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id de sesión: {this.IdSesion}.");
            sb.AppendLine($"Puesto:");
            sb.AppendLine(Puesto.ToString());
            sb.AppendLine("Cliente:");
            sb.AppendLine(Cliente.mostrar());
            sb.AppendLine($"Hora de inicio: {this.TiempoInicio}.");
            if (this.TiempoFinal != DateTime.MinValue)
            {
                sb.AppendLine($"Hora de final: {this.TiempoFinal}.");
                sb.AppendLine($"Duracion Sesion: {this.DuracionSesion}.");
                sb.AppendLine($"Costo: {this.CostoSesion}.");
            }

            return sb.ToString();
        }
    }
}
