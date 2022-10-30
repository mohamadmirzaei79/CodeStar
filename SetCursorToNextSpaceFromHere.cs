using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class SetCursorToNextSpaceFromHere
    {
        public static int setCursorToNextSpaceFromHere(int cursor1,FileParameters fileParameters)
        {
            cursor1 = fileParameters.myfilename[fileParameters.fileNumber].IndexOf(" ", cursor1 + 1);
            return cursor1;
        }
    }
}
