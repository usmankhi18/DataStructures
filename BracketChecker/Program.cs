using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BracketChecker
{
    internal class Program
    {
        private static readonly Dictionary<char, char> bracketPairs = new Dictionary<char, char> {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

        public static bool AreBracketsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (bracketPairs.ContainsValue(c))
                {
                    if (stack.Count == 0 || stack.Pop() != bracketPairs.FirstOrDefault(x => x.Value == c).Key)
                        return false;
                }
                else if (bracketPairs.ContainsKey(c))
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }

        public static void Main(string[] args)
        {
            string input = "{}{}()[]";
            Console.WriteLine("Brackets are balanced: " + AreBracketsBalanced(input));
            Console.ReadKey();
        }
    }
}
