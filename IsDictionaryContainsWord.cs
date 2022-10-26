using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class IsDictionaryContainsWord
    {
        public static bool isDictionaryContainsWord(List<string> words, int wordNumber, Dictionary<string, Dictionary<int, List<int>>> dictionary)
        {
            if (dictionary.ContainsKey(words[wordNumber])) return true;
            else return false;

        }
    }
}
