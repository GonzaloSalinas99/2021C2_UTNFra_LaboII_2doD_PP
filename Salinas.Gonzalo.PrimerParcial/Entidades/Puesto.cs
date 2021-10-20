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
        protected const double IVA = 0.21;
        /// <summary>
        /// Constructor de Puesto que inicia los minutos de uso en 0 y el estado del puesto en SinUso
        /// </summary>
        protected Puesto()
        {
            this.usoMinutos = 0;
            this.estado = EstadoPuesto.SinUso;
        }
        /// <summary>
        /// Propiedad IdPuesto de lectura y asignacion del atributo IDPuesto
        /// </summary>
        public string IdPuesto
        {
            get{ return this.idPuesto; }
            set { this.idPuesto = value; }
        }

        /// <summary>
        /// Propiedad EstadoPuesto de lectura y asignacion del atributo Estado Puesto
        /// </summary>
        public EstadoPuesto EstadoPuesto
        {
            get { return this.estado; }
            set { this.estado = value; }
        }


        /// <summary>
        /// Propiedad UsoMinutos de lectura y asignacion del atributo Uso Minutos
        /// </summary>
        public int UsoMinutos
        {
            get { return this.usoMinutos; }
            set { this.usoMinutos = value; }
        }
        /// <summary>
        /// Compara dos puestos 
        /// </summary>
        /// <param name="puesto1">Puesto a comparar</param>
        /// <param name="puesto2">Puesto a comparar</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator == (Puesto puesto1 , Puesto puesto2)
        {
            if(puesto1.Equals(puesto2) && puesto1.GetHashCode() == puesto2.GetHashCode())
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Compara dos puestos
        /// </summary>
        /// <param name="puesto1">Puesto a comparar</param>
        /// <param name="puesto2">Puesto a comparar</param>
        /// <returns>True si son diferentes, false si son iguales</returns>
        public static bool operator !=(Puesto puesto1, Puesto puesto2)
        {
            return !(puesto1 == puesto2);
        }
        /// <summary>
        /// Escribe los datos del Puesto
        /// </summary>
        /// <returns>Retorna los datos escritos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {IdPuesto}\n\t");
            sb.AppendLine($"Estado: {EstadoPuesto}\n\t");
            sb.AppendLine($"Uso minutos: {UsoMinutos}\n\t");
            sb.AppendLine("---------------------------\t");
            return sb.ToString();
        }
        /// <summary>
        /// Calcula costo de la sesions
        /// </summary>
        /// <param name="sesion">Sesion a calcular su costo</param>
        /// <returns>Retorna costo total de la sesion</returns>
        public abstract double CalcularCosto(Sesion sesion);

        public override bool Equals(object obj)
        {
            if(obj is not null && obj is Puesto && this.GetType().Equals(obj.GetType()))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return int.Parse(idPuesto);
        }

       }
}
