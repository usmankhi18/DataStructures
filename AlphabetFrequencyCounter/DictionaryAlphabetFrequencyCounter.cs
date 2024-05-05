using System.Collections.Generic;

namespace DataStructures.AlphabetFrequencyCounter
{
    // Implementation using Dictionary
    public class DictionaryAlphabetFrequencyCounter : IAlphabetFrequencyCounter
    {
        public Dictionary<char, int> CountAlphabetFrequency(string text)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char cLower = char.ToLower(c);
                    if (frequency.ContainsKey(cLower))
                    {
                        frequency[cLower]++;
                    }
                    else
                    {
                        frequency[cLower] = 1;
                    }
                }
            }

            return frequency;
        }
    }
}