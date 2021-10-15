
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmSesionLlamada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBoxClientes = new System.Windows.Forms.ListBox();
            this.lBoxCabinas = new System.Windows.Forms.ListBox();
            this.btnCrearSesionLlamada = new System.Windows.Forms.Button();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.txtIdentificadorCabina = new System.Windows.Forms.TextBox();
            this.lblDocumentoCliente = new System.Windows.Forms.Label();
            this.lblIdentificadorCabina = new System.Windows.Forms.Label();
            this.lblClienteEncontrado = new System.Windows.Forms.Label();
            this.lblCabinaEncontrada = new System.Windows.Forms.Label();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.btnAYUDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxClientes
            // 
            this.lBoxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxClientes.FormattingEnabled = true;
            this.lBoxClientes.ItemHeight = 15;
            this.lBoxClientes.Location = new System.Drawing.Point(11, 8);
            this.lBoxClientes.Name = "lBoxClientes";
            this.lBoxClientes.Size = new System.Drawing.Size(1141, 109);
            this.lBoxClientes.TabIndex = 0;
            // 
            // lBoxCabinas
            // 
            this.lBoxCabinas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxCabinas.FormattingEnabled = true;
            this.lBoxCabinas.ItemHeight = 15;
            this.lBoxCabinas.Location = new System.Drawing.Point(11, 132);
            this.lBoxCabinas.Name = "lBoxCabinas";
            this.lBoxCabinas.Size = new System.Drawing.Size(1141, 124);
            this.lBoxCabinas.TabIndex = 1;
            // 
            // btnCrearSesionLlamada
            // 
            this.btnCrearSesionLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearSesionLlamada.Location = new System.Drawing.Point(1047, 318);
            this.btnCrearSesionLlamada.Name = "btnCrearSesionLlamada";
            this.btnCrearSesionLlamada.Size = new System.Drawing.Size(105, 43);
            this.btnCrearSesionLlamada.TabIndex = 2;
            this.btnCrearSesionLlamada.Text = "Crear Sesion";
            this.btnCrearSesionLlamada.UseVisualStyleBackColor = true;
            this.btnCrearSesionLlamada.Click += new System.EventHandler(this.btnCrearSesionLlamada_Click);
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumentoCliente.Location = new System.Drawing.Point(560, 307);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(124, 23);
            this.txtDocumentoCliente.TabIndex = 3;
            // 
            // txtIdentificadorCabina
            // 
            this.txtIdentificadorCabina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentificadorCabina.Location = new System.Drawing.Point(560, 338);
            this.txtIdentificadorCabina.Name = "txtIdentificadorCabina";
            this.txtIdentificadorCabina.Size = new System.Drawing.Size(127, 23);
            this.txtIdentificadorCabina.TabIndex = 4;
            // 
            // lblDocumentoCliente
            // 
            this.lblDocumentoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentoCliente.AutoSize = true;
            this.lblDocumentoCliente.Location = new System.Drawing.Point(408, 315);
            this.lblDocumentoCliente.Name = "lblDocumentoCliente";
            this.lblDocumentoCliente.Size = new System.Drawing.Size(110, 15);
            this.lblDocumentoCliente.TabIndex = 5;
            this.lblDocumentoCliente.Text = "Documento Cliente";
            // 
            // lblIdentificadorCabina
            // 
            this.lblIdentificadorCabina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdentificadorCabina.AutoSize = true;
            this.lblIdentificadorCabina.Location = new System.Drawing.Point(408, 346);
            this.lblIdentificadorCabina.Name = "lblIdentificadorCabina";
            this.lblIdentificadorCabina.Size = new System.Drawing.Size(114, 15);
            this.lblIdentificadorCabina.TabIndex = 6;
            this.lblIdentificadorCabina.Text = "Identificador Cabina";
            // 
            // lblClienteEncontrado
            // 
            this.lblClienteEncontrado.AutoSize = true;
            this.lblClienteEncontrado.Location = new System.Drawing.Point(402, 285);
            this.lblClienteEncontrado.Name = "lblClienteEncontrado";
            this.lblClienteEncontrado.Size = new System.Drawing.Size(0, 15);
            this.lblClienteEncontrado.TabIndex = 7;
            // 
            // lblCabinaEncontrada
            // 
            this.lblCabinaEncontrada.AutoSize = true;
            this.lblCabinaEncontrada.Location = new System.Drawing.Point(402, 316);
            this.lblCabinaEncontrada.Name = "lblCabinaEncontrada";
            this.lblCabinaEncontrada.Size = new System.Drawing.Size(0, 15);
            this.lblCabinaEncontrada.TabIndex = 8;
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(12, 318);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(105, 43);
            this.btnVolverMenuPrincipal.TabIndex = 9;
            this.btnVolverMenuPrincipal.Text = "Volver";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // btnAYUDA
            // 
            this.btnAYUDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAYUDA.Location = new System.Drawing.Point(12, 262);
            this.btnAYUDA.Name = "btnAYUDA";
            this.btnAYUDA.Size = new System.Drawing.Size(57, 23);
            this.btnAYUDA.TabIndex = 10;
            this.btnAYUDA.Text = "AYUDA";
            this.btnAYUDA.UseVisualStyleBackColor = true;
            this.btnAYUDA.Click += new System.EventHandler(this.btnAYUDA_Click);
            // 
            // frmSesionLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 373);
            this.Controls.Add(this.btnAYUDA);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Controls.Add(this.lblCabinaEncontrada);
            this.Controls.Add(this.lblClienteEncontrado);
            this.Controls.Add(this.lblIdentificadorCabina);
            this.Controls.Add(this.lblDocumentoCliente);
            this.Controls.Add(this.txtIdentificadorCabina);
            this.Controls.Add(this.txtDocumentoCliente);
            this.Controls.Add(this.btnCrearSesionLlamada);
            this.Controls.Add(this.lBoxCabinas);
            this.Controls.Add(this.lBoxClientes);
            this.MinimumSize = new System.Drawing.Size(1180, 412);
            this.Name = "frmSesionLlamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion Llamada";
            this.Load += new System.EventHandler(this.frmSesionLlamada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxClientes;
        private System.Windows.Forms.ListBox lBoxCabinas;
        private System.Windows.Forms.Button btnCrearSesionLlamada;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.TextBox txtIdentificadorCabina;
        private System.Windows.Forms.Label lblDocumentoCliente;
        private System.Windows.Forms.Label lblIdentificadorCabina;
        private System.Windows.Forms.Label lblClienteEncontrado;
        private System.Windows.Forms.Label lblCabinaEncontrada;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
        private System.Windows.Forms.Button btnAYUDA;
    }
}