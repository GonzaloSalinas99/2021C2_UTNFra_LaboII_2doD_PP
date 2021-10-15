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
    public partial class frmAltaCabina : Form
    {
        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de AltaCabina
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmAltaCabina(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }
        /// <summary>
        /// Carga el comboBox con los tipos de telefono.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AltaCabina_Load(object sender, EventArgs e)
        {
            cmbTipoTelefono.Items.Add("A Disco");
            cmbTipoTelefono.Items.Add("Teclado");
        }
        /// <summary>
        /// Agrega una cabina a la listaPuesto de control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCabina_Click(object sender, EventArgs e)
        {
            if(ValidadorDeInformacion.ValidarStringTexto(txtMarcaTelefono.Text) && ValidadorDeInformacion.ValidarStringTexto(cmbTipoTelefono.Text))
            {
                string marcaTelefono = txtMarcaTelefono.Text;
                Enumerados.TipoTelefono tipoTelefono;
                if(cmbTipoTelefono.SelectedItem.ToString() == "A Disco")
                {
                    tipoTelefono = Enumerados.TipoTelefono.ADisco;
                }
                else
                {
                    tipoTelefono = Enumerados.TipoTelefono.Teclado;
                }
                Cabina cabina = new Cabina(marcaTelefono, tipoTelefono);
                if(control.CorroborarCantidadPuestos(cabina,5) && control.AgregarPuesto(cabina))
                {
                    MessageBox.Show("Se agrego la cabina correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la cabina");
                }
            }
        }
        /// <summary>
        /// Propiedad DevolverControlador de lectura, que devuelve el controlador local.
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
        /// indica al usuario que pasos tiene que hacer para que se agregue la cabina correctamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese la marca y el tipo del telefono a dar el alta, luego presione el boton AgregarCabina para agregar la cabina a la " +
             "lista de cabinas. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
