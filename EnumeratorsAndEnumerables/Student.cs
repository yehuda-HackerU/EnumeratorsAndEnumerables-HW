using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Practice { get; private set; } = 0;

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Student(string firstName, string lastName, int practices) : this(firstName, lastName)
        {
            Practice = practices;
        }

        public void ShowUpToPractice()
        {
            Practice++;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
