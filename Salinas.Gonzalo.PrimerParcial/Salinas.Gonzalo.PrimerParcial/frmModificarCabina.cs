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
    public partial class frmModificarCabina : Form
    {
        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de ModificarCabina
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmModificarCabina(Controlador controlador)
        {
            control = controlador;
            InitializeComponent();
        }
        /// <summary>
        /// Carga los datos al ListBox y Le agrega items al ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModificarCabina_Load(object sender, EventArgs e)
        {

            ActualizarLista(control);
            cmbTipoTelefono.Items.Add("A Disco");
            cmbTipoTelefono.Items.Add("Teclado");
        }
        /// <summary>
        /// Modifica los datos de la cabina seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCabina_Click(object sender, EventArgs e)
        {
            if(ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorCabina.Text))
            {
                if(ValidadorDeInformacion.ValidarStringTexto(txtMarcaTelefono.Text) && ValidadorDeInformacion.ValidarStringTexto(cmbTipoTelefono.Text))
                {

                    Cabina cabinaAuxiliar = (Cabina)control.BuscarPuestoPorIdentificador(txtIdentificadorCabina.Text,"Cabina");

                    if(cabinaAuxiliar is not null)
                    {
                        int indice = control.ListaPuestos.IndexOf(cabinaAuxiliar);
                        control.ListaPuestos.RemoveAt(indice);

                        string marcaTelefono = txtMarcaTelefono.Text;
                        Enumerados.TipoTelefono tipoTelefono;
                        if(cmbTipoTelefono.Text == "A Disco")
                        {
                            tipoTelefono = Enumerados.TipoTelefono.ADisco;
                        }
                        else
                        {
                            tipoTelefono = Enumerados.TipoTelefono.Teclado;
                        }
                        cabinaAuxiliar.Marca = marcaTelefono;
                        cabinaAuxiliar.TipoTelefono = tipoTelefono;
                        control.ListaPuestos.Insert(indice, cabinaAuxiliar);
                        lBoxListaCabinas.Items.Clear();
                        ActualizarLista(control);
                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontro la cabina por su identificador.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe ingresar datos en los campos para modificar la cabina correctamente.");

                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un identificador de cabina.");

            }
        }
        /// <summary>
        /// Ingresa los datos de las cabinas al listBox
        /// </summary>
        /// <param name="control"></param>
        private void ActualizarLista(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is Cabina && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxListaCabinas.Items.Add(puesto.ToString());
                }
            }

        }
        /// <summary>
        /// Propiedad DevolverControlador de lectura. Retorna el controlador local
        /// </summary>
        public Controlador DevolverControlador
        {
            get { return this.control; }
        }
        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnvolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario los pasos que tiene que hacer para crear la sesion correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lea la lista de cabinas que se encuentran logueadas,ingrese el identificador de la cabina a modificar,la marca y el tipo del telefono que quiere cargarle" +
                ", luego presione el boton ModificarCabina para modificarla. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
