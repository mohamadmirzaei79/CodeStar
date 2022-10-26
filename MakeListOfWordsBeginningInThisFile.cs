using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class MakeListOfWordsBeginningInThisFile
    {
        public static List<int> makeListOfWordsBeginningInThisFile(int fileNumber, int charNumber, int cursor1, List<int> cursor, List<string> myfilename)
        {
            for (charNumber = 0; IsCharBeforeLastSpace.isCharBeforeLastSpace(cursor1, fileNumber, myfilename);)
            {
                if (IsCharSpace.isCharSpace(fileNumber, cursor1, myfilename))
                {
                    cursor1++;
                    continue;
                }
                if (IsCharFirstOfDocument.isCharFirstOfDocument(charNumber)) cursor1 = SetCursorToFirstSpaceOfFile.setCursorToFirstSpaceOfFile(cursor1, fileNumber, myfilename);
                else cursor1 = SetCursorToNextSpaceFromHere.setCursorToNextSpaceFromHere(cursor1, fileNumber, myfilename);
                cursor.Add(cursor1);
                charNumber++;
            }
            return cursor;
        }
    }
}
