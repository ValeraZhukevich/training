using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Parcer
    {
        const int numberOfSentencesOnPage = 15;
        List<Sentence> listOfSentences = new List<Sentence>();
        List<Word> listOfWords = new List<Word>();

        public void Send(string path)
        {
            StreamReader reader = File.OpenText(path);
            string allText = reader.ReadToEnd();

            char[] splittersForSentence = { '.', '!', '?' };
            char[] splittersForWords = new char[] { '\n', ',', '/', ':', '+', '-', ';', '%', '(', ')', '_', ' ', '\t', '\r' };

            string[] sentences = allText.Split(splittersForSentence, StringSplitOptions.RemoveEmptyEntries);

            int pageNumber = 1;
            int numberTheSentenceOnThisPage = 1;
            for (int i = 0; i < sentences.Length; i++)
            {
                if (numberTheSentenceOnThisPage > numberOfSentencesOnPage)
                {
                    pageNumber++;
                    numberTheSentenceOnThisPage = 1;
                }
                    
                listOfSentences.Add(new Sentence() { content = sentences[i], pageNumber = pageNumber, numberTheSentenceOnPage = numberTheSentenceOnThisPage });
            }

            foreach(Sentence sentence in listOfSentences)
            {
                string[] words = sentence.content.Split(splittersForWords, StringSplitOptions.RemoveEmptyEntries);

                foreach(string word in words)
                {
                    listOfWords.Add(new Word() { content = word, pageNumber = sentence.pageNumber });                        
                }
            }
        }

        public void Show()
        {
            Console.WriteLine(listOfWords.Count);
            foreach (Word word in listOfWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
