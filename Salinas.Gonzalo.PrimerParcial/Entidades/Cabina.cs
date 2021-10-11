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
        /// <returns></returns>
        public override double CalcularCosto(Sesion llamada)
        {
            double retorno=0;
            Llamada auxiliar;
            if(llamada is Llamada && llamada.DuracionSesion >0)
            {
                auxiliar = (Llamada)llamada;

                if(auxiliar.TipoLlamada == TipoLlamada.LargaDistancia)
                {
                    retorno = llamada.DuracionSesion * 2.50;
                }
                else if(auxiliar.TipoLlamada == TipoLlamada.Internacional)
                {
                    retorno = llamada.DuracionSesion * 5;
                }
                else
                {
                    retorno = llamada.DuracionSesion;
                }
            }
            return retorno * 0.21;
        }
        /// <summary>
        /// Retorna los datos de Puesto y los propios
        /// </summary>
        /// <returns></returns>
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
