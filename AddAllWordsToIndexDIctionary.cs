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
        public static Dictionary<string, Dictionary<int, List<int>>> addAllWordsInThisFileToIndexDictionary(Dictionary<string, Dictionary<int, List<int>>> dictionary,IndexParameter indexParameter, int fileNumber)
        {
            for (indexParameter.wordNumber = 0; IsCounterLessThan.isCounterLesserThan(indexParameter.wordNumber, indexParameter.words.Count); indexParameter.wordNumber++)
            {
                if (dictionary.ContainsKey(indexParameter.words[indexParameter.wordNumber])) AddExistingWordInDictionary.addExistingWordInDictionary(dictionary, indexParameter, fileNumber);
                else AddNewWordInDictionary.addNewWordInDictionary(dictionary, fileNumber, indexParameter );
            }
            return dictionary;
        }
    }
}
