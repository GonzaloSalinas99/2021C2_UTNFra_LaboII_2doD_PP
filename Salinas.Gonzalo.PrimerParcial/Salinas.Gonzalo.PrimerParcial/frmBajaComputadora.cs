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
   
    public partial class frmBajaComputadora : Form
    {
        Controlador control;
        public frmBajaComputadora(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }

        private void frmBajaComputadora_Load(object sender, EventArgs e)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if(puesto is not null && puesto is Computadora)
                {
                    lBoxListaComputadora.Items.Add(puesto.ToString());
                    lBoxListaComputadora.Items.Clear();
                    ActualizarLista(control);
                }
            }
        }

        private void btnBajaComputadora_Click(object sender, EventArgs e)
        {
            if(ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorCabina.Text))
            {
                Computadora computadoraAuxiliar = (Computadora)control.BuscarPuestoPorIdentificador(txtIdentificadorCabina.Text, "Computadora");
                if(computadoraAuxiliar is not null)
                {
                    control.ListaPuestos.Remove(computadoraAuxiliar);
                    lBoxListaComputadora.Items.Clear();
                    ActualizarLista(control);
                }
            }
        }

        private void ActualizarLista(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is not null && puesto is Computadora)
                {
                    lBoxListaComputadora.Items.Add(puesto.ToString());
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
