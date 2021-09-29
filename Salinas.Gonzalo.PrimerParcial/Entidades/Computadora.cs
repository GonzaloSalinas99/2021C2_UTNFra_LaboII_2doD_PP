﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Computadora : Puesto
    {
        private List<string> hadware;
        private List<string> software;
        private List<string> perifericos;
        private List<string> juegos;
        private static int idSiguiente = 1;


        public Computadora():base()
        {
            this.hadware = new List<string>();
            this.software = new List<string>();
            this.perifericos = new List<string>();
            this.juegos = new List<string>();
            if(idSiguiente<11)
            {
                this.idPuesto = "C0" + idSiguiente;
            }
            idSiguiente++;
        }

        public override double CalcularCosto(Sesion conexion)
        {
            double retorno = 0;
            int division;
            if(conexion is Conexion && conexion.DuracionSesion > 0)
            {
                division = conexion.DuracionSesion / 30;
                if(conexion.DuracionSesion%30 !=0)
                {
                    division++;
                }
                retorno = division * 0.5;
            }
            return retorno;
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
                if (value is not null)
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