
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmModificarCabina
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
            this.btnvolverMenuPrincipal = new System.Windows.Forms.Button();
            this.btnModificarCabina = new System.Windows.Forms.Button();
            this.cmbTipoTelefono = new System.Windows.Forms.ComboBox();
            this.txtMarcaTelefono = new System.Windows.Forms.TextBox();
            this.lblTipoTelefono = new System.Windows.Forms.Label();
            this.lblMarcaTelefono = new System.Windows.Forms.Label();
            this.lBoxListaCabinas = new System.Windows.Forms.ListBox();
            this.txtIdentificadorCabina = new System.Windows.Forms.TextBox();
            this.lblIdentificadorCabina = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvolverMenuPrincipal
            // 
            this.btnvolverMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnvolverMenuPrincipal.Location = new System.Drawing.Point(12, 247);
            this.btnvolverMenuPrincipal.Name = "btnvolverMenuPrincipal";
            this.btnvolverMenuPrincipal.Size = new System.Drawing.Size(97, 38);
            this.btnvolverMenuPrincipal.TabIndex = 11;
            this.btnvolverMenuPrincipal.Text = "Volver";
            this.btnvolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnvolverMenuPrincipal.Click += new System.EventHandler(this.btnvolverMenuPrincipal_Click);
            // 
            // btnModificarCabina
            // 
            this.btnModificarCabina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCabina.Location = new System.Drawing.Point(978, 247);
            this.btnModificarCabina.Name = "btnModificarCabina";
            this.btnModificarCabina.Size = new System.Drawing.Size(97, 41);
            this.btnModificarCabina.TabIndex = 10;
            this.btnModificarCabina.Text = "Modificar Cabina";
            this.btnModificarCabina.UseVisualStyleBackColor = true;
            this.btnModificarCabina.Click += new System.EventHandler(this.btnAgregarCabina_Click);
            // 
            // cmbTipoTelefono
            // 
            this.cmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTelefono.FormattingEnabled = true;
            this.cmbTipoTelefono.Location = new System.Drawing.Point(812, 200);
            this.cmbTipoTelefono.Name = "cmbTipoTelefono";
            this.cmbTipoTelefono.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoTelefono.TabIndex = 9;
            // 
            // txtMarcaTelefono
            // 
            this.txtMarcaTelefono.Location = new System.Drawing.Point(547, 200);
            this.txtMarcaTelefono.Name = "txtMarcaTelefono";
            this.txtMarcaTelefono.Size = new System.Drawing.Size(121, 23);
            this.txtMarcaTelefono.TabIndex = 8;
            // 
            // lblTipoTelefono
            // 
            this.lblTipoTelefono.AutoSize = true;
            this.lblTipoTelefono.Location = new System.Drawing.Point(696, 203);
            this.lblTipoTelefono.Name = "lblTipoTelefono";
            this.lblTipoTelefono.Size = new System.Drawing.Size(94, 15);
            this.lblTipoTelefono.TabIndex = 7;
            this.lblTipoTelefono.Text = "Tipo de Telefono";
            // 
            // lblMarcaTelefono
            // 
            this.lblMarcaTelefono.AutoSize = true;
            this.lblMarcaTelefono.Location = new System.Drawing.Point(441, 203);
            this.lblMarcaTelefono.Name = "lblMarcaTelefono";
            this.lblMarcaTelefono.Size = new System.Drawing.Size(88, 15);
            this.lblMarcaTelefono.TabIndex = 6;
            this.lblMarcaTelefono.Text = "Marca Telefono";
            // 
            // lBoxListaCabinas
            // 
            this.lBoxListaCabinas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxListaCabinas.FormattingEnabled = true;
            this.lBoxListaCabinas.ItemHeight = 15;
            this.lBoxListaCabinas.Location = new System.Drawing.Point(12, 12);
            this.lBoxListaCabinas.Name = "lBoxListaCabinas";
            this.lBoxListaCabinas.Size = new System.Drawing.Size(1063, 154);
            this.lBoxListaCabinas.TabIndex = 12;
            // 
            // txtIdentificadorCabina
            // 
            this.txtIdentificadorCabina.Location = new System.Drawing.Point(291, 200);
            this.txtIdentificadorCabina.Name = "txtIdentificadorCabina";
            this.txtIdentificadorCabina.Size = new System.Drawing.Size(121, 23);
            this.txtIdentificadorCabina.TabIndex = 14;
            // 
            // lblIdentificadorCabina
            // 
            this.lblIdentificadorCabina.AutoSize = true;
            this.lblIdentificadorCabina.Location = new System.Drawing.Point(155, 203);
            this.lblIdentificadorCabina.Name = "lblIdentificadorCabina";
            this.lblIdentificadorCabina.Size = new System.Drawing.Size(130, 15);
            this.lblIdentificadorCabina.TabIndex = 13;
            this.lblIdentificadorCabina.Text = "Identificador de Cabina";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(12, 172);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(56, 23);
            this.btnAyuda.TabIndex = 15;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmModificarCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 300);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.txtIdentificadorCabina);
            this.Controls.Add(this.lblIdentificadorCabina);
            this.Controls.Add(this.lBoxListaCabinas);
            this.Controls.Add(this.btnvolverMenuPrincipal);
            this.Controls.Add(this.btnModificarCabina);
            this.Controls.Add(this.cmbTipoTelefono);
            this.Controls.Add(this.txtMarcaTelefono);
            this.Controls.Add(this.lblTipoTelefono);
            this.Controls.Add(this.lblMarcaTelefono);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarCabina";
            this.Text = "frmModificarCabina";
            this.Load += new System.EventHandler(this.frmModificarCabina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolverMenuPrincipal;
        private System.Windows.Forms.Button btnModificarCabina;
        private System.Windows.Forms.ComboBox cmbTipoTelefono;
        private System.Windows.Forms.TextBox txtMarcaTelefono;
        private System.Windows.Forms.Label lblTipoTelefono;
        private System.Windows.Forms.Label lblMarcaTelefono;
        private System.Windows.Forms.ListBox lBoxListaCabinas;
        private System.Windows.Forms.TextBox txtIdentificadorCabina;
        private System.Windows.Forms.Label lblIdentificadorCabina;
        private System.Windows.Forms.Button btnAyuda;
    }
}