using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    class PokeRepo
    {
        // Listas de diferentes pokemones
        public List<PokemonPlanta> PokemonesPlanta { get; set; }
        public List<PokemonFuego> PokemonesFuego { get; set; }
        public List<PokemonAgua> PokemonesAgua { get; set; }

        //Lista total de pokemones
        public List<Pokemones> Pokemones { get; set; }

       public PokeRepo()
        {
            PokemonesPlanta = new List<PokemonPlanta>();
            PokemonesFuego = new List<PokemonFuego>();
            PokemonesAgua = new List<PokemonAgua>();
            Pokemones = new List<Pokemones>();
        }

        public void GuardarPokemonAgua(PokemonAgua pokemones)
        {
            PokemonesAgua.Add(pokemones);
        }

        public void GuardarPokemonFuego(PokemonFuego pokemones)
        {
            PokemonesFuego.Add(pokemones);
        }

        public void GuardarPokemonPlanta(PokemonPlanta pokemones)
        {
            PokemonesPlanta.Add(pokemones);
        }

        //Guarda en la lista general
        public void GuardarPokemones(Pokemones pokemones)
        {
            Pokemones.Add(pokemones);
        }

        //Si ya existe no lo guarda al pokemon
        public void GuardarPokemon(Pokemones Pokemones, int tipo)
        {
            switch (tipo)
            {
                case 1:
                    var Busqueda = PokemonesPlanta.Where(p => p.PokeName == Pokemones.PokeName).ToList();
                    
                    if (Busqueda.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {                       
                        GuardarPokemones(Pokemones);
                    }
                    break;

                case 2:
                    var Busqueda1 = PokemonesAgua.Where(p => p.PokeName == Pokemones.PokeName).ToList();
                    
                    if (Busqueda1.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {
                        GuardarPokemones(Pokemones);
                    }
                    break;                

                case 3:
                    var Busqueda2 = PokemonesFuego.Where(p => p.PokeName == Pokemones.PokeName).ToList();
                    
                    if (Busqueda2.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {
                        GuardarPokemones(Pokemones);
                    }
                    break;
            }
        }

        //Devuelve la lista completa
        public List<Pokemones> GetAll()
        {
            return Pokemones;
        }
        
        public List<PokemonPlanta> GetAllPlanta()
        {
            return PokemonesPlanta;
        }
        
        public List<PokemonFuego> GetAllFuego()
        {
            return PokemonesFuego;
        }
        
        public List<PokemonAgua> GetAllAgua()
        {
            return PokemonesAgua;
        }


    }
}
