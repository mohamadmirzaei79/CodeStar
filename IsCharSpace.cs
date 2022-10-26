using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class IsCharSpace
    {
        public static bool isCharSpace(int fileNumber, int cursor1, List<string> myfilename)
        {
            return myfilename[fileNumber][cursor1 + 1] == ' ';
        }
    }
}
