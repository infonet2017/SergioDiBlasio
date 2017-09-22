using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBird
{
    class AngryBird : Bird
    {
        public int Anger { get; set; }

        public void Provoke (int number)
        {
            if (this.Hunger > 0)
            {
                number = number * 2;
            }
            this.Anger = this.Anger + number;
        }

        public void StatusAngryBird()
        {
            Console.WriteLine("I'm a Angry-Bird with a weight = {0}, a hunger level = {1}, and an anger level = {2}.", this.Weight, this.Hunger, this.Anger);
        }
    }
}
