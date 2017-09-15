using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    public class PokemonData
    {
        public string PokeName { get; set; }
        public float Peso { get; set; }
        public string Apodo { get; set; }
        public float Altura { get; set; }
        public int TipoPoke { get; set; }

        public PokemonData(float Peso, string PokeName, int TipPoke, string Apodo, float Altura)
        {
            this.PokeName = PokeName;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Apodo = Apodo;
            this.TipoPoke = TipoPoke;
        }


    }
}
