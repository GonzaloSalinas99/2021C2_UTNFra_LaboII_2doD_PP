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

        public Cabina(string marca, TipoTelefono tipo):base()
        {
            Marca = marca;
            TipoTelefono = tipo;
            if(idSiguiente <6)
            {
                this.idPuesto = "T0" + idSiguiente;
            }
            idSiguiente++;
        }



        public  string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public TipoTelefono TipoTelefono 
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

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
            return retorno;
        }

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
