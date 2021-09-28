using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class First10Powers : IEnumerable<double>
    {
        private int Number;

        public First10Powers(int number)
        {
            Number = number;
        }

        public IEnumerator<double> GetEnumerator()
        {
            for (int i = 1; i <=10; i++)
            {
                yield return Math.Pow(Number, i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
