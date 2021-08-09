using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class CuentaJoven: Cuenta
    {
        private int bonificacion;

        public CuentaJoven()
        {
            bonificacion = 0;
        }

        public void setBonificacion(int bono)
        {
            bonificacion = bono;
        }

        public int getBonificacion()
        {
            return bonificacion;
        }

        public bool esTitularValido()
        {
            if (this.getEdad() >= 25)
                return true;
            else
                return false;
        }

        public void retirarMayor(double aux)
        {
            if (esTitularValido())
            {
                retirar(aux);
                return;
            }

            Console.WriteLine("Para retirar debe ser maroy de 25 años");
        }

        public void Mostrar()
        {
            
            Console.WriteLine("Bonificacion: " + getBonificacion() + "%" );
        }
    }
}
