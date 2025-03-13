namespace Herramientas_Aplicativo_III.View
{
    partial class login
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Ingresar_correo = new System.Windows.Forms.TextBox();
            this.Ver_Contraseña = new System.Windows.Forms.CheckBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(257, 216);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(128, 29);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(84, 216);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(113, 28);
            this.Ingresar.TabIndex = 2;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(115, 41);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 3;
            this.Usuario.Text = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(123, 115);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 4;
            this.Contraseña.Text = "Contraseña";
            // 
            // Ingresar_correo
            // 
            this.Ingresar_correo.Location = new System.Drawing.Point(105, 69);
            this.Ingresar_correo.Name = "Ingresar_correo";
            this.Ingresar_correo.Size = new System.Drawing.Size(280, 20);
            this.Ingresar_correo.TabIndex = 5;
            this.Ingresar_correo.Text = "Ingresar correo";
            // 
            // Ver_Contraseña
            // 
            this.Ver_Contraseña.AutoSize = true;
            this.Ver_Contraseña.Location = new System.Drawing.Point(105, 173);
            this.Ver_Contraseña.Name = "Ver_Contraseña";
            this.Ver_Contraseña.Size = new System.Drawing.Size(98, 17);
            this.Ver_Contraseña.TabIndex = 6;
            this.Ver_Contraseña.Text = "Ver contraseña";
            this.Ver_Contraseña.UseVisualStyleBackColor = true;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(105, 131);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(280, 20);
            this.contrasena.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.Ver_Contraseña);
            this.Controls.Add(this.Ingresar_correo);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.Cancelar);
            this.Name = "login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox Ingresar_correo;
        private System.Windows.Forms.CheckBox Ver_Contraseña;
        private System.Windows.Forms.TextBox contrasena;
    }
}