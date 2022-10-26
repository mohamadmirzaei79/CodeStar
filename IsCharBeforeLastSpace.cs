using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class IsCharBeforeLastSpace
    {
        public static bool isCharBeforeLastSpace(int cursor1, int fileNumber, List<string> myfilename)
        {
            if (cursor1 < myfilename[fileNumber].LastIndexOf(" ")) return true;
            else return false;
        }
    }
}
