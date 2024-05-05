using System.Collections.Generic;

namespace DataStructures.AlphabetFrequencyCounter
{
    internal interface IAlphabetFrequencyCounter
    {
        Dictionary<char, int> CountAlphabetFrequency(string text);
    }
}