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
    public partial class frmCerrarSesionConexion : Form
    {
        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de CerrarSesionConexion
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmCerrarSesionConexion(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }
        /// <summary>
        /// Cierra la sesion entre computadora y cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarSesionConexion_Click(object sender, EventArgs e)
        {
            string identificador = txtIdentificadorConexion.Text;
            if (control.BuscarSesionPorIdentificador(control, identificador,"Conexion") is not null)
            {
                Conexion conexionAux= (Conexion)control.BuscarSesionPorIdentificador(control, identificador,"Conexion");
                MessageBox.Show(control.CerrarSesionConexion(conexionAux));
                MessageBox.Show("Se cerro sesion correctamente");
                lBoxSesionConexion.Items.Clear();
                ActualizarListasSesiones(control);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al cerrar sesion");
            }
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
        /// Carga las sesiones en el listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCerrarSesionConexion_Load(object sender, EventArgs e)
        {
            ActualizarListasSesiones(control);
        }
        /// <summary>
        /// Ingresa los datos de las sesiones de tipo Conexion al listBox.
        /// </summary>
        /// <param name="control"></param>
        private void ActualizarListasSesiones(Controlador control)
        {
            foreach (Sesion sesion in control.ListaSesiones)
            {
                if (sesion is Conexion)
                {
                    lBoxSesionConexion.Items.Add(sesion.ToString());
                }
            }

        }
        /// <summary>
        /// Propiedad DevolverControlador de lectura, retorna el controlador local.
        /// </summary>
        public Controlador DevolverControlador
        {
            get { return this.control; }
        }
        /// <summary>
        /// Indica al usuario que pasos tiene que hacer para cerrar sesion correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Lea la lista de sesiones de conexion activas. Ingrese identificador de la sesion. Luego presione el boton CerrarSesion para cerrar la sesion entre el cliente y la computadora. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
