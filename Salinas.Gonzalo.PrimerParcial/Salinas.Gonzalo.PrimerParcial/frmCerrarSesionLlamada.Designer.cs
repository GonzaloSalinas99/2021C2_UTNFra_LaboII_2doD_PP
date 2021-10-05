
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmCerrarSesionLlamada
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
            this.lBoxLlamadas = new System.Windows.Forms.ListBox();
            this.txtIdentificadorLlamada = new System.Windows.Forms.TextBox();
            this.lblIdentificadorLlamada = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnCerrarSesionLlamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxLlamadas
            // 
            this.lBoxLlamadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxLlamadas.FormattingEnabled = true;
            this.lBoxLlamadas.ItemHeight = 15;
            this.lBoxLlamadas.Location = new System.Drawing.Point(25, 12);
            this.lBoxLlamadas.Name = "lBoxLlamadas";
            this.lBoxLlamadas.Size = new System.Drawing.Size(1111, 139);
            this.lBoxLlamadas.TabIndex = 0;
            // 
            // txtIdentificadorLlamada
            // 
            this.txtIdentificadorLlamada.Location = new System.Drawing.Point(177, 189);
            this.txtIdentificadorLlamada.Name = "txtIdentificadorLlamada";
            this.txtIdentificadorLlamada.Size = new System.Drawing.Size(138, 23);
            this.txtIdentificadorLlamada.TabIndex = 1;
            // 
            // lblIdentificadorLlamada
            // 
            this.lblIdentificadorLlamada.AutoSize = true;
            this.lblIdentificadorLlamada.Location = new System.Drawing.Point(25, 197);
            this.lblIdentificadorLlamada.Name = "lblIdentificadorLlamada";
            this.lblIdentificadorLlamada.Size = new System.Drawing.Size(122, 15);
            this.lblIdentificadorLlamada.TabIndex = 2;
            this.lblIdentificadorLlamada.Text = "Identificador Llamada";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(453, 197);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 15);
            this.lblInformacion.TabIndex = 3;
            // 
            // btnCerrarSesionLlamada
            // 
            this.btnCerrarSesionLlamada.Location = new System.Drawing.Point(983, 182);
            this.btnCerrarSesionLlamada.Name = "btnCerrarSesionLlamada";
            this.btnCerrarSesionLlamada.Size = new System.Drawing.Size(138, 45);
            this.btnCerrarSesionLlamada.TabIndex = 4;
            this.btnCerrarSesionLlamada.Text = "Cerrar Sesion";
            this.btnCerrarSesionLlamada.UseVisualStyleBackColor = true;
            this.btnCerrarSesionLlamada.Click += new System.EventHandler(this.btnCerrarSesionLlamada_Click);
            // 
            // frmCerrarSesionLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 242);
            this.Controls.Add(this.btnCerrarSesionLlamada);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblIdentificadorLlamada);
            this.Controls.Add(this.txtIdentificadorLlamada);
            this.Controls.Add(this.lBoxLlamadas);
            this.Name = "frmCerrarSesionLlamada";
            this.Text = "frmCerrarSesionLlamada";
            this.Load += new System.EventHandler(this.frmCerrarSesionLlamada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxLlamadas;
        private System.Windows.Forms.TextBox txtIdentificadorLlamada;
        private System.Windows.Forms.Label lblIdentificadorLlamada;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnCerrarSesionLlamada;
    }
}