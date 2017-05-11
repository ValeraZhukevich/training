using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Sentence
    {
        public int pageNumber;
        public string content;
        public int numberTheSentenceOnPage;

        public override string ToString()
        {
            return content;
        }
    }
}
