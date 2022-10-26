using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal static class MakeDictionaryInThisFiles
    {
        public static Dictionary<string, Dictionary<int, List<int>>> makeDictionaryInThisFiles (Dictionary<string, Dictionary<int, List<int>>> dictionary,List<string> myfilename, int fileNumber, int wordNumber)
        {
            for (fileNumber = 0; fileNumber < 2; fileNumber++)
            {
                Cursor cursor = new Cursor();
                Words words = new Words();
                CharNumber charNumber = new CharNumber();
                Cursor1 cursor1 = new Cursor1();
                cursor.cursor = MakeListOfWordsBeginningInThisFile.makeListOfWordsBeginningInThisFile(fileNumber, charNumber.charNumber, cursor1.cursor1, cursor.cursor, myfilename);
                words.words = IndexAllWordsInThisFile.indexAllWordsInThisFile(myfilename, words.words, cursor.cursor, charNumber.charNumber, fileNumber);
                for (int j = 0; IsCounterLessThan.isCounterLesserThan(j, words.words.Count); j++)
                {
                    words.words[j] = TrimThisWordAndPrint.trimThisWordAndPrint(words.words[j]);
                }
                dictionary = AddAllWordsInThisFileToIndexDictionary.addAllWordsInThisFileToIndexDictionary(dictionary, words.words, fileNumber, wordNumber);
            }
            return dictionary; 
        }
    }
}
