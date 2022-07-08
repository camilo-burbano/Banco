namespace Banco
{
    public partial class Form1 : Form
    {
        Cuenta cuenta = new Cuenta();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form2 formularioDos = new Form2();
            formularioDos.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try 
            {
                int dni = int.Parse(textDni.Text);
                string contrasena = textContrasena.Text;

                if(cuenta.validar(dni, contrasena)) 
                {
                    
                    Form3 formularioTres = new Form3();
                    formularioTres.cargarDatos();
                    formularioTres.Show();
                    this.Hide();
                }
                else
                {
                    textDni.Text = "";
                    textContrasena.Text = "";
                }
            } 
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos");
            }
            
        }
    }
}