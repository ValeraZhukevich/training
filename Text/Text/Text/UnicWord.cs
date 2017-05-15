using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class UnicWord 
    {
        public List<int> listOfPages = new List<int>();
        private int unicWordCount;
        public string Content { get; }
        private int count;

        public UnicWord(string content)
            
        {
            
            
        }

        public void AddToExistUnicWord(int pageNumber)
        {
            unicWordCount++;
            if (!listOfPages.Contains(pageNumber))
                listOfPages.Add(pageNumber);
        }

        public override string ToString()
        {
            return string.Format("{0} ...........{1}: {2}", Content, unicWordCount, listOfPages.ToString());
        }

    }
}
