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
    public partial class frmModificarCabina : Form
    {
        private Controlador control;
        public frmModificarCabina(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }

        private void frmModificarCabina_Load(object sender, EventArgs e)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if(puesto is not null && puesto is Cabina)
                {
                    lBoxListaCabinas.Items.Add(puesto.ToString());
                }
            }

            cmbTipoTelefono.Items.Add("A Disco");
            cmbTipoTelefono.Items.Add("Teclado");
        }

        private void btnAgregarCabina_Click(object sender, EventArgs e)
        {
            if(ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorCabina.Text))
            {
                if(ValidadorDeInformacion.ValidarStringTexto(txtMarcaTelefono.Text) && ValidadorDeInformacion.ValidarStringTexto(cmbTipoTelefono.Text))
                {

                    Cabina cabinaAuxiliar = control.BuscarCabinaIdentificador(txtIdentificadorCabina.Text);
                    if(cabinaAuxiliar is not null)
                    {

                    }
                }
            }
        }
    }
}
