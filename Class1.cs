using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Text.Json.JsonSerializer;

namespace CodeStar
{
    public static class Print
    {
        public static void thing (object input)
        {
            
            Console.WriteLine(Serialize(input));

        }
    }
    public class Indexing
    {
        
        public Dictionary<string, Dictionary<int , List<int>>> dictionary { get; set; } = new Dictionary<string, Dictionary<int, List<int>>>();

        FileParameters fileParameters = new FileParameters();
        
        public void Index ()
        {
            GetFile.getFile(fileParameters.myfilename);
            dictionary = MakeDictionaryInThisFiles.makeDictionaryInThisFiles(fileParameters, dictionary);
            Search.search(dictionary);
        }
        

    }
}