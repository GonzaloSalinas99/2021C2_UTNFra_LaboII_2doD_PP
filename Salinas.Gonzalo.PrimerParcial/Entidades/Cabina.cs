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

            Llamada auxiliar;
            if(llamada is Llamada && llamada.CalcularDuracionSesion() >0)
            {
                auxiliar = (Llamada)llamada;

                if(auxiliar.TipoLlamada == TipoLlamada.LargaDistancia)
                {
                    costoTotal = llamada.CalcularDuracionSesion() * 2.50;
                }
                else if(auxiliar.TipoLlamada == TipoLlamada.Internacional)
                {
                    costoTotal = llamada.CalcularDuracionSesion() * 5;
                }
                else
                {
                    costoTotal = llamada.CalcularDuracionSesion();
                }
            }
            return costoTotal;
        }
        /// <summary>
        /// Calcula el costo final sumandole el IVA
        /// </summary>
        /// <param name="llamada">Sesion a calcular su costo</param>
        /// <returns>Retorna el precio total a pagar</returns>
        public override double CalcularCostoFinalMasIva(Sesion llamada)
        {
            double costoTotal = CalcularCosto(llamada);
            double costoFinal = costoTotal * IVA;
            return costoFinal + costoTotal;
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
