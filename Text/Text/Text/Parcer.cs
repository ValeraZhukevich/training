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
        List<UnicWord> listOfUnicWord = new List<UnicWord>();

        public void Send(string path)
        {
            StreamReader reader = File.OpenText(path);
            string allText = reader.ReadToEnd();
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

                foreach(string word in words)
                {
                    listOfWords.Add(new Word(word, sentence.PageNumber));                        
                }
            }

            foreach(Word word in listOfWords)
            {
                foreach(UnicWord unicword in listOfUnicWord)
                {
                    if (word.Content != unicword.Content)
                        listOfUnicWord.Add(new UnicWord(word.Content, word.PageNumber));
                    else
                        unicword.AddToExistUnicWord(word.PageNumber);
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

        public void WriteToFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);

  

            foreach (UnicWord unicWord in listOfUnicWord)
            {
                writer.WriteLine(unicWord);
            }

            writer.Close();
        }
    }
}
