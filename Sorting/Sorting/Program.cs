﻿using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateRandomArray(10);
            Console.WriteLine("array before sorting");
            PrintArray(numbers);
            Console.WriteLine("array after sorting");
            Quicksort(numbers);
            PrintArray(numbers);

        }
        public static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next() % (10 * size);
            }
            return array;
        }
        public static void Quicksort(int[] array)
        {
            Quicksortinternal(array, 0, array.Length - 1);
        }
        public static void Quicksortinternal(int[] array, int p, int r)
        {

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
            while (swapped)
            {
                swapped = false;
                for (int i = start; i < end -1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                end--;
                for (int i = end; i > start; i--)
                {
                    if (array[i-1] > array[i])
                    {
                        int temp = array[i-1];
                        array[i-1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
                start++;
            }
        }
    }
}

