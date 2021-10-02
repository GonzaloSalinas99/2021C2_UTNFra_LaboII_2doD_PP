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
    public partial class frmMenuPrincipal : Form
    {
        Controlador controlador;
        public frmMenuPrincipal()
        {
            controlador = new Controlador();
            controlador.AgregarPuesto(new Cabina("PHILIPS", Enumerados.TipoTelefono.Teclado));
            controlador.AgregarPuesto(new Cabina("PHILIPS", Enumerados.TipoTelefono.ADisco));
            controlador.AgregarPuesto(new Cabina("TELECOM", Enumerados.TipoTelefono.ADisco));
            controlador.AgregarPuesto(new Cabina("SANYO", Enumerados.TipoTelefono.Teclado));
            controlador.AgregarPuesto(new Cabina("TLC", Enumerados.TipoTelefono.Teclado));
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string nombre = textBox1.Text;
            //string apellido= textBox2.Text;
            //string dni= textBox3.Text;
            //string edad = textBox4.Text;
            //ClienteComputadora cl2 = new ClienteComputadora("FACUNDO", "SALINAS", "40293029","24");
            //cl2.JuegosCliente = "Counter Strike";
            //cl2.JuegosCliente = "Age of Empire";
            //cl2.JuegosCliente = "MU";
            //cl2.PerifericosCliente = "Camara";
            //cl2.SoftwareCliente = "Messenger";
            //cl2.SoftwareCliente = "Mi Encarta";

            //Computadora comp1 = new Computadora();

            //comp1.CargarJuegos("Counter Strike","Age of Empire","MU");
            //comp1.CargarPerifericos("Camara","","");
            //comp1.CargarSoftware("Messenger","Mi Encarta","");
            ////Crear cabina
            //Cabina cab1 = new Cabina("PHILIPS", Enumerados.TipoTelefono.Teclado);
            ////Crear Cliente
            //ClienteCabina cl1 = new ClienteCabina("Gonzalo", "Salinas", "42038608", "21",Enumerados.TipoTelefono.ADisco,"441142414903");

            //controlador.AgregarClienteComputadora(cl2);
            //controlador.AbrirSesionConexion(cl2,comp1);
            //richTextBox1.Text = controlador.MostrarSesionConexion().ToString();
            
            //////agrego el cliente a la lista
            ////controlador.AgregarClienteCabina(cl1);
            //////abro sesion de llamada con cliente y cabina
            ////controlador.AbrirSesionLlamada(cl1, cab1).ToString();
            //////recorro las sesiones y las cierro


            ////richTextBox1.Text = controlador.MostrarSesionLlamada().ToString();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void btnAgregarClienteCabina_Click(object sender, EventArgs e)
        {
            frmClienteCabina frmClienteCabina = new frmClienteCabina(controlador);
            frmClienteCabina.ShowDialog();
            controlador= (frmClienteCabina.DevolverControlador);
            foreach (ClienteCabina Cliente in controlador.ListaClienteCabinas)
            {
                if (Cliente is ClienteCabina && Cliente is not null)
                {
                    listBox1.Items.Add(Cliente.ToString());
                }
            }            
        }
        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarClienteComputadora_Click(object sender, EventArgs e)
        {
            frmClienteComputadora frmClienteComputadora = new frmClienteComputadora(controlador);
            frmClienteComputadora.ShowDialog();
        }
    }
}
