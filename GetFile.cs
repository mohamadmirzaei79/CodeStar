using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class GetFile
    {
        public static void getFile(List<String> myfilename)
        {
            myfilename.Add(File.ReadAllText("D:/Index/EnglishData/57110"));
            myfilename.Add(File.ReadAllText("D:/Index/EnglishData/58043"));
            foreach (var item in myfilename)
            {
                Print.thing(item);
            }

        }
    }
}
