using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class StudentsWhoPracticeALot : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Practice >= 10)
                {
                    yield return students[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
