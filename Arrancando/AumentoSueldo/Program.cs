using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo, antig;
            double aumento, total;
            sueldo = 40000;

            Console.Write("Ingrese la antiguedad (expresada en años) del empleado: ");
            antig = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (antig >= 10)
            {
                aumento = (sueldo * 0.10);
                total = aumento + sueldo;
                Console.WriteLine("El aumento para el empleado es de: " + aumento + " euros");
                Console.WriteLine("El sueldo a cobrar : " + total + " euros");
            }

            if (antig < 10 && antig > 5)
            {
                aumento = (sueldo * 0.07);
                total = aumento + sueldo;
                Console.WriteLine("El aumento para el empleado es de: " + aumento + " euros");
                Console.WriteLine("El sueldo a cobrar : " + total + " euros");
            }

            if (antig < 5 && antig > 3)
            {
                aumento = (sueldo * 0.05);
                total = aumento + sueldo;
                Console.WriteLine("El aumento para el empleado es de: " + aumento + " euros");
                Console.WriteLine("El ueldo a cobrar : " + total + " euros");
            }

            if (antig < 3)
            {
                aumento = (sueldo * 0.03);
                total = aumento + sueldo;
                Console.WriteLine("El aumento para el empleado es de: " + aumento + " euros");
                Console.WriteLine("El ueldo a cobrar : " + total + " euros");
            }

            Console.WriteLine("");
            Console.Write("Fin del programa....(Presione una tecla para finalizar)");
            Console.ReadLine();
        }
    }
}
