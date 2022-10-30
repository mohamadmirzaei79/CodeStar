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
        public static Dictionary<string, Dictionary<int, List<int>>> addNewWordAndNewFileToDictionary (Dictionary<string, Dictionary<int, List<int>>> dictionary, int fileNumber, IndexParameter indexParameter)
        {
            dictionary.Add(indexParameter.words[indexParameter.wordNumber], new Dictionary<int, List<int>> { [fileNumber] = new List<int> { { indexParameter.wordNumber} } });
            return dictionary;
        }
    }
}
