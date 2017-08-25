using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutivosONo
{
    class Program
    {
        static void Main(string[] args)
        {
         int num1, num2, num3, numAux1, numAux2;

         Console.WriteLine("Se le pedirá que ingrese 3 numeros enteros para saber si se ingresan ");
         Console.WriteLine("en orden creciente: ");
         Console.WriteLine("");

         Console.Write("Ingrese el primer numero: ");
         num1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Ingrese el segundo numero: ");
         num2 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Ingrese el tercer numero: ");
         num3 = Convert.ToInt32(Console.ReadLine());
         numAux1 = num1 + 1;
         numAux2 = num2 + 1;

         if (Equals(num2, numAux1))
           {
                if (Equals(num2, numAux1))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Los números se ingresaron en orden creciente");
                }                
           }
        else
            {
                Console.WriteLine("");
                Console.WriteLine("Los números NO se ingresaron en orden creciente");
            }

         Console.WriteLine("");
         Console.WriteLine("Fin del programa....(Presione una tecla para finalizar)");
         Console.ReadLine();
        }
    }
}
