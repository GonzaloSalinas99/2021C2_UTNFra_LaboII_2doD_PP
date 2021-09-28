using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Puesto;
namespace Cliente
{
    public class ClienteTelefono : Cliente
    {
        private string numeroTelefono;
        private TipoLlamada tipoLlamada;
        private string marcaTelefono;

        public ClienteTelefono(string nombre, string apellido, string dni, string edad,TipoLlamada tipoLlamada,string numeroTelefono,string marcaTelefono)
            :base(nombre,apellido,dni,edad)
        {
            this.tipoLlamada = tipoLlamada;
            this.numeroTelefono = numeroTelefono;
            this.marcaTelefono = marcaTelefono;
        }

        public TipoLlamada TipoLlamada
        {
            get { return this.tipoLlamada; }
            set { this.tipoLlamada = value; }
        }

        public string NumeroTelefono
        {
            get { return this.numeroTelefono; }
            set { this.numeroTelefono = value; }
        }

        public string MarcaTelefono
        {
            get { return this.marcaTelefono; }
            set { this.marcaTelefono = value; }
        }


    }
}
