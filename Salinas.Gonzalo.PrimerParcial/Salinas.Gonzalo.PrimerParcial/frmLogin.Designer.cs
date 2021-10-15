
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
            this.txtNombreAdministrador = new System.Windows.Forms.TextBox();
            this.txtApellidoAdministrador = new System.Windows.Forms.TextBox();
            this.btnIngresarAdministrador = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // txtNombreAdministrador
            // 
            this.txtNombreAdministrador.Location = new System.Drawing.Point(122, 37);
            this.txtNombreAdministrador.Name = "txtNombreAdministrador";
            this.txtNombreAdministrador.Size = new System.Drawing.Size(100, 23);
            this.txtNombreAdministrador.TabIndex = 2;
            // 
            // txtApellidoAdministrador
            // 
            this.txtApellidoAdministrador.Location = new System.Drawing.Point(122, 98);
            this.txtApellidoAdministrador.Name = "txtApellidoAdministrador";
            this.txtApellidoAdministrador.Size = new System.Drawing.Size(100, 23);
            this.txtApellidoAdministrador.TabIndex = 3;
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
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIngresarAdministrador);
            this.Controls.Add(this.txtApellidoAdministrador);
            this.Controls.Add(this.txtNombreAdministrador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoginNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAdministrador;
        private System.Windows.Forms.TextBox txtApellidoAdministrador;
        private System.Windows.Forms.Button btnIngresarAdministrador;
        private System.Windows.Forms.Button button1;
    }
}