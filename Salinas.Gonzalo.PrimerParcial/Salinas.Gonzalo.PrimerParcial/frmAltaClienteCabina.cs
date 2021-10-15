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
            if(ValidadorDeInformacion.ValidarStringTexto(txtNombre.Text) == false || ValidadorDeInformacion.ValidarStringTexto(txtApellido.Text) == false ||
                ValidadorDeInformacion.ValidarDocumento(txtDni.Text) == false || ValidadorDeInformacion.ValidarEdad(txtEdad.Text) == false ||
                ValidadorDeInformacion.ValidarNumero(txtCodigoPais.Text) == false ||
                ValidadorDeInformacion.ValidarNumero(txtCodigoArea.Text)==false || ValidadorDeInformacion.ValidarNumero(txtNumeroTelefono.Text)==false)
            {
                MessageBox.Show("Ocurrio un error al guardar los datos", "Error de ingreso");
            }
            else
            {
                StringBuilder numeroTelefono = new StringBuilder();
                numeroTelefono.Append($"{txtCodigoPais.Text}{txtCodigoArea.Text}{txtNumeroTelefono.Text}");
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDni.Text;
                string edad = txtEdad.Text;
                Enumerados.TipoTelefono tipo;
                

                if (cmbTipoTelefono.SelectedItem.ToString() == "A Disco")
                {
                    tipo = Enumerados.TipoTelefono.ADisco;
                }
                else
                {
                    tipo = Enumerados.TipoTelefono.Teclado;
                }
                
                 ClienteCabina clienteCabina = new ClienteCabina(nombre, apellido, dni, edad, tipo, numeroTelefono.ToString());
                
                if(controlAux.AgregarClienteCabina(clienteCabina))
                {
                    MessageBox.Show(clienteCabina.ToString());
                }
                else
                {
                    MessageBox.Show("Ocurrio un error con el cliente");
                }
                this.Close();
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
