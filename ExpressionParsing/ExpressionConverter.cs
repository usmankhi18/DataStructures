using System.Collections.Generic;
using System;

namespace DataStructures.ExpressionParsing
{
    // Implementation of expression conversion using Stack
    public class ExpressionConverter : IExpressionConverter
    {
        public string Convert(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string postfixExpression = "";
            foreach (char symbol in infix)
            {
                // Implementation of infix to postfix conversion using stack
                if (Char.IsDigit(symbol))
                {
                    postfixExpression += symbol;
                }
                else if (symbol == '(')
                {
                    stack.Push(symbol);
                }
                else if (symbol == ')')
                {
                    while (stack.Peek() != '(')
                    {
                        postfixExpression += stack.Pop();
                    }
                    stack.Pop(); // Discard '('
                }
                else
                {
                    while (stack.Count > 0 && Precedence(symbol) <= Precedence(stack.Peek()))
                    {
                        postfixExpression += stack.Pop();
                    }
                    stack.Push(symbol);
                }
            }
            while (stack.Count > 0)
            {
                postfixExpression += stack.Pop();
            }
            return postfixExpression;
        }

        private int Precedence(char symbol)
        {
            switch (symbol)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }
    }
}