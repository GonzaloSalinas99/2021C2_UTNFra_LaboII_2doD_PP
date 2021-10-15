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
    public partial class frmCerrarSesionLlamada : Form
    {

        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de CerrarSesionConexion
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmCerrarSesionLlamada(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }
        /// <summary>
        /// Cierra la sesion entre el cliente y el telefono.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarSesionLlamada_Click(object sender, EventArgs e)
        {
            string identificador = txtIdentificadorLlamada.Text;
            if(control.BuscarSesionPorIdentificador(control,identificador,"Llamada") is not null)
            {
                Llamada llamadaAux = (Llamada)control.BuscarSesionPorIdentificador(control, identificador,"Llamada");
                MessageBox.Show(control.CerrarSesionTelefono(llamadaAux));
                MessageBox.Show("Se cerro sesion correctamente");
                lBoxLlamadas.Items.Clear();
                ActualizarListasSesiones(control);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al cerrar sesion");
            }

        }
        /// <summary>
        /// Carga el listBox con las sesiones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCerrarSesionLlamada_Load(object sender, EventArgs e)
        {
            ActualizarListasSesiones(control);
        }

        /// <summary>
        /// Ingresa al listBox los datos de las sesiones de tipo Llamada
        /// </summary>
        /// <param name="control"></param>
        private void ActualizarListasSesiones(Controlador control)
        {
            foreach (Sesion sesion in control.ListaSesiones)
            {
                if (sesion is Llamada)
                {
                    lBoxLlamadas.Items.Add(sesion);
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
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario los pasos que tiene que hacer para cerrar una sesion correctamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Lea la lista de sesiones de llamadas activas. Ingrese identificador de la sesion. Luego presione el boton CerrarSesion para cerrar la sesion entre el cliente y la cabina. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
