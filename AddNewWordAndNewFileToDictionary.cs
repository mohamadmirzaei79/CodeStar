using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddNewWordAndNewFileToDictionary
    {
        public static Dictionary<string, Dictionary<int, List<int>>> addNewWordAndNewFileToDictionary (Dictionary<string, Dictionary<int, List<int>>> dictionary, List<string> words, int fileNumber, int wordNumber, Dictionary<int, List<int>> tempdictionary,List<int> templist)
        {
            templist.Add(wordNumber);
            tempdictionary.Add(fileNumber, templist);
            dictionary.Add(words[wordNumber], tempdictionary);
            return dictionary;
        }
    }
}
