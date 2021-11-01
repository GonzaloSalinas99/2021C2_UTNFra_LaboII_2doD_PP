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
    public partial class frmModificarComputadora : Form
    {
        /// <summary>
        /// Variable donde se van a guardar las acciones realizadas en el formulario.
        /// </summary>
        Controlador control;
        /// <summary>
        /// Constructor de ModificarComputadora
        /// </summary>
        /// <param name="controlador">controlador a asignar a la variable local control</param>
        public frmModificarComputadora(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }
        /// <summary>
        /// Modifica los datos de la cabina seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarComputadora_Click(object sender, EventArgs e)
        {
            if (ValidadorDeInformacion.ValidarStringTexto(txtIdentificadorCabina.Text))
            {
                Computadora computadoraAuxiliar = (Computadora)control.BuscarPuestoPorIdentificador(txtIdentificadorCabina.Text, "Computadora");
                Computadora computadoraAGuardar = new Computadora();
                if (computadoraAuxiliar is not null)
                {
                    int indice = control.ListaPuestos.IndexOf(computadoraAuxiliar);
                    control.ListaPuestos.RemoveAt(indice);

                    foreach (Control item in gBoxHadware.Controls)
                    {
                        if (item is CheckBox && ((CheckBox)item).Checked)
                        {
                            computadoraAGuardar.Hadware = ((CheckBox)item).Text;

                        }
                    }
                    foreach (Control item in gBoxSoftware.Controls)
                    {
                        if (item is CheckBox && ((CheckBox)item).Checked)
                        {
                            computadoraAGuardar.Software = ((CheckBox)item).Text;

                        }
                    }

                    foreach (Control item in gBoxJuegos.Controls)
                    {
                        if (item is CheckBox && ((CheckBox)item).Checked)
                        {
                            computadoraAGuardar.Juegos = ((CheckBox)item).Text;
                        }
                    }

                    foreach (Control item in gBoxPerifericos.Controls)
                    {
                        if (item is CheckBox && ((CheckBox)item).Checked)
                        {
                            computadoraAGuardar.Perifericos = ((CheckBox)item).Text;
                        }
                    }
                    computadoraAGuardar.IdPuesto = computadoraAuxiliar.IdPuesto;
                    control.ListaPuestos.Insert(indice, computadoraAGuardar);
                    lBoxListaComputadora.Items.Clear();
                    ActualizarLista(control);
                }
                else
                {
                    MessageBox.Show("No se encontro la computadora por su identificador.");

                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un identificador de computadora.");
            }
        }

        /// <summary>
        /// Carga los datos al ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModificarComputadora_Load(object sender, EventArgs e)
        {
            ActualizarLista(control);
        }
        /// <summary>
        /// Ingresa los datos de las computadoras al ListBox
        /// </summary>
        /// <param name="control"></param>
        private void ActualizarLista(Controlador control)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is Computadora && puesto.EstadoPuesto == Enumerados.EstadoPuesto.SinUso)
                {
                    lBoxListaComputadora.Items.Add(puesto.ToString());
                }
            }

        }
        /// <summary>
        /// Propiedad DevolverControlador de lectura. Retorna el controlador local.
        /// </summary>
        public Controlador DevolverControlador
        {
            get { return this.control; }
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Indica al usuario que pasos tiene que hacer para modiflcar la computadora correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAYUDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ingrese el identificador de la computadora y seleccione las especificaciones que va a modificar de la computadora, tanto como HADWARE,SOFTWARE,JUEGOS y PERIFERICOS" +
                ". Luego presione el boton ModificarComputadora para modificar la computadora en la lista de computadoras. Volver lo regresara al menu principal", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
