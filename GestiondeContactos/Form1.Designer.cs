namespace GestiondeContactos
{
    partial class Form1
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
            btnAñadir = new Button();
            btnEliminarContacto = new Button();
            btnModificarTelefono = new Button();
            btnMostrarContactos = new Button();
            SuspendLayout();
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(109, 69);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(170, 59);
            btnAñadir.TabIndex = 0;
            btnAñadir.Text = "button1";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnEliminarContacto
            // 
            btnEliminarContacto.Location = new Point(132, 191);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(170, 59);
            btnEliminarContacto.TabIndex = 1;
            btnEliminarContacto.Text = "button2";
            btnEliminarContacto.UseVisualStyleBackColor = true;
            // 
            // btnModificarTelefono
            // 
            btnModificarTelefono.Location = new Point(429, 69);
            btnModificarTelefono.Name = "btnModificarTelefono";
            btnModificarTelefono.Size = new Size(170, 59);
            btnModificarTelefono.TabIndex = 2;
            btnModificarTelefono.Text = "button3";
            btnModificarTelefono.UseVisualStyleBackColor = true;
            // 
            // btnMostrarContactos
            // 
            btnMostrarContactos.Location = new Point(443, 191);
            btnMostrarContactos.Name = "btnMostrarContactos";
            btnMostrarContactos.Size = new Size(170, 59);
            btnMostrarContactos.TabIndex = 3;
            btnMostrarContactos.Text = "button4";
            btnMostrarContactos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarContactos);
            Controls.Add(btnModificarTelefono);
            Controls.Add(btnEliminarContacto);
            Controls.Add(btnAñadir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadir;
        private Button btnEliminarContacto;
        private Button btnModificarTelefono;
        private Button btnMostrarContactos;
    }
}
