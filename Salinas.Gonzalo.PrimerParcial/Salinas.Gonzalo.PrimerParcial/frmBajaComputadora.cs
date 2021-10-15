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
   
    public partial class frmBajaComputadora : Form
    {

        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de BajaComputadora
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmBajaComputadora(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }
        /// <summary>
        /// Carga el listBox con los datos de las computadoras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBajaComputadora_Load(object sender, EventArgs e)
        {
            ActualizarLista(control);
        }
        /// <summary>
        /// Da de baja a una computadora elegida por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBajaComputadora_Click(object sender, EventArgs e)
        {
            if(ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorCabina.Text))
            {
                Computadora computadoraAuxiliar = (Computadora)control.BuscarPuestoPorIdentificador(txtIdentificadorCabina.Text, "Computadora");
                if(computadoraAuxiliar is not null)
                {
                    control.ListaPuestos.Remove(computadoraAuxiliar);
                    lBoxListaComputadora.Items.Clear();
                    ActualizarLista(control);
                }
            }
        }
        /// <summary>
        /// Ingresa los datos de las computadoras al listBox.
        /// </summary>
        /// <param name="control"></param>
        private void ActualizarLista(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is not null && puesto is Computadora)
                {
                    lBoxListaComputadora.Items.Add(puesto.ToString());
                }
            }
        }
        /// <summary>
        /// Propiedad DevolverControl de lectura, retorna el controlador local.
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
        private void btnvolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario los pasos que tiene que hacer para dar de baja a una computadora correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ingrese el identificador de la cabina que quiere eliminar. Luego presione el boton BorrarComputadora para eliminar la computadora de la lista de computadoras. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
