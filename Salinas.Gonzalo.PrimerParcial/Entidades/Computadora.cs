using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Computadora : Puesto
    {

        private List<string> listaSoftware;
        private List<string> listaPerifericos;
        private List<string> listaJuegos;
        private static int idSiguiente = 1;


        public Computadora() : base()
        {

            this.listaSoftware = new List<string>();
            this.listaPerifericos = new List<string>();
            this.listaJuegos = new List<string>();
            if (idSiguiente < 11)
            {
                this.idPuesto = "C0" + idSiguiente;
            }
            idSiguiente++;
        }

        public override double CalcularCosto(Sesion conexion)
        {
            double retorno = 0;
            int division;
            if (conexion is Conexion && conexion.DuracionSesion > 0)
            {
                division = conexion.DuracionSesion / 30;
                if (conexion.DuracionSesion % 30 != 0)
                {
                    division++;
                }
                retorno = division * 0.5;
            }
            return retorno;
        }



        public string Software
        {
            get
            {
                StringBuilder b = new StringBuilder();
                if(listaSoftware.Count == 0)
                {
                    b.AppendLine("No hay software cargados");
                }
                else
                {
                    foreach (string s in listaSoftware)
                    {
                        b.AppendLine(s.ToString());
                    }
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


        public string Juegos
        {
            get
            {
                StringBuilder b = new StringBuilder();
                if (listaJuegos.Count == 0)
                {
                    b.AppendLine("No hay juegos cargados");
                }
                else
                {
                    foreach (string s in listaJuegos)
                    {
                        b.AppendLine(s.ToString());
                    }
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

        public string Perifericos
        {
            get
            {
                StringBuilder b = new StringBuilder();
                if (listaPerifericos.Count == 0)
                {
                    b.AppendLine("No hay perifericos cargados");
                }
                else
                {
                    foreach (string s in listaPerifericos)
                    {
                        b.AppendLine(s.ToString());
                    }
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
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Software: {Software}  ");
            sb.AppendLine($"Juegos: {Juegos}  ");
            sb.AppendLine($"Perifericos: {Perifericos} ");

            return sb.ToString();
        }

    }

}
