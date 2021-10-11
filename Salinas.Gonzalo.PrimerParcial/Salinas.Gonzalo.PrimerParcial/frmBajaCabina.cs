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
    public partial class frmBajaCabina : Form
    {
        Controlador control;
        public frmBajaCabina(Controlador controlador)
        {

            control = controlador;
            InitializeComponent();
        }

        private void frmBajaCabina_Load(object sender, EventArgs e)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is not null && puesto is Cabina)
                {
                    lBoxListaCabinas.Items.Add(puesto.ToString());
                }
            }
        }

        private void btnModificarCabina_Click(object sender, EventArgs e)
        {
            if(ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorCabina.Text))
            {
                Cabina cabinaAuxiliar = (Cabina)control.BuscarPuestoPorIdentificador(txtIdentificadorCabina.Text,"Cabina");
                if(cabinaAuxiliar is not null)
                {
                    control.ListaPuestos.Remove(cabinaAuxiliar);
                    lBoxListaCabinas.Items.Clear();
                    ActualizarLista(control);
                }
            }
        }
        private void ActualizarLista(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is Cabina && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxListaCabinas.Items.Add(puesto.ToString());
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
