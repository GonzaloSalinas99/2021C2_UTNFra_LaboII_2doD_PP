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

        public Queue<ClienteComputadora> ListaClienteComputadora
        {
            get { return this.listaClientesComputadoras; }
            set { listaClientesComputadoras = value; }
        }
        public List<Sesion> ListaSesiones
        {
            get { return this.listaSesiones; }
            set { listaSesiones = value; }
        }
        public List<Puesto> ListaPuestos
        {
            get { return this.listaPuestos; }
            set { listaPuestos = value; }
        }
        public Queue<ClienteCabina> ListaClienteCabinas
        {
            get { return this.listaClienteCabinas; }
            set { listaClienteCabinas = value; }
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        //public int CantidadCabinas
        //{
        //    get { return this.cantidadCabinas; }

        //}

        public Controlador()
        {
            listaSesiones = new List<Sesion>();
            listaPuestos = new List<Puesto>();
            listaClienteCabinas = new Queue<ClienteCabina>();
            listaClientesComputadoras = new Queue<ClienteComputadora>();
            fecha = default(DateTime);
        }

        public bool AgregarClienteCabina(ClienteCabina cliente)
        {
            if(cliente is ClienteCabina && cliente is not null )
            {
                listaClienteCabinas.Enqueue(cliente);
                return true;
            }
            return false;
        }

        public bool AgregarClienteComputadora(ClienteComputadora cliente)
        {
            if (cliente is ClienteComputadora && cliente is not null)
            {
                listaClientesComputadoras.Enqueue(cliente);
                return true;
            }
            return false;
        }

        
        public bool AgregarPuesto(Puesto puesto)
        {
            if (puesto is Puesto && puesto is not null)
            {
                listaPuestos.Add(puesto);
                return true;
            }
            return false;
        }

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
        public Sesion MostrarSesionLlamada()
        {
            foreach (Llamada llamada in this.listaSesiones)
            {
                return llamada;
            }
            return null;
        }
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


        public bool AbrirSesionConexion(ClienteComputadora cliente, Computadora computadora)
        {

            if (cliente is ClienteComputadora && computadora is Computadora)
            {
                if (cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando
                    && computadora.EstadoPuesto == Enumerados.EstadoPuesto.SinUso && CompararClienteConComputadora(cliente,computadora))
                {
                    Conexion nuevaConexion = new Conexion(computadora,cliente);
                    ListaSesiones.Add(nuevaConexion);
                    return true;
                }
            }
            return false;
        }
        public Sesion MostrarSesionConexion()
        {
            foreach (Conexion conexion in ListaSesiones)
            {
                return conexion;
            }
            return null;
        }

        
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

        public Cabina BuscarCabinaIdentificador( string identificador)
        {
            foreach (Puesto puesto in ListaPuestos)
            {
                if (puesto is Cabina && puesto is not null)
                {
                    if (puesto.IdPuesto == identificador && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                    {
                        return (Cabina)puesto;
                    }
                }
            }
            return null;
        }
    }
}
