using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class UnicWord : IWord
    {
        public string Content { get; }
        public char FirstLetter { get { return Content[0]; } }
        public List<int> ListOfPages { get; }
        private int UnicWordCount { get { return ListOfPages.Count; } }

        public List<int> GetListOfUnicPages()
        {
            List<int> listOfUnicPages = new List<int>();
            foreach(int page in ListOfPages)
            {
                if (!listOfUnicPages.Contains(page))
                {
                    listOfUnicPages.Add(page);
                }
            }
            return listOfUnicPages;  
        }


        public UnicWord(string content, List<int> listOfPages)

        {
            Content = content;
            ListOfPages = listOfPages;
        }

 
        public override string ToString()
        {
            return string.Format("{0} .....{1}:", Content, UnicWordCount);
            
        }



    }
}
