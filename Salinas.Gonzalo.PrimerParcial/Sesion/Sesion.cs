using System;

namespace Sesion
{
    public abstract class Sesion
    {
        protected DateTime tiempoInicio;
        protected DateTime tiempoFinal;

        public abstract DateTime TiempoInicio { get; set; }
        public abstract DateTime TiempoFinal { get; set; }

        public abstract double CalcularPrecioACobrar(DateTime inicio, DateTime final);


    }
}
