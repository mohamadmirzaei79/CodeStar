using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class IsCharBeforeLastSpace
    {
        public static bool isCharBeforeLastSpace(int cursor1, FileParameters fileParameters)
        {
            if (cursor1 < fileParameters.myfilename[fileParameters.fileNumber].LastIndexOf(" ")) return true;
            else return false;
        }
    }
}
