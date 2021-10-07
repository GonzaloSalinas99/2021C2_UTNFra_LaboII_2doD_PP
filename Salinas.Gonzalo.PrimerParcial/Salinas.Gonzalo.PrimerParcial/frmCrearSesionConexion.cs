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
                    Computadora aux = (Computadora)puesto;
                    lBoxComputadora.Items.Add(aux.ToString());
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


            if(ValidadorDeInformacion.ValidarStringTexto(txtDocumentoCliente.Text) && ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorComputadora.Text))
            {
                ClienteComputadora clienteAuxiliar;
                Computadora computadoraAuxiliar;
                string documento = txtDocumentoCliente.Text;
                string identificador = txtIdentificadorComputadora.Text;
                computadoraAuxiliar = BuscarComputadoraIdentificador(control, identificador);
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
                        MessageBox.Show("Error con el identificador de la computadora. Reingrese el identificador", "Error de informacion");
                    }
                }
                else
                {
                    MessageBox.Show("Error con la asignacion de la computadora. Asegurese que el documento coincida con el primer cliente o que haya clientes cargados", "Error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar datos en todos los campos.");
            }
        }

        private ClienteComputadora BuscarClienteDocumento(Controlador control, string documento)
        {
            if(control.ListaClienteComputadora.Count != 0)
            {
                ClienteComputadora aux = control.ListaClienteComputadora.Peek();
                foreach (ClienteComputadora cliente in control.ListaClienteComputadora)
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
            
            return null;
        }

        private Computadora BuscarComputadoraIdentificador(Controlador control, string identificador)
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
