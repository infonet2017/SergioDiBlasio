using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public Person (string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void SetAge (int n)
        {//setea la edad que ingresen para la persona
            this.age = n;
        }

        public void Greet()
        {//saluda al mundo :)
            Console.WriteLine("Hello, how are you?");
        }
    }
}
