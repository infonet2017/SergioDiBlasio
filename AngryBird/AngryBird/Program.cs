using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBird
{
    class Program
    {
        static void Main(string[] args)
        {
            var littlebird = new Bird();
            littlebird.Hunger = 100;
            littlebird.Weight = 50;
            littlebird.Status();

            littlebird.Eat(20);
            littlebird.Status();

            var Angrybird = new AngryBird();
            Angrybird.Hunger = 100;
            Angrybird.Weight = 50;
            Angrybird.Anger = 50;
            Angrybird.StatusAngryBird();
            //uso el metodo
            Angrybird.Provoke(5);
            Angrybird.StatusAngryBird();


            Angrybird.Eat(100);
            Angrybird.Provoke(5);
            Angrybird.StatusAngryBird();
            Console.Read();
        }
    }
}
