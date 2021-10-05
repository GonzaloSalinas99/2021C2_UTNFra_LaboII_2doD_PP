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


        private int contAgeOfEmpires;
        private int contCounterStrike;
        private int contMu;
        private int contMessenger;
        private int contAres;
        private int contMiEncarta;
        private int contCamara;
        private int contMicrofono;
        private int contAuriculares;


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
                    if(value == "Messenger")
                    {
                        contMessenger++;
                    }
                    else
                    {
                        if (value == "Ares")
                        {
                            contAres++;
                        }
                        else
                        {
                            contMiEncarta++;
                        }
                    }
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
                    if (value == "Age of Empires")
                    {
                        contAgeOfEmpires++;
                    }
                    else
                    {
                        if (value == "Counter Strike")
                        {
                            contCounterStrike++;
                        }
                        else
                        {
                            contMu++;
                        }
                    }
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

                    if (value == "Camara")
                    {
                        contCamara++;
                    }
                    else
                    {
                        if (value == "Microfono")
                        {
                            contMicrofono++;
                        }
                        else
                        {
                            contAuriculares++;
                        }
                    }
                    this.perifericos.Add(value);
                }
            }
        }

        public int ContadorAgeOfEmpires
        {
            get { return this.contAgeOfEmpires; }
        }
        public int ContadorCounterStrike
        {
            get { return this.contCounterStrike; }
        }
        public int ContadorMuOnline
        {
            get { return this.ContadorMuOnline; }
        }
        public int ContadorMessenger
        {
            get { return this.contMessenger; }
        }
        public int ContadorAres
        {
            get { return this.contAres; }
        }
        public int ContadorMiEncarta
        {
            get { return this.contMiEncarta; }
        }
        public int ContadorCamara
        {
            get { return this.contCamara; }
        }
        public int ContadorAuriculares
        {
            get { return this.contAuriculares; }
        }
        public int ContadorMicrofono
        {
            get { return this.contMicrofono; }
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
