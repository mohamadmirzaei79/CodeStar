using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class MakeListOfWordsBeginningInThisFile
    {
        public static List<int> makeListOfWordsBeginningInThisFile(IndexParameter indexParameters,FileParameters fileParameters)
        {
            for (indexParameters.charNumber = 0; IsCharBeforeLastSpace.isCharBeforeLastSpace(indexParameters.cursor1,fileParameters);)
            {
                if (IsCharSpace.isCharSpace(indexParameters.cursor1, fileParameters))
                {
                    indexParameters.cursor1++;
                    continue;
                }
                if (IsCharFirstOfDocument.isCharFirstOfDocument(indexParameters.charNumber)) indexParameters.cursor1 = SetCursorToFirstSpaceOfFile.setCursorToFirstSpaceOfFile(indexParameters.cursor1, fileParameters);
                else indexParameters.cursor1 = SetCursorToNextSpaceFromHere.setCursorToNextSpaceFromHere(indexParameters.cursor1,fileParameters);
                indexParameters.cursor.Add(indexParameters.cursor1);
                indexParameters.charNumber++;
            }
            return indexParameters.cursor;
        }
    }
}
