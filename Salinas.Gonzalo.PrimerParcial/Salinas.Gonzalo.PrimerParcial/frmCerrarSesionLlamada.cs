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
    }
}
