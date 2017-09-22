using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBird
{
    class Bird
    {
        public int Hunger { get; set; }
        public int Weight { get; set; }

        public void Eat(int number)
        {
            this.Hunger = this.Hunger - number;
            this.Weight = this.Weight + number;
        }

        public void Status()
        {
            Console.WriteLine("I'm a bird with a weight = {0} and a hunger level = {1}.", this.Weight, this.Hunger);
        }
    }
}
