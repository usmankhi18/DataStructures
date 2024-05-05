using System.Collections.Generic;

namespace DataStructures.AlphabetFrequencyCounter
{
     // Implementation using List
    public class ListAlphabetFrequencyCounter : IAlphabetFrequencyCounter
    {
        public Dictionary<char, int> CountAlphabetFrequency(string text)
        {
            int[] frequency = new int[26]; // Assuming only lowercase alphabets
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char cLower = char.ToLower(c);
                    frequency[cLower - 'a']++;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (frequency[i] > 0)
                {
                    result[(char)('a' + i)] = frequency[i];
                }
            }

            return result;
        }
    }
}