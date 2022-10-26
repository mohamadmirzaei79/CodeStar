using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class IsDictionaryContainsFile
    {
        public static bool isDictionaryContainsFile(List<string> words, int fileNumber, int wordNumber, Dictionary<string, Dictionary<int, List<int>>> dictionary)
        {
            if (dictionary.GetValueOrDefault(words[wordNumber]).ContainsKey(fileNumber)) return true;
            else return false;
        }
    }
}
