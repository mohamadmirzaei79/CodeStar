using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class SetCursorToNextSpaceFromHere
    {
        public static int setCursorToNextSpaceFromHere(int cursor1, int u, List<string> myfilename)
        {
            cursor1 = myfilename[u].IndexOf(" ", cursor1 + 1);
            return cursor1;
        }
    }
}
