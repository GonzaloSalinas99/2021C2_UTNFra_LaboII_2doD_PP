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
        private Enumerados.TipoLlamada tipoLlamada;

        public Llamada(string numero, Cliente cliente, Puesto puesto)
            : base(puesto, cliente)
        {
            Numero = numero;
        }

        public string Numero
        {
            get { return this.numero; }
            set
            {
                char[] arrayTelefono = value.ToCharArray();
                for(int i=0;i<arrayTelefono.Length;i++)
                {
                    if(arrayTelefono[i]>='0' && arrayTelefono[i]<='9')
                    {
                        this.numero = value;
                    }
                    else
                    {
                        this.numero = "Valor Invalido";
                    }
                }
            }
        }

        public Enumerados.TipoLlamada TipoLlamada
        {
            get { return ValidarTipoLlamada(this.numero); }
            set 
            {
                if(value == Enumerados.TipoLlamada.Local || value == Enumerados.TipoLlamada.LargaDistancia || value == Enumerados.TipoLlamada.Internacional || value == Enumerados.TipoLlamada.SinAsignar )
                {
                    this.tipoLlamada = value;
                }
            }
        }

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

        public override double CostoSesion
        {
            get { return this.costoSesion; }
            set { this.costoSesion = this.Puesto.CalcularCosto(this); }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Numero Telefono: {Numero}");
            sb.AppendLine($"Tipo de Llamada: {TipoLlamada}");
            sb.AppendLine($"Costo Llamada: {costoSesion}");

            return sb.ToString();
        }


    }
}
