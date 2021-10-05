using System;
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
    public partial class frmCrearSesionConexion : Form
    {
        Controlador control;
        public frmCrearSesionConexion(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }

        private void frmSesionConexion_Load(object sender, EventArgs e)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is Computadora && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxComputadora.Items.Add(puesto.ToString());
                }
            }



            foreach (ClienteComputadora cliente in control.ListaClienteComputadora)
            {
                if (cliente is ClienteComputadora && cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                {
                    lBoxClientes.Items.Add(cliente.ToString());
                }
            }
        }
        private void btnCrearSesionConexion_Click_1(object sender, EventArgs e)
        {
            ClienteComputadora clienteAuxiliar;
            Computadora computadoraAuxiliar;
            string documento = txtDocumentoCliente.Text;
            string identificador = txtIdentificadorComputadora.Text;
            computadoraAuxiliar = BuscarCabinaIdentificador(control, identificador);
            clienteAuxiliar = BuscarClienteDocumento(control, documento);


            if (clienteAuxiliar is not null && clienteAuxiliar.Dni == documento && computadoraAuxiliar is not null && computadoraAuxiliar.IdPuesto == identificador)
            {
                if (control.AbrirSesionConexion(clienteAuxiliar, computadoraAuxiliar))
                {
                    MessageBox.Show("Se inicio la sesion correctamente", "Inicio Sesion");
                    lBoxComputadora.Items.Clear();
                    lBoxClientes.Items.Clear();
                    ActualizarListaClienteComputadora(control);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error con el inicio de sesion");
                }
            }
            else
            {
                lblClienteEncontrado.Text = "Hubo un error";
            }
        }

        private ClienteComputadora BuscarClienteDocumento(Controlador control, string documento)
        {
            foreach (ClienteComputadora cliente in control.ListaClienteComputadora)
            {
                if (cliente is ClienteComputadora && cliente is not null)
                {
                    if (cliente.Dni == documento && cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                    {
                        return cliente;
                    }
                }
            }
            return null;
        }

        private Computadora BuscarCabinaIdentificador(Controlador control, string identificador)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is Computadora && puesto is not null)
                {
                    if (puesto.IdPuesto == identificador && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                    {
                        return (Computadora)puesto;
                    }
                }
            }
            return null;
        }
        private void ActualizarListaClienteComputadora(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is Computadora && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxComputadora.Items.Add(puesto);
                }
            }
            foreach (ClienteComputadora cliente in control.ListaClienteComputadora)
            {
                if (cliente is ClienteComputadora && cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                {
                    lBoxClientes.Items.Add(cliente);
                }
            }
        }

        public Controlador DevolverControlador
        {
            get { return this.control; }
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
