using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class IndexAllWordsInThisFile
    {
        public static List<string> indexAllWordsInThisFile (IndexParameter indexParameters, FileParameters fileParameters)
        {
            for (indexParameters.charNumber = 0; ; indexParameters.charNumber++)
            {
                if (IsCharNumberZero.isCharNumberZero(indexParameters.charNumber)) indexParameters.words = AddFirstWordToIndex.addFirstWordToIndex(indexParameters,fileParameters);
                else indexParameters.words = AddNextWordToIndex.addNextWordToIndex(indexParameters,fileParameters);
                if (indexParameters.cursor[indexParameters.charNumber] == fileParameters.myfilename[fileParameters.fileNumber].LastIndexOf(" ")) break;
            }
            return indexParameters.words;   
        }
    }
}
