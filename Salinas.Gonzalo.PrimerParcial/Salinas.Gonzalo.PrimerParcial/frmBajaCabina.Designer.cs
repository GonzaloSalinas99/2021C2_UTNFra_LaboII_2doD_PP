
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmBajaCabina
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
            this.lblIdentificadorCabina = new System.Windows.Forms.Label();
            this.lBoxListaCabinas = new System.Windows.Forms.ListBox();
            this.btnvolverMenuPrincipal = new System.Windows.Forms.Button();
            this.btnBajaCabina = new System.Windows.Forms.Button();
            this.btnAYUDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdentificadorCabina
            // 
            this.txtIdentificadorCabina.Location = new System.Drawing.Point(435, 204);
            this.txtIdentificadorCabina.Name = "txtIdentificadorCabina";
            this.txtIdentificadorCabina.Size = new System.Drawing.Size(121, 23);
            this.txtIdentificadorCabina.TabIndex = 23;
            // 
            // lblIdentificadorCabina
            // 
            this.lblIdentificadorCabina.AutoSize = true;
            this.lblIdentificadorCabina.Location = new System.Drawing.Point(299, 207);
            this.lblIdentificadorCabina.Name = "lblIdentificadorCabina";
            this.lblIdentificadorCabina.Size = new System.Drawing.Size(130, 15);
            this.lblIdentificadorCabina.TabIndex = 22;
            this.lblIdentificadorCabina.Text = "Identificador de Cabina";
            // 
            // lBoxListaCabinas
            // 
            this.lBoxListaCabinas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxListaCabinas.FormattingEnabled = true;
            this.lBoxListaCabinas.ItemHeight = 15;
            this.lBoxListaCabinas.Location = new System.Drawing.Point(24, 12);
            this.lBoxListaCabinas.Name = "lBoxListaCabinas";
            this.lBoxListaCabinas.Size = new System.Drawing.Size(872, 154);
            this.lBoxListaCabinas.TabIndex = 21;
            // 
            // btnvolverMenuPrincipal
            // 
            this.btnvolverMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnvolverMenuPrincipal.Location = new System.Drawing.Point(24, 220);
            this.btnvolverMenuPrincipal.Name = "btnvolverMenuPrincipal";
            this.btnvolverMenuPrincipal.Size = new System.Drawing.Size(97, 38);
            this.btnvolverMenuPrincipal.TabIndex = 20;
            this.btnvolverMenuPrincipal.Text = "Volver";
            this.btnvolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnvolverMenuPrincipal.Click += new System.EventHandler(this.btnvolverMenuPrincipal_Click);
            // 
            // btnBajaCabina
            // 
            this.btnBajaCabina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBajaCabina.Location = new System.Drawing.Point(799, 217);
            this.btnBajaCabina.Name = "btnBajaCabina";
            this.btnBajaCabina.Size = new System.Drawing.Size(97, 41);
            this.btnBajaCabina.TabIndex = 19;
            this.btnBajaCabina.Text = "Borrar Cabina";
            this.btnBajaCabina.UseVisualStyleBackColor = true;
            this.btnBajaCabina.Click += new System.EventHandler(this.btnModificarCabina_Click);
            // 
            // btnAYUDA
            // 
            this.btnAYUDA.Location = new System.Drawing.Point(24, 172);
            this.btnAYUDA.Name = "btnAYUDA";
            this.btnAYUDA.Size = new System.Drawing.Size(55, 23);
            this.btnAYUDA.TabIndex = 24;
            this.btnAYUDA.Text = "AYUDA";
            this.btnAYUDA.UseVisualStyleBackColor = true;
            this.btnAYUDA.Click += new System.EventHandler(this.btnAYUDA_Click);
            // 
            // frmBajaCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 270);
            this.Controls.Add(this.btnAYUDA);
            this.Controls.Add(this.txtIdentificadorCabina);
            this.Controls.Add(this.lblIdentificadorCabina);
            this.Controls.Add(this.lBoxListaCabinas);
            this.Controls.Add(this.btnvolverMenuPrincipal);
            this.Controls.Add(this.btnBajaCabina);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBajaCabina";
            this.Text = "frmBajaCabina";
            this.Load += new System.EventHandler(this.frmBajaCabina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificadorCabina;
        private System.Windows.Forms.Label lblIdentificadorCabina;
        private System.Windows.Forms.ListBox lBoxListaCabinas;
        private System.Windows.Forms.Button btnvolverMenuPrincipal;
        private System.Windows.Forms.Button btnBajaCabina;
        private System.Windows.Forms.Button btnAYUDA;
    }
}