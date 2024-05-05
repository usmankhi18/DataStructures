using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemonstrateArrayStack();
            DemonstrateGenericStack();
            Console.ReadKey();
        }

        // Method to demonstrate the usage of ArrayStack
        static void DemonstrateArrayStack()
        {
            Console.WriteLine("Demonstrating ArrayStack:");
            IStack arrayStack = new ArrayStack();
            arrayStack.Push(44);
            arrayStack.Push(10);
            arrayStack.Push(62);
            arrayStack.Push(123);
            arrayStack.Push(15);
            Console.WriteLine("Element at the top of the stack: " + arrayStack.Peek());
            PrintStackElements(arrayStack);
            Console.WriteLine();
        }

        // Method to demonstrate the usage of GenericStack
        static void DemonstrateGenericStack()
        {
            Console.WriteLine("Demonstrating GenericStack:");
            IStack genericStack = new GenericStack();
            genericStack.Push(44);
            genericStack.Push(10);
            genericStack.Push(62);
            genericStack.Push(123);
            genericStack.Push(15);
            Console.WriteLine("Element at the top of the stack: " + genericStack.Peek());
            PrintStackElements(genericStack);
            Console.WriteLine();
        }

        // Method to print elements of the stack
        static void PrintStackElements(IStack stack)
        {
            Console.Write("Elements in the stack: ");
            while (!stack.IsEmpty())
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
