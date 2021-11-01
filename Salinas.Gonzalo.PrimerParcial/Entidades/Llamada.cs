using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Llamada : Sesion
    {
        private string numero;

        /// <summary>
        /// Constructor de Llamada
        /// </summary>
        /// <param name="numero">Numero de telefono del cliente</param>
        /// <param name="cliente">cliente a realizar la llamada</param>
        /// <param name="puesto">Puesto para realizar la llamada</param>
        public Llamada(string numero, Cliente cliente, Puesto puesto)
            : base(puesto, cliente)
        {
            Numero = numero;
        }
        /// <summary>
        /// Propiedad Numero de lectura y asignacion del atributo Numero
        /// </summary>
        public string Numero
        {
            get { return this.numero; }
            set
            {
                this.numero = value;
            }
        }

        /// <summary>
        /// Propiedad TipoLlamada de lectura y asignacion del atributo TipoLlamada
        /// </summary>
        public Enumerados.TipoLlamada TipoLlamada
        {
            get { return ValidarTipoLlamada(this.numero); }
        }
        /// <summary>
        /// Valida el tipo de la llamada
        /// </summary>
        /// <param name="numero">Numero a validar</param>
        /// <returns>Retorna el tipo de llamada (Local,Larga Distancia,Internacional)dependiendo el numero de telefono</returns>
        private Enumerados.TipoLlamada ValidarTipoLlamada(string numero)
        {
            char[] arrayTelefono = this.Numero.ToCharArray();
            if (arrayTelefono.Length == 12)
            {
                if (arrayTelefono[0] == '5' && arrayTelefono[1] == '4')
                {
                    if (arrayTelefono[2] == '1' && arrayTelefono[3] == '1')
                    {
                        return Enumerados.TipoLlamada.Local;
                    }
                    else
                    {
                        return  Enumerados.TipoLlamada.LargaDistancia;
                    }
                }
                else
                {
                    return  Enumerados.TipoLlamada.Internacional;
                }
            }
            else
            {
                return  Enumerados.TipoLlamada.SinAsignar;
            }
        }
        /// <summary>
        /// Propiedad CostoSesion de lectura y asignacion del atributo CostoSesion
        /// </summary>
        public override double CostoSesion
        {
            get { return this.costoSesion; }
            set { this.costoSesion = this.Puesto.CalcularCosto(this); }
        }

        /// <summary>
        /// Escribe los datos de la sesion y los datos de la llamada
        /// </summary>
        /// <returns>Retorna los datos escritos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Numero Telefono: {Numero}");
            sb.AppendLine($"Tipo de Llamada: {TipoLlamada}");
            sb.AppendLine($"Costo Llamada Total: {costoSesion}");
            sb.AppendLine($"Costo Llamada Final Mas Iva: {this.Puesto.CalcularCostoFinalMasIva(this)}");

            return sb.ToString();
        }


    }
}
