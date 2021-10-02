using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            sb.AppendLine($"Administrador: {textBox1.Text} {textBox2.Text}");
            sb.AppendLine($"Fecha : {DateTime.Now.ToString("dd-MM-yyyy")}");
            menuPrincipal.lblInformacion.Text = sb.ToString();
            
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
