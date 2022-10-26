using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddAllWordsInThisFileToIndexDictionary
    {
        public static Dictionary<string, Dictionary<int, List<int>>> addAllWordsInThisFileToIndexDictionary(Dictionary<string, Dictionary<int, List<int>>> dictionary, List<string> words, int fileNumber, int wordNumber)
        {
            for (wordNumber = 0; IsCounterLessThan.isCounterLesserThan(wordNumber, words.Count); wordNumber++)
            {
                if (dictionary.ContainsKey(words[wordNumber])) AddExistingWordInDictionary.addExistingWordInDictionary(dictionary, words, fileNumber, wordNumber);
                else AddNewWordInDictionary.addNewWordInDictionary(dictionary, words, fileNumber, wordNumber);
            }
            return dictionary;
        }
    }
}
