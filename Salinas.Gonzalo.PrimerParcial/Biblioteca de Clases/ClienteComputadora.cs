using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class ClienteComputadora : Cliente
    {
        private List<string> hadware;
        private List<string> software;
        private List<string> perifericos;
        private List<string> juegos;

        public ClienteComputadora(string nombre, string apellido, string dni, string edad)
                                :base(nombre, apellido, dni, edad)
        {
            this.hadware = new List<string>();
            this.software = new List<string>();
            this.perifericos = new List<string>();
            this.juegos = new List<string>();
        }


        public string HadwareCliente
        {
            get
            {
                StringBuilder b = new StringBuilder();
                foreach (string s in hadware)
                {
                    b.AppendLine(s.ToString());
                }
                return b.ToString();
            }

            set
            {
                if (value is not null)
                {
                    this.hadware.Add(value);
                }
            }
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

    }
}
