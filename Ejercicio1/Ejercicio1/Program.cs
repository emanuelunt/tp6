using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona alumno1 = new Persona();

            Persona alumno2 = new Persona("Daniel","3025663",10);

            Console.WriteLine("Ingresar el nombre");
            string apodo = Console.ReadLine();
            alumno1.setNombre(apodo);

            Console.WriteLine("Ingrese el dni: ");
            alumno1.setDNI(Console.ReadLine());

            Console.WriteLine("Ingrese una edad (mayor a cero) : ");
            alumno1.setEdad(byte.Parse(Console.ReadLine()));


            alumno1.Mostrar();
            alumno2.Mostrar();

            if (alumno1.esMayorDeEdad())
                Console.WriteLine("{0} es mayor de edad", alumno1.getNombre());
            else
                Console.WriteLine("{0} es menor de edad", alumno1.getNombre());

            /*  condicion ? 'valor si es verdadero' : 'valor si es falso'   */

            /*  a>b => true/false  (a<b)&&(c!=0) => true/false  */

            Console.WriteLine("{0} es {1} de edad" ,alumno2.getNombre(), alumno2.esMayorDeEdad() ? "mayor" : "menor");



            Console.ReadKey();
        }
    }
}
