namespace Banco
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.textAbonar = new System.Windows.Forms.TextBox();
            this.textRetirar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textDniTransferir = new System.Windows.Forms.TextBox();
            this.textCantidadTransferir = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(12, 48);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(119, 48);
            this.textApellido.Name = "textApellido";
            this.textApellido.ReadOnly = true;
            this.textApellido.Size = new System.Drawing.Size(100, 23);
            this.textApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(119, 128);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.ReadOnly = true;
            this.textSaldo.Size = new System.Drawing.Size(100, 23);
            this.textSaldo.TabIndex = 7;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(227, 48);
            this.textDni.Name = "textDni";
            this.textDni.ReadOnly = true;
            this.textDni.Size = new System.Drawing.Size(100, 23);
            this.textDni.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "DNI";
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(13, 127);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(99, 23);
            this.btnSaldo.TabIndex = 8;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnAbonar
            // 
            this.btnAbonar.Location = new System.Drawing.Point(13, 156);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(99, 23);
            this.btnAbonar.TabIndex = 9;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(13, 185);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(99, 23);
            this.btnRetirar.TabIndex = 10;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // textAbonar
            // 
            this.textAbonar.Location = new System.Drawing.Point(118, 157);
            this.textAbonar.Name = "textAbonar";
            this.textAbonar.PlaceholderText = "Cantidad";
            this.textAbonar.Size = new System.Drawing.Size(100, 23);
            this.textAbonar.TabIndex = 11;
            // 
            // textRetirar
            // 
            this.textRetirar.Location = new System.Drawing.Point(119, 186);
            this.textRetirar.Name = "textRetirar";
            this.textRetirar.PlaceholderText = "Cantidad";
            this.textRetirar.Size = new System.Drawing.Size(100, 23);
            this.textRetirar.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(333, 48);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textDniTransferir
            // 
            this.textDniTransferir.Location = new System.Drawing.Point(332, 157);
            this.textDniTransferir.Name = "textDniTransferir";
            this.textDniTransferir.PlaceholderText = "DNI Persona a Transferir";
            this.textDniTransferir.Size = new System.Drawing.Size(132, 23);
            this.textDniTransferir.TabIndex = 16;
            // 
            // textCantidadTransferir
            // 
            this.textCantidadTransferir.Location = new System.Drawing.Point(332, 127);
            this.textCantidadTransferir.Name = "textCantidadTransferir";
            this.textCantidadTransferir.PlaceholderText = "Cantidad";
            this.textCantidadTransferir.Size = new System.Drawing.Size(133, 23);
            this.textCantidadTransferir.TabIndex = 15;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(333, 186);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(132, 23);
            this.btnTransferir.TabIndex = 18;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 268);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.textDniTransferir);
            this.Controls.Add(this.textCantidadTransferir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textRetirar);
            this.Controls.Add(this.textAbonar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "BANCO PERSONAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private TextBox textApellido;
        private Label label2;
        private TextBox textSaldo;
        private TextBox textDni;
        private Label label4;
        private Button btnSaldo;
        private Button btnAbonar;
        private Button btnRetirar;
        private TextBox textAbonar;
        private TextBox textRetirar;
        private Button btnSalir;
        private TextBox textDniTransferir;
        private TextBox textCantidadTransferir;
        private Button btnTransferir;
    }
}