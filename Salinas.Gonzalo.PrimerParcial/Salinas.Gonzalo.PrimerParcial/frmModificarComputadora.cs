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
        Controlador control;
        public frmModificarComputadora(Controlador controlador)
        {
            InitializeComponent();
            control = controlador;
        }

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
            }
        }


        private void frmModificarComputadora_Load(object sender, EventArgs e)
        {
            foreach (Puesto puesto in control.ListaPuestos)
            {
                if (puesto is not null && puesto is Computadora)
                {
                    lBoxListaComputadora.Items.Add(puesto.ToString());
                }
            }
        }

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
        public Controlador DevolverControlador
        {
            get { return this.control; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
