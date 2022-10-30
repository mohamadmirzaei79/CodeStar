using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class SetCursorToFirstSpaceOfFile
    {
        public static int setCursorToFirstSpaceOfFile(int cursor1, FileParameters fileParameters)
        {
            cursor1 = fileParameters.myfilename[fileParameters.fileNumber].IndexOf(" ");
            return cursor1;

        }
    }
}
