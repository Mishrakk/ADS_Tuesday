using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 1, 5, 9 };
            Console.WriteLine("array before sorting");
            printarray(numbers);
            
        }
        public static void printarray (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
