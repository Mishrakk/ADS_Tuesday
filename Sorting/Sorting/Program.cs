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
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j - 1] > array[j]) 
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
        }
        public static void CocktailSort (int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length;




        }
    }
}

