using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddNewWordInDictionary
    {
        public static Dictionary<string, Dictionary<int, List<int>>> addNewWordInDictionary(Dictionary<string, Dictionary<int, List<int>>> dictionary, int fileNumber,IndexParameter indexParameter)
        {
            
            dictionary = AddNewWordAndNewFileToDictionary.addNewWordAndNewFileToDictionary(dictionary, fileNumber, indexParameter);
            return dictionary;
        }
    }
}
