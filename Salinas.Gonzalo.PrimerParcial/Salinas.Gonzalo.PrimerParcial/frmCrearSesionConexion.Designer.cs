﻿
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmCrearSesionConexion
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
            this.lblCabinaEncontrada = new System.Windows.Forms.Label();
            this.lblClienteEncontrado = new System.Windows.Forms.Label();
            this.lblIdentificadorCabina = new System.Windows.Forms.Label();
            this.lblDocumentoCliente = new System.Windows.Forms.Label();
            this.txtIdentificadorComputadora = new System.Windows.Forms.TextBox();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.btnCrearSesionConexion = new System.Windows.Forms.Button();
            this.lBoxComputadora = new System.Windows.Forms.ListBox();
            this.lBoxClientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCabinaEncontrada
            // 
            this.lblCabinaEncontrada.AutoSize = true;
            this.lblCabinaEncontrada.Location = new System.Drawing.Point(642, 225);
            this.lblCabinaEncontrada.Name = "lblCabinaEncontrada";
            this.lblCabinaEncontrada.Size = new System.Drawing.Size(0, 15);
            this.lblCabinaEncontrada.TabIndex = 17;
            // 
            // lblClienteEncontrado
            // 
            this.lblClienteEncontrado.AutoSize = true;
            this.lblClienteEncontrado.Location = new System.Drawing.Point(642, 194);
            this.lblClienteEncontrado.Name = "lblClienteEncontrado";
            this.lblClienteEncontrado.Size = new System.Drawing.Size(0, 15);
            this.lblClienteEncontrado.TabIndex = 16;
            // 
            // lblIdentificadorCabina
            // 
            this.lblIdentificadorCabina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdentificadorCabina.AutoSize = true;
            this.lblIdentificadorCabina.Location = new System.Drawing.Point(473, 95);
            this.lblIdentificadorCabina.Name = "lblIdentificadorCabina";
            this.lblIdentificadorCabina.Size = new System.Drawing.Size(151, 15);
            this.lblIdentificadorCabina.TabIndex = 15;
            this.lblIdentificadorCabina.Text = "Identificador Computadora";
            // 
            // lblDocumentoCliente
            // 
            this.lblDocumentoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentoCliente.AutoSize = true;
            this.lblDocumentoCliente.Location = new System.Drawing.Point(473, 33);
            this.lblDocumentoCliente.Name = "lblDocumentoCliente";
            this.lblDocumentoCliente.Size = new System.Drawing.Size(110, 15);
            this.lblDocumentoCliente.TabIndex = 14;
            this.lblDocumentoCliente.Text = "Documento Cliente";
            // 
            // txtIdentificadorComputadora
            // 
            this.txtIdentificadorComputadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentificadorComputadora.Location = new System.Drawing.Point(642, 92);
            this.txtIdentificadorComputadora.Name = "txtIdentificadorComputadora";
            this.txtIdentificadorComputadora.Size = new System.Drawing.Size(126, 23);
            this.txtIdentificadorComputadora.TabIndex = 13;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Location = new System.Drawing.Point(642, 30);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(126, 23);
            this.txtDocumentoCliente.TabIndex = 12;
            // 
            // btnCrearSesionConexion
            // 
            this.btnCrearSesionConexion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearSesionConexion.Location = new System.Drawing.Point(642, 255);
            this.btnCrearSesionConexion.Name = "btnCrearSesionConexion";
            this.btnCrearSesionConexion.Size = new System.Drawing.Size(139, 43);
            this.btnCrearSesionConexion.TabIndex = 11;
            this.btnCrearSesionConexion.Text = "Crear Sesion";
            this.btnCrearSesionConexion.UseVisualStyleBackColor = true;
            this.btnCrearSesionConexion.Click += new System.EventHandler(this.btnCrearSesionConexion_Click_1);
            // 
            // lBoxComputadora
            // 
            this.lBoxComputadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxComputadora.FormattingEnabled = true;
            this.lBoxComputadora.ItemHeight = 15;
            this.lBoxComputadora.Location = new System.Drawing.Point(19, 174);
            this.lBoxComputadora.Name = "lBoxComputadora";
            this.lBoxComputadora.Size = new System.Drawing.Size(423, 124);
            this.lBoxComputadora.TabIndex = 10;
            // 
            // lBoxClientes
            // 
            this.lBoxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxClientes.FormattingEnabled = true;
            this.lBoxClientes.ItemHeight = 15;
            this.lBoxClientes.Location = new System.Drawing.Point(19, 36);
            this.lBoxClientes.Name = "lBoxClientes";
            this.lBoxClientes.Size = new System.Drawing.Size(423, 109);
            this.lBoxClientes.TabIndex = 9;
            // 
            // frmSesionConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.lblCabinaEncontrada);
            this.Controls.Add(this.lblClienteEncontrado);
            this.Controls.Add(this.lblIdentificadorCabina);
            this.Controls.Add(this.lblDocumentoCliente);
            this.Controls.Add(this.txtIdentificadorComputadora);
            this.Controls.Add(this.txtDocumentoCliente);
            this.Controls.Add(this.btnCrearSesionConexion);
            this.Controls.Add(this.lBoxComputadora);
            this.Controls.Add(this.lBoxClientes);
            this.Name = "frmSesionConexion";
            this.Text = "frmSesionConexion";
            this.Load += new System.EventHandler(this.frmSesionConexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabinaEncontrada;
        private System.Windows.Forms.Label lblClienteEncontrado;
        private System.Windows.Forms.Label lblIdentificadorCabina;
        private System.Windows.Forms.Label lblDocumentoCliente;
        private System.Windows.Forms.TextBox txtIdentificadorComputadora;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Button btnCrearSesionConexion;
        private System.Windows.Forms.ListBox lBoxComputadora;
        private System.Windows.Forms.ListBox lBoxClientes;
    }
}