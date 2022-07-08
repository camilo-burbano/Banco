using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form2 : Form
    {
        Cuenta cuenta = new Cuenta();
        string cadena = "";
        Form1 formularioUno = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(validar() == true)
            {
                cuenta.leerPersonas();
                if (cuenta.validarDni(int.Parse(textDni.Text)))
                {
                    concatenar();
                    StreamWriter archivo = new StreamWriter("personas.txt", append: true);
                    archivo.WriteLine(cadena);
                    archivo.Close();
                    cuenta.leerPersonas();
                    MessageBox.Show("Persona Creada");
                    Limpiar();
                    formularioUno.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Este DNI " + textDni.Text + " ya esta registrado");
                }
                
            }
            else
            {
                MessageBox.Show("Error al digitar los campos");
            }
            
        }
        public bool validar()
        {
            if(textNombre.Text != String.Empty && textApellido.Text != String.Empty &&
                textDni.Text != String.Empty && textContrasena.Text != String.Empty &&
                textSaldo.Text != String.Empty)
            {
                if(textDni.Text.All(char.IsDigit) && textSaldo.Text.All(char.IsDigit))
                {
                    return true;
                }
            }
           
           return false;
            
        }

        public void concatenar()
        {
            cadena += textNombre.Text + "@";
            cadena += textApellido.Text + "@";
            cadena += textDni.Text + "@";
            cadena += textContrasena.Text + "@";
            cadena += textSaldo.Text + "@";
        }
        public void Limpiar()
        {
            cadena = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textDni.Text = "";
            textContrasena.Text = "";
            textSaldo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            formularioUno.Show();
            this.Hide();
        }
    }
}
