using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStar
{
    internal class IndexParameter
    {
        public int wordNumber { get; set; }
        public int charNumber { get; set; }
        public int cursor1 { get; set; } = 0;
        public List<int> cursor { get; set; } = new List<int>();
        public List<string> words { get; set; } = new List<string>();
    }
}
