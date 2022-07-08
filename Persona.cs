using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Persona
    {
        private string nombre="";
        private string apellido="";
        private int dni=0;
        private string contraseña="";
        private int saldo=0;

        public Persona() { }

        public Persona(string nombre, string apellido, int dni, string contraseña, int saldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.contraseña = contraseña;
            this.saldo = saldo;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public int Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
    }
}
