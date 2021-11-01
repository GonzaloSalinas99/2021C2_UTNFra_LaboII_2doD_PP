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

    public partial class frmAltaClienteCabina : Form
    {
        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        private Controlador controlAux;
        /// <summary>
        /// Constructor de AltaClienteCabina
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmAltaClienteCabina(Controlador controlador)
        {
            InitializeComponent();
            this.controlAux = controlador;
        }
        /// <summary>
        /// Carga el comboBox con los tipos de telefonos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClienteCabina_Load(object sender, EventArgs e)
        {
            cmbTipoTelefono.Items.Add("A Disco");
            cmbTipoTelefono.Items.Add("Teclado");

        }
        /// <summary>
        /// Le da de alta a un cliente de tipo Telefono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarClienteCabina_Click(object sender, EventArgs e)
        {
            string nombre = null;
            string apellido = null;
            string dni = null;
            string edad = null;
            StringBuilder numeroTelefono = new StringBuilder(null);
            Enumerados.TipoTelefono tipo = Enumerados.TipoTelefono.SinAsignar;

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
            if((ValidadorDeInformacion.ValidarNumero(txtCodigoPais.Text) && ValidadorDeInformacion.ValidarCantidadCaracteresString(txtCodigoPais.Text,2))&& (ValidadorDeInformacion.ValidarNumero(txtCodigoArea.Text) && ValidadorDeInformacion.ValidarCantidadCaracteresString(txtCodigoArea.Text, 2)) 
                && (ValidadorDeInformacion.ValidarNumero(txtNumeroTelefono.Text) && ValidadorDeInformacion.ValidarCantidadCaracteresString(txtNumeroTelefono.Text, 8)))
            {
                numeroTelefono.Append($"{txtCodigoPais.Text}{txtCodigoArea.Text}{txtNumeroTelefono.Text}");
            }
            else
            {
                MessageBox.Show($"Error con la numero telefonico. Asegurese de ingresar los numeros correctamente.{Environment.NewLine}Codigo de Pais son 2 digitos.{Environment.NewLine}Codigo de area son 2 digitos." +
                    $"{Environment.NewLine}Numero de telefono son 8 digitos", "Error de ingreso");
            }
            if(cmbTipoTelefono.SelectedItem != null)
            {
                if (cmbTipoTelefono.SelectedItem.ToString() == "A Disco")
                {
                    tipo = Enumerados.TipoTelefono.ADisco;
                }
                else
                {
                    tipo = Enumerados.TipoTelefono.Teclado;
                }
            }
            else
            {
                MessageBox.Show("Error con el tipo de telefono elegido. Asegurese de haber seleccionado un tipo de telefono.", "Error de ingreso");
            }



            if (nombre is not null && apellido is not null && dni is not null && edad is not null && numeroTelefono.Length > 0 && tipo != Enumerados.TipoTelefono.SinAsignar)
            {
                ClienteCabina clienteCabina = new ClienteCabina(nombre, apellido, dni, edad, tipo, numeroTelefono.ToString());

                if (controlAux.AgregarClienteCabina(clienteCabina))
                {
                    MessageBox.Show(clienteCabina.ToString());
                }
                else
                {
                    MessageBox.Show("Ocurrio un error con el cliente");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Error con todos los datos");
            }
                
            

        }
        /// <summary>
        /// Propiedad DevolverControlador de lectura, que retorna el controlador local.
        /// </summary>
        public Controlador DevolverControlador
        {
            get { return this.controlAux; }
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario que pasos tiene que hacer para que agregue el cliente de forma correcta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ingrese Nombre,Apellido,Dni y Edad, seleccione el tipo del telefono que solicita el cliente y el numero de telefono, primero ingresar el codigo del pais, " +
                "luego el codigo de area y por ultimo el numero de telefono. Luego presione el boton AgregarCliente para agregar al cliente a la lista de clientes con cabina. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
