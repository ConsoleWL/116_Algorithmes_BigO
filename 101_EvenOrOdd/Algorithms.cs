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
    }
}
