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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string apellido= textBox2.Text;
            string dni= textBox3.Text;
            string edad = textBox4.Text;


            //Crear Cliente
            ClienteCabina cl1 = new ClienteCabina("Gonzalo", "Salinas", "42038608", "21",Enumerados.TipoTelefono.Teclado,"541142414903","PHILIPS");
            //List<Cliente> listaClientes = new List<Cliente>();

            richTextBox1.Text = cl1.ToString();
            
            
            //listaClientes.Add(cl1);

            //Cabina cab1 = new Cabina("PHILIPS", Enumerados.TipoTelefono.Teclado);

            //Llamada llam = new Llamada("541142414903", cl1, cab1);


            //foreach (Cliente aux in listaClientes)
            //{
            //    richTextBox1.Text = $"{aux.mostrar()}";
            //    richTextBox1.Text =  cab1.ToString();
            //    richTextBox1.Text = llam.ToString();
            //}
            
            
            //Computadora compu = new Computadora();

            //foreach (Control c in groupBox1.Controls)
            //{
            //    if(checkBox2.Checked== true )
            //    {
            //        compu.Hadware = checkBox2.Text;
            //    }


            //    if (checkBox3.Checked == true)
            //    {
            //        compu.Hadware=checkBox3.Text;
            //    }
            //    if (checkBox4.Checked == true)
            //    {
            //        compu.Hadware=checkBox4.Text;
            //    }
            //}

            ////compu.AGREGARHADWARE("PLACA VIDEO");
            ////compu.AGREGARHADWARE("INTERNET");
            ////compu.AGREGARHADWARE("RAM");
            //MessageBox.Show(compu.MostrarCompu());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Computadora> listaComputadoras = new List<Computadora>();
            
            List<string> hadware = new List<string>();
            List<string> software= new List<string>();
            List<string> juegos = new List<string>();
            List<string> perifericos = new List<string>();

    

            Computadora aux = new Computadora();
            aux.CargarHadware("PLACA VIDEO", "INTERNET", "RAM");
            aux.CargarSoftware("MESSENGER", "ARES", "");
            aux.CargarJuegos("AGE OF EMPIRES", "COUNTER STRIKE", "MU");
            aux.CargarPerifericos("cAMARA", "MICROFONO", "");
            listaComputadoras.Add(aux);

            Computadora aux2 = new Computadora();
            aux2.CargarHadware("", "", "RAM");
            aux2.CargarSoftware("MESSENGER", "", "");
            aux2.CargarJuegos("AGE OF EMPIRES", "DIABLO II", "MU");
            aux2.CargarPerifericos("", "", "AURICULARES");
            listaComputadoras.Add(aux2);


            foreach (Computadora c in listaComputadoras)
            {
                if(c is not null)
                {
                    MessageBox.Show( c.MostrarCompu());
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
