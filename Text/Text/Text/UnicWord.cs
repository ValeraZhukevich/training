using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class UnicWord 
    {
        public List<int> ListOfPages { get; }
        private int UnicWordCount { get { return ListOfPages.Count; } }
        public string Content { get; }
       

        public UnicWord(string content, List<int> listOfPages)
            
        {
            Content = content;
            ListOfPages = listOfPages; 
        }

        //public void AddToExistUnicWord(int pageNumber)
        //{
        //    unicWordCount++;
        //    if (!listOfPages.Contains(pageNumber))
        //        listOfPages.Add(pageNumber);
        //}

        public override string ToString()
        {
            return string.Format("{0} ...........{1}: {2}", Content, UnicWordCount, ListOfPages);
        }

    }
}
