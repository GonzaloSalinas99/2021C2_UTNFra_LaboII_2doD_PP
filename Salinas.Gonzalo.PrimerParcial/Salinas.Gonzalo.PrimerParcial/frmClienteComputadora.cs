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
    public partial class frmClienteComputadora : Form
    {
        private Controlador control;
        public frmClienteComputadora(Controlador controlador)
        {

            InitializeComponent();
            this.control = controlador;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (ValidadorDeInformacion.ValidarStringTexto(txtNombre.Text) == false || ValidadorDeInformacion.ValidarStringTexto(txtApellido.Text) == false ||
                ValidadorDeInformacion.ValidarDocumento(txtDni.Text) == false || ValidadorDeInformacion.ValidarEdad(txtEdad.Text) == false )
            {
                MessageBox.Show("Ocurrio un error al guardar los datos", "Error de ingreso");
            }
            else
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDni.Text;
                string edad = txtEdad.Text;

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

                MessageBox.Show(cliente.ToString());
                control.AgregarClienteComputadora(cliente);
                this.Close();
            }
        }

        public Controlador DevolverControlador
        {
            get { return this.control; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClienteComputadora_Load(object sender, EventArgs e)
        {

        }

    }
}
