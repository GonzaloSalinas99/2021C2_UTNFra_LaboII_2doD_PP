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
            cmbTiempoSesion.Items.Add("Libre");
            cmbTiempoSesion.Items.Add("30");
            cmbTiempoSesion.Items.Add("60");
            cmbTiempoSesion.Items.Add("90");
            cmbTiempoSesion.Items.Add("120");
            ActualizarLista(control);
        }
        /// <summary>
        /// Crea la sesion entre el cliente y computadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearSesionConexion_Click_1(object sender, EventArgs e)
        {
            if (lBoxClientes.SelectedItem != null && lBoxComputadora.SelectedItem != null && cmbTiempoSesion.SelectedItem != null)
            {
                ClienteComputadora clienteAuxiliar = (ClienteComputadora)lBoxClientes.SelectedItem;
                Computadora computadoraAuxiliar = (Computadora)lBoxComputadora.SelectedItem;
                if (control.ValidarPrimerClienteEnFila(clienteAuxiliar, "Computadora"))
                {
                    if(control.CompararClienteConComputadora(clienteAuxiliar,computadoraAuxiliar))
                    {
                        if(cmbTiempoSesion.SelectedItem.ToString() == "Libre")
                        {
                            if (control.AbrirSesionConexion(clienteAuxiliar, computadoraAuxiliar))
                            {
                                control.ListaClienteComputadora.Dequeue();
                                MessageBox.Show("Se inicio la sesion correctamente", "Inicio Sesion");
                                lBoxComputadora.Items.Clear();
                                lBoxClientes.Items.Clear();
                                ActualizarLista(control);
                            }
                        }
                        else
                        {
                            Conexion sesionAuxiliar = (Conexion)control.AbrirSesionConexion(clienteAuxiliar, computadoraAuxiliar, cmbTiempoSesion.SelectedItem.ToString());
                            control.ListaClienteComputadora.Dequeue();
                            lBoxClientes.Items.Clear();
                            lBoxComputadora.Items.Clear();
                            ActualizarLista(control);
                            MessageBox.Show(control.CerrarSesionConexionConHorarioAsignado(sesionAuxiliar));

                        }

                    }
                    else
                    {
                        MessageBox.Show("Error con la asignacion de la computadora. No coincide las especificaciones del cliente con la de la computadora", "Error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Error con la asignacion de la computadora. El cliente que usted selecciono no es el primero en la fila", "Error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Error con la asignacion de la computadora. No selecciono item de la lista", "Error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            MessageBox.Show("Lea tanto la lista de clientes, como la de computadoras.  Seleccione el cliente que este primero en la lista de espera y luego la computadora a asignar. SI O SI PARA CREAR LA SESION, EL CLIENTE Y LA COMPUTADORA TIENEN QUE TENER LAS MISMAS ESPECIFICACIONES(SOFTWARE,JUEGO,PERIFERICO). " +
                "Luego presione el boton CrearSesion para crear la sesion entre el cliente y la computadora. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
