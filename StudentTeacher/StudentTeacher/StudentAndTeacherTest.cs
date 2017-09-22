using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            //instancio a una nueva persona
            Person Persona = new Person("Pepe", "Argento");
            //usa sus metodos de la clase Person
            Persona.Greet();
            Console.ReadKey();

            //instancio un nuevo estudiante
            Student Estudiante = new Student("Coqui", "Argento");
            //usa sus metodos de la clase Student
            Estudiante.SetAge(21);
            Estudiante.Greet();
            Estudiante.ShowAge();
            Console.ReadKey();

            //instancion un nuevo maestro
            Teacher Maestro = new Teacher ("Maestro", "Ciruela");
            //usa sus metodos de la clase Teacher
            Maestro.SetAge(30);
            Maestro.Greet();
            Maestro.Explain();

            Console.ReadKey();
        }
    }
}
