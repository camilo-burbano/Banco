namespace Banco
{
    partial class Form2
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(87, 37);
            this.textNombre.Name = "textNombre";
            this.textNombre.PlaceholderText = "Nombre";
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(87, 66);
            this.textApellido.Name = "textApellido";
            this.textApellido.PlaceholderText = "Apellido";
            this.textApellido.Size = new System.Drawing.Size(100, 23);
            this.textApellido.TabIndex = 3;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(87, 95);
            this.textDni.Name = "textDni";
            this.textDni.PlaceholderText = "DNI";
            this.textDni.Size = new System.Drawing.Size(100, 23);
            this.textDni.TabIndex = 5;
            // 
            // textContrasena
            // 
            this.textContrasena.Location = new System.Drawing.Point(87, 124);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.PlaceholderText = "Contraseña";
            this.textContrasena.Size = new System.Drawing.Size(100, 23);
            this.textContrasena.TabIndex = 7;
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(87, 153);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.PlaceholderText = "Saldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 23);
            this.textSaldo.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(97, 182);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Name = "Form2";
            this.Text = "BANCO REGISTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDni;
        private TextBox textContrasena;
        private TextBox textSaldo;
        private Button btnCrear;
        private Button button1;
    }
}