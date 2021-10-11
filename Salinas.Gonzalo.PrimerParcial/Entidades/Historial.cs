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
        /// <summary>
        /// Propiedad Sesiones de lectura y asignacion del atributo listaSesiones
        /// </summary>
        public static List<Sesion> Sesiones
        { get => listaSesiones;
            set => listaSesiones = value; 
        }

        /// <summary>
        /// Compara las sesiones finalizadas por la duracion de forma descendente
        /// </summary>
        /// <param name="puesto1">Puesto a comparar la duracion de la sesion</param>
        /// <param name="puesto2">Puesto a comparar la duracion de la sesion</param>
        /// <returns>-1 si el puesto1 tiene menos minutos de duracion que el puesto2
        ///          0 si los dos puestos tienen la misma duracion
        ///          +1 si el puesto1 tiene mas minutos de duracion que el puesto2 </returns>
        private static int CompararPuestoPorDuracionDeSesion(Puesto puesto1, Puesto puesto2)
        {
            return puesto2.UsoMinutos.CompareTo(puesto1.UsoMinutos);
        }
        /// <summary>
        /// Filtra una lista de puestos segun el tipo de puesto requerido
        /// </summary>
        /// <param name="puesto">Tipo del puesto a filtrar</param>
        /// <returns>Retorna la lista filtrada a travez del tipo del puesto</returns>

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
        /// <summary>
        /// Ordena la lista de puestos segun su duracion 
        /// </summary>
        /// <param name="tipoDePuesto">Tipo de puesto a ordenar</param>
        /// <returns>Retorna la lista ordenada de forma descendente</returns>
        public static List<Puesto> OrdenarLista(string tipoDePuesto)
        {
            List<Puesto> retorno = new List<Puesto>();

            if (tipoDePuesto.Equals("Entidades.Cabina") || tipoDePuesto.Equals("Entidades.Computadora"))
            {
                retorno = FiltroLista(tipoDePuesto);

                if (retorno.Count > 0)
                {
                    retorno.Sort(CompararPuestoPorDuracionDeSesion);
                }
            }

            return retorno;
        }
        /// <summary>
        /// Calcula la ganancia total de las llamadas Locales
        /// </summary>
        /// <returns>Ganancia total de llamadas locales</returns>
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
        /// <summary>
        /// Calcula la ganancia total de las llamadas Larga Distancia
        /// </summary>
        /// <returns>Ganancia total de llamadas Larga distancia</returns>
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
        /// <summary>
        /// Calcula la ganancia total de las llamadas Internacionales
        /// </summary>
        /// <returns>Ganancia total de llamadas internacionales</returns>
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
        /// <summary>
        /// Calcula la ganancia total de las conexiones
        /// </summary>
        /// <returns>Ganancia total de conexiones</returns>
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
        /// <summary>
        /// Calcula las horas totales de todas las sesiones
        /// </summary>
        /// <returns>Horas totales de las sesiones</returns>
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
        /// <summary>
        /// Escribe las ganancias totales de las llamadas y conexiones
        /// </summary>
        /// <returns>Ganancia total de todas las sesiones</returns>
        public static string GananciaTotalClasificadasPorServicio()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ganancias del ciber.");
            sb.AppendLine($"Ganancia de Llamadas{GananciaLlamadaLocal() + GananciaLlamadaLargaDistancia() + GananciaLlamadaInternacional()}");
            sb.AppendLine($"Ganancia de Conexiones{GananciaConexion()}");
            sb.AppendLine($"Ganancia Total: {GananciaLlamadaLocal() + GananciaLlamadaLargaDistancia() + GananciaLlamadaInternacional() + GananciaConexion()}");
            return sb.ToString();
        }
        /// <summary>
        /// Escribe las ganancias de todas las llamadas y las horas totales
        /// </summary>
        /// <returns>Retorna las ganancias de las llamadas y las horas totales que estuvieron en uso las sesiones</returns>
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
        /// <summary>
        /// Escribe las especificaciones de las computadoras mas pedidas por los clientes 
        /// </summary>
        /// <returns>Retorna los datos de las especificaciones de computadoras mas pedidas</returns>
        public static string LoMasPedidoPorClientesComputadora()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lo mas solicitado por los clientes.");
            sb.AppendLine(SoftwareMasPedido());
            sb.AppendLine(PerifericoMasPedido());
            sb.AppendLine(JuegoMasPedido());

            return sb.ToString();
        }
        /// <summary>
        /// Calcula el software mas pedido
        /// </summary>
        /// <returns>Retorna el software mas pedido, si no hay ningun retorna un mensaje que no se eligieron software</returns>
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
            if(contMessenger == 0 && contAres == 0 && contMiEncarta==0)
            {
                return "No se selecciono ningun software";
            }
            else
            {
                if (contMessenger > contAres && contMessenger > contMiEncarta)
                {
                    return $"El software mas solicitado es Messenger con {contMessenger} veces pedido";
                }
                else
                {
                    if (contAres > contMiEncarta)
                    {
                        return $"El software mas solicitado es Ares con {contAres} veces pedido";
                    }
                    else
                    {
                        return $"El software mas solicitado es Mi Encarta con {contMiEncarta} veces pedido";

                    }
                }
            }
            
        }
        /// <summary>
        /// Calcula el Juego mas pedido
        /// </summary>
        /// <returns>Retorna el juego mas pedido, si no hay ningun retorna un mensaje que no se eligieron juegos</returns>

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
            if(contAgeOfEmpires == 0 && contCounterStrike == 0 && contMu == 0)
            {
                return "No se selecciono ningun juego";
            }
            else
            {
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
            
        }
        /// <summary>
        /// Calcula el periferico mas pedido
        /// </summary>
        /// <returns>Retorna el periferico mas pedido, si no hay ningun retorna un mensaje que no se eligieron perifericos</returns>

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
            if (contAuriculares == 0 && contCamara == 0 && contMicrofono == 0)
            {
                return "No se selecciono ningun periferico";
            }
            else
            {
                if (contAuriculares > contCamara && contAuriculares > contMicrofono)
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
}
