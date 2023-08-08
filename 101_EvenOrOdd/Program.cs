namespace _101_EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithms algorithms = new Algorithms();

            bool result1 = algorithms.EvenOrOdd(5);
            bool result2 = algorithms.EvenOrOdd(6);

            int[] numbers1 = new[] { 1, 5, 6, 7, };
            int[] numbers2 = new[] { 1, 5, 6, 7, 198 };

            bool names1Result = algorithms.LessThan100(numbers1);
            bool names2Result = algorithms.LessThan100(numbers2);

            string[] names1 = new[] {"Tom", "Mike", "Jorge", "Tom"};
            string[] names2 = new[] {"Tom", "Mike", "Jorge", "Bob"};

            bool resultNames1 = algorithms.RepeatedNames(names1);
            bool resultNames2 = algorithms.RepeatedNames(names2);

            int[] numbersUnsoreted = new[] { 1, 7, 3, 6, 100, 32 };
            int[] resultSorted = algorithms.SortList(numbersUnsoreted);

            

            int temp = 0;
        }
    }
}