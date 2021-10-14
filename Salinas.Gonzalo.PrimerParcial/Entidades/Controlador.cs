using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Entidades
{
    public sealed class Controlador
    {
        private List<Sesion> listaSesiones;
        private List<Puesto> listaPuestos;
        private Queue <ClienteCabina>listaClienteCabinas;
        private Queue<ClienteComputadora> listaClientesComputadoras;
        private DateTime fecha;
        /// <summary>
        /// Propiedad ListaClienteComputadora de lectura y asignacion del atributo Lista Clientes Computadora
        /// </summary>
        public Queue<ClienteComputadora> ListaClienteComputadora
        {
            get { return this.listaClientesComputadoras; }
            set { listaClientesComputadoras = value; }
        }
        /// <summary>
        /// Propiedad ListaSesiones de lectura y asignacion del atributo Lista Sesiones
        /// </summary>
        public List<Sesion> ListaSesiones
        {
            get { return this.listaSesiones; }
            set { listaSesiones = value; }
        }
        /// <summary>
        /// Propiedad ListaPuestos de lectura y asignacion del atributo Lista Puestos
        /// </summary>
        public List<Puesto> ListaPuestos
        {
            get { return this.listaPuestos; }
            set { listaPuestos = value; }
        }
        /// <summary>
        /// Propiedad ListaClienteCabinas de lectura y asignacion del atributo Lista Clientes Cabinas
        /// </summary>
        public Queue<ClienteCabina> ListaClienteCabinas
        {
            get { return this.listaClienteCabinas; }
            set { listaClienteCabinas = value; }
        }
        /// <summary>
        /// Propiedad Fecha de lectura y asignacion del atributo Fecha
        /// </summary>
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        /// <summary>
        /// Constructor sin parametro que instancia todas las listas
        /// </summary>
        public Controlador()
        {
            listaSesiones = new List<Sesion>();
            listaPuestos = new List<Puesto>();
            listaClienteCabinas = new Queue<ClienteCabina>();
            listaClientesComputadoras = new Queue<ClienteComputadora>();
            fecha = default(DateTime);
        }
        /// <summary>
        /// Agrega un cliente de tipo Cabina a la lista de clientes
        /// </summary>
        /// <param name="cliente">Cliente a ser guardado</param>
        /// <returns>True si pudo agregar el cliente, False si no pudo</returns>
        public bool AgregarClienteCabina(ClienteCabina cliente)
        {
            if(cliente is ClienteCabina && cliente is not null && this != cliente)
            {
                listaClienteCabinas.Enqueue(cliente);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Agrega un cliente de tipo Computadora a la lista de clientes
        /// </summary>
        /// <param name="cliente">Cliente a ser guardado</param>
        /// <returns>True si pudo agregar el cliente, False si no pudo</returns>
        public bool AgregarClienteComputadora(ClienteComputadora cliente)
        {
            if (cliente is ClienteComputadora && cliente is not null && this != cliente)
            {
                listaClientesComputadoras.Enqueue(cliente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Agrega un puesto a la lista de Puestos
        /// </summary>
        /// <param name="cliente">Puesto a ser guardado</param>
        /// <returns>True si pudo agregar el puestos, False si no pudo</returns>
        public bool AgregarPuesto(Puesto puesto)
        {
            if (puesto is Puesto && puesto is not null)
            {
                listaPuestos.Add(puesto);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Corroba la cantidad de Puestos que hay en la lista Puesto
        /// </summary>
        /// <param name="puestoACorroborar">Tipo de puesto a corroborar la cantidad</param>
        /// <param name="numeroLimite">Cantidad limite de puestos que tienen que estar cargados</param>
        /// <returns>True si se puede agregar un puesto, False si no se puede</returns>
        public bool CorroborarCantidadPuestos(Puesto puestoACorroborar,int numeroLimite)
        {
            int contador = 0;
            foreach (Puesto puesto in listaPuestos)
            {
                if(puesto is not null && puesto.GetType() == puestoACorroborar.GetType())
                {
                    contador++;
                }
            }
            if(contador<numeroLimite)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Abre Sesion de llamada
        /// </summary>
        /// <param name="cliente">Cliente a ser vinculado con la llamada</param>
        /// <param name="cabina">Cabina a ser vinculada con la llamada</param>
        /// <returns>True si pudo abrir la sesion, False si no pudo</returns>
        public bool AbrirSesionLlamada(ClienteCabina cliente,Cabina cabina)
        {
            
            if (cliente is ClienteCabina && cabina is Cabina)
            {
                if(cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando 
                    && cabina.EstadoPuesto == Enumerados.EstadoPuesto.SinUso
                    && cabina.TipoTelefono == cliente.TipoTelefono)
                {
                    Llamada nuevaLlamada = new Llamada(cliente.NumeroTelefono, cliente, cabina);
                    this.listaSesiones.Add(nuevaLlamada);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Cierra la sesion de llamada
        /// </summary>
        /// <param name="sesion">Sesion a ser cerrada</param>
        /// <returns>Si puedo cerrar la sesion, retorna los datos, sino un mensaje que no encontro la sesion</returns>
        public string CerrarSesionTelefono(Sesion sesion)
        {
            if (sesion.Puesto.EstadoPuesto == Enumerados.EstadoPuesto.EnUso
                && sesion.Cliente.EstadoCliente == Enumerados.EstadoCliente.Asignado)
            {
                sesion.Puesto.EstadoPuesto = Enumerados.EstadoPuesto.SinUso;
                sesion.Cliente.EstadoCliente = Enumerados.EstadoCliente.Atendido;
                sesion.TiempoFinal = DateTime.Now;
                sesion.CostoSesion = sesion.Puesto.CalcularCosto(sesion);
                sesion.Puesto.UsoMinutos = sesion.DuracionSesion;
                foreach (Sesion item in this.listaSesiones)
                {
                    if (sesion == item)
                    {
                        Historial.Sesiones.Add(sesion);
                        this.listaSesiones.Remove(sesion);
                        return sesion.ToString();
                    }
                }
            }
            return "NO LO ENCONTRE";
        }
        /// <summary>
        /// Compara que un cliente tenga las mismas especificaciones que la computadora
        /// </summary>
        /// <param name="cliente">Cliente a ser comparado</param>
        /// <param name="computadora">Computadora a ser comparada</param>
        /// <returns>True si el cliente tiene las mismas especificaciones que la computadora, False si son diferentes</returns>
        private bool CompararClienteConComputadora(ClienteComputadora cliente, Computadora computadora)
        {
            if (cliente is ClienteComputadora && computadora is Computadora)
            {
                if(cliente.SoftwareCliente == computadora.Software  &&
                    cliente.PerifericosCliente == computadora.Perifericos && cliente.JuegosCliente == computadora.Juegos)
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// Abre la sesion Conexion entre cliente y computadora
        /// </summary>
        /// <param name="cliente">Cliente a ser vinculado en la conexion</param>
        /// <param name="computadora">Computadora a ser vinculada en la conexion</param>
        /// <returns>True si pudo abrir la sesion, False si no pudo</returns>
        public bool AbrirSesionConexion(ClienteComputadora cliente, Computadora computadora)
        {

            if (cliente is ClienteComputadora && computadora is Computadora)
            {
                if (cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando
                    && computadora.EstadoPuesto == Enumerados.EstadoPuesto.SinUso && CompararClienteConComputadora(cliente, computadora))
                {
                    Conexion nuevaConexion = new Conexion(computadora, cliente);
                    ListaSesiones.Add(nuevaConexion);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Cierra la sesion de conexion
        /// </summary>
        /// <param name="sesion">Sesion a ser cerrada</param>
        /// <returns>Si pudo cerrar la sesion, retorna los datos, sino un mensaje que no encontro la sesion</returns>
        public string CerrarSesionConexion(Sesion sesion)
        {
            if (sesion.Puesto.EstadoPuesto == Enumerados.EstadoPuesto.EnUso
                && sesion.Cliente.EstadoCliente == Enumerados.EstadoCliente.Asignado)
            {
                sesion.Puesto.EstadoPuesto = Enumerados.EstadoPuesto.SinUso;
                sesion.Cliente.EstadoCliente = Enumerados.EstadoCliente.Atendido;
                sesion.TiempoFinal = DateTime.Now;
                sesion.CostoSesion = sesion.Puesto.CalcularCosto(sesion);
                sesion.Puesto.UsoMinutos = sesion.DuracionSesion;
                foreach (Sesion sesionLista in ListaSesiones)
                {
                    if (sesion == sesionLista)
                    {
                        Historial.Sesiones.Add(sesion);
                        this.listaSesiones.Remove(sesion);
                        return sesion.ToString();
                    }
                }
            }
            return "NO LO ENCONTRE";
        }
        /// <summary>
        /// Filtra una lista de puestos dependiendo el tipo de puesto pasado por parametro
        /// </summary>
        /// <param name="puesto">Nombre del tipo de puesto a filtrar</param>
        /// <returns>Retorna la lista filtrada por el tipo del puesto</returns>
        public List<Puesto> FiltroLista(string puesto)
        {
            List<Puesto> retorno = new List<Puesto>();

            if (puesto.Equals("Cabina"))
            {
                foreach (Puesto item in ListaPuestos)
                {
                    if(item is Cabina)
                    {
                        Cabina auxiliar = (Cabina)item;
                        retorno.Add(auxiliar);
                    }
                }
            }

            if (puesto.Equals("Computadora"))
            {
                foreach (Puesto item in ListaPuestos)
                {
                    if (item is Computadora)
                    {
                        Computadora auxiliar = (Computadora)item;
                        retorno.Add(auxiliar);
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Busca a travez del identificador un Puesto en la ListaPuestos 
        /// </summary>
        /// <param name="identificador">Identificador del puesto a buscar</param>
        /// <param name="tipoPuesto">Nombre del tipo del puesto a buscar</param>
        /// <returns>Retorna el puesto buscado por identificador</returns>
        public Puesto BuscarPuestoPorIdentificador( string identificador,string tipoPuesto)
        {
            if(tipoPuesto == "Cabina")
            {
                foreach (Puesto puesto in ListaPuestos)
                {
                    if (puesto is Cabina && puesto is not null)
                    {
                        if (puesto.IdPuesto == identificador && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                        {
                            return puesto;
                        }
                    }
                }
            }
            else
            {
                foreach (Puesto puesto in ListaPuestos)
                {
                    if (puesto is Computadora && puesto is not null)
                    {
                        if (puesto.IdPuesto == identificador && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                        {
                            return puesto;
                        }
                    }
                }
            }
           
            return null;
        }

        /// <summary>
        /// Busca un cliente por el numero de documento y el tipo del cliente
        /// </summary>
        /// <param name="documento">Documento a buscar en las listas</param>
        /// <param name="tipoCliente">Tipo de cliente a buscar</param>
        /// <returns>Retorna el cliente buscado a travez del documento</returns>
        public Cliente BuscarClienteDocumento(string documento,string tipoCliente)
        {
            if (ListaClienteComputadora.Count != 0 && tipoCliente == "Computadora")
            {
                ClienteComputadora aux = ListaClienteComputadora.Peek();
                foreach (ClienteComputadora cliente in ListaClienteComputadora)
                {
                    if (cliente is ClienteComputadora && cliente is not null && cliente == aux)
                    {
                        if (cliente.Dni == documento && cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                        {
                            return cliente;
                        }
                    }
                }
            }
            else
            {
                if(ListaClienteCabinas.Count != 0 && tipoCliente == "Cabina")
                {
                    ClienteCabina aux = ListaClienteCabinas.Peek();
                    foreach (ClienteCabina cliente in ListaClienteCabinas)
                    {
                        if (cliente is Cliente && cliente is not null && cliente == aux)
                        {
                            if (cliente.Dni == documento && cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                            {
                                return cliente;
                            }
                        }
                    }
                }
            }

            return null;
        }

        public static bool operator == (Controlador control, Cliente cliente)
        {
            if(control is not null && cliente.Equals(cliente))
            {
                if(cliente is ClienteCabina)
                {
                    foreach (Cliente c1 in control.ListaClienteCabinas)
                    {
                        if (c1 == cliente)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    if(cliente is ClienteComputadora)
                    {
                        foreach (Cliente c1 in control.ListaClienteComputadora)
                        {
                            if(c1 == cliente)
                            {
                                return true;
                            }
                        }
                    }
                }
                
            }
            return false;
        }

        public static bool operator !=(Controlador control, Cliente cliente)
        {
            return !(control == cliente);
        }

    }
}
