using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class Search
    {
        public static void search(Dictionary<string, Dictionary<int, List<int>>> dictionary)
        {
            string searchWord;
            Console.WriteLine("Write your Word :");
            searchWord = Console.ReadLine();
            if (searchWord.Equals(""))
            {
                Console.WriteLine("Error, you wrote nothing!");
            }
            else Print.thing(dictionary[searchWord]);
        }
    }
}
