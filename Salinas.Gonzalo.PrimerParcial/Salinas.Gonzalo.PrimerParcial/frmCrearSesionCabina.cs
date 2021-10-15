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
    public partial class frmSesionLlamada : Form
    {

        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de CerrarSesionConexion
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmSesionLlamada(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }
        /// <summary>
        /// Carga los dos listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSesionLlamada_Load(object sender, EventArgs e)
        {
            ActualizarListasClienteCabina(control);
        }

        /// <summary>
        /// Crea una sesion entre cliente y telefono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearSesionLlamada_Click(object sender, EventArgs e)
        {
            if(ValidadorDeInformacion.ValidarStringTexto(txtDocumentoCliente.Text) && ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorCabina.Text))
            {
                ClienteCabina clienteAuxiliar;
                Cabina cabinaAuxiliar;
                string documento = txtDocumentoCliente.Text;
                string identificador = txtIdentificadorCabina.Text;
                cabinaAuxiliar = (Cabina)control.BuscarPuestoPorIdentificador(identificador,"Cabina");
                clienteAuxiliar = (ClienteCabina)control.BuscarClienteDocumento(documento,"Cabina");


                if (clienteAuxiliar is not null && clienteAuxiliar.Dni == documento && cabinaAuxiliar is not null && cabinaAuxiliar.IdPuesto == identificador)
                {
                    if (control.AbrirSesionLlamada(clienteAuxiliar, cabinaAuxiliar))
                    {
                        control.ListaClienteCabinas.Dequeue();
                        MessageBox.Show("Se inicio la sesion correctamente", "Inicio Sesion");
                        lBoxCabinas.Items.Clear();
                        lBoxClientes.Items.Clear();
                        ActualizarListasClienteCabina(control);
                    }
                    else
                    {
                        MessageBox.Show("Error con el identificador de la cabina. Reingrese el identificador", "Error de informacion");
                    }
                }
                else
                {
                    MessageBox.Show("Error con la asignacion de cabina. Asegurese que el documento coincida con el primer cliente o que haya clientes cargados", "Error de informacion");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar datos en todos los campos.");
            }


        }

        private void ActualizarListasClienteCabina(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if(puesto is Cabina && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxCabinas.Items.Add(puesto);
                }
            }
            foreach (ClienteCabina cliente in control.ListaClienteCabinas)
            {
                if (cliente is ClienteCabina && cliente.EstadoCliente == Enumerados.EstadoCliente.Esperando)
                {
                    lBoxClientes.Items.Add(cliente);
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

        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Lea tanto la lista de clientes, como la de computadoras. Ingrese el numero de documento e identificador de la cabina. SI O SI PARA CREAR LA SESION, EL CLIENTE Y LA CABINA TIENEN QUE TENER LAS MISMAS ESPECIFICACIONES(TIPO DE TELEFONO). " +
                "Luego presione el boton CrearSesion para crear la sesion entre el cliente y la cabina. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
