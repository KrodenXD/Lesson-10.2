using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._2
{
    class Methods
    {
        public int Factorial(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }
        public decimal? Multiply(decimal? a, decimal? b, decimal? c, decimal? d)
        {
            return a * b * c * d;
        }
    }
}
