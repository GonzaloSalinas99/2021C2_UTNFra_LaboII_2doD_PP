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
    
    public partial class frmClienteCabina : Form
    {
        private ClienteCabina clienteCabina;
        private Controlador controlAux;
        public frmClienteCabina(Controlador controlador)
        {
            InitializeComponent();
            this.controlAux = controlador;
           // controlador = btnAgregarClienteCabina();
        }

        private void frmClienteCabina_Load(object sender, EventArgs e)
        {
            cmbTipoTelefono.Items.Add("A Disco");
            cmbTipoTelefono.Items.Add("Teclado");
            
        }

        private void btnAgregarClienteCabina_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string edad = txtEdad.Text;
            Enumerados.TipoTelefono tipo;
            string numeroTelefono = txtNumeroTelefono.Text;

            if(cmbTipoTelefono.SelectedItem.ToString() == "A Disco")
            {
                tipo = Enumerados.TipoTelefono.ADisco;
            }
            else
            {
                tipo = Enumerados.TipoTelefono.Teclado;
            }

            clienteCabina = new ClienteCabina(nombre,apellido,dni,edad,tipo,numeroTelefono);
            MessageBox.Show(clienteCabina.ToString());
            controlAux.AgregarClienteCabina(clienteCabina);

            this.Close();
        }
        public Controlador DevolverControlador
        {
            get { return this.controlAux; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
