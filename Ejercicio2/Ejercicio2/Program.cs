using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta persona1 = new Cuenta();
            CuentaJoven persona2 = new CuentaJoven();

            persona2.setTitular("Esteban");
            persona2.Ingresar(2500);
            persona2.setBonificacion(20);
            persona2.Mostrar();

            persona2.retirarMayor(5000);

            persona1.setTitular("Pablo");
            persona1.Cantidad = 500.5;

            persona1.Mostrar();

            persona1.Ingresar(250);

            persona1.Mostrar();

            persona1.retirar(150);
            persona1.Mostrar();

            Console.ReadKey();
        }
    }
}
