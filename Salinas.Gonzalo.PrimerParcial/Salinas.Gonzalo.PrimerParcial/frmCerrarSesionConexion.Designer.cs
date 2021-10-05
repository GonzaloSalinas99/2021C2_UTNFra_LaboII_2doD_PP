
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmCerrarSesionConexion
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
            this.lBoxSesionConexion = new System.Windows.Forms.ListBox();
            this.lblIdentificadorConexion = new System.Windows.Forms.Label();
            this.txtIdentificadorConexion = new System.Windows.Forms.TextBox();
            this.btnCerrarSesionConexion = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxSesionConexion
            // 
            this.lBoxSesionConexion.FormattingEnabled = true;
            this.lBoxSesionConexion.ItemHeight = 15;
            this.lBoxSesionConexion.Location = new System.Drawing.Point(27, 35);
            this.lBoxSesionConexion.Name = "lBoxSesionConexion";
            this.lBoxSesionConexion.Size = new System.Drawing.Size(1197, 94);
            this.lBoxSesionConexion.TabIndex = 0;
            // 
            // lblIdentificadorConexion
            // 
            this.lblIdentificadorConexion.AutoSize = true;
            this.lblIdentificadorConexion.Location = new System.Drawing.Point(279, 209);
            this.lblIdentificadorConexion.Name = "lblIdentificadorConexion";
            this.lblIdentificadorConexion.Size = new System.Drawing.Size(144, 15);
            this.lblIdentificadorConexion.TabIndex = 1;
            this.lblIdentificadorConexion.Text = "Identificador de Conexion";
            // 
            // txtIdentificadorConexion
            // 
            this.txtIdentificadorConexion.Location = new System.Drawing.Point(450, 201);
            this.txtIdentificadorConexion.Name = "txtIdentificadorConexion";
            this.txtIdentificadorConexion.Size = new System.Drawing.Size(133, 23);
            this.txtIdentificadorConexion.TabIndex = 2;
            // 
            // btnCerrarSesionConexion
            // 
            this.btnCerrarSesionConexion.Location = new System.Drawing.Point(1019, 195);
            this.btnCerrarSesionConexion.Name = "btnCerrarSesionConexion";
            this.btnCerrarSesionConexion.Size = new System.Drawing.Size(165, 42);
            this.btnCerrarSesionConexion.TabIndex = 3;
            this.btnCerrarSesionConexion.Text = "Cerrar Conexion";
            this.btnCerrarSesionConexion.UseVisualStyleBackColor = true;
            this.btnCerrarSesionConexion.Click += new System.EventHandler(this.btnCerrarSesionConexion_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(669, 204);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 15);
            this.lblInformacion.TabIndex = 4;
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(40, 195);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(165, 42);
            this.btnVolverMenuPrincipal.TabIndex = 5;
            this.btnVolverMenuPrincipal.Text = "Volver";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // frmCerrarSesionConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 254);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnCerrarSesionConexion);
            this.Controls.Add(this.txtIdentificadorConexion);
            this.Controls.Add(this.lblIdentificadorConexion);
            this.Controls.Add(this.lBoxSesionConexion);
            this.Name = "frmCerrarSesionConexion";
            this.Text = "frmCerrarSesionConexion";
            this.Load += new System.EventHandler(this.frmCerrarSesionConexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxSesionConexion;
        private System.Windows.Forms.Label lblIdentificadorConexion;
        private System.Windows.Forms.TextBox txtIdentificadorConexion;
        private System.Windows.Forms.Button btnCerrarSesionConexion;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
    }
}