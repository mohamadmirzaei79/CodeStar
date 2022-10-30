using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddExistingWordInDictionary
    {
        public static Dictionary<string, Dictionary<int, List<int>>> addExistingWordInDictionary (Dictionary<string, Dictionary<int, List<int>>> dictionary, IndexParameter indexParameter, int fileNumber)
        {
            if (IsDictionaryContainsFile.isDictionaryContainsFile(indexParameter.words, fileNumber, indexParameter.wordNumber, dictionary))
            {
                dictionary = AddWordToFileDictionary.addWordToFileDictionary(indexParameter.words, fileNumber, indexParameter.wordNumber, dictionary);
            }
            else
            {
                AddNewWordInThisFileToDictionary addNewWordInThisFileToDictionary = new AddNewWordInThisFileToDictionary();
                dictionary = addNewWordInThisFileToDictionary.addNewWordInThisFileToDictionary(dictionary, indexParameter.words, fileNumber, indexParameter.wordNumber);
            }
            return dictionary;
        }
    }
}
