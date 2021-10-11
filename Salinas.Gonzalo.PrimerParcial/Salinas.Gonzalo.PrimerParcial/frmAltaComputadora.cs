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
        Controlador control;
        public frmAltaComputadora(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
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
            if(control.CorroborarCantidadPuestos(computadoraAuxiliar,10) && control.AgregarPuesto(computadoraAuxiliar))
            {
                MessageBox.Show("Se agrego la computadora correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar la computadora");
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

        private void frmAltaComputadora_Load(object sender, EventArgs e)
        {

        }
    }
}
