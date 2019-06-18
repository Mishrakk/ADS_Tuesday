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
                if (int.TryParse(element, out int result))
                {
                    stack.Push(result);
                }
                else
                {
                    int op2 = stack.Pop();
                    int op1 = stack.Pop();

                }
            }

            return stack.Pop();


        }
        public static int Evaluate(int op1, int op2, string op)
        {

        }
    }
}
