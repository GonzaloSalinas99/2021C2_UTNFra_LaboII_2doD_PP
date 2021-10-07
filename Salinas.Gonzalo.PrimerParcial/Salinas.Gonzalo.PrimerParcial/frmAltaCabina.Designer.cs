
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmAltaCabina
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
            this.lblMarcaTelefono = new System.Windows.Forms.Label();
            this.lblTipoTelefono = new System.Windows.Forms.Label();
            this.txtMarcaTelefono = new System.Windows.Forms.TextBox();
            this.cmbTipoTelefono = new System.Windows.Forms.ComboBox();
            this.btnAgregarCabina = new System.Windows.Forms.Button();
            this.btnvolverMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarcaTelefono
            // 
            this.lblMarcaTelefono.AutoSize = true;
            this.lblMarcaTelefono.Location = new System.Drawing.Point(30, 36);
            this.lblMarcaTelefono.Name = "lblMarcaTelefono";
            this.lblMarcaTelefono.Size = new System.Drawing.Size(88, 15);
            this.lblMarcaTelefono.TabIndex = 0;
            this.lblMarcaTelefono.Text = "Marca Telefono";
            // 
            // lblTipoTelefono
            // 
            this.lblTipoTelefono.AutoSize = true;
            this.lblTipoTelefono.Location = new System.Drawing.Point(30, 81);
            this.lblTipoTelefono.Name = "lblTipoTelefono";
            this.lblTipoTelefono.Size = new System.Drawing.Size(94, 15);
            this.lblTipoTelefono.TabIndex = 1;
            this.lblTipoTelefono.Text = "Tipo de Telefono";
            // 
            // txtMarcaTelefono
            // 
            this.txtMarcaTelefono.Location = new System.Drawing.Point(183, 27);
            this.txtMarcaTelefono.Name = "txtMarcaTelefono";
            this.txtMarcaTelefono.Size = new System.Drawing.Size(121, 23);
            this.txtMarcaTelefono.TabIndex = 2;
            // 
            // cmbTipoTelefono
            // 
            this.cmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTelefono.FormattingEnabled = true;
            this.cmbTipoTelefono.Location = new System.Drawing.Point(183, 73);
            this.cmbTipoTelefono.Name = "cmbTipoTelefono";
            this.cmbTipoTelefono.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoTelefono.TabIndex = 3;
            // 
            // btnAgregarCabina
            // 
            this.btnAgregarCabina.Location = new System.Drawing.Point(376, 120);
            this.btnAgregarCabina.Name = "btnAgregarCabina";
            this.btnAgregarCabina.Size = new System.Drawing.Size(97, 23);
            this.btnAgregarCabina.TabIndex = 4;
            this.btnAgregarCabina.Text = "Agregar Cabina";
            this.btnAgregarCabina.UseVisualStyleBackColor = true;
            this.btnAgregarCabina.Click += new System.EventHandler(this.btnAgregarCabina_Click);
            // 
            // btnvolverMenuPrincipal
            // 
            this.btnvolverMenuPrincipal.Location = new System.Drawing.Point(12, 120);
            this.btnvolverMenuPrincipal.Name = "btnvolverMenuPrincipal";
            this.btnvolverMenuPrincipal.Size = new System.Drawing.Size(97, 23);
            this.btnvolverMenuPrincipal.TabIndex = 5;
            this.btnvolverMenuPrincipal.Text = "Volver";
            this.btnvolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnvolverMenuPrincipal.Click += new System.EventHandler(this.btnvolverMenuPrincipal_Click);
            // 
            // frmAltaCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 155);
            this.Controls.Add(this.btnvolverMenuPrincipal);
            this.Controls.Add(this.btnAgregarCabina);
            this.Controls.Add(this.cmbTipoTelefono);
            this.Controls.Add(this.txtMarcaTelefono);
            this.Controls.Add(this.lblTipoTelefono);
            this.Controls.Add(this.lblMarcaTelefono);
            this.Name = "frmAltaCabina";
            this.Text = "Agregar Cabina";
            this.Load += new System.EventHandler(this.AltaCabina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcaTelefono;
        private System.Windows.Forms.Label lblTipoTelefono;
        private System.Windows.Forms.TextBox txtMarcaTelefono;
        private System.Windows.Forms.ComboBox cmbTipoTelefono;
        private System.Windows.Forms.Button btnAgregarCabina;
        private System.Windows.Forms.Button btnvolverMenuPrincipal;
    }
}