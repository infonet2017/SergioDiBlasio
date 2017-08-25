using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorYMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, mayor, menor;

            Console.WriteLine("Se le solicitara que ingrese 10 numeros y determinaremos el mayor y el menor: ");
            mayor = -1;
            menor = 64000;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
                Console.Write("Ingrese un número para la proxima posicion: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > mayor)

                {
                    mayor = numero;
                }
                else 
                {
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                   
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("El MAYOR numero ingresado es: " + mayor);
            Console.WriteLine("El MENOR numero ingresado es: " + menor);
            Console.WriteLine("");
            Console.Write("Fin del programa....(Presione una tecla para finalizar)");
            Console.ReadLine();
        }
    }
}
