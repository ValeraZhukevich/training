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
        List<Word> listOfUnicWord = new List<Word>();



        public void Send(string path)
        {
            StreamReader reader = File.OpenText(path);
            string allText = reader.ReadToEnd().ToLower();
            reader.Close();

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

                listOfSentences.Add(new Sentence(sentences[i], pageNumber, numberTheSentenceOnThisPage));
            }

            foreach(Sentence sentence in listOfSentences)
            {
                string[] words = sentence.Content.Split(splittersForWords, StringSplitOptions.RemoveEmptyEntries);



                foreach (string word in words)
                {
                    listOfWords.Add(new Word(word, sentence.PageNumber));                        
                }
            }

            var queryUnicWord =
                from word in listOfWords
                orderby word.Content
                group word by word.Content;
                

            foreach(var unicWordGroup in queryUnicWord)
            {
                Console.Write("{0}.......{1}: ", unicWordGroup.Key, unicWordGroup.Count());
                foreach(Word word in unicWordGroup)
                {
                    Console.Write(" {0}", word.PageNumber);
                }
                Console.WriteLine();
            }
      

            foreach (Word unic in listOfUnicWord)
            {
                Console.WriteLine(unic);
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

        public void WriteToFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);

  

            foreach(Word unicWord in listOfUnicWord)
            {
                writer.WriteLine(unicWord);
            }

            writer.Close();
        }
    }
}
