using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddFirstWordToIndex
    {
        public static List<string> addFirstWordToIndex(IndexParameter indexParameters,FileParameters fileParameters)
        {
            indexParameters.words.Add(fileParameters.myfilename[fileParameters.fileNumber].Substring(0, indexParameters.cursor[indexParameters.charNumber]));
            return indexParameters.words;
        }
    }
}
