using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Persona
    {
        private string nombre;
        private string dni;
        private byte edad;


        public Persona()
        {
            nombre = string.Empty;
            dni = "";
            edad = 0;
 
        }
        public Persona(string nom, string documento, byte anios)
        {
            this.nombre = nom;
            this.dni = documento;
            this.edad = anios;
        }

        //Métodos getter y Setter
        public void setNombre(string nom)
        {
            if (string.IsNullOrEmpty(nom))
            {
                Console.WriteLine("Debe ingresar un nombre");
                return;
            }

            this.nombre = nom;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setDNI(string doc)
        {
            if (string.IsNullOrEmpty(doc))
            {
                Console.WriteLine("Debe ingresar el dni");
                return;
            }

            this.dni = doc;
 
        }
        public string getDNI()
        {
            return dni;
        }

        public void setEdad(byte anio)
        {
            if (anio < 0)
            {
                Console.WriteLine("La edad No puede ser negativa");
                return;
            }

            this.edad = anio;
        }

        public byte getEdad()
        {
            return edad;
        }


        public void Mostrar()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Nombre: " + getNombre());
            Console.WriteLine("DNI: {0}", getDNI());
            Console.WriteLine("Edad: " + getEdad());
            Console.WriteLine("-------------------");
 
        }


        public bool esMayorDeEdad()
        {
            if (getEdad() >= 18)
                return true;
            else
                return false;
        }


    }
}
