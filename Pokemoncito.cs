using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pockedex
{
    public class Pokemoncito: Pokemon
    {
        public String Ataque2 { get; set; }

        public Pokemoncito (String ataque2, String alias, String tipo) //quiero pedir el nuevo ataque sin poner todos los datos de pokemon
        {
            this.Ataque2 = ataque2;
            base.Alias = alias;
            base.Tipo = tipo;

        }

        public void MuestraPoder2()
        {
            Console.WriteLine("Soy {0} y Mi segundo ataque es: {1} ", Ataque2);

        }
    }
}
