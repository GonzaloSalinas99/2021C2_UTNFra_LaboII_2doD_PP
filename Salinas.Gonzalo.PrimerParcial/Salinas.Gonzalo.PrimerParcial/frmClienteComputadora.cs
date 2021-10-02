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
    public partial class frmClienteComputadora : Form
    {
        private Controlador control;
        public frmClienteComputadora(Controlador controlador)
        {

            InitializeComponent();
            this.control = controlador;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        public Controlador DevolverControlador
        {
            get { return this.control; }
        }
    }
}
