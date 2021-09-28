using System;
using System.Collections.Generic;
using Puesto;
using Cliente;


namespace Sesion
{
    public abstract class Sesion
    {
        protected DateTime tiempoInicio;
        protected DateTime tiempoFinal;

        public Sesion(DateTime tiempoInicio, DateTime tiempoFinal)
        {
            this.tiempoInicio = tiempoInicio;
            this.tiempoFinal = tiempoFinal;
        }

        public abstract DateTime TiempoInicio { get; set;}
        public abstract DateTime TiempoFinal { get; set;}

        public abstract double CalcularPrecioACobrar(DateTime inicio, DateTime final);



    }
}
