using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerados;
using Sesion;
namespace Puesto
{

    public class Telefono : Puesto
    {
        private TipoTelefono tipo;
        private string marca;
        private static int idSiguiente = 1;

        public Telefono(string marca, TipoTelefono tipo):base()
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

        public override double CalcularCosto(Sesion.Sesion llamada)
        {
            if(llamada is Llam)
        }



    }
}
