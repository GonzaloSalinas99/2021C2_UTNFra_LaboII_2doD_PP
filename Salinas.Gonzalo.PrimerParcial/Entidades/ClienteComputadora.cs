using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteComputadora : Cliente
    {
        private List<string> software;
        private List<string> perifericos;
        private List<string> juegos;

        public ClienteComputadora(string nombre, string apellido, string dni, string edad)
                                :base(nombre, apellido, dni, edad)
        {
            this.software = new List<string>();
            this.perifericos = new List<string>();
            this.juegos = new List<string>();
        }


        


        public string SoftwareCliente
        {
            get
            {
                StringBuilder b = new StringBuilder();
                foreach (string s in software)
                {
                    
                        b.AppendLine(s.ToString());

                    
                }
                return b.ToString();
            }

            set
            {
                if (value is not null)
                {
                    this.software.Add(value);
                }
            }
        }


        public string JuegosCliente
        {
            get
            {
                StringBuilder b = new StringBuilder();
                foreach (string s in juegos)
                {
                        b.AppendLine(s.ToString());
                }
                return b.ToString();
            }

            set
            {
                if (value is not null)
                {
                    this.juegos.Add(value);
                }
            }
        }

        public string PerifericosCliente
        {
            get
            {
                StringBuilder b = new StringBuilder();
                foreach (string s in perifericos)
                {
                    
                        b.AppendLine(s.ToString());

                    
                }
                return b.ToString();
            }
            set
            {
                if (value is not null)
                {
                    this.perifericos.Add(value);
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
