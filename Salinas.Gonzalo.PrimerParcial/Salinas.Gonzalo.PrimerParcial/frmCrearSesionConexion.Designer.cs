
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
            this.btnCrearSesionConexion = new System.Windows.Forms.Button();
            this.lBoxComputadora = new System.Windows.Forms.ListBox();
            this.lBoxClientes = new System.Windows.Forms.ListBox();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.btnAYUDA = new System.Windows.Forms.Button();
            this.cmbTiempoSesion = new System.Windows.Forms.ComboBox();
            this.lblHorarioSesion = new System.Windows.Forms.Label();
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
            // btnCrearSesionConexion
            // 
            this.btnCrearSesionConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearSesionConexion.Location = new System.Drawing.Point(1347, 382);
            this.btnCrearSesionConexion.Name = "btnCrearSesionConexion";
            this.btnCrearSesionConexion.Size = new System.Drawing.Size(198, 43);
            this.btnCrearSesionConexion.TabIndex = 11;
            this.btnCrearSesionConexion.Text = "Crear Sesion";
            this.btnCrearSesionConexion.UseVisualStyleBackColor = true;
            this.btnCrearSesionConexion.Click += new System.EventHandler(this.btnCrearSesionConexion_Click_1);
            // 
            // lBoxComputadora
            // 
            this.lBoxComputadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxComputadora.FormattingEnabled = true;
            this.lBoxComputadora.ItemHeight = 15;
            this.lBoxComputadora.Location = new System.Drawing.Point(19, 139);
            this.lBoxComputadora.Name = "lBoxComputadora";
            this.lBoxComputadora.Size = new System.Drawing.Size(1526, 139);
            this.lBoxComputadora.TabIndex = 10;
            // 
            // lBoxClientes
            // 
            this.lBoxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxClientes.FormattingEnabled = true;
            this.lBoxClientes.ItemHeight = 15;
            this.lBoxClientes.Location = new System.Drawing.Point(19, 12);
            this.lBoxClientes.Name = "lBoxClientes";
            this.lBoxClientes.Size = new System.Drawing.Size(1526, 109);
            this.lBoxClientes.TabIndex = 9;
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(19, 380);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(198, 43);
            this.btnVolverMenuPrincipal.TabIndex = 18;
            this.btnVolverMenuPrincipal.Text = "Volver";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // btnAYUDA
            // 
            this.btnAYUDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAYUDA.Location = new System.Drawing.Point(19, 285);
            this.btnAYUDA.Name = "btnAYUDA";
            this.btnAYUDA.Size = new System.Drawing.Size(57, 23);
            this.btnAYUDA.TabIndex = 19;
            this.btnAYUDA.Text = "AYUDA";
            this.btnAYUDA.UseVisualStyleBackColor = true;
            this.btnAYUDA.Click += new System.EventHandler(this.btnAYUDA_Click);
            // 
            // cmbTiempoSesion
            // 
            this.cmbTiempoSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbTiempoSesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiempoSesion.FormattingEnabled = true;
            this.cmbTiempoSesion.Location = new System.Drawing.Point(775, 393);
            this.cmbTiempoSesion.Name = "cmbTiempoSesion";
            this.cmbTiempoSesion.Size = new System.Drawing.Size(161, 23);
            this.cmbTiempoSesion.TabIndex = 20;
            // 
            // lblHorarioSesion
            // 
            this.lblHorarioSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHorarioSesion.AutoSize = true;
            this.lblHorarioSesion.Location = new System.Drawing.Point(592, 396);
            this.lblHorarioSesion.Name = "lblHorarioSesion";
            this.lblHorarioSesion.Size = new System.Drawing.Size(177, 15);
            this.lblHorarioSesion.TabIndex = 21;
            this.lblHorarioSesion.Text = "Tiempo de la sesion en minutos.";
            // 
            // frmCrearSesionConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 435);
            this.Controls.Add(this.lblHorarioSesion);
            this.Controls.Add(this.cmbTiempoSesion);
            this.Controls.Add(this.btnAYUDA);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Controls.Add(this.lblCabinaEncontrada);
            this.Controls.Add(this.lblClienteEncontrado);
            this.Controls.Add(this.btnCrearSesionConexion);
            this.Controls.Add(this.lBoxComputadora);
            this.Controls.Add(this.lBoxClientes);
            this.MinimumSize = new System.Drawing.Size(1573, 474);
            this.Name = "frmCrearSesionConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion Conexion";
            this.Load += new System.EventHandler(this.frmSesionConexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabinaEncontrada;
        private System.Windows.Forms.Label lblClienteEncontrado;
        private System.Windows.Forms.Button btnCrearSesionConexion;
        private System.Windows.Forms.ListBox lBoxComputadora;
        private System.Windows.Forms.ListBox lBoxClientes;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
        private System.Windows.Forms.Button btnAYUDA;
        private System.Windows.Forms.ComboBox cmbTiempoSesion;
        private System.Windows.Forms.Label lblHorarioSesion;
    }
}