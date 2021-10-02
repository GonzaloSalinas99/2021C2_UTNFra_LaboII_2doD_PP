
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnAgregarClienteCabina = new System.Windows.Forms.Button();
            this.lblAgregarClienteCabina = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAgregarClienteComputadora = new System.Windows.Forms.Button();
            this.lblAgregarClienteComputadora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(21, 413);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 15);
            this.lblInformacion.TabIndex = 15;
            // 
            // btnAgregarClienteCabina
            // 
            this.btnAgregarClienteCabina.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarClienteCabina.Location = new System.Drawing.Point(192, 50);
            this.btnAgregarClienteCabina.Name = "btnAgregarClienteCabina";
            this.btnAgregarClienteCabina.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClienteCabina.TabIndex = 16;
            this.btnAgregarClienteCabina.Text = "Agregar";
            this.btnAgregarClienteCabina.UseVisualStyleBackColor = true;
            this.btnAgregarClienteCabina.Click += new System.EventHandler(this.btnAgregarClienteCabina_Click);
            // 
            // lblAgregarClienteCabina
            // 
            this.lblAgregarClienteCabina.AutoSize = true;
            this.lblAgregarClienteCabina.Location = new System.Drawing.Point(21, 54);
            this.lblAgregarClienteCabina.Name = "lblAgregarClienteCabina";
            this.lblAgregarClienteCabina.Size = new System.Drawing.Size(82, 15);
            this.lblAgregarClienteCabina.TabIndex = 17;
            this.lblAgregarClienteCabina.Text = "Cliente cabina";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(278, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 64);
            this.listBox1.TabIndex = 18;
            // 
            // btnAgregarClienteComputadora
            // 
            this.btnAgregarClienteComputadora.Location = new System.Drawing.Point(192, 147);
            this.btnAgregarClienteComputadora.Name = "btnAgregarClienteComputadora";
            this.btnAgregarClienteComputadora.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClienteComputadora.TabIndex = 19;
            this.btnAgregarClienteComputadora.Text = "Agregar";
            this.btnAgregarClienteComputadora.UseVisualStyleBackColor = true;
            this.btnAgregarClienteComputadora.Click += new System.EventHandler(this.btnAgregarClienteComputadora_Click);
            // 
            // lblAgregarClienteComputadora
            // 
            this.lblAgregarClienteComputadora.AutoSize = true;
            this.lblAgregarClienteComputadora.Location = new System.Drawing.Point(21, 151);
            this.lblAgregarClienteComputadora.Name = "lblAgregarClienteComputadora";
            this.lblAgregarClienteComputadora.Size = new System.Drawing.Size(121, 15);
            this.lblAgregarClienteComputadora.TabIndex = 20;
            this.lblAgregarClienteComputadora.Text = "Cliente Computadora";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.lblAgregarClienteComputadora);
            this.Controls.Add(this.btnAgregarClienteComputadora);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblAgregarClienteCabina);
            this.Controls.Add(this.btnAgregarClienteCabina);
            this.Controls.Add(this.lblInformacion);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLoginAdministrador;
        public System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnAgregarClienteCabina;
        private System.Windows.Forms.Label lblAgregarClienteCabina;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAgregarClienteComputadora;
        private System.Windows.Forms.Label lblAgregarClienteComputadora;
    }
}

