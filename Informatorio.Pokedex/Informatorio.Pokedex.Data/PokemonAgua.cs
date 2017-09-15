using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    class PokemonAgua: Pokemones
    {
        public PokemonAgua(string PokeName, string Apodo, double altura, double peso)
        {
            
            this.PokeName = PokeName;
            this.Apodo = Apodo;
            this.Peso = Peso;
            this.Altura = Altura;

            //tengo que ver como agregar los ataques, 2 en comun de todos los tipos y uno especial (CHORRO DE AGUA)
        }
    }
}
