using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueDiaEs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero entero entre 1 y 7 para saber que dia de la semana es: ");
            numero = Convert.ToInt32(Console.ReadLine());
            
            switch (numero)
            {
                case 1:
                    Console.WriteLine("el dia es LUNES");
                    break;
                case 2:
                    Console.WriteLine("el dia es MARTES");
                    break;
                case 3:
                    Console.WriteLine("el dia es MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("el dia es JUEVES");
                    break;
                case 5:
                    Console.WriteLine("el dia es VIERNES");
                    break;
                case 6:
                    Console.WriteLine("el dia es SABADO");
                    break;
                case 7:
                    Console.WriteLine("el dia es DOMINGO");
                    break;                                   
            }
            Console.WriteLine("");
            Console.Write("Fin del programa...(Presione una tecla para finalizar");
            Console.ReadLine();

        }
    }
}
