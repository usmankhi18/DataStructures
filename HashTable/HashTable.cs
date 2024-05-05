using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class HashTable
    {
        private const int SIZE = 20;

        public class DataItem
        {
            public int Data { get; }
            public int Key { get; }

            public DataItem(int data, int key)
            {
                Data = data;
                Key = key;
            }
        }

        private DataItem[] hashArray = new DataItem[SIZE];
        private readonly DataItem dummyItem = new DataItem(-1, -1);

        private int HashCode(int key) => key % SIZE;

        public void Insert(int key, int data)
        {
            var newItem = new DataItem(data, key);
            int hashIndex = HashCode(key);

            while (hashArray[hashIndex] != null && hashArray[hashIndex].Key != -1)
            {
                hashIndex = (hashIndex + 1) % SIZE;
            }
            hashArray[hashIndex] = newItem;
        }

        public DataItem Search(int key)
        {
            int hashIndex = HashCode(key);

            while (hashArray[hashIndex] != null)
            {
                if (hashArray[hashIndex].Key == key)
                    return hashArray[hashIndex];

                hashIndex = (hashIndex + 1) % SIZE;
            }
            return null;
        }

        public DataItem Delete(int key)
        {
            int hashIndex = HashCode(key);
            while (hashArray[hashIndex] != null)
            {
                if (hashArray[hashIndex].Key == key)
                {
                    DataItem temp = hashArray[hashIndex];
                    hashArray[hashIndex] = dummyItem;
                    return temp;
                }

                hashIndex = (hashIndex + 1) % SIZE;
            }
            return null;
        }

        public void Display()
        {
            for (int i = 0; i < SIZE; i++)
            {
                if (hashArray[i] != null)
                    Console.Write(" (" + hashArray[i].Key + "," + hashArray[i].Data + ")");
            }
            Console.WriteLine();
        }
    }
}
