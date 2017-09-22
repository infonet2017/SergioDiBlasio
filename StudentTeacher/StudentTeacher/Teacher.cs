using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class Teacher: Person
    {
        private string Subject { get; set; }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }

        public Teacher(string name, string surname): base(name, surname)
        {

        }
    }
}
