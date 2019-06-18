using System;
using System.Collections.Generic;
namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int PostfixEvaluator(string expression)
        {
            Stack<int> stack = new Stack<int>();
            string[] expressionArray = expression.Split(' ');
            for (int i = 0; i < expressionArray.Length; i++)
            {
                string element = expressionArray[i];
            }

            return stack.Pop();


        }
    }
}
