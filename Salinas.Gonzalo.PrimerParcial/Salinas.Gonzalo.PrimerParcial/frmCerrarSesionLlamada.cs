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
    public partial class frmCerrarSesionLlamada : Form
    {
        Controlador control;
        public frmCerrarSesionLlamada(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }

        private void btnCerrarSesionLlamada_Click(object sender, EventArgs e)
        {
            string identificador = txtIdentificadorLlamada.Text;
            if(BuscarLlamadaIdentificador(control,identificador) is not null)
            {
                Llamada llamadaAux = BuscarLlamadaIdentificador(control, identificador);
                MessageBox.Show(control.CerrarSesionTelefono(llamadaAux));
                MessageBox.Show("Se cerro sesion correctamente");
                //MessageBox.Show(Historial.MostrarHistorial());
                lBoxLlamadas.Items.Clear();
                ActualizarListasSesiones(control);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al cerrar sesion");
            }

        }

        private void frmCerrarSesionLlamada_Load(object sender, EventArgs e)
        {
            foreach (Sesion item in control.ListaSesiones)
            {
                if(item is Llamada && item is not null)
                {
                    lBoxLlamadas.Items.Add(item.ToString());
                }
            }
        }

        private Llamada BuscarLlamadaIdentificador(Controlador control, string identificador)
        {
            int valorIdentificador;
            if(int.TryParse(identificador,out valorIdentificador))
            {
                foreach (Sesion sesion in control.ListaSesiones)
                {
                    if (sesion is Llamada && sesion is not null)
                    {
                        if (sesion.IdSesion == valorIdentificador )
                        {
                            return (Llamada)sesion;
                        }
                    }
                }
            }
            
            return null;
        }

        private void ActualizarListasSesiones(Controlador control)
        {
            foreach (Sesion sesion in control.ListaSesiones)
            {
                if (sesion is Llamada)
                {
                    lBoxLlamadas.Items.Add(sesion);
                }
            }
            
        }
        public Controlador DevolverControlador
        {
            get { return this.control; }
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
