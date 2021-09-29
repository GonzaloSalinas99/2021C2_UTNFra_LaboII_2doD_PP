using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerados;
namespace Entidades
{
    public class ClienteCabina : Cliente
    {
        private string numeroTelefono;
        private Enumerados.TipoTelefono tipoTelefono;
        private string marcaTelefono;

        public ClienteCabina(string nombre, string apellido, string dni, string edad,TipoTelefono tipoTelefono,string numeroTelefono,string marcaTelefono)
            :base(nombre,apellido,dni,edad)
        {
            this.tipoTelefono = tipoTelefono;
            this.numeroTelefono = numeroTelefono;
            this.marcaTelefono = marcaTelefono;
        }

        public Enumerados.TipoTelefono TipoTelefono
        {
            get { return this.tipoTelefono; }
            set { this.tipoTelefono = value; }
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cliente.");
            sb.AppendLine(base.mostrar());
            sb.AppendLine($"Tipo Telefono: {TipoTelefono}");
            sb.AppendLine($"Numero Telefono: {NumeroTelefono}");
            sb.AppendLine($"Marca Telefono: {MarcaTelefono}");

            return sb.ToString();
        }
    }
}
