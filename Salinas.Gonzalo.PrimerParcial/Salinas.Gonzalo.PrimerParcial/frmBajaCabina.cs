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
    public partial class frmBajaCabina : Form
    {
        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de BajaCabina
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmBajaCabina(Controlador controlador)
        {

            control = controlador;
            InitializeComponent();
        }
        /// <summary>
        /// Imprime las cabinas en el ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBajaCabina_Load(object sender, EventArgs e)
        {
            ActualizarLista(control);
        }
        /// <summary>
        /// Borra la cabina elegida por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCabina_Click(object sender, EventArgs e)
        {
            if(ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorCabina.Text))
            {
                Cabina cabinaAuxiliar = (Cabina)control.BuscarPuestoPorIdentificador(txtIdentificadorCabina.Text,"Cabina");
                if(cabinaAuxiliar is not null)
                {
                    control.ListaPuestos.Remove(cabinaAuxiliar);
                    lBoxListaCabinas.Items.Clear();
                    ActualizarLista(control);
                }
            }
        }
        /// <summary>
        /// Ingresa los datos de las cabinas al listBox
        /// </summary>
        /// <param name="control"></param>
        private void ActualizarLista(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is Cabina && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxListaCabinas.Items.Add(puesto.ToString());
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
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnvolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario los pasos que tiene que hacer para que se pueda borrar una cabina correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lea la lista de cabinas que se encuentran logueadas, ingrese el identificador de la cabina que quiere borrar" +
                ",luego presione el boton BorrarCabina para eliminar la cabina de la lista de cabinas. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
