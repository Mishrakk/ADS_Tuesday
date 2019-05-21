using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 1, 5, 9 };
            Console.WriteLine("array before sorting");
            PrintArray(numbers);
            Console.WriteLine("array after sorting");
            InsertionSort(numbers);
            PrintArray(numbers);
           
        }

        public static void PrintArray (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void InsertionSort(int[] array)
        {

        }
    }
}

