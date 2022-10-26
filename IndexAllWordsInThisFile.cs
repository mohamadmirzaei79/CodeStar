using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class IndexAllWordsInThisFile
    {
        public static List<string> indexAllWordsInThisFile (List<string> myfilename,List<string> words,List<int> cursor,int charNumber,int fileNumber)
        {
            for (charNumber = 0; ; charNumber++)
            {
                if (IsCharNumberZero.isCharNumberZero(charNumber)) words = AddFirstWordToIndex.addFirstWordToIndex(words, fileNumber, charNumber, cursor, myfilename);
                else words = AddNextWordToIndex.addNextWordToIndex(words, fileNumber, charNumber, cursor, myfilename);
                if (cursor[charNumber] == myfilename[fileNumber].LastIndexOf(" ")) break;
            }
            return words;   
        }
    }
}
