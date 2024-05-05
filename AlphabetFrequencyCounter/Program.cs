using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.AlphabetFrequencyCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";

            // Using List implementation
            IAlphabetFrequencyCounter listCounter = new ListAlphabetFrequencyCounter();
            Dictionary<char, int> listFrequency = listCounter.CountAlphabetFrequency(text);
            Console.WriteLine("Frequency by List:");
            PrintFrequency(listFrequency);

            // Using Dictionary implementation
            IAlphabetFrequencyCounter dictionaryCounter = new DictionaryAlphabetFrequencyCounter();
            Dictionary<char, int> dictionaryFrequency = dictionaryCounter.CountAlphabetFrequency(text);
            Console.WriteLine("\nFrequency by Dictionary:");
            PrintFrequency(dictionaryFrequency);

            Console.ReadKey();
        }

        static void PrintFrequency(Dictionary<char, int> frequency)
        {
            foreach (KeyValuePair<char, int> entry in frequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
