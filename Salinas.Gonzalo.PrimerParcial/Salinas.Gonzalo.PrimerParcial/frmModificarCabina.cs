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

                    Cabina cabinaAuxiliar = (Cabina)control.BuscarPuestoPorIdentificador(txtIdentificadorCabina.Text,"Cabina");

                    if(cabinaAuxiliar is not null)
                    {
                        int indice = control.ListaPuestos.IndexOf(cabinaAuxiliar);
                        control.ListaPuestos.RemoveAt(indice);

                        string marcaTelefono = txtMarcaTelefono.Text;
                        Enumerados.TipoTelefono tipoTelefono;
                        if(cmbTipoTelefono.Text == "A Disco")
                        {
                            tipoTelefono = Enumerados.TipoTelefono.ADisco;
                        }
                        else
                        {
                            tipoTelefono = Enumerados.TipoTelefono.Teclado;
                        }
                        cabinaAuxiliar.Marca = marcaTelefono;
                        cabinaAuxiliar.TipoTelefono = tipoTelefono;
                        control.ListaPuestos.Insert(indice, cabinaAuxiliar);
                        lBoxListaCabinas.Items.Clear();
                        ActualizarLista(control);
                        
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error con la modificacion.");
                    }
                    
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
