using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddNewWordInDictionary
    {
        public static Dictionary<string, Dictionary<int, List<int>>> addNewWordInDictionary(Dictionary<string, Dictionary<int, List<int>>> dictionary, List<string> words, int fileNumber, int wordNumber)
        {
            Dictionary<int, List<int>> tempdictionary = new Dictionary<int, List<int>>();
            List<int> templist = new List<int>();
            dictionary = AddNewWordAndNewFileToDictionary.addNewWordAndNewFileToDictionary(dictionary, words, fileNumber, wordNumber, tempdictionary, templist);
            return dictionary;
        }
    }
}
