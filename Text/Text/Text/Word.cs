using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Word
    {
        public string content;
        private char firstLetterOfTheWord;
        public int pageNumber;
        public char FirstLetterOfTheWord { get { return content[0]; } }

        public override string ToString()
        {
            return content;
        }
    }
}
