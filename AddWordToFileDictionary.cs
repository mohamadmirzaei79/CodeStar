using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddWordToFileDictionary
    {
        public static Dictionary<string, Dictionary<int, List<int>>> addWordToFileDictionary(List<string> words, int fileNumber, int wordNumber, Dictionary<string, Dictionary<int, List<int>>> dictionary)
        {
            dictionary.GetValueOrDefault(words[wordNumber]).GetValueOrDefault(fileNumber).Add(wordNumber);
            return dictionary;
        }
    }
}
