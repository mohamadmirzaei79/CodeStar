using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddNextWordToIndex
    {
        public static List<string> addNextWordToIndex(List<string> words, int fileNumber, int charNumber, List<int> cursor, List<string> myfilename)
        {
            words.Add(myfilename[fileNumber].Substring(cursor[charNumber - 1] + 1, cursor[charNumber] - cursor[charNumber - 1])); ;
            return words;
        }
    }
}
