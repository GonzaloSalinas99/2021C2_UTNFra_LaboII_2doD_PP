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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void btnIngresarAdministrador_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            StringBuilder sb = new StringBuilder();
            if(ValidadorDeInformacion.ValidarStringTexto(txtNombreAdministrador.Text) == false || ValidadorDeInformacion.ValidarStringTexto(txtApellidoAdministrador.Text) == false)
            {
                MessageBox.Show("Tiene que ingresar un nombre y un apellido", "Error de ingreso");
            }
            else
            {
                sb.AppendLine($"Administrador: {txtNombreAdministrador.Text} {txtApellidoAdministrador.Text}");
                sb.AppendLine($"Fecha : {DateTime.Now.ToString("dd-MM-yyyy")}");
                menuPrincipal.lblInformacion.Text = sb.ToString();

                menuPrincipal.Show();
                this.Hide();
            }
            
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese el nombre y apellido, luego presione el boton Login para logearse e ingresar al programa","Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
