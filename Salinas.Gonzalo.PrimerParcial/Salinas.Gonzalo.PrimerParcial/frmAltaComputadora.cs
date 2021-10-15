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
    public partial class frmAltaComputadora : Form
    {

        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de AltaComputadora
        /// </summary>
        /// <param name="controlador">Controlador a asignar a la variable local control.</param>
        public frmAltaComputadora(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }
        /// <summary>
        /// Da de alta a una computadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarComputadora_Click(object sender, EventArgs e)
        {
            Computadora computadoraAuxiliar = new Computadora();

            foreach (Control item in gBoxHadware.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    computadoraAuxiliar.Hadware = ((CheckBox)item).Text;

                }
            }
            foreach (Control item in gBoxSoftware.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    computadoraAuxiliar.Software = ((CheckBox)item).Text;

                }
            }

            foreach (Control item in gBoxJuegos.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    computadoraAuxiliar.Juegos = ((CheckBox)item).Text;
                }
            }

            foreach (Control item in gBoxPerifericos.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    computadoraAuxiliar.Perifericos = ((CheckBox)item).Text;
                }
            }
            if (control.CorroborarCantidadPuestos(computadoraAuxiliar, 10) && control.AgregarPuesto(computadoraAuxiliar))
            {
                MessageBox.Show("Se agrego la computadora correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar la computadora");
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario que pasos tiene que hacer para que se de de alta una computadora correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Seleccione las especificaciones que tiene la computadora, tanto como HADWARE,SOFTWARE,JUEGOS y PERIFERICOS" +
                ". Luego presione el boton AgregarComputadora para agregar la computadora a la lista de computadoras. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
    }
}
