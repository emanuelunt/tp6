using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;
        private byte edad;

               
        public Cuenta()
        {
            this.titular = string.Empty;
            this.cantidad = 0;
        }

        public void setTitular(string nom)
        {
            if (string.IsNullOrEmpty(nom))
            {
                Console.WriteLine("el Nombre del tirular es obligatorio");
                return;
            }

            this.titular = nom;
        }

        public string getTitular()
        {
            return this.titular;
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public void setEdad(byte ed)
        {
            edad = ed;
        }
        public byte getEdad()
        {
            return edad;
        }

        public void Mostrar()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Titular: " + getTitular());
            Console.WriteLine("Cantidad: " + this.Cantidad);
            Console.WriteLine("-----------------------");
        }

        public void Ingresar(double aux)
        {
            if (aux < 0)
                return;

            Cantidad = Cantidad + aux;
        }

        public void retirar(double aux)
        {
            if (aux > Cantidad)
            {
                Console.WriteLine("no tiene sufucuente saldo pra retirar ese importe: " + aux);
                return;
            }

            Cantidad = Cantidad - aux;
            Console.Write("Su saldo es: " + Cantidad);

        }

    }
}
