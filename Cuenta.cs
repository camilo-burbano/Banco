using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    
    public class Cuenta
    {
        static List<Persona> personas = new List<Persona>();
        static Persona persona = new Persona();
        
        public Cuenta() { }

        public void leerPersonas()
        {
            personas.Clear();
            StreamReader lector = new StreamReader("personas.txt");
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                string[] campos = linea.Split("@");
                Persona persona = new Persona(campos[0], campos[1], int.Parse(campos[2]), campos[3], int.Parse(campos[4]));
                personas.Add(persona);
            }
            lector.Close();
        }

        public void escribirPersonas(Persona p)
        {
            string[] u = File.ReadAllLines("personas.txt");

            int linea = 0;

            for (int i = 0; i < u.Length; i++)
            {
                string[] campos = u[i].Split("@");  
                if (int.Parse(campos[2]) == p.Dni)
                {
                    linea = i;
                }
            }

            u[linea] = p.Nombre + "@" + p.Apellido + "@" + p.Dni + "@" + p.Contraseña + "@" + p.Saldo + "@";
            File.WriteAllLines("personas.txt", u);
        }

        public bool validar(int dni, string contrasena)
        {
            leerPersonas();
            for (int i=0; i < personas.Count; i++)
            {
                if(personas[i].Dni == dni && personas[i].Contraseña == contrasena)
                {
                    persona = personas[i];
                    return true;
                }
            }
            MessageBox.Show("Persona no encontrada");
            return false;
        }

        public Persona datos()
        {
            return persona;
        }
        public int saldo()
        {
            return persona.Saldo;
        }
        public int abono(int cantidad)
        {
            persona.Saldo = persona.Saldo + cantidad;
            escribirPersonas(persona);
            return persona.Saldo;
        }
        public int retiro(int cantidad)
        {
            persona.Saldo = persona.Saldo - cantidad;
            escribirPersonas(persona);
            return persona.Saldo;
        }

        public int transferencia(int dni, int cantidad)
        {
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Dni == dni)
                {
                    int retorno = retiro(cantidad);
                    Persona aux = persona;
                    persona = personas[i];
                    abono(cantidad);
                    MessageBox.Show("Transferencia Exitosa");
                    persona = aux;
                    return retorno;
                }
            }
            MessageBox.Show("Persona no encontrada");
            return persona.Saldo;
        }

        public bool validarDni(int dni)
        {
            for(int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Dni == dni) 
                {
                    return false;
                }
            }
            return true;
        }
       
        public void salir()
        {
            personas.Clear();
        }
        

    }
}
