using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class AddNextWordToIndex
    {
        public static List<string> addNextWordToIndex(IndexParameter indexParameters,FileParameters fileParameters)
        {
            indexParameters.words.Add(fileParameters.myfilename[fileParameters.fileNumber].Substring(indexParameters.cursor[indexParameters.charNumber - 1] + 1, indexParameters.cursor[indexParameters.charNumber] - indexParameters.cursor[indexParameters.charNumber - 1])); ;
            return indexParameters.words;
        }
    }
}
