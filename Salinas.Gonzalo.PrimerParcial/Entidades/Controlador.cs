using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Entidades
{
    public sealed class Controlador
    {
        //private List<Llamada> listaLlamadas;
        private List<Sesion> listaSesiones;
        private List<Puesto> listaPuestos;
        private List<ClienteCabina> listaClienteCabinas;
        private List<ClienteComputadora> listaClientesComputadoras;
        private DateTime fecha;


        internal List<ClienteComputadora> ClienteComputadoras
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
        public List<ClienteCabina> ListaClienteCabinas
        {
            get { return this.listaClienteCabinas; }
            set { listaClienteCabinas = value; }
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public Controlador()
        {
            listaSesiones = new List<Sesion>();
            listaPuestos = new List<Puesto>();
            listaClienteCabinas = new List<ClienteCabina>();
            listaClientesComputadoras = new List<ClienteComputadora>();
            fecha = default(DateTime);
        }

        public bool AgregarClienteCabina(ClienteCabina cliente)
        {
            if(cliente is ClienteCabina && cliente is not null)
            {
                listaClienteCabinas.Add(cliente);
                return true;
            }
            return false;
        }

        public bool AgregarClienteComputadora(ClienteComputadora cliente)
        {
            if (cliente is ClienteComputadora && cliente is not null)
            {
                listaClientesComputadoras.Add(cliente);
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

        public Sesion MostrarSesionLlamada()
        {
            foreach (Llamada llamada in this.listaSesiones)
            {
                return llamada;
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
                    if(sesion == item)
                    {
                        Historial.Sesiones.Add(sesion);
                        this.listaSesiones.Remove(sesion);
                        return sesion.ToString();
                    
                    }
                }

            }

            return "NO LO ENCONTRE";
        }

        public List<Puesto> MOSTRAR()
        {
            return ListaPuestos;
        }
    }
}
