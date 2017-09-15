using Informatorio.pokedex.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Informatorio.Pokedex.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            PokemonManager PokeManager = new PokemonManager();
            
            while (flag)
            {                
                 Console.WriteLine("Seleccione una opción");
                 Console.Write("1- Ingresar Pokemon");
                 Console.Write("2- Liestar Pokemones");
                 Console.WriteLine("3- Salir");

                int opcionMenu = Convert.ToInt32(Console.ReadLine()); //leo lo que quiere hacer

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Imgrese el nombre del Pokemon a ingresar");
                        string PokeName = Console.ReadLine();

                        Console.WriteLine("Opciones disponibles de tipo de pokemon");
                        Console.WriteLine("1- Pokemon tipo Agua");
                        Console.WriteLine("2- Pokemon tipo Fuego");
                        Console.WriteLine("3- Pokemon tipo Planta");

                        int ChoiceTipoPoke = Convert.ToInt32(Console.ReadLine()); //leo el tipo de pokemon que quiere
                      
                        if (ChoiceTipoPoke == 1 | ChoiceTipoPoke == 2 | ChoiceTipoPoke == 3)
                        {
                            Console.Write("Datos a ingresar del pokemon registrado: (...PRESIONE CUALQUIER TECLA PARA COMENZAR...)");
                            Console.ReadKey();
                            Console.Write("Apodo/Alias: )");
                            string Apodo = Console.ReadLine();
                            Console.Write("Altura: )");
                            double Altura = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Peso: )");
                            double Peso = Convert.ToDouble(Console.ReadLine());

                            PokeManager.RegisterPokemon(PokeName, Peso, ChoiceTipoPoke, Altura, Apodo);                            
                        }
                        else
                        {
                            Console.WriteLine("El pokemon "+ PokeName + " ya ha sido ingresado");
                            Console.ReadKey();
                        }
                        return;
                    case 2:
                        var text = PokeManager.GetAllPokemons();
                        Console.WriteLine(text);
                        return;
                    case 3:
                        Console.WriteLine("Finalizó el ingreso de Pokemones");
                        flag = false;
                        return;

                    default: //por si ingresa cualquier otra cosa de lo que puse arriba
                        Console.WriteLine("Opción inválida. Leé chamigo!!");
                        break;
                }
            }//fin del while           

            Console.ReadKey();
        }
    }
}
