using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddFirstWordToIndex
    {
        public static List<string> addFirstWordToIndex(List<string> words, int fileNumber, int charNumber, List<int> cursor, List<string> myfilename)
        {
            words.Add(myfilename[fileNumber].Substring(0, cursor[charNumber]));
            return words;
        }
    }
}
