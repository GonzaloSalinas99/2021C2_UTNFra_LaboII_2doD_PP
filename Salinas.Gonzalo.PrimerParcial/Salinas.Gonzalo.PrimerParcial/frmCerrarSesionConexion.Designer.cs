
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
            this.btnCerrarSesionConexion = new System.Windows.Forms.Button();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.btnAYUDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxSesionConexion
            // 
            this.lBoxSesionConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxSesionConexion.FormattingEnabled = true;
            this.lBoxSesionConexion.ItemHeight = 15;
            this.lBoxSesionConexion.Location = new System.Drawing.Point(27, 20);
            this.lBoxSesionConexion.Name = "lBoxSesionConexion";
            this.lBoxSesionConexion.Size = new System.Drawing.Size(1293, 139);
            this.lBoxSesionConexion.TabIndex = 0;
            // 
            // btnCerrarSesionConexion
            // 
            this.btnCerrarSesionConexion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesionConexion.Location = new System.Drawing.Point(1059, 235);
            this.btnCerrarSesionConexion.Name = "btnCerrarSesionConexion";
            this.btnCerrarSesionConexion.Size = new System.Drawing.Size(261, 42);
            this.btnCerrarSesionConexion.TabIndex = 3;
            this.btnCerrarSesionConexion.Text = "Cerrar Conexion";
            this.btnCerrarSesionConexion.UseVisualStyleBackColor = true;
            this.btnCerrarSesionConexion.Click += new System.EventHandler(this.btnCerrarSesionConexion_Click);
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(27, 235);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(165, 42);
            this.btnVolverMenuPrincipal.TabIndex = 5;
            this.btnVolverMenuPrincipal.Text = "Volver";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // btnAYUDA
            // 
            this.btnAYUDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAYUDA.Location = new System.Drawing.Point(27, 161);
            this.btnAYUDA.Name = "btnAYUDA";
            this.btnAYUDA.Size = new System.Drawing.Size(55, 23);
            this.btnAYUDA.TabIndex = 6;
            this.btnAYUDA.Text = "AYUDA";
            this.btnAYUDA.UseVisualStyleBackColor = true;
            this.btnAYUDA.Click += new System.EventHandler(this.btnAYUDA_Click);
            // 
            // frmCerrarSesionConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 289);
            this.Controls.Add(this.btnAYUDA);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Controls.Add(this.btnCerrarSesionConexion);
            this.Controls.Add(this.lBoxSesionConexion);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1365, 328);
            this.Name = "frmCerrarSesionConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar Sesion Conexion";
            this.Load += new System.EventHandler(this.frmCerrarSesionConexion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxSesionConexion;
        private System.Windows.Forms.Button btnCerrarSesionConexion;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
        private System.Windows.Forms.Button btnAYUDA;
    }
}