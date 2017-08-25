using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrancanco //como se le puede cambiar el nombre al archivo?
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un número entero para saber si es par o impar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0) //si el numero es par
            {
                Console.WriteLine("El numero ingresado es PAR");
            }
            else
            {
                Console.WriteLine("El numero ingresado es IMPAR");
            }

            Console.WriteLine("");
            Console.Write("Fin del programa....(Presione una tecla para finalizar)");
            Console.ReadLine();
        }
    }
}
