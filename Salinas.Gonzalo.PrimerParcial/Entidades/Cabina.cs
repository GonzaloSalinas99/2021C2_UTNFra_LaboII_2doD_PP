using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerados;

namespace Entidades
{

    public class Cabina : Puesto
    {
        private TipoTelefono tipo;
        private string marca;
        private static int idSiguiente = 1;
        /// <summary>
        /// Constructor de la clase Cabina que genera ID autoincrementable
        /// </summary>
        /// <param name="marca">Marca a asignar</param>
        /// <param name="tipo">Tipo de telefono</param>
        public Cabina(string marca, TipoTelefono tipo):base()
        {
            Marca = marca;
            TipoTelefono = tipo;
            this.idPuesto = "T0" + idSiguiente;
            idSiguiente++;
        }


        /// <summary>
        /// Propiedad Marca de lectura y asignacion del atributo marca
        /// </summary>
        public  string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }
        /// <summary>
        /// Propiedad TipoTelefono de lectura y asignacion del atributo tipoTelefono
        /// </summary>
        public TipoTelefono TipoTelefono 
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        /// <summary>
        /// Calcula costo de la llamada 
        /// </summary>
        /// <param name="llamada">Llamada a calcular su costo</param>
        /// <returns>Retorna el costo total de la llamada con IVA</returns>
        public override double CalcularCosto(Sesion llamada)
        {
            double costoTotal=0;
            double costoFinal;
            Llamada auxiliar;
            if(llamada is Llamada && llamada.DuracionSesion >0)
            {
                auxiliar = (Llamada)llamada;

                if(auxiliar.TipoLlamada == TipoLlamada.LargaDistancia)
                {
                    costoTotal = llamada.DuracionSesion * 2.50;
                }
                else if(auxiliar.TipoLlamada == TipoLlamada.Internacional)
                {
                    costoTotal = llamada.DuracionSesion * 5;
                }
                else
                {
                    costoTotal = llamada.DuracionSesion;
                }
            }

            costoFinal = costoTotal * IVA;
            return costoFinal+costoTotal;
        }
        /// <summary>
        /// Escribe los datos de la cabina y el puesto
        /// </summary>
        /// <returns>Cadena con los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo Telefono: {TipoTelefono}\t");
            sb.AppendLine($"Marca Telefono: {Marca}\t");
            sb.AppendLine("----------------------------\t");

            return sb.ToString();
        }

    }
}
