using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conexion : Sesion
    {
        /// <summary>
        /// Constructor de la clase Conexion
        /// </summary>
        /// <param name="puesto">Tipo de puesto a establecer conexion</param>
        /// <param name="cliente">Cliente a ser vinculada la conexion</param>
        public Conexion (Puesto puesto,Cliente cliente)
            :base(puesto,cliente)
        {
        }
        /// <summary>
        /// Propiedad CostoSesion de lectura y asignacion del atributo Costo Sesion
        /// </summary>
        public override double CostoSesion 
        {
            get { return this.costoSesion; }
            set { this.costoSesion = this.Puesto.CalcularCosto(this); }
        }
        /// <summary>
        /// Escribe los datos de la sesion y el costo de la conexion
        /// </summary>
        /// <returns>Retorna un string con todos los datos de la conexion</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine($"Costo Conexion Total: ${costoSesion}");
            stringBuilder.AppendLine($"Costo Conexion Final Mas Iva: ${this.Puesto.CalcularCostoFinalMasIva(this)}");

            return stringBuilder.ToString();
        }
    }
}
