using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate ArrayQueue
            IQueue queue = new ArrayQueue(6);
            DemoArrayQueue(queue);

            // Demonstrate GenericQueue
            queue = new GenericQueue();
            DemoGenericQueue(queue);

            Console.ReadKey();
        }

        static void DemoArrayQueue(IQueue queue)
        {
            queue.Insert(3);
            queue.Insert(5);
            queue.Insert(9);
            queue.Insert(1);
            queue.Insert(12);
            queue.Insert(15);

            Console.WriteLine("ArrayQueue:");
            Console.WriteLine("Queue size: " + queue.Size());
            Console.Write("Queue: ");
            ArrayQueue arrayQueue = (ArrayQueue)queue;
            for (int i = 0; i < 6; i++)
            {
                Console.Write(arrayQueue.GetElementAtIndex(i) + " ");
            }
            if (queue.IsFull())
            {
                Console.Write("\nQueue is full!");
            }

            // Remove one item
            int num = queue.RemoveData();
            Console.WriteLine("\nElement removed: " + num);
            Console.WriteLine("Queue size after deletion: " + queue.Size());
            Console.WriteLine("Element at front: " + queue.Peek());
        }

        static void DemoGenericQueue(IQueue queue)
        {
            queue.Insert(3);
            queue.Insert(5);
            queue.Insert(9);
            queue.Insert(1);
            queue.Insert(12);
            queue.Insert(15);

            Console.WriteLine("\nGenericQueue:");
            Console.WriteLine("Queue size: " + queue.Size());
            Console.Write("Queue: ");
            GenericQueue genericQueue = new GenericQueue();

            Console.WriteLine("\nGenericQueue:");
            Console.WriteLine("Queue size: " + genericQueue.Size());
            Console.Write("Queue: ");
            while (!queue.IsEmpty())
            {
                int data = queue.RemoveData();
                Console.Write(data + " ");
                genericQueue.Insert(data);
            }
            if (genericQueue.IsFull())
            {
                Console.Write("\nQueue is full!");
            }
            else
            {
                Console.Write("\nQueue is not full!");
            }

            // Remove one item
            int num = genericQueue.RemoveData();
            Console.WriteLine("\nElement removed: " + num);
            Console.WriteLine("Queue size after deletion: " + genericQueue.Size());
            Console.WriteLine("Element at front: " + genericQueue.Peek());
        }
    }
}
