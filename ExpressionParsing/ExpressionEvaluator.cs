using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ExpressionParsing
{
    // Implementation of expression evaluation using Stack
    public class ExpressionEvaluator : IExpressionEvaluator
    {
        public int Evaluate(string postfix)
        {
            Stack<int> stackInt = new Stack<int>();
            foreach (char ch in postfix)
            {
                if (Char.IsDigit(ch))
                {
                    stackInt.Push(ch - '0'); // Push the operand
                }
                else
                {
                    int operand2 = stackInt.Pop();
                    int operand1 = stackInt.Pop();
                    switch (ch)
                    {
                        case '+':
                            stackInt.Push(operand1 + operand2);
                            break;
                        case '-':
                            stackInt.Push(operand1 - operand2);
                            break;
                        case '*':
                            stackInt.Push(operand1 * operand2);
                            break;
                        case '/':
                            stackInt.Push(operand1 / operand2);
                            break;
                    }
                }
            }
            return stackInt.Peek();
        }
    }
}
