using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_EvenOrOdd
{
    public class Algorithms
    {  
        // O(1) aka constant
        public bool EvenOrOdd(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }

        // O(n) aka linear
        public bool LessThan100(int[] numbers)
        {
            bool result = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 100)
                    result = false;
            }

            return result;
        }

        //string[] names1 = new[] { "Tom", "Mike", "Jorge", "Tom" };
        //string[] names2 = new[] { "Tom", "Mike", "Jorge", "Bob" };

        // I think is complexity here is O(n log n) aka N-log-N
        // because with each iteration amount of names we have to go in the second loop decreases
        
        public bool RepeatedNames(string[] names)
        {
            bool result = false;
            int counter = 1;

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = counter; j < names.Length; j++)
                {
                    if (names[i] == names[j])
                    {
                        result = true;
                        i = names.Length;
                        j = names.Length;

                    }
                }
                counter++;
            }

            return result;
        }

        // O(n^2) aka quadratic
        public int[] SortList(int[] numbers)
        {
            int temp;

            for (int i = 0; i < numbers.Length - 1 ; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
