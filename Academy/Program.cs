using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Vercetti", "Tommy", 30);
            human.Info();
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jessie", 25, "Chemisty", "WW_220", 95, 98);
            student.Info();
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemisty", 20);
            teacher.Info();
            Console.WriteLine(teacher);

            Graduate graduate = new Graduate("Schereder", "Hank", 40, "Criminalictic", "OBN", 40, 42, "How to catch someone");
            graduate.Info();
            Console.WriteLine(graduate);

            Student tommy = new Student(human, "Theft", "Vice", 98, 99);
            Console.WriteLine(tommy);

            
        }
    }
}

