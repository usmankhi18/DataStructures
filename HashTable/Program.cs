using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable();

            hashTable.Insert(1, 20);
            hashTable.Insert(2, 70);
            hashTable.Insert(42, 80);
            hashTable.Insert(4, 25);
            hashTable.Insert(12, 44);
            hashTable.Insert(14, 32);
            hashTable.Insert(17, 11);
            hashTable.Insert(13, 78);
            hashTable.Insert(37, 97);

            Console.WriteLine("Insertion done");
            Console.WriteLine("Contents of Hash Table:");
            hashTable.Display();

            int ele = 37;
            Console.WriteLine("The element to be searched: " + ele);
            var item = hashTable.Search(37);

            if (item != null)
            {
                Console.WriteLine("Element found: " + item.Key);
            }
            else
            {
                Console.WriteLine("Element not found");
            }

            hashTable.Delete(37);
            Console.WriteLine("Hash Table contents after deletion:");
            hashTable.Display();
            Console.ReadKey();
        }
    }
}
