using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: ", this.age + " years old");
        }

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }

        public Student(string name, string surname): base(name, surname)
        {

        }
    }
}
