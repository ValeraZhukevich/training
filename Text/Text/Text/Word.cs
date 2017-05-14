using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Word
    {
        public string Content { get; }
       
        private List<int> pageNumbers = new List<int>();
        public char FirstLetterOfTheWord { get { return Content[0]; } }

        public List<int> PageNumbers
        {
            get
            {
                return pageNumbers;
            }
        }
        
        public Word(string content, int pageNumber)
        {
            Content = content;
            pageNumbers.Add(pageNumber);
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
