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
        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de CerrarSesionConexion
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmCrearSesionConexion(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }
        /// <summary>
        /// Cargo los datos al listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSesionConexion_Load(object sender, EventArgs e)
        {
            ActualizarLista(control);
        }
        /// <summary>
        /// Crea la sesion entre el cliente y computadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ingresa los datos de cliente y computadora al listBox.
        /// </summary>
        /// <param name="control"></param>
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
        /// <summary>
        /// Propiedad DevolverControlador de lectura. Retorna el controlador local.
        /// </summary>
        public Controlador DevolverControlador
        {
            get { return this.control; }
        }
        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario los pasos que tiene que hacer para crear la sesion correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Lea tanto la lista de clientes, como la de computadoras. Ingrese el numero de documento e identificador de la computadora. SI O SI PARA CREAR LA SESION, EL CLIENTE Y LA COMPUTADORA TIENEN QUE TENER LAS MISMAS ESPECIFICACIONES(SOFTWARE,JUEGO,PERIFERICO). " +
                "Luego presione el boton CrearSesion para crear la sesion entre el cliente y la computadora. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
