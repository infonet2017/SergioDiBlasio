using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pockedex
{
    public class Pokemon //no la deje abstracta para poder ingresar los datos
    {
        public String Nombre { get; set; }
        public String Alias { get; set; }
        public Double Peso { get; set; }
        public Double Altura { get; set; }
        public String Tipo { get; set; }

        public Pokemon (String Nombre, String Alias, Double Peso, Double Altura, String Tipo)
        {
            this.Nombre = Nombre;
            this.Alias = Alias;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Tipo = Tipo;
        }

        public void CualEsMiPokeInfo()  
        {
            Console.WriteLine("Mi nombre es {0}, me dicen {1}, peso {2} y por suerte mido {3}, y soy del tipo {4} ", Nombre, Alias, Peso, Altura, Tipo);
        }
    }
}
