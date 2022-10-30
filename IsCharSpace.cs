using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class IsCharSpace
    {
        public static bool isCharSpace(int cursor1, FileParameters fileParameters)
        {
            return fileParameters.myfilename[fileParameters.fileNumber][cursor1 + 1] == ' ';
        }
    }
}
