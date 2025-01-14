﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Computadora : Puesto
    {

        private List<string> listaSoftware;
        private List<string> listaPerifericos;
        private List<string> listaJuegos;
        private List<string> listaHadware;
        private static int idSiguiente = 1;

        /// <summary>
        /// Constructor de Computadora, instancia las listas y asigna un ID autoincrementable
        /// </summary>
        public Computadora() : base()
        {
            this.listaHadware = new List<string>();
            this.listaSoftware = new List<string>();
            this.listaPerifericos = new List<string>();
            this.listaJuegos = new List<string>();
            this.idPuesto = "C0" + idSiguiente;
            idSiguiente++;
        }
        
        public Computadora(List<string> listaHadware, List<string> listaSoftware, List<string> listaJuegos, List<string> listaPerifericos):this()
        {
            this.listaHadware = listaHadware;
            this.listaSoftware = listaSoftware;
            this.listaJuegos = listaJuegos;
            this.listaPerifericos = listaPerifericos;
        }

        /// <summary>
        /// Calcula el costo de la Sesion segun el tiempo de duracion
        /// </summary>
        /// <param name="conexion">Conexion a calcular el costo </param>
        /// <returns>Retorna el costo total de la sesion</returns>
        public override double CalcularCosto(Sesion conexion)
        {
            double retorno = 0;

            int division;
            if (conexion is Conexion && conexion.CalcularDuracionSesion() > 0)
            {
                division = conexion.CalcularDuracionSesion() / 30;
                if (conexion.CalcularDuracionSesion() % 30 != 0)
                {
                    division++;
                }
                retorno = division * 0.5;
            }

            return retorno ;
        }
        /// <summary>
        /// Calcula el costo final mas IVA
        /// </summary>
        /// <param name="conexion">Sesion a calcular el costo final</param>
        /// <returns>Retorna el costo total a pagar con IVA incluido</returns>
        public override double CalcularCostoFinalMasIva(Sesion conexion)
        {
            double costoTotal = CalcularCosto(conexion);
            double costoFinal = costoTotal * IVA;
            return costoFinal + costoTotal;
        }
        /// <summary>
        /// Propiedad Hadware de lectura y asignacion del atributo Lista Hadware
        /// </summary>
        public string Hadware
        {
            get
            {
                StringBuilder b = new StringBuilder();
                if (listaHadware.Count == 0)
                {
                    b.AppendLine("No hay hadware cargados");
                }
                else
                {
                    foreach (string s in listaHadware)
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
                    this.listaHadware.Add(value);
                }
            }
        }

        /// <summary>
        /// Propiedad Software de lectura y asignacion del atributo Lista Sofware
        /// </summary>
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


        /// <summary>
        /// Propiedad Juegos de lectura y asignacion del atributo Lista Juegos
        /// </summary>
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

        /// <summary>
        /// Propiedad Perifericos de lectura y asignacion del atributo Lista Perifericos
        /// </summary>
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
        /// <summary>
        /// Escribe los datos del puesto y las especificaciones de la computadora
        /// </summary>
        /// <returns>Retorna los datos escritos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Hadware: {Hadware}  ");
            sb.AppendLine($"Software: {Software}  ");
            sb.AppendLine($"Juegos: {Juegos}  ");
            sb.AppendLine($"Perifericos: {Perifericos} ");
            sb.AppendLine("-----------------------------");
            return sb.ToString();
        }

    }

}
