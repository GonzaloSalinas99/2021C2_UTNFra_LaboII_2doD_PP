﻿
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnAgregarClienteCabina = new System.Windows.Forms.Button();
            this.lblAgregarClienteCabina = new System.Windows.Forms.Label();
            this.btnAgregarClienteComputadora = new System.Windows.Forms.Button();
            this.lblAgregarClienteComputadora = new System.Windows.Forms.Label();
            this.btnMostrarClientesEnEspera = new System.Windows.Forms.Button();
            this.btnCrearSesionLlamada = new System.Windows.Forms.Button();
            this.btnCrearSesionConexion = new System.Windows.Forms.Button();
            this.btnCerrarSesionLlamada = new System.Windows.Forms.Button();
            this.btnCerrarSesionConexion = new System.Windows.Forms.Button();
            this.txtNombrePuesto = new System.Windows.Forms.TextBox();
            this.lblCrearSesionLlamada = new System.Windows.Forms.Label();
            this.lblCrearSesionConexion = new System.Windows.Forms.Label();
            this.lblCerrarSesionLlamada = new System.Windows.Forms.Label();
            this.lblCerrarSesionConexion = new System.Windows.Forms.Label();
            this.btnMostrarEstadisticas = new System.Windows.Forms.Button();
            this.btnMostrarPuestos = new System.Windows.Forms.Button();
            this.lblCabinas = new System.Windows.Forms.Label();
            this.btnAgregarCabina = new System.Windows.Forms.Button();
            this.btnModificarCabina = new System.Windows.Forms.Button();
            this.btnBorrarCabina = new System.Windows.Forms.Button();
            this.btnBorrarComputadora = new System.Windows.Forms.Button();
            this.btnModificarComputadora = new System.Windows.Forms.Button();
            this.btnAgregarComputadora = new System.Windows.Forms.Button();
            this.lblComputadoras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(26, 321);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 15);
            this.lblInformacion.TabIndex = 15;
            // 
            // btnAgregarClienteCabina
            // 
            this.btnAgregarClienteCabina.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarClienteCabina.Location = new System.Drawing.Point(191, 141);
            this.btnAgregarClienteCabina.Name = "btnAgregarClienteCabina";
            this.btnAgregarClienteCabina.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClienteCabina.TabIndex = 16;
            this.btnAgregarClienteCabina.Text = "Agregar";
            this.btnAgregarClienteCabina.UseVisualStyleBackColor = true;
            this.btnAgregarClienteCabina.Click += new System.EventHandler(this.btnAgregarClienteCabina_Click);
            // 
            // lblAgregarClienteCabina
            // 
            this.lblAgregarClienteCabina.AutoSize = true;
            this.lblAgregarClienteCabina.Location = new System.Drawing.Point(15, 149);
            this.lblAgregarClienteCabina.Name = "lblAgregarClienteCabina";
            this.lblAgregarClienteCabina.Size = new System.Drawing.Size(82, 15);
            this.lblAgregarClienteCabina.TabIndex = 17;
            this.lblAgregarClienteCabina.Text = "Cliente cabina";
            // 
            // btnAgregarClienteComputadora
            // 
            this.btnAgregarClienteComputadora.Location = new System.Drawing.Point(706, 141);
            this.btnAgregarClienteComputadora.Name = "btnAgregarClienteComputadora";
            this.btnAgregarClienteComputadora.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClienteComputadora.TabIndex = 19;
            this.btnAgregarClienteComputadora.Text = "Agregar";
            this.btnAgregarClienteComputadora.UseVisualStyleBackColor = true;
            this.btnAgregarClienteComputadora.Click += new System.EventHandler(this.btnAgregarClienteComputadora_Click);
            // 
            // lblAgregarClienteComputadora
            // 
            this.lblAgregarClienteComputadora.AutoSize = true;
            this.lblAgregarClienteComputadora.Location = new System.Drawing.Point(544, 145);
            this.lblAgregarClienteComputadora.Name = "lblAgregarClienteComputadora";
            this.lblAgregarClienteComputadora.Size = new System.Drawing.Size(121, 15);
            this.lblAgregarClienteComputadora.TabIndex = 20;
            this.lblAgregarClienteComputadora.Text = "Cliente Computadora";
            // 
            // btnMostrarClientesEnEspera
            // 
            this.btnMostrarClientesEnEspera.Location = new System.Drawing.Point(315, 114);
            this.btnMostrarClientesEnEspera.Name = "btnMostrarClientesEnEspera";
            this.btnMostrarClientesEnEspera.Size = new System.Drawing.Size(167, 50);
            this.btnMostrarClientesEnEspera.TabIndex = 21;
            this.btnMostrarClientesEnEspera.Text = "Mostrar Clientes en Espera";
            this.btnMostrarClientesEnEspera.UseVisualStyleBackColor = true;
            this.btnMostrarClientesEnEspera.Click += new System.EventHandler(this.btnMostrarClientesEnEspera_Click);
            // 
            // btnCrearSesionLlamada
            // 
            this.btnCrearSesionLlamada.Location = new System.Drawing.Point(191, 181);
            this.btnCrearSesionLlamada.Name = "btnCrearSesionLlamada";
            this.btnCrearSesionLlamada.Size = new System.Drawing.Size(75, 23);
            this.btnCrearSesionLlamada.TabIndex = 22;
            this.btnCrearSesionLlamada.Text = "Crear";
            this.btnCrearSesionLlamada.UseVisualStyleBackColor = true;
            this.btnCrearSesionLlamada.Click += new System.EventHandler(this.btnCrearSesionLlamada_Click);
            // 
            // btnCrearSesionConexion
            // 
            this.btnCrearSesionConexion.Location = new System.Drawing.Point(706, 181);
            this.btnCrearSesionConexion.Name = "btnCrearSesionConexion";
            this.btnCrearSesionConexion.Size = new System.Drawing.Size(75, 23);
            this.btnCrearSesionConexion.TabIndex = 23;
            this.btnCrearSesionConexion.Text = "Crear";
            this.btnCrearSesionConexion.UseVisualStyleBackColor = true;
            this.btnCrearSesionConexion.Click += new System.EventHandler(this.btnCrearSesionConexion_Click);
            // 
            // btnCerrarSesionLlamada
            // 
            this.btnCerrarSesionLlamada.Location = new System.Drawing.Point(191, 222);
            this.btnCerrarSesionLlamada.Name = "btnCerrarSesionLlamada";
            this.btnCerrarSesionLlamada.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarSesionLlamada.TabIndex = 24;
            this.btnCerrarSesionLlamada.Text = "Cerrar";
            this.btnCerrarSesionLlamada.UseVisualStyleBackColor = true;
            this.btnCerrarSesionLlamada.Click += new System.EventHandler(this.btnCerrarSesionLlamada_Click);
            // 
            // btnCerrarSesionConexion
            // 
            this.btnCerrarSesionConexion.Location = new System.Drawing.Point(706, 218);
            this.btnCerrarSesionConexion.Name = "btnCerrarSesionConexion";
            this.btnCerrarSesionConexion.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarSesionConexion.TabIndex = 25;
            this.btnCerrarSesionConexion.Text = "Cerrar";
            this.btnCerrarSesionConexion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrarSesionConexion.UseVisualStyleBackColor = true;
            this.btnCerrarSesionConexion.Click += new System.EventHandler(this.btnCerrarSesionConexion_Click);
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.Location = new System.Drawing.Point(315, 12);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(167, 23);
            this.txtNombrePuesto.TabIndex = 27;
            // 
            // lblCrearSesionLlamada
            // 
            this.lblCrearSesionLlamada.AutoSize = true;
            this.lblCrearSesionLlamada.Location = new System.Drawing.Point(15, 189);
            this.lblCrearSesionLlamada.Name = "lblCrearSesionLlamada";
            this.lblCrearSesionLlamada.Size = new System.Drawing.Size(120, 15);
            this.lblCrearSesionLlamada.TabIndex = 28;
            this.lblCrearSesionLlamada.Text = "Crear Sesion Llamada";
            // 
            // lblCrearSesionConexion
            // 
            this.lblCrearSesionConexion.AutoSize = true;
            this.lblCrearSesionConexion.Location = new System.Drawing.Point(544, 185);
            this.lblCrearSesionConexion.Name = "lblCrearSesionConexion";
            this.lblCrearSesionConexion.Size = new System.Drawing.Size(126, 15);
            this.lblCrearSesionConexion.TabIndex = 29;
            this.lblCrearSesionConexion.Text = "Crear Sesion Conexion";
            // 
            // lblCerrarSesionLlamada
            // 
            this.lblCerrarSesionLlamada.AutoSize = true;
            this.lblCerrarSesionLlamada.Location = new System.Drawing.Point(16, 226);
            this.lblCerrarSesionLlamada.Name = "lblCerrarSesionLlamada";
            this.lblCerrarSesionLlamada.Size = new System.Drawing.Size(124, 15);
            this.lblCerrarSesionLlamada.TabIndex = 30;
            this.lblCerrarSesionLlamada.Text = "Cerrar Sesion Llamada";
            // 
            // lblCerrarSesionConexion
            // 
            this.lblCerrarSesionConexion.AutoSize = true;
            this.lblCerrarSesionConexion.Location = new System.Drawing.Point(544, 226);
            this.lblCerrarSesionConexion.Name = "lblCerrarSesionConexion";
            this.lblCerrarSesionConexion.Size = new System.Drawing.Size(130, 15);
            this.lblCerrarSesionConexion.TabIndex = 31;
            this.lblCerrarSesionConexion.Text = "Cerrar Sesion Conexion";
            // 
            // btnMostrarEstadisticas
            // 
            this.btnMostrarEstadisticas.Location = new System.Drawing.Point(315, 195);
            this.btnMostrarEstadisticas.Name = "btnMostrarEstadisticas";
            this.btnMostrarEstadisticas.Size = new System.Drawing.Size(167, 50);
            this.btnMostrarEstadisticas.TabIndex = 32;
            this.btnMostrarEstadisticas.Text = "Mostrar Estadisticas ";
            this.btnMostrarEstadisticas.UseVisualStyleBackColor = true;
            this.btnMostrarEstadisticas.Click += new System.EventHandler(this.btnMostrarEstadisticas_Click);
            // 
            // btnMostrarPuestos
            // 
            this.btnMostrarPuestos.Location = new System.Drawing.Point(315, 41);
            this.btnMostrarPuestos.Name = "btnMostrarPuestos";
            this.btnMostrarPuestos.Size = new System.Drawing.Size(167, 31);
            this.btnMostrarPuestos.TabIndex = 33;
            this.btnMostrarPuestos.Text = "Mostrar Puestos";
            this.btnMostrarPuestos.UseVisualStyleBackColor = true;
            this.btnMostrarPuestos.Click += new System.EventHandler(this.btnMostrarPuestos_Click);
            // 
            // lblCabinas
            // 
            this.lblCabinas.AutoSize = true;
            this.lblCabinas.Location = new System.Drawing.Point(85, 20);
            this.lblCabinas.Name = "lblCabinas";
            this.lblCabinas.Size = new System.Drawing.Size(56, 15);
            this.lblCabinas.TabIndex = 34;
            this.lblCabinas.Text = "CABINAS";
            // 
            // btnAgregarCabina
            // 
            this.btnAgregarCabina.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarCabina.Location = new System.Drawing.Point(12, 49);
            this.btnAgregarCabina.Name = "btnAgregarCabina";
            this.btnAgregarCabina.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCabina.TabIndex = 35;
            this.btnAgregarCabina.Text = "Agregar";
            this.btnAgregarCabina.UseVisualStyleBackColor = true;
            this.btnAgregarCabina.Click += new System.EventHandler(this.btnAgregarCabina_Click);
            // 
            // btnModificarCabina
            // 
            this.btnModificarCabina.Location = new System.Drawing.Point(93, 49);
            this.btnModificarCabina.Name = "btnModificarCabina";
            this.btnModificarCabina.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCabina.TabIndex = 36;
            this.btnModificarCabina.Text = "Modificar";
            this.btnModificarCabina.UseVisualStyleBackColor = true;
            this.btnModificarCabina.Click += new System.EventHandler(this.btnModificarCabina_Click);
            // 
            // btnBorrarCabina
            // 
            this.btnBorrarCabina.Location = new System.Drawing.Point(174, 49);
            this.btnBorrarCabina.Name = "btnBorrarCabina";
            this.btnBorrarCabina.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCabina.TabIndex = 37;
            this.btnBorrarCabina.Text = "Borrar";
            this.btnBorrarCabina.UseVisualStyleBackColor = true;
            this.btnBorrarCabina.Click += new System.EventHandler(this.btnBorrarCabina_Click);
            // 
            // btnBorrarComputadora
            // 
            this.btnBorrarComputadora.Location = new System.Drawing.Point(706, 45);
            this.btnBorrarComputadora.Name = "btnBorrarComputadora";
            this.btnBorrarComputadora.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarComputadora.TabIndex = 42;
            this.btnBorrarComputadora.Text = "Borrar";
            this.btnBorrarComputadora.UseVisualStyleBackColor = true;
            this.btnBorrarComputadora.Click += new System.EventHandler(this.btnBorrarComputadora_Click);
            // 
            // btnModificarComputadora
            // 
            this.btnModificarComputadora.Location = new System.Drawing.Point(625, 45);
            this.btnModificarComputadora.Name = "btnModificarComputadora";
            this.btnModificarComputadora.Size = new System.Drawing.Size(75, 23);
            this.btnModificarComputadora.TabIndex = 41;
            this.btnModificarComputadora.Text = "Modificar";
            this.btnModificarComputadora.UseVisualStyleBackColor = true;
            this.btnModificarComputadora.Click += new System.EventHandler(this.btnModificarComputadora_Click);
            // 
            // btnAgregarComputadora
            // 
            this.btnAgregarComputadora.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarComputadora.Location = new System.Drawing.Point(544, 45);
            this.btnAgregarComputadora.Name = "btnAgregarComputadora";
            this.btnAgregarComputadora.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarComputadora.TabIndex = 40;
            this.btnAgregarComputadora.Text = "Agregar";
            this.btnAgregarComputadora.UseVisualStyleBackColor = true;
            this.btnAgregarComputadora.Click += new System.EventHandler(this.btnAgregarComputadora_Click);
            // 
            // lblComputadoras
            // 
            this.lblComputadoras.AutoSize = true;
            this.lblComputadoras.Location = new System.Drawing.Point(617, 16);
            this.lblComputadoras.Name = "lblComputadoras";
            this.lblComputadoras.Size = new System.Drawing.Size(101, 15);
            this.lblComputadoras.TabIndex = 39;
            this.lblComputadoras.Text = "COMPUTADORAS";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 381);
            this.Controls.Add(this.btnBorrarComputadora);
            this.Controls.Add(this.btnModificarComputadora);
            this.Controls.Add(this.btnAgregarComputadora);
            this.Controls.Add(this.lblComputadoras);
            this.Controls.Add(this.btnBorrarCabina);
            this.Controls.Add(this.btnModificarCabina);
            this.Controls.Add(this.btnAgregarCabina);
            this.Controls.Add(this.lblCabinas);
            this.Controls.Add(this.btnMostrarPuestos);
            this.Controls.Add(this.btnMostrarEstadisticas);
            this.Controls.Add(this.lblCerrarSesionConexion);
            this.Controls.Add(this.lblCerrarSesionLlamada);
            this.Controls.Add(this.lblCrearSesionConexion);
            this.Controls.Add(this.lblCrearSesionLlamada);
            this.Controls.Add(this.txtNombrePuesto);
            this.Controls.Add(this.btnCerrarSesionConexion);
            this.Controls.Add(this.btnCerrarSesionLlamada);
            this.Controls.Add(this.btnCrearSesionConexion);
            this.Controls.Add(this.btnCrearSesionLlamada);
            this.Controls.Add(this.btnMostrarClientesEnEspera);
            this.Controls.Add(this.lblAgregarClienteComputadora);
            this.Controls.Add(this.btnAgregarClienteComputadora);
            this.Controls.Add(this.lblAgregarClienteCabina);
            this.Controls.Add(this.btnAgregarClienteCabina);
            this.Controls.Add(this.lblInformacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLoginAdministrador;
        public System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnAgregarClienteCabina;
        private System.Windows.Forms.Label lblAgregarClienteCabina;
        private System.Windows.Forms.Button btnAgregarClienteComputadora;
        private System.Windows.Forms.Label lblAgregarClienteComputadora;
        private System.Windows.Forms.Button btnMostrarClientesEnEspera;
        private System.Windows.Forms.Button btnCrearSesionLlamada;
        private System.Windows.Forms.Button btnCrearSesionConexion;
        private System.Windows.Forms.Button btnCerrarSesionLlamada;
        private System.Windows.Forms.Button btnCerrarSesionConexion;
        private System.Windows.Forms.TextBox txtNombrePuesto;
        private System.Windows.Forms.Label lblCrearSesionLlamada;
        private System.Windows.Forms.Label lblCrearSesionConexion;
        private System.Windows.Forms.Label lblCerrarSesionLlamada;
        private System.Windows.Forms.Label lblCerrarSesionConexion;
        private System.Windows.Forms.Button btnMostrarEstadisticas;
        private System.Windows.Forms.Button btnMostrarPuestos;
        private System.Windows.Forms.Label lblCabinas;
        private System.Windows.Forms.Button btnAgregarCabina;
        private System.Windows.Forms.Button btnModificarCabina;
        private System.Windows.Forms.Button btnBorrarCabina;
        private System.Windows.Forms.Button btnBorrarComputadora;
        private System.Windows.Forms.Button btnModificarComputadora;
        private System.Windows.Forms.Button btnAgregarComputadora;
        private System.Windows.Forms.Label lblComputadoras;
    }
}

