using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 1, 5, 9 };
            Console.WriteLine("array before sorting");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] +" ");
            }
            Console.WriteLine();
        }
    }
}
