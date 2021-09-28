using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puesto
{
    public enum TipoLlamada
    {
        disco,teclado
    }

    public class Telefono : Puesto
    {
        private string numeroTelefono;
        private TipoLlamada tipoLlamada;
        private string marcaTelefono;

        public Telefono (string numeroTelefono,string marca,TipoLlamada tipoLlamada,string identificador,bool enUso,string dniCliente)
                    :base(identificador,enUso,dniCliente)
        {
            NumeroTelefono = numeroTelefono;
            this.marcaTelefono = marca;
            this.tipoLlamada = tipoLlamada;
        }

        public override bool EnUso
        {
            get { return this.enUso; }
            set { this.enUso = value; }
        }

        public override string DniCliente 
        {
            get { return this.dniCliente; }
            set { this.dniCliente = value; }
        }

        public override string Identificador
        {
            get { return this.identificador; }
            set
            {
                if (value is not null)
                {
                    char[] array = value.ToCharArray();

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[0] == 'T' && array[1] == '0' && (array[2] > '0' || array[2] < '9'))
                        {
                            this.identificador = new string(array);
                        }
                        else
                        {
                            this.identificador = "VALOR INVALIDO";
                            break;
                        }
                    }
                }
            }
        }

        public string NumeroTelefono
        {
            get { return this.numeroTelefono; }
            set 
            {
                this.numeroTelefono = value;
            }
        }

        public TipoLlamada TipoLlamada
        {
            get { return this.tipoLlamada; }
            set { this.tipoLlamada = value; }
        }


    }
}
