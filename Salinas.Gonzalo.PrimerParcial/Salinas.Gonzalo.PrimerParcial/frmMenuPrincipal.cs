﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Salinas.Gonzalo.PrimerParcial
{
    public partial class frmMenuPrincipal : Form
    {
        /// <summary>
        /// Variable donde se va a guardar toda la informacion y procesos que se realizen
        /// </summary>
        Controlador controlador;
        /// <summary>
        /// Constructor del formulario, que instancia clientes y puestos
        /// </summary>
        public frmMenuPrincipal()
        {
            controlador = new Controlador();
            controlador.AgregarPuesto(new Cabina("PHILIPS", Enumerados.TipoTelefono.Teclado));
            controlador.AgregarPuesto(new Cabina("PHILIPS", Enumerados.TipoTelefono.ADisco));
            controlador.AgregarPuesto(new Cabina("TELECOM", Enumerados.TipoTelefono.ADisco));
            controlador.AgregarPuesto(new Cabina("SANYO", Enumerados.TipoTelefono.Teclado));
            controlador.AgregarPuesto(new Cabina("TLC", Enumerados.TipoTelefono.Teclado));
            Computadora c1 = new Computadora();
            c1.Hadware = "CPU Gamer";
            c1.Hadware = "Usb";
            c1.Software = "Ares";
            c1.Software = "Messenger";
            c1.Juegos = "Age of Empires";
            c1.Juegos = "Counter Strike";
            c1.Perifericos = "Camara";
            controlador.AgregarPuesto(c1);
            Computadora c2 = new Computadora();
            c2.Hadware = "Usb";
            c2.Software = "Mi Encarta";
            c2.Software = "Ares";
            c2.Software = "Messenger";
            c2.Juegos = "Age of Empires";
            c2.Juegos = "Counter Strike";
            c2.Perifericos = "Microfono";
            c2.Perifericos = "Camara";
            controlador.AgregarPuesto(c2);
            Computadora c3 = new Computadora();
            c3.Hadware = "Placa de video";
            c3.Hadware = "CPU Gamer";
            c3.Juegos = "Age of Empires";
            c3.Juegos = "Counter Strike";
            
            
            controlador.AgregarPuesto(c3);
            ClienteCabina cliCab1 = new ClienteCabina("Gonzalo","Salinas","42038608","21",Enumerados.TipoTelefono.Teclado,"111112345678");
            ClienteCabina cliCab2 = new ClienteCabina("Facundo","Cruz","40101010","23",Enumerados.TipoTelefono.Teclado,"121212345678");
            ClienteCabina cliCab3 = new ClienteCabina("Eliana","Cuervo","40123123","21",Enumerados.TipoTelefono.ADisco,"541142414903");
            ClienteCabina cliCab4 = new ClienteCabina("Hugo","Horacio","10123456","21",Enumerados.TipoTelefono.ADisco,"541220771022");
            controlador.AgregarClienteCabina(cliCab1);
            controlador.AgregarClienteCabina(cliCab2);
            controlador.AgregarClienteCabina(cliCab3);
            controlador.AgregarClienteCabina(cliCab4);
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            
            
        }
        /// <summary>
        /// Timer para saber la fecha en la que estamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Llama al formulario AltaClienteCabina para agregar un nuevo cliente de tipo cabina en controlador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarClienteCabina_Click(object sender, EventArgs e)
        {
            frmAltaClienteCabina frmClienteCabina = new frmAltaClienteCabina(controlador);
            frmClienteCabina.ShowDialog();
            controlador= (frmClienteCabina.DevolverControlador);
            
           
        }

        /// <summary>
        /// Llama al formulario AltaClienteComputadora para agregar un nuevo cliente de tipo computadora en controlador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarClienteComputadora_Click(object sender, EventArgs e)
        {
            frmAltaClienteComputadora frmClienteComputadora = new frmAltaClienteComputadora(controlador);
            frmClienteComputadora.ShowDialog();
            controlador = (frmClienteComputadora.DevolverControlador);
            
        }

        /// <summary>
        /// Llama al formulario CrearSesionLlamada para agregar ,una sesion entre cliente y telefono, en controlador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearSesionLlamada_Click(object sender, EventArgs e)
        {
            frmSesionLlamada frmSesionLlamada = new frmSesionLlamada(controlador);
            frmSesionLlamada.ShowDialog();
            controlador = frmSesionLlamada.DevolverControlador;
        }

        /// <summary>
        /// Llama al formulario CrearSesionConexion para agregar ,una sesion entre cliente y computadora, en controlador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearSesionConexion_Click(object sender, EventArgs e)
        {
            frmCrearSesionConexion frmSesionConexion = new frmCrearSesionConexion(controlador);
            frmSesionConexion.ShowDialog();
            controlador = frmSesionConexion.DevolverControlador;
        }

        /// <summary>
        /// Llama al formulario CerrarrSesionLlamada para cerrar ,una sesion entre cliente y telefono, y guardarlo en controlador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarSesionLlamada_Click(object sender, EventArgs e)
        {
            frmCerrarSesionLlamada frmCerrarSesionLlamada = new frmCerrarSesionLlamada(controlador);
            frmCerrarSesionLlamada.ShowDialog();
            controlador = frmCerrarSesionLlamada.DevolverControlador;
            
        }
        /// <summary>
        /// Llama al formulario CerrarrSesionConexion para cerrar ,una sesion entre cliente y computadora, y guardarlo en controlador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarSesionConexion_Click(object sender, EventArgs e)
        {
            frmCerrarSesionConexion frmCerrarSesionConexion = new frmCerrarSesionConexion(controlador);
            frmCerrarSesionConexion.ShowDialog();
            controlador = frmCerrarSesionConexion.DevolverControlador;
        }
        /// <summary>
        /// Imprime en una ventana, los clientes cargados, de cabina como tambien de computadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarClientesEnEspera_Click(object sender, EventArgs e)
        {
            StringBuilder clientesCabina = new StringBuilder();
            clientesCabina.AppendLine("Lista Clientes Cabina");
            if (controlador.ListaClienteCabinas.Count == 0)
            {
                clientesCabina.AppendLine("No hay clientes cargados");
            }
            else
            {
                foreach (ClienteCabina cliente in controlador.ListaClienteCabinas)
                {
                    if(cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                    {
                        clientesCabina.AppendLine(cliente.ToString());
                    }
                }

            }

            StringBuilder clientesComputadora = new StringBuilder();
            clientesComputadora.AppendLine("Lista Clientes Computadora");

            if (controlador.ListaClienteComputadora.Count == 0)
            {
                clientesComputadora.AppendLine("No hay clientes cargados");
            }
            else
            {
                foreach (ClienteComputadora cliente in controlador.ListaClienteComputadora)
                {
                    if(cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                    {
                        clientesComputadora.AppendLine(cliente.ToString());
                    }
                }
            }

            MessageBox.Show(clientesCabina.ToString());
            MessageBox.Show(clientesComputadora.ToString());
        }
        /// <summary>
        /// Imprime por ventana la ganancia total clasificada por servicio, lo mas elegido de los clientes de tipo computadora y la recaudacion por tipo de llamadas y horas totales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarEstadisticas_Click(object sender, EventArgs e)
        {
            StringBuilder puesto = new StringBuilder();
            puesto.Append("Entidades.");
            puesto.Append(txtNombrePuesto.Text);
            List<Puesto> listaAux = Historial.OrdenarLista(puesto.ToString());

            MessageBox.Show(Historial.GananciaTotalClasificadasPorServicio());
            MessageBox.Show(Historial.LoMasPedidoPorClientesComputadora());
            MessageBox.Show(Historial.RecaudacionPorTipoDeLlamadaYHorasTotales());
        }
        /// <summary>
        /// Muestra por ventana, el puesto elegido a mostrar por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarPuestos_Click(object sender, EventArgs e)
        {
            StringBuilder puestoABuscar = new StringBuilder();
            puestoABuscar.Append(txtNombrePuesto.Text);

            List<Puesto> listaAux = controlador.FiltroLista(puestoABuscar.ToString());
            StringBuilder listaDePuesto = new StringBuilder();
            foreach (Puesto puesto in listaAux)
            {
                listaDePuesto.AppendLine(puesto.ToString());
            }
            MessageBox.Show(listaDePuesto.ToString());
        }
        /// <summary>
        /// Llama al formulario AltaCabina para agregar una cabina a la listaPuesto de controlador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCabina_Click(object sender, EventArgs e)
        {
            frmAltaCabina altaCabina = new frmAltaCabina(controlador);
            altaCabina.ShowDialog();
            controlador = altaCabina.DevolverControlador; 
        }

        /// <summary>
        /// Llama al formulario ModificarCabina para modificar una cabina en la listaPuesto de controlador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCabina_Click(object sender, EventArgs e)
        {
            frmModificarCabina frmModificarCabina = new frmModificarCabina(controlador);
            frmModificarCabina.ShowDialog();
        }
        /// <summary>
        /// Llama al formulario BajaCabina para borrar una cabina en la listaPuesto de controlador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarCabina_Click(object sender, EventArgs e)
        {
            frmBajaCabina frmBajaCabina = new frmBajaCabina(controlador);
            frmBajaCabina.ShowDialog();
            controlador = frmBajaCabina.DevolverControlador;
        }
        /// <summary>
        /// Llama al formulario AltaComputadora para agregar una computadora en la listaPuesto de controlador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarComputadora_Click(object sender, EventArgs e)
        {
            frmAltaComputadora frmAltaComputadora = new frmAltaComputadora(controlador);
            frmAltaComputadora.ShowDialog();
            controlador = frmAltaComputadora.DevolverControlador;
        }
        /// <summary>
        /// Llama al formulario ModificarComputadora para modificar una computadora en la listaPuesto de controlador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarComputadora_Click(object sender, EventArgs e)
        {
            frmModificarComputadora frmModificarComputadora = new frmModificarComputadora(controlador);
            frmModificarComputadora.ShowDialog();
            controlador = frmModificarComputadora.DevolverControlador;
        }
        /// <summary>
        /// Llama al formulario BajaComputadora para borrar una cabina en la listaPuesto de controlador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarComputadora_Click(object sender, EventArgs e)
        {
            frmBajaComputadora frmBajaComputadora = new frmBajaComputadora(controlador);
            frmBajaComputadora.ShowDialog();
            controlador = frmBajaComputadora.DevolverControlador;
        }
        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
