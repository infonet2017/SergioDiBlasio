using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pockedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del Pokemon: ");
            var pokeNombre = Console.ReadLine();
            Console.Write("Ingrese el alias : ");
            var pokeAlias = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el peso en kg (ej: 7.5): ");
            var pokePeso = Console.ReadLine();
            Console.Write("Ingrese la altura en mts (ej: 1.50 ): ");
            var pokeAltura = Console.ReadLine();
            Console.Write("Ingrese Tipo (Agua, Fuego, Planta): ");
            var pokeTipo = Console.ReadLine();

            Pokemon pokeNuevo = new Pokemon (pokeNombre, pokeAlias, pokePeso, PokeAltura, PokeTipo);



            pokeNuevo.CualEsMiPokeInfo();
            Console.ReadKey();
        }
    }
}
