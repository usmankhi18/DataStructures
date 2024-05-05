using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ExpressionParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string infix = "1*(2+3)";
            var converter = new ExpressionConverter();
            var evaluator = new ExpressionEvaluator();
            var processor = new ExpressionProcessor(converter, evaluator);

            Console.WriteLine("Infix expression is: " + infix);
            Console.WriteLine("Postfix expression is: " + converter.Convert(infix));
            Console.WriteLine("Evaluated expression is: " + processor.Process(infix));
            Console.ReadKey();
        }
    }
}
