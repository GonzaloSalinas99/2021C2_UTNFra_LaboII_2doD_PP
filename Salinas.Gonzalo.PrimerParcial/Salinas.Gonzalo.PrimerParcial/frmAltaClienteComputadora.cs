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
    public partial class frmAltaClienteComputadora : Form
    {

        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        private Controlador control;
        /// <summary>
        /// Constructor de AltaClienteComputadora
        /// </summary>
        /// <param name="controlador">Controlador a asignar a la variable local control</param>
        public frmAltaClienteComputadora(Controlador controlador)
        {

            InitializeComponent();
            this.control = controlador;
        }
        /// <summary>
        /// Da de alta a un cliente de tipo Computadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (ValidadorDeInformacion.ValidarStringTexto(txtNombre.Text) == false || ValidadorDeInformacion.ValidarStringTexto(txtApellido.Text) == false ||
                ValidadorDeInformacion.ValidarDocumento(txtDni.Text) == false || ValidadorDeInformacion.ValidarEdad(txtEdad.Text) == false )
            {
                MessageBox.Show("Ocurrio un error al guardar los datos", "Error de ingreso");
            }
            else
            {
                string nombre = null;
                string apellido = null;
                string dni = null;
                string edad = null;
                if (ValidadorDeInformacion.ValidarStringTexto(txtNombre.Text) == false)
                {
                    MessageBox.Show("Debe Ingresar Su Nombre.", "Error de ingreso");
                }
                else
                {
                    nombre = txtNombre.Text;
                }
                if (ValidadorDeInformacion.ValidarStringTexto(txtApellido.Text) == false)
                {
                    MessageBox.Show("Debe Ingresar Su Apellido.", "Error de ingreso");

                }
                else
                {
                    apellido = txtApellido.Text;
                }
                if (ValidadorDeInformacion.ValidarDocumento(txtDni.Text) == false)
                {
                    MessageBox.Show("Error con el numero de documento. Asegurese de ingresar el numero y que tenga 8 digitos.", "Error de ingreso");

                }
                else
                {
                    dni = txtDni.Text;
                }

                if (ValidadorDeInformacion.ValidarEdad(txtEdad.Text) == false)
                {
                    MessageBox.Show("Error con la edad. Asegurese de ingresar la edad y que tenga entre 3 y 100 años.", "Error de ingreso");
                }
                else
                {
                    edad = txtEdad.Text;
                }
                if (nombre is not null && apellido is not null && dni is not null && edad is not null)
                {
                    ClienteComputadora cliente = new ClienteComputadora(nombre, apellido, dni, edad);

                    foreach (Control item in gBoxSoftware.Controls)
                    {
                        if (item is CheckBox && ((CheckBox)item).Checked)
                        {
                            cliente.SoftwareCliente = ((CheckBox)item).Text;

                        }
                    }

                    foreach (Control item in gBoxJuegos.Controls)
                    {
                        if (item is CheckBox && ((CheckBox)item).Checked)
                        {
                            cliente.JuegosCliente = ((CheckBox)item).Text;
                        }
                    }

                    foreach (Control item in gBoxPerifericos.Controls)
                    {
                        if (item is CheckBox && ((CheckBox)item).Checked)
                        {
                            cliente.PerifericosCliente = ((CheckBox)item).Text;
                        }
                    }

                    if (control.AgregarClienteComputadora(cliente))
                    {
                        MessageBox.Show(cliente.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error. No puede haber dos clientes con el mismo documento", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error. Asegurese de tener todos los campos con informacion.", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario que pasos tiene que hacer para que se de de alta al cliente correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ingrese Nombre,Apellido,Dni y Edad, seleccione las especificaciones de la computadora que solicita, SOFTWARE, JUEGO, PERIFERICO. " +
                "Luego presione el boton AgregarCliente para agregar al cliente a la lista de clientes con computadora. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
