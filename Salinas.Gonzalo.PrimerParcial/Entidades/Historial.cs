using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Historial
    {
        private static List<Sesion> listaSesiones;

        public static List<Sesion> Sesiones
        { get => listaSesiones;
            set => listaSesiones = value; }

        static Historial()
        {
            Sesiones = new List<Sesion>();
        }

        public static string MostrarHistorial()
        {
            foreach (Sesion sesion in listaSesiones)
            {
                return sesion.ToString();
            }
            return "NO ENCONTRE SESIONES";
        }

        private static int OrdenarPorDuracion(Puesto puesto1, Puesto puesto2)
        {
            return puesto2.UsoMinutos.CompareTo(puesto1.UsoMinutos);
        }


        private static List<Puesto> FiltroLista(string puesto)
        {
            List<Puesto> retorno = new List<Puesto>();

            if (puesto.Equals("Entidades.Cabina") || puesto.Equals("Entidades.Computadora"))
            {
                foreach (Sesion item in Historial.Sesiones)
                {
                    if (item.Puesto.GetType().ToString().Equals(puesto))
                    {
                        retorno.Add(item.Puesto);
                    }

                }
            }

            return retorno;
        }

        public static List<Puesto> OrdenarLista(string tipoDePuesto)
        {
            List<Puesto> retorno = new List<Puesto>();

            if (tipoDePuesto.Equals("Entidades.Cabina") || tipoDePuesto.Equals("Entidades.Computadora"))
            {
                retorno = FiltroLista(tipoDePuesto);

                if (retorno.Count > 0)
                {
                    retorno.Sort(OrdenarPorDuracion);
                }
            }

            return retorno;
        }

        public static double GananciaLlamadaLocal()
        {
            double retorno = 0;
            Llamada aux;
            foreach (Sesion sesion in listaSesiones)
            {
                
                if(sesion is Llamada)
                {
                    aux = (Llamada)sesion;
                    if(aux.TipoLlamada == Enumerados.TipoLlamada.Local)
                    {
                        retorno += sesion.CostoSesion;
                    }
                }
            }
            return retorno;
        }
        public static double GananciaLlamadaLargaDistancia()
        {
            double retorno = 0;
            Llamada aux;
            foreach (Sesion sesion in listaSesiones)
            {

                if (sesion is Llamada)
                {
                    aux = (Llamada)sesion;
                    if (aux.TipoLlamada == Enumerados.TipoLlamada.LargaDistancia)
                    {
                        retorno += sesion.CostoSesion;
                    }
                }
            }
            return retorno;
        }
        public static double GananciaLlamadaInternacional()
        {
            double retorno = 0;
            Llamada aux;
            foreach (Sesion sesion in listaSesiones)
            {

                if (sesion is Llamada)
                {
                    aux = (Llamada)sesion;
                    if (aux.TipoLlamada == Enumerados.TipoLlamada.Internacional)
                    {
                        retorno += sesion.CostoSesion;
                    }
                }
            }
            return retorno;
        }

        public static double GananciaConexion()
        {
            double retorno = 0;
            foreach (Sesion sesion in listaSesiones)
            {
                if (sesion is Conexion)
                {      
                        retorno += sesion.CostoSesion;
                }
            }
            return retorno;
        }

        public static double HorasTotales()
        {
            int duracionTotal = 0;
            foreach (Sesion sesion in listaSesiones)
            {
                if(sesion is not null)
                {
                    duracionTotal += sesion.DuracionSesion;
                }
            }
            return duracionTotal;
        }

        public static string GananciaTotalClasificadasPorServicio()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ganancias del ciber.");
            sb.AppendLine($"Ganancia de Llamadas{GananciaLlamadaLocal() + GananciaLlamadaLargaDistancia() + GananciaLlamadaInternacional()}");
            sb.AppendLine($"Ganancia de Conexiones{GananciaConexion()}");
            sb.AppendLine($"Ganancia Total: {GananciaLlamadaLocal() + GananciaLlamadaLargaDistancia() + GananciaLlamadaInternacional() + GananciaConexion()}");
            return sb.ToString();
        }

        public static string RecaudacionPorTipoDeLlamadaYHorasTotales()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ganancia de Llamadas Locales{GananciaLlamadaLocal()}");
            sb.AppendLine($"Ganancia de Llamadas Larga Distancia{GananciaLlamadaLargaDistancia()}");
            sb.AppendLine($"Ganancia de Llamadas Internacionales{GananciaLlamadaInternacional()}");
            sb.AppendLine($"Horas Totales: {HorasTotales()}");
            return sb.ToString();
        }

        public static string LoMasPedidoPorClientesComputadora()
        {
            foreach (Sesion sesion in listaSesiones)
            {
                if(sesion is Conexion)
                {
                    Conexion aux = (Conexion)sesion;
                    if(aux.Cliente is ClienteComputadora)
                    {
                        ClienteComputadora clienteAux = (ClienteComputadora)aux.Cliente;
                        
                        if(clienteAux.)
                    
                    }
                }
            }

        }

        public static string SoftwareMasPedido()
        {
            foreach (Sesion sesion in listaSesiones)
            {
                if (sesion is Conexion)
                {
                    Conexion aux = (Conexion)sesion;
                    if (aux.Cliente is ClienteComputadora)
                    {
                        ClienteComputadora clienteAux = (ClienteComputadora)aux.Cliente;

                        if (clienteAux.SoftwareCliente == "Mi Encarta")
                        {
                            foreach (string item in clienteAux.SoftwareCliente)
                            {

                            }
                        }


                    }
                }
            }
        }







    }
}
