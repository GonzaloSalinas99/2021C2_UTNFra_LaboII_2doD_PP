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
            get { return  CalcularDuracionSesion(); }
            set {
                this.DuracionSesion = value;
                 }
        }
        public int CalcularDuracionSesion()
        {
            double var= (this.tiempoFinal - this.tiempoInicio).TotalSeconds;

            return (int)var;
        }

        public abstract double CostoSesion { get; set; }
        
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
