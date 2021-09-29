using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conexion : Sesion
    {
        public Conexion (Puesto puesto,Cliente cliente):base(puesto,cliente)
        {
        }

        public override double CostoSesion 
        {
            get { return this.costoSesion; }
            set { this.Puesto.CalcularCosto(this); }
        }

    }
}
