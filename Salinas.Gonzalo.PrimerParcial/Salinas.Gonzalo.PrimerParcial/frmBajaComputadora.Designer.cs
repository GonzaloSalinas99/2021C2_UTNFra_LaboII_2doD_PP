
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmBajaComputadora
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
            this.txtIdentificadorCabina = new System.Windows.Forms.TextBox();
            this.lblIdentificadorComputadora = new System.Windows.Forms.Label();
            this.lBoxListaComputadora = new System.Windows.Forms.ListBox();
            this.btnvolverMenuPrincipal = new System.Windows.Forms.Button();
            this.btnBajaComputadora = new System.Windows.Forms.Button();
            this.btnAYUDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdentificadorCabina
            // 
            this.txtIdentificadorCabina.Location = new System.Drawing.Point(563, 241);
            this.txtIdentificadorCabina.Name = "txtIdentificadorCabina";
            this.txtIdentificadorCabina.Size = new System.Drawing.Size(150, 23);
            this.txtIdentificadorCabina.TabIndex = 28;
            // 
            // lblIdentificadorComputadora
            // 
            this.lblIdentificadorComputadora.AutoSize = true;
            this.lblIdentificadorComputadora.Location = new System.Drawing.Point(381, 244);
            this.lblIdentificadorComputadora.Name = "lblIdentificadorComputadora";
            this.lblIdentificadorComputadora.Size = new System.Drawing.Size(167, 15);
            this.lblIdentificadorComputadora.TabIndex = 27;
            this.lblIdentificadorComputadora.Text = "Identificador de Computadora";
            // 
            // lBoxListaComputadora
            // 
            this.lBoxListaComputadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxListaComputadora.FormattingEnabled = true;
            this.lBoxListaComputadora.ItemHeight = 15;
            this.lBoxListaComputadora.Location = new System.Drawing.Point(25, 24);
            this.lBoxListaComputadora.Name = "lBoxListaComputadora";
            this.lBoxListaComputadora.Size = new System.Drawing.Size(1231, 154);
            this.lBoxListaComputadora.TabIndex = 26;
            // 
            // btnvolverMenuPrincipal
            // 
            this.btnvolverMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnvolverMenuPrincipal.Location = new System.Drawing.Point(25, 226);
            this.btnvolverMenuPrincipal.Name = "btnvolverMenuPrincipal";
            this.btnvolverMenuPrincipal.Size = new System.Drawing.Size(126, 38);
            this.btnvolverMenuPrincipal.TabIndex = 25;
            this.btnvolverMenuPrincipal.Text = "Volver";
            this.btnvolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnvolverMenuPrincipal.Click += new System.EventHandler(this.btnvolverMenuPrincipal_Click);
            // 
            // btnBajaComputadora
            // 
            this.btnBajaComputadora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBajaComputadora.Location = new System.Drawing.Point(1130, 226);
            this.btnBajaComputadora.Name = "btnBajaComputadora";
            this.btnBajaComputadora.Size = new System.Drawing.Size(126, 38);
            this.btnBajaComputadora.TabIndex = 24;
            this.btnBajaComputadora.Text = "Borrar Computadora";
            this.btnBajaComputadora.UseVisualStyleBackColor = true;
            this.btnBajaComputadora.Click += new System.EventHandler(this.btnBajaComputadora_Click);
            // 
            // btnAYUDA
            // 
            this.btnAYUDA.Location = new System.Drawing.Point(25, 185);
            this.btnAYUDA.Name = "btnAYUDA";
            this.btnAYUDA.Size = new System.Drawing.Size(53, 23);
            this.btnAYUDA.TabIndex = 29;
            this.btnAYUDA.Text = "AYUDA";
            this.btnAYUDA.UseVisualStyleBackColor = true;
            this.btnAYUDA.Click += new System.EventHandler(this.btnAYUDA_Click);
            // 
            // frmBajaComputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 276);
            this.Controls.Add(this.btnAYUDA);
            this.Controls.Add(this.txtIdentificadorCabina);
            this.Controls.Add(this.lblIdentificadorComputadora);
            this.Controls.Add(this.lBoxListaComputadora);
            this.Controls.Add(this.btnvolverMenuPrincipal);
            this.Controls.Add(this.btnBajaComputadora);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBajaComputadora";
            this.Text = "frmBajaComputadora";
            this.Load += new System.EventHandler(this.frmBajaComputadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificadorCabina;
        private System.Windows.Forms.Label lblIdentificadorComputadora;
        private System.Windows.Forms.ListBox lBoxListaComputadora;
        private System.Windows.Forms.Button btnvolverMenuPrincipal;
        private System.Windows.Forms.Button btnBajaComputadora;
        private System.Windows.Forms.Button btnAYUDA;
    }
}