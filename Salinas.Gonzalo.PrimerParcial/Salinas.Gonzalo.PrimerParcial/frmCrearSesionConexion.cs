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
                computadoraAuxiliar = (Computadora)control.BuscarPuestoPorIdentificador(identificador,"Computadora");
                clienteAuxiliar =(ClienteComputadora)control.BuscarClienteDocumento(documento,"Computadora");
                if (clienteAuxiliar is not null && clienteAuxiliar.Dni == documento && computadoraAuxiliar is not null && computadoraAuxiliar.IdPuesto == identificador)
                {
                    if (control.AbrirSesionConexion(clienteAuxiliar, computadoraAuxiliar))
                    {
                        MessageBox.Show("Se inicio la sesion correctamente", "Inicio Sesion");
                        lBoxComputadora.Items.Clear();
                        lBoxClientes.Items.Clear();
                        ActualizarLista(control);
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


        private void ActualizarLista(Controlador control)
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

        public Controlador DevolverControlador
        {
            get { return this.control; }
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Lea tanto la lista de clientes, como la de computadoras. Ingrese el numero de documento e identificador de la computadora. SI O SI PARA CREAR LA SESION, EL CLIENTE Y LA COMPUTADORA TIENEN QUE TENER LAS MISMAS ESPECIFICACIONES(SOFTWARE,JUEGO,PERIFERICO). " +
                "Luego presione el boton CrearSesion para crear la sesion entre el cliente y la computadora. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
