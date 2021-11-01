using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Entidades
{
    /// <summary>
    /// Clase sellada Controlador, maneja las acciones que se van a realizar en los distintos formularios. 
    /// Esta clase es la unica que no tiene sobrescrito el metodo Equals ni el GetHashCode, ya que no tiene ningun dato ni identificador como para devolver en el GetHashCode.
    /// El Equals no se sobrescribe ya que esta clase es unica y no se va a tener que comparar con otra de su mismo tipo, ya que su unica funcion es controlar la interfaz de usuario e ir 
    /// administrando las acciones que solicita el usuario.
    /// </summary>
    public sealed class Controlador
    {

        private List<Sesion> listaSesiones;
        private List<Puesto> listaPuestos;
        private Queue <ClienteCabina>listaClienteCabinas;
        private Queue<ClienteComputadora> listaClientesComputadoras;
        private DateTime fecha;

        /// <summary>
        /// Indexador de tipo Sesion de solo lectura.
        /// </summary>
        /// <param name="i">Posicion a retonar la informacion</param>
        /// <returns>Retorna la informacion de la sesion segun la posicion pedida</returns>
        public Sesion this [int i]
        {
            get { return listaSesiones[i]; }
        }


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
        /// Agrega un cliente de tipo Cabina a la lista de clientesCabinas
        /// </summary>
        /// <param name="cliente">Cliente a ser guardado</param>
        /// <returns>True si pudo agregar el cliente, False si no pudo</returns>
        public bool AgregarClienteCabina(ClienteCabina cliente)
        {
            if(cliente is ClienteCabina && cliente is not null && this != cliente)
            {
                if(this != cliente)
                {
                    listaClienteCabinas.Enqueue(cliente);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Agrega un cliente de tipo Computadora a la lista de clientesComputadoras
        /// </summary>
        /// <param name="cliente">Cliente a ser guardado</param>
        /// <returns>True si pudo agregar el cliente, False si no pudo</returns>
        public bool AgregarClienteComputadora(ClienteComputadora cliente)
        {
            if (cliente is ClienteComputadora && cliente is not null && this != cliente)
            {
                if(this != cliente)
                {
                    listaClientesComputadoras.Enqueue(cliente);
                    return true;
                }
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
            if(puestoACorroborar != null)
            {
                foreach (Puesto puesto in listaPuestos)
                {
                    if (puesto is not null && puesto.GetType() == puestoACorroborar.GetType())
                    {
                        contador++;
                    }
                }
                if (contador < numeroLimite)

                {
                    return true;
                }
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
                    && cabina.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                    
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
                sesion.Puesto.UsoMinutos = sesion.CalcularDuracionSesion();
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
        public bool CompararClienteConComputadora(ClienteComputadora cliente, Computadora computadora)
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
        /// Sobrecarga del metodo AbrirSesionConexion, recibe un argumento para asignarle el tiempo a la sesion.
        /// </summary>
        /// <param name="cliente">Cliente a ser vinculado con la conexion</param>
        /// <param name="computadora">Computadora a ser vinculada con la conexion</param>
        /// <param name="tiempoUso">Tiempo de uso a ser asignado</param>
        /// <returns>Retorna la conexion realizada en caso de exito, sino null.</returns>
        public Sesion AbrirSesionConexion(ClienteComputadora cliente, Computadora computadora, string tiempoUso)
        {
            Conexion nuevaConexion = null;
            if (cliente is ClienteComputadora && computadora is Computadora && (ValidadorDeInformacion.ValidarStringTexto(tiempoUso) && ValidadorDeInformacion.ValidarNumero(tiempoUso)))
            {
                if (cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando
                    && computadora.EstadoPuesto == Enumerados.EstadoPuesto.SinUso && CompararClienteConComputadora(cliente, computadora))
                {
                     nuevaConexion= new Conexion(computadora, cliente);
                    
                    DateTime horaFinalSesion = DateTime.Now;
                    horaFinalSesion = horaFinalSesion.Add(new TimeSpan(0,0,int.Parse(tiempoUso)));
                    nuevaConexion.TiempoFinal = horaFinalSesion;
                    listaSesiones.Add(nuevaConexion);

                }
            }
            return nuevaConexion;
        }
        /// <summary>
        /// Cierra la sesion de la conexion.
        /// </summary>
        /// <param name="sesion">Sesion a ser finalizada</param>
        /// <returns>Si pudo cerrar la sesion, retorna todos los datos, sino un mensaje que no encontro la sesion buscada.</returns>
        public string CerrarSesionConexionConHorarioAsignado(Sesion sesion)
        {
            if (sesion.Puesto.EstadoPuesto == Enumerados.EstadoPuesto.EnUso
                && sesion.Cliente.EstadoCliente == Enumerados.EstadoCliente.Asignado)
            {
                sesion.Puesto.EstadoPuesto = Enumerados.EstadoPuesto.SinUso;
                sesion.Cliente.EstadoCliente = Enumerados.EstadoCliente.Atendido;
                sesion.CostoSesion = sesion.Puesto.CalcularCosto(sesion);
                sesion.Puesto.UsoMinutos = sesion.CalcularDuracionSesion();
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
                sesion.Puesto.UsoMinutos = sesion.CalcularDuracionSesion();
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
        /// Verifica si el cliente esta en la lista de clientes
        /// </summary>
        /// <param name="control">Controlador en donde se va a utilizar la lista de clientes a verificar</param>
        /// <param name="cliente">Cliente a verificar si esta en la lista</param>
        /// <returns>Retorna true si el cliente esta en la lista de clientes o False si no lo esta</returns>
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
        /// <summary>
        /// Verifica si el cliente esta en la lista de clientes
        /// </summary>
        /// <param name="control">Controlador en donde se va a utilizar la lista de clientes a verificar</param>
        /// <param name="cliente">Cliente a verificar si esta en la lista</param>
        /// <returns>Retorna true si el cliente no esta en la lista o False si el cliente esta</returns>
        public static bool operator !=(Controlador control, Cliente cliente)
        {
            return !(control == cliente);
        }
        /// <summary>
        /// Valida que el cliente elegido sea el primero en la lista de clientes
        /// </summary>
        /// <param name="cliente">Cliente a ser verificado si es el primero en la fila</param>
        /// <param name="tipoCliente">Tipo de cliente, para recorrer la lista de clientes de computadoras o de cabinas</param>
        /// <returns>Retorna True si el cliente es el primero en la lista o False si el cliente no es el primero.</returns>
        public bool ValidarPrimerClienteEnFila(Cliente cliente,string tipoCliente)
        {
            if(!string.IsNullOrWhiteSpace(tipoCliente))
            {
                if(tipoCliente == "Cabina")
                {
                    if(cliente == listaClienteCabinas.Peek())
                    {
                        return true;
                    }
                }
                else
                {
                    if(tipoCliente == "Computadora")
                    {
                        if(cliente == listaClientesComputadoras.Peek())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;

        }
        /// <summary>
        /// Hardcodea los clientes de tipo cabina.
        /// </summary>
        public void HardcodeoClientesCabinas()
        {
            ClienteCabina cliCab1 = new ClienteCabina("Gonzalo", "Salinas", "42038608", "21", Enumerados.TipoTelefono.Teclado, "111112345678");
            ClienteCabina cliCab2 = new ClienteCabina("Facundo", "Cruz", "40101010", "23", Enumerados.TipoTelefono.Teclado, "121212345678");
            ClienteCabina cliCab3 = new ClienteCabina("Eliana", "Cuervo", "40123123", "21", Enumerados.TipoTelefono.ADisco, "541142414903");
            ClienteCabina cliCab4 = new ClienteCabina("Hugo", "Horacio", "10123456", "21", Enumerados.TipoTelefono.ADisco, "541220771022");
            AgregarClienteCabina(cliCab1);
            AgregarClienteCabina(cliCab2);
            AgregarClienteCabina(cliCab3);
            AgregarClienteCabina(cliCab4);
        }
        /// <summary>
        /// Hardcodea los clientes de tipo computadora.
        /// </summary>
        public void HardcodeoClientesComputadoras()
        {
            ClienteComputadora c1 = new ClienteComputadora("Quimey","Espinosa","12332112","23");
            c1.SoftwareCliente = "Ares";
            c1.SoftwareCliente = "Messenger";
            c1.JuegosCliente = "Age of Empires";
            c1.JuegosCliente = "Counter Strike";
            c1.PerifericosCliente = "Camara";
            ClienteComputadora c2 = new ClienteComputadora("Alejo","Carmona","98765432","43");
            c2.SoftwareCliente = "Mi Encarta";
            c2.SoftwareCliente = "Ares";
            c2.SoftwareCliente = "Messenger";
            c2.JuegosCliente = "Age of Empires";
            c2.JuegosCliente = "Counter Strike";
            c2.PerifericosCliente = "Microfono";
            c2.PerifericosCliente = "Camara";

            ClienteComputadora c3 = new ClienteComputadora("Ignacio","Giampaolo","99887766","13");
            c3.JuegosCliente = "Age of Empires";
            c3.JuegosCliente = "Counter Strike";
            ClienteComputadora c4 = new ClienteComputadora("Franco","Alvarez","11223344","12");
            c4.SoftwareCliente = "Mi Encarta";
            c4.SoftwareCliente = "Ares";
            c4.SoftwareCliente = "Messenger";
            c4.JuegosCliente = "Age of Empires";
            c4.JuegosCliente = "Counter Strike";
            c4.PerifericosCliente = "Microfono";
            c4.PerifericosCliente = "Camara";

            AgregarClienteComputadora(c1);
            AgregarClienteComputadora(c2);
            AgregarClienteComputadora(c3);
            AgregarClienteComputadora(c4);
        
        }
        /// <summary>
        /// Hardcodea los puestos de tipo cabina.
        /// </summary>
        public void HardcodeoCabinas()
        {
            AgregarPuesto(new Cabina("PHILIPS", Enumerados.TipoTelefono.Teclado));
            AgregarPuesto(new Cabina("PHILIPS", Enumerados.TipoTelefono.ADisco));
            AgregarPuesto(new Cabina("TELECOM", Enumerados.TipoTelefono.ADisco));
            AgregarPuesto(new Cabina("SANYO", Enumerados.TipoTelefono.Teclado));
            AgregarPuesto(new Cabina("TLC", Enumerados.TipoTelefono.Teclado));

        }
        /// <summary>
        /// Hardcodea los puestos de tipo computadora.
        /// </summary>
        public void HardcodeoComputadoras()
        {
            Computadora c1 = new Computadora();
            c1.Hadware = "CPU Gamer";
            c1.Hadware = "Usb";
            c1.Software = "Ares";
            c1.Software = "Messenger";
            c1.Juegos = "Age of Empires";
            c1.Juegos = "Counter Strike";
            c1.Perifericos = "Camara";
            AgregarPuesto(c1);
            Computadora c2 = new Computadora();
            c2.Hadware = "Usb";
            c2.Software = "Mi Encarta";
            c2.Software = "Ares";
            c2.Software = "Messenger";
            c2.Juegos = "Age of Empires";
            c2.Juegos = "Counter Strike";
            c2.Perifericos = "Microfono";
            c2.Perifericos = "Camara";
            AgregarPuesto(c2);
            Computadora c3 = new Computadora();
            c3.Hadware = "Placa de video";
            c3.Hadware = "CPU Gamer";
            c3.Juegos = "Age of Empires";
            c3.Juegos = "Counter Strike";
            AgregarPuesto(c3);

            List<string> listadoSoftware = new List<string>();
            listadoSoftware.Add("Mi Encarta");

            List<string> listadoJuegos = new List<string>();
            listadoJuegos.Add("Counter Strike");

            List<string> listadoHadware = new List<string>();
            listadoHadware.Add("Usb");

            List<string> listadoPerifericos = new List<string>();
            listadoPerifericos.Add("Camara");

            Computadora c4 = new Computadora(listadoHadware,listadoSoftware,listadoJuegos,listadoPerifericos);

            AgregarPuesto(c4);


        }
    }
}
