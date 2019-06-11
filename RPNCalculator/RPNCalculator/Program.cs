using System;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Stack
    {
        int[] array = new int[10];
        int count;
        public Stack()
        {
            count = 0;
        }

        public void Push(int newElement)
        {
            array[count]= newElement;
            count++;
        }
        public int Pop()
        {

        }
        public int Peek()
        {

        }
    }
}
