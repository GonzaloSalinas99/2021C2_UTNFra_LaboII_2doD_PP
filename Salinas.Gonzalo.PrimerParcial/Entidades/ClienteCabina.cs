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


        public ClienteCabina(string nombre, string apellido, string dni, string edad,TipoTelefono tipoTelefono,string numeroTelefono)
            :base(nombre,apellido,dni,edad)
        {
            this.tipoTelefono = tipoTelefono;
            this.numeroTelefono = numeroTelefono;

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


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendLine("DATOS TELEFONO.  ");
            sb.AppendLine($"Tipo Telefono: {TipoTelefono}  ");
            sb.AppendLine($"Numero Telefono: {NumeroTelefono}  ");
            

            return sb.ToString();
        }

        

    }
}
