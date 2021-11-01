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

        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de CerrarSesionConexion
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmSesionLlamada(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }
        /// <summary>
        /// Carga los dos listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSesionLlamada_Load(object sender, EventArgs e)
        {
            ActualizarListasClienteCabina(control);
        }

        /// <summary>
        /// Crea una sesion entre cliente y telefono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearSesionLlamada_Click(object sender, EventArgs e)
        {
            if(lBoxClientes.SelectedItem != null && lBoxCabinas.SelectedItem != null)
            {
                ClienteCabina clienteAuxiliar = (ClienteCabina)lBoxClientes.SelectedItem;
                Cabina cabinaAuxiliar = (Cabina)lBoxCabinas.SelectedItem;
                if (control.ValidarPrimerClienteEnFila(clienteAuxiliar, "Cabina"))
                {
                    if (clienteAuxiliar.TipoTelefono == cabinaAuxiliar.TipoTelefono)
                    {
                        if (control.AbrirSesionLlamada(clienteAuxiliar, cabinaAuxiliar))
                        {
                            control.ListaClienteCabinas.Dequeue();
                            MessageBox.Show("Se inicio la sesion correctamente", "Inicio Sesion");
                            lBoxCabinas.Items.Clear();
                            lBoxClientes.Items.Clear();
                            ActualizarListasClienteCabina(control);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error con la asignacion de cabina. Asegurese que el el tipo de telefono de la cabina coincida con el tipo de telefono elegido por el cliente", "Error de informacion");

                    }

                }
                else
                {
                    MessageBox.Show("Error con la asignacion de cabina. Asegurese que el cliente seleccionado sea el primero en la fila", "Error de informacion");
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun item", "Error de informacion");

            }

        }
        /// <summary>
        /// Ingresa los datos del cliente y de la cabina al listBox.
        /// </summary>
        /// <param name="control"></param>
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
        /// <summary>
        /// Propuedad DevolverControlador de lectura. Retorna el controlador local.
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

            MessageBox.Show("Lea tanto la lista de clientes, como la de computadoras. Seleccione el cliente que este primero en la lista de espera y luego la cabina a asignar. SI O SI PARA CREAR LA SESION, EL CLIENTE Y LA CABINA TIENEN QUE TENER LAS MISMAS ESPECIFICACIONES(TIPO DE TELEFONO). " +
                "Luego presione el boton CrearSesion para crear la sesion entre el cliente y la cabina. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
