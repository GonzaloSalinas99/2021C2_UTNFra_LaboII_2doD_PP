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


        public static List<Puesto> FiltroLista(string puesto)
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

        private static double GananciaLlamadaLocal()
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
        private static double GananciaLlamadaLargaDistancia()
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
        private static double GananciaLlamadaInternacional()
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

        private static double GananciaConexion()
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

        private static double HorasTotales()
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
            double horasTotales = HorasTotales();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ganancia de Llamadas Locales{GananciaLlamadaLocal()}");
            sb.AppendLine($"Ganancia de Llamadas Larga Distancia{GananciaLlamadaLargaDistancia()}");
            sb.AppendLine($"Ganancia de Llamadas Internacionales{GananciaLlamadaInternacional()}");
            sb.AppendLine($"Horas Totales: {horasTotales/60}");
            return sb.ToString();
        }

        public static string LoMasPedidoPorClientesComputadora()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lo mas solicitado por los clientes.");
            sb.AppendLine(SoftwareMasPedido());
            sb.AppendLine(PerifericoMasPedido());
            sb.AppendLine(JuegoMasPedido());

            return sb.ToString();
        }

        private static string SoftwareMasPedido()
        {
         int contMessenger = 0;
         int contAres = 0;
         int contMiEncarta = 0;
            foreach (Sesion sesion in listaSesiones)
            {
                if (sesion is Conexion)
                {
                    Conexion aux = (Conexion)sesion;
                    if (aux.Cliente is ClienteComputadora)
                    {
                        ClienteComputadora clienteAux = (ClienteComputadora)aux.Cliente;

                        if (clienteAux is not null)
                        {
                            foreach (string item in clienteAux.ListaSoftware)
                            {
                                if(item == "Messenger")
                                {
                                    contMessenger++;
                                }
                                else
                                {
                                    if(item == "Ares")
                                    {
                                        contAres++;
                                    }
                                    else
                                    {
                                        contMiEncarta++;
                                    }
                                }
                            }
                        }


                    }
                }
            }
            if(contMessenger>contAres && contMessenger>contMiEncarta)
            {
                return $"El software mas solicitado es Messenger con {contMessenger} veces pedido";
            }
            else
            {
                if (contAres> contMiEncarta)
                {
                    return $"El software mas solicitado es Ares con {contAres} veces pedido";
                }
                else
                {
                    return $"El software mas solicitado es Mi Encarta con {contMiEncarta} veces pedido";

                }
            }
        }
        private static string JuegoMasPedido()
        {
            int contAgeOfEmpires = 0;
            int contCounterStrike = 0;
            int contMu = 0;

            foreach (Sesion sesion in listaSesiones)
            {
                if (sesion is Conexion)
                {
                    Conexion aux = (Conexion)sesion;
                    if (aux.Cliente is ClienteComputadora)
                    {
                        ClienteComputadora clienteAux = (ClienteComputadora)aux.Cliente;

                        if (clienteAux is not null)
                        {
                            foreach (string item in clienteAux.ListaJuegos)
                            {
                                if (item == "Age of Empires")
                                {
                                    contAgeOfEmpires++;
                                }
                                else
                                {
                                    if (item == "Counter Strike")
                                    {
                                        contCounterStrike++;
                                    }
                                    else
                                    {
                                        contMu++;
                                    }
                                }
                            }
                        }


                    }
                }
            }
            if (contAgeOfEmpires > contCounterStrike && contAgeOfEmpires > contMu)
            {
                return $"El juego mas solicitado es Age of Empires con {contAgeOfEmpires} veces pedido";
            }
            else
            {
                if (contCounterStrike > contMu)
                {
                    return $"El juego mas solicitado es Counter Strike con {contCounterStrike} veces pedido";
                }
                else
                {
                    return $"El juego mas solicitado es MU Online con {contMu} veces pedido";

                }
            }
        }

        private static string PerifericoMasPedido()
        {

            int contCamara = 0;
            int contMicrofono = 0;
            int contAuriculares = 0;

            foreach (Sesion sesion in listaSesiones)
            {
                if (sesion is Conexion)
                {
                    Conexion aux = (Conexion)sesion;
                    if (aux.Cliente is ClienteComputadora)
                    {
                        ClienteComputadora clienteAux = (ClienteComputadora)aux.Cliente;

                        if (clienteAux is not null)
                        {
                            foreach (string item in clienteAux.ListaPerifericos)
                            {
                                if (item == "Camara")
                                {
                                    contCamara++;
                                }
                                else
                                {
                                    if (item == "Auriculares")
                                    {
                                        contAuriculares++;
                                    }
                                    else
                                    {
                                        contMicrofono++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (contAuriculares > contCamara && contAuriculares> contMicrofono)
            {
                return $"El periferico mas solicitado es Auriculares con {contAuriculares} veces pedido";
            }
            else
            {
                if (contCamara > contMicrofono)
                {
                    return $"El periferico mas solicitado es Camara con {contCamara} veces pedido";
                }
                else
                {
                    return $"El periferico mas solicitado es Microfono con {contMicrofono} veces pedido";

                }
            }
        }







    }
}
