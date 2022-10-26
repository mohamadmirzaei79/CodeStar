using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class TrimThisWordAndPrint
    {
        public static string trimThisWordAndPrint(string words)
        {
            words = words.Trim();
            Console.WriteLine(words);
            return words;
        }
    }
}
