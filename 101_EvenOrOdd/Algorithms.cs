using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_EvenOrOdd
{
    public class Algorithms
    {  
        // O(1)
        public bool EvenOrOdd(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }

        // O(n);
        public bool LessThan100(int[] numbers)
        {
            bool result = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i >= 100)
                    result = false;
            }

            return result;
        }
    }
}
