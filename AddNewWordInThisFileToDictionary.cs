using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal class AddNewWordInThisFileToDictionary
    {
        public Dictionary<string, Dictionary<int, List<int>>> addNewWordInThisFileToDictionary (Dictionary<string, Dictionary<int, List<int>>> dictionary, List<string> words,int fileNumber,int wordNumber)
        {
            Dictionary<int, List<int>> tempdictionary2 = new Dictionary<int, List<int>>();
            List<int> templist2 = new List<int>();
            templist2.Add(wordNumber);
            tempdictionary2.Add(fileNumber, templist2);
            dictionary.GetValueOrDefault(words[wordNumber]).Add(fileNumber, templist2);
            return dictionary;
        }
    }
}
