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
        public static Dictionary<string, Dictionary<int, List<int>>> addExistingWordInDictionary (Dictionary<string, Dictionary<int, List<int>>> dictionary, List<string> words, int fileNumber, int wordNumber)
        {
            if (IsDictionaryContainsFile.isDictionaryContainsFile(words, fileNumber, wordNumber, dictionary))
            {
                dictionary = AddWordToFileDictionary.addWordToFileDictionary(words, fileNumber, wordNumber, dictionary);
            }
            else
            {
                AddNewWordInThisFileToDictionary addNewWordInThisFileToDictionary = new AddNewWordInThisFileToDictionary();
                dictionary = addNewWordInThisFileToDictionary.addNewWordInThisFileToDictionary(dictionary, words, fileNumber, wordNumber);
            }
            return dictionary;
        }
    }
}
