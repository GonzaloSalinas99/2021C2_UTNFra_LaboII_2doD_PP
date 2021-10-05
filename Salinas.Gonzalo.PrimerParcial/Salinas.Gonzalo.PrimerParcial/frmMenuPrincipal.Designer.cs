
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrearSesionLlamada = new System.Windows.Forms.Button();
            this.btnCrearSesionConexion = new System.Windows.Forms.Button();
            this.btnCerrarSesionLlamada = new System.Windows.Forms.Button();
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
            this.lblInformacion.Location = new System.Drawing.Point(21, 413);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 15);
            this.lblInformacion.TabIndex = 15;
            // 
            // btnAgregarClienteCabina
            // 
            this.btnAgregarClienteCabina.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarClienteCabina.Location = new System.Drawing.Point(197, 26);
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
            this.lblAgregarClienteCabina.Location = new System.Drawing.Point(21, 34);
            this.lblAgregarClienteCabina.Name = "lblAgregarClienteCabina";
            this.lblAgregarClienteCabina.Size = new System.Drawing.Size(82, 15);
            this.lblAgregarClienteCabina.TabIndex = 17;
            this.lblAgregarClienteCabina.Text = "Cliente cabina";
            // 
            // btnAgregarClienteComputadora
            // 
            this.btnAgregarClienteComputadora.Location = new System.Drawing.Point(197, 58);
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
            this.lblAgregarClienteComputadora.Location = new System.Drawing.Point(21, 66);
            this.lblAgregarClienteComputadora.Name = "lblAgregarClienteComputadora";
            this.lblAgregarClienteComputadora.Size = new System.Drawing.Size(121, 15);
            this.lblAgregarClienteComputadora.TabIndex = 20;
            this.lblAgregarClienteComputadora.Text = "Cliente Computadora";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Mostrar Clientes en Espera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCrearSesionLlamada
            // 
            this.btnCrearSesionLlamada.Location = new System.Drawing.Point(160, 138);
            this.btnCrearSesionLlamada.Name = "btnCrearSesionLlamada";
            this.btnCrearSesionLlamada.Size = new System.Drawing.Size(169, 23);
            this.btnCrearSesionLlamada.TabIndex = 22;
            this.btnCrearSesionLlamada.Text = "Crear Sesion Llamada";
            this.btnCrearSesionLlamada.UseVisualStyleBackColor = true;
            this.btnCrearSesionLlamada.Click += new System.EventHandler(this.btnCrearSesionLlamada_Click);
            // 
            // btnCrearSesionConexion
            // 
            this.btnCrearSesionConexion.Location = new System.Drawing.Point(160, 167);
            this.btnCrearSesionConexion.Name = "btnCrearSesionConexion";
            this.btnCrearSesionConexion.Size = new System.Drawing.Size(169, 23);
            this.btnCrearSesionConexion.TabIndex = 23;
            this.btnCrearSesionConexion.Text = "Crear Sesion Conexion";
            this.btnCrearSesionConexion.UseVisualStyleBackColor = true;
            this.btnCrearSesionConexion.Click += new System.EventHandler(this.btnCrearSesionConexion_Click);
            // 
            // btnCerrarSesionLlamada
            // 
            this.btnCerrarSesionLlamada.Location = new System.Drawing.Point(160, 196);
            this.btnCerrarSesionLlamada.Name = "btnCerrarSesionLlamada";
            this.btnCerrarSesionLlamada.Size = new System.Drawing.Size(169, 23);
            this.btnCerrarSesionLlamada.TabIndex = 24;
            this.btnCerrarSesionLlamada.Text = "Cerrar Sesion Llamada";
            this.btnCerrarSesionLlamada.UseVisualStyleBackColor = true;
            this.btnCerrarSesionLlamada.Click += new System.EventHandler(this.btnCerrarSesionLlamada_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.btnCerrarSesionLlamada);
            this.Controls.Add(this.btnCrearSesionConexion);
            this.Controls.Add(this.btnCrearSesionLlamada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAgregarClienteComputadora);
            this.Controls.Add(this.btnAgregarClienteComputadora);
            this.Controls.Add(this.lblAgregarClienteCabina);
            this.Controls.Add(this.btnAgregarClienteCabina);
            this.Controls.Add(this.lblInformacion);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearSesionLlamada;
        private System.Windows.Forms.Button btnCrearSesionConexion;
        private System.Windows.Forms.Button btnCerrarSesionLlamada;
    }
}

