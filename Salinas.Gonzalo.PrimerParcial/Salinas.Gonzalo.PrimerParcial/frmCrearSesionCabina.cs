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
    public partial class frmSesionLlamada : Form
    {
        Controlador control;
        public frmSesionLlamada(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }

        private void frmSesionLlamada_Load(object sender, EventArgs e)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is Cabina && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxCabinas.Items.Add(puesto.ToString());
                }
            }

            

            foreach (ClienteCabina cli in control.ListaClienteCabinas)
            {
                if (cli is ClienteCabina && cli.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                {
                    lBoxClientes.Items.Add(cli.ToString());
                }
            }
        }

        private ClienteCabina BuscarClienteCabinaDocumento(Controlador control,string documento)
        {
            foreach (ClienteCabina cliente in control.ListaClienteCabinas)
            {
                if (cliente is ClienteCabina && cliente is not null)
                {
                    if (cliente.Dni == documento && cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                    {
                        return cliente;
                    }
                }
            }
            return null;
        }

        private Cabina BuscarCabinaIdentificador(Controlador control,string identificador)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if(puesto is Cabina && puesto is not null)
                {
                    if(puesto.IdPuesto == identificador && puesto.EstadoPuesto== Enumerados.EstadoPuesto.SinUso)
                    {
                        return (Cabina)puesto;
                    }
                }
            }
            return null;
        }

        private void btnCrearSesionLlamada_Click(object sender, EventArgs e)
        {
            ClienteCabina clienteAuxiliar;
            Cabina cabinaAuxiliar;
            string documento = txtDocumentoCliente.Text;
            string identificador = txtIdentificadorCabina.Text;
            cabinaAuxiliar = BuscarCabinaIdentificador(control, identificador);
            clienteAuxiliar = BuscarClienteCabinaDocumento(control, documento);

            
            if (clienteAuxiliar is not null && clienteAuxiliar.Dni == documento && cabinaAuxiliar is not null && cabinaAuxiliar.IdPuesto == identificador)
            {
                if(control.AbrirSesionLlamada(clienteAuxiliar, cabinaAuxiliar))
                {
                    MessageBox.Show("Se inicio la sesion correctamente", "Inicio Sesion");
                    lBoxCabinas.Items.Clear();
                    lBoxClientes.Items.Clear();
                    ActualizarListasClienteCabina(control);
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

        private void ActualizarListasClienteCabina(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if(puesto is Cabina && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxCabinas.Items.Add(puesto);
                }
            }
            foreach (ClienteCabina cliente in control.ListaClienteCabinas)
            {
                if (cliente is ClienteCabina && cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
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
