using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteComputadora : Cliente
    {
        private List<string> listaSoftware;
        private List<string> listaPerifericos;
        private List<string> listaJuegos;

        public ClienteComputadora(string nombre, string apellido, string dni, string edad)
                                :base(nombre, apellido, dni, edad)
        {
            this.listaSoftware = new List<string>();
            this.listaPerifericos = new List<string>();
            this.listaJuegos = new List<string>();
        }

        public List<string> ListaSoftware
        {
            get { return this.listaSoftware; }
        }

        public List<string> ListaPerifericos
        {
            get { return this.listaPerifericos; }
        }

        public List<string> ListaJuegos
        {
            get { return this.listaJuegos; }
        }


        public string SoftwareCliente
        {
            get
            {
                StringBuilder b = new StringBuilder();
                foreach (string s in listaSoftware)
                {
                        b.AppendLine(s.ToString());
                }
                return b.ToString();
            }

            set
            {
                if (value is not null)
                {
                   
                    this.listaSoftware.Add(value);
                }
            }
        }


        public string JuegosCliente
        {
            get
            {
                StringBuilder b = new StringBuilder();
                foreach (string s in listaJuegos)
                {
                    b.AppendLine(s.ToString());
                }
                return b.ToString();
            }
            set
            {
                if (value is not null)
                {
                   
                    this.listaJuegos.Add(value);
                }
            }
        }

        public string PerifericosCliente
        {
            get
            {
                StringBuilder b = new StringBuilder();
                foreach (string s in listaPerifericos)
                {
                    
                        b.AppendLine(s.ToString());

                    
                }
                return b.ToString();
            }
            set
            {
                if (value is not null)
                {

                    
                    this.listaPerifericos.Add(value);
                }
            }
        }

       

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            
            if(SoftwareCliente == "")
            {
                sb.AppendLine($"Software Requerido: Sin Software Requerido.");
            }
            else
            {
                sb.AppendLine($"Software Requerido: {SoftwareCliente}");
            }
            if (JuegosCliente == "")
            {
                sb.AppendLine($"Juegos Requerido: Sin Juego Requerido.");
            }
            else
            {
                sb.AppendLine($"Juego Requerido: {JuegosCliente}");
            }
            if (PerifericosCliente == "")
            {
                sb.AppendLine($"Periferico Requerido: Sin Periferico Requerido.");
            }
            else
            {
                sb.AppendLine($"Periferico Requerido: {PerifericosCliente}");
            }

            return sb.ToString();
        }

        
    }
}
