using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_de_Clases
{
    public class Computadora
    {
        private List<string> hadware;
        private List<string> software;
        private List<string> perifericos;
        private List<string> juegos;
        private string identificador;

        private Computadora()
        {
            this.hadware = new List<string>();
            this.software = new List<string>();
            this.perifericos = new List<string>();
            this.juegos = new List<string>();
        }

        public Computadora (string identificador):this()
        {
            this.Identificador = identificador;
        }




        public string Identificador
        {
            get { return this.identificador; }
            set 
            { 
                if(value is not null)
                {
                    char[] array = value.ToCharArray();

                    for (int i = 0; i < array.Length; i++)
                    {
                        if(array[0] == 'C' && array[1] == '0' && (array[2] > '0' || array[2] < '9'))
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

        public string Hadware
        {
            get {
                StringBuilder b = new StringBuilder();
                foreach (string s in hadware)
                {
                    b.AppendLine(s.ToString());
                }
                return b.ToString();
            }

            set 
            { 
                if(value is not null )
                {
                    this.hadware.Add(value);
                }
            }
        }

        
        public string Software
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


        public string Juegos
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

        public string Perifericos
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
                if (value is not null && String.IsNullOrEmpty(value))
                {
                    this.perifericos.Add(value);
                }
            }
        }

        public string MostrarCompu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hadware: {Hadware}");
            sb.AppendLine($"Software: {Software}");
            sb.AppendLine($"Juegos: {Juegos}");
            sb.AppendLine($"Perifericos: {Perifericos}");
            sb.AppendLine($"Identificador: {Identificador}");
            return sb.ToString();
                }


        public string CargarHadware(string a, string b, string c)
        {
            if(a!="")
            {
                Hadware = a;
            }
            if (b != "")
            {
                Hadware = b;
            }
            if (c != "")
            {
                Hadware = c;
            }
            return Hadware;
        }
        public string CargarSoftware(string a, string b, string c)
        {
            if (a != "")
            {
                Software = a;
            }
            if (b != "")
            {
                Software = b;
            }
            if (c != "")
            {
                Software = c;
            }
            return Software;
        }
        public string CargarJuegos(string a, string b, string c)
        {
            if (a != "")
            {
                Juegos = a;
            }
            if (b != "")
            {
                Juegos = b;
            }
            if (c != "")
            {
                Juegos = c;
            }
            return Juegos;
        }
        public string CargarPerifericos(string a, string b, string c)
        {
            if (a != "")
            {
                Perifericos = a;
            }
            if (b != "")
            {
                Perifericos = b;
            }
            if (c != "")
            {
                Perifericos = c;
            }
            return Perifericos;
        }
    }
}
