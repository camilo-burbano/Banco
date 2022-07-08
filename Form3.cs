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
    public partial class Form3 : Form
    {
        Cuenta cuenta = new Cuenta();
        Persona persona = new Persona();

        public Form3()
        {
            InitializeComponent();
        }
        
        public void cargarDatos()
        {
            persona = cuenta.datos();
            textNombre.Text = persona.Nombre;
            textApellido.Text = persona.Apellido;
            textDni.Text = Convert.ToString(persona.Dni);
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            int saldo = cuenta.saldo();
            textSaldo.Text = Convert.ToString(saldo);
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(textAbonar.Text);
                int cantidadNueva = cuenta.abono(cantidad);
                textSaldo.Text = Convert.ToString(cantidadNueva);
                textAbonar.Text = "";
                MessageBox.Show("Abono Exitoso");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la cantidad");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(textRetirar.Text);
                
                if(cantidad <= int.Parse(textSaldo.Text))
                {
                    int cantidadNueva = cuenta.retiro(cantidad);
                    textSaldo.Text = Convert.ToString(cantidadNueva);
                    textRetirar.Text = "";
                    MessageBox.Show("Retiro Exitoso");
                }
                else
                {
                    MessageBox.Show("Saldo Insuficiente");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la cantidad");
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try 
            {
                int dni = int.Parse(textDniTransferir.Text);
                int cantidad = int.Parse(textCantidadTransferir.Text);

                if (cantidad <= int.Parse(textSaldo.Text))
                {
                    if (dni != int.Parse(textDni.Text)) 
                    {
                        int cantidadNueva = cuenta.transferencia(dni, cantidad);
                        textSaldo.Text = Convert.ToString(cantidadNueva);
                        textCantidadTransferir.Text = "";
                        textDniTransferir.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Acción Invalida");
                    }
                }
                else
                {
                    MessageBox.Show("Saldo Insuficiente");
                }
            
            } 
            catch (Exception) 
            {
                MessageBox.Show("Error al digitar los datos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 formularioUno = new Form1();
            cuenta.salir();
            formularioUno.Show();
            this.Hide();
        }
    }
}
