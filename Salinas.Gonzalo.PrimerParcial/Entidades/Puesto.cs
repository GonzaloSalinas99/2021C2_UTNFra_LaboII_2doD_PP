using System;
using System.Text;
using Enumerados;
namespace Entidades
{
    public abstract class Puesto
    {
        protected string idPuesto;
        private EstadoPuesto estado;
        private int usoMinutos;

        protected Puesto()
        {
            this.usoMinutos = 0;
            this.estado = EstadoPuesto.SinUso;
        }

        public string IdPuesto
        {
            get{ return this.idPuesto; }
        }
        public EstadoPuesto EstadoPuesto
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public int UsoMinutos
        {
            get { return this.usoMinutos; }
            set { this.usoMinutos = value; }
        }

        public static bool operator == (Puesto puesto1 , Puesto puesto2)
        {
            if(puesto1.IdPuesto.Equals(puesto2.IdPuesto))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Puesto puesto1, Puesto puesto2)
        {
            return !(puesto1 == puesto2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {IdPuesto}\n\t");
            sb.AppendLine($"Estado: {EstadoPuesto}\n\t");
            sb.AppendLine($"Uso minutos: {UsoMinutos}\n\t");
            sb.AppendLine("---------------------------\t");
            return sb.ToString();
        }

        public abstract double CalcularCosto(Sesion sesion);

    }
}
