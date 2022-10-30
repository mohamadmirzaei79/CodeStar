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
        public static Dictionary<string, Dictionary<int, List<int>>> makeDictionaryInThisFiles(FileParameters fileParameters, Dictionary<string, Dictionary<int, List<int>>> dictionary)
        {
            for (fileParameters.fileNumber = 0; fileParameters.fileNumber < 2; fileParameters.fileNumber++)
            {
                IndexParameter indexParameter = new IndexParameter();   
                indexParameter.cursor = MakeListOfWordsBeginningInThisFile.makeListOfWordsBeginningInThisFile(indexParameter,fileParameters);
                indexParameter.words = IndexAllWordsInThisFile.indexAllWordsInThisFile(indexParameter,fileParameters);
                for (int j = 0; IsCounterLessThan.isCounterLesserThan(j, indexParameter.words.Count); j++)
                {
                    indexParameter.words[j] = TrimThisWordAndPrint.trimThisWordAndPrint(indexParameter.words[j]);
                }
                dictionary = AddAllWordsInThisFileToIndexDictionary.addAllWordsInThisFileToIndexDictionary(dictionary, indexParameter, fileParameters.fileNumber);
            }
            return dictionary; 
        }
    }
}
