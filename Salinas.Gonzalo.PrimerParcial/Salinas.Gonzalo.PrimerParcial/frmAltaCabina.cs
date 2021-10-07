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
        Controlador control;
        public frmAltaCabina(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }

        private void AltaCabina_Load(object sender, EventArgs e)
        {
            cmbTipoTelefono.Items.Add("A Disco");
            cmbTipoTelefono.Items.Add("Teclado");
        }

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
        public Controlador DevolverControlador
        {
            get { return this.control; }
        }

        private void btnvolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
