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
    public partial class frmCerrarSesionConexion : Form
    {
        Controlador control;
        public frmCerrarSesionConexion(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }

        private void btnCerrarSesionConexion_Click(object sender, EventArgs e)
        {
            string identificador = txtIdentificadorConexion.Text;
            if (BuscarConexionIdentificador(control, identificador) is not null)
            {
                Conexion conexionAux= BuscarConexionIdentificador(control, identificador);
                MessageBox.Show(control.CerrarSesionConexion(conexionAux));
                MessageBox.Show("Se cerro sesion correctamente");
                //MessageBox.Show(Historial.MostrarHistorial());
                lBoxSesionConexion.Items.Clear();
                ActualizarListasSesiones(control);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al cerrar sesion");
            }
        }


        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Conexion BuscarConexionIdentificador(Controlador control, string identificador)
        {
            int valorIdentificador;
            if (int.TryParse(identificador, out valorIdentificador))
            {
                foreach (Sesion sesion in control.ListaSesiones)
                {
                    if (sesion is Conexion && sesion is not null)
                    {
                        if (sesion.IdSesion == valorIdentificador)
                        {
                            return (Conexion)sesion;
                        }
                    }
                }
            }
            return null;
        }

        private void frmCerrarSesionConexion_Load(object sender, EventArgs e)
        {
            foreach (Sesion item in control.ListaSesiones)
            {
                if (item is Conexion && item is not null)
                {
                    lBoxSesionConexion.Items.Add(item.ToString());
                }
            }
        }

        private void ActualizarListasSesiones(Controlador control)
        {
            foreach (Sesion sesion in control.ListaSesiones)
            {
                if (sesion is Conexion)
                {
                    lBoxSesionConexion.Items.Add(sesion);
                }
            }

        }
        public Controlador DevolverControlador
        {
            get { return this.control; }
        }
    }
}
