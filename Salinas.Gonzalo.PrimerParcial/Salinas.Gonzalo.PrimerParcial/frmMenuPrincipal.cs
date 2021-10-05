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
            Computadora c1 = new Computadora();
            c1.Software = "Ares";
            c1.Software = "Messenger";
            c1.Juegos = "Age of Empires";
            c1.Juegos = "Counter Strike";
            c1.Perifericos = "Camara";
            controlador.AgregarPuesto(c1);
            Computadora c2 = new Computadora();
            c2.Software = "Mi Encarta";
            c2.Software = "Ares";
            c2.Software = "Messenger";
            c2.Juegos = "Age of Empires";
            c2.Juegos = "Counter Strike";

            
            c2.Perifericos = "Microfono";
            c2.Perifericos = "Camara";
            controlador.AgregarPuesto(c2);
            Computadora c3 = new Computadora();
            c3.Juegos = "Counter Strike";
            c3.Juegos = "Age of Empires";
            
            controlador.AgregarPuesto(c3);
            ClienteCabina cliCab1 = new ClienteCabina("Gonzalo","Salinas","42038608","21",Enumerados.TipoTelefono.Teclado,"111112345678");
            ClienteCabina cliCab2 = new ClienteCabina("Facundo","Cruz","40101010","23",Enumerados.TipoTelefono.Teclado,"121212345678");
            ClienteCabina cliCab3 = new ClienteCabina("Eliana","Cuervo","40123123","21",Enumerados.TipoTelefono.ADisco,"541142414903");
            ClienteCabina cliCab4 = new ClienteCabina("Hugo","Horacio","10123456","21",Enumerados.TipoTelefono.ADisco,"541220771022");
            controlador.AgregarClienteCabina(cliCab1);
            controlador.AgregarClienteCabina(cliCab2);
            controlador.AgregarClienteCabina(cliCab3);
            controlador.AgregarClienteCabina(cliCab4);
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
            
           
        }
        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarClienteComputadora_Click(object sender, EventArgs e)
        {
            @as frmClienteComputadora = new @as(controlador);
            frmClienteComputadora.ShowDialog();
            controlador = (frmClienteComputadora.DevolverControlador);
            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {

            StringBuilder clientesCabina = new StringBuilder();
            clientesCabina.AppendLine("Lista Clientes Cabina");
            if(controlador.ListaClienteCabinas.Count == 0 )
            {
                clientesCabina.AppendLine("No hay clientes cargados");
            }
            else
            {
                foreach (ClienteCabina cliente in controlador.ListaClienteCabinas)
                {
                    clientesCabina.AppendLine(cliente.ToString());
                }
                
            }
            
            StringBuilder clientesComputadora = new StringBuilder();
            clientesComputadora.AppendLine("Lista Clientes Computadora");

            if (controlador.ListaClienteComputadora.Count == 0)
            {
                clientesComputadora.AppendLine("No hay clientes cargados");
            }
            else
            {
                foreach (ClienteComputadora cliente in controlador.ListaClienteComputadora)
                {
                    clientesComputadora.AppendLine(cliente.ToString());
                }
            }
            
            MessageBox.Show(clientesCabina.ToString());
            MessageBox.Show(clientesComputadora.ToString());
        }

        private void btnCrearSesionLlamada_Click(object sender, EventArgs e)
        {
            frmSesionLlamada frmSesionLlamada = new frmSesionLlamada(controlador);
            frmSesionLlamada.ShowDialog();
            controlador = frmSesionLlamada.DevolverControlador;
        }

        private void btnCrearSesionConexion_Click(object sender, EventArgs e)
        {
            frmCrearSesionConexion frmSesionConexion = new frmCrearSesionConexion(controlador);
            frmSesionConexion.ShowDialog();
            controlador = frmSesionConexion.DevolverControlador;
        }

        private void btnCerrarSesionLlamada_Click(object sender, EventArgs e)
        {
            frmCerrarSesionLlamada frmCerrarSesionLlamada = new frmCerrarSesionLlamada(controlador);
            frmCerrarSesionLlamada.ShowDialog();
            controlador = frmCerrarSesionLlamada.DevolverControlador;
            
        }
    }
}
