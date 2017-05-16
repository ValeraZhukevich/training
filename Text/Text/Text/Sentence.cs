using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Sentence
    {
        public int PageNumber { get; }
        public string Content { get; }


        public Sentence(string content, int pageNumber)
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
