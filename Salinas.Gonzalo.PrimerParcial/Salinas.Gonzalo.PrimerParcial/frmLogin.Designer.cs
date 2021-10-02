
namespace Salinas.Gonzalo.PrimerParcial
{
    partial class frmLogin
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
            this.lblLoginNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnIngresarAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginNombre
            // 
            this.lblLoginNombre.AutoSize = true;
            this.lblLoginNombre.Location = new System.Drawing.Point(39, 40);
            this.lblLoginNombre.Name = "lblLoginNombre";
            this.lblLoginNombre.Size = new System.Drawing.Size(51, 15);
            this.lblLoginNombre.TabIndex = 0;
            this.lblLoginNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // btnIngresarAdministrador
            // 
            this.btnIngresarAdministrador.Location = new System.Drawing.Point(215, 142);
            this.btnIngresarAdministrador.Name = "btnIngresarAdministrador";
            this.btnIngresarAdministrador.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarAdministrador.TabIndex = 4;
            this.btnIngresarAdministrador.Text = "Login";
            this.btnIngresarAdministrador.UseVisualStyleBackColor = true;
            this.btnIngresarAdministrador.Click += new System.EventHandler(this.btnIngresarAdministrador_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 177);
            this.Controls.Add(this.btnIngresarAdministrador);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoginNombre);
            this.Name = "frmLogin";
            this.Text = "Login Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnIngresarAdministrador;
    }
}