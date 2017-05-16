using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Word : IWord
    {
        public string Content { get; }
        public char FirstLetter { get { return Content[0]; } }

        public int PageNumber { get; }
        public char FirstLetterOfTheWord { get { return Content[0]; } }


        public Word(string content, int pageNumber)
        {
            Content = content;
            PageNumber = pageNumber;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
