using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            First10Powers powers = new First10Powers(2);
            foreach (var num in powers)
            {
                Console.WriteLine(num);
            }


            StudentsWhoPracticeALot students = new StudentsWhoPracticeALot();
            students.AddStudent(new Student("Yehuda", "Ben-Shushan", 25));
            students.AddStudent(new Student("Yair", "Ben-Shushan", 3));
            students.AddStudent(new Student("John", "Doe", 12));
            students.AddStudent(new Student("Jane", "Doe", 11));

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }


            Console.WriteLine("\n\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
