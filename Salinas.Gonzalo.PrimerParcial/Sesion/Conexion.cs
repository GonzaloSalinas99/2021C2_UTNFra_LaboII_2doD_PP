using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion
{
    class Conexion : Sesion
    {
        public Conexion(DateTime tiempoInicio)
        {
            TiempoInicio = tiempoInicio;
            // TiempoFinal = 
        }

        public override DateTime TiempoInicio
        {
            get { return this.tiempoInicio; }
            set { this.tiempoInicio = value; }
        }
        public override DateTime TiempoFinal
        {
            get { return this.tiempoFinal; }
            set { this.tiempoFinal = value; }
        }




        public override double CalcularPrecioACobrar(DateTime inicio, DateTime final)
        {
            return final.Subtract(inicio).TotalMinutes;
        }


    }
}
