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
        const int numberOfSentencesOnPage = 10;
        IList<Sentence> listOfSentences = new List<Sentence>();
        IList<Word> listOfWords = new List<Word>();
        IList<UnicWord> listOfUnicWord = new List<UnicWord>();



        public void Send(string path)
        {
            char[] splittersForSentence = { '.', '!', '?' };
            char[] splittersForWords = new char[] { '\n', ',', '/', ':', '+', '-', ';', '%', '(', ')', '_', ' ', '\t', '\r', '"', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string allText = reader.ReadToEnd().ToLower();
                    string[] sentences = allText.Split(splittersForSentence, StringSplitOptions.RemoveEmptyEntries);

                    int pageNumber = 1;
                    int numberSentence = 0; 
                    for (int i = 0; i < sentences.Length; i++)
                    {
                        numberSentence++;
                        pageNumber = (int)Math.Ceiling((double)(numberSentence / numberOfSentencesOnPage) + 1);                    
                        listOfSentences.Add(new Sentence(sentences[i], pageNumber));
                    }

                    foreach (Sentence sentence in listOfSentences)
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


                    foreach (var unicWordGroup in queryUnicWord)
                    {

                        IList<int> temp = new List<int>();
                        foreach (Word word in unicWordGroup)
                        {
                            temp.Add(word.PageNumber);
                        }

                        listOfUnicWord.Add(new UnicWord(unicWordGroup.Key, temp));

                    }


                    foreach (UnicWord unic in listOfUnicWord)
                    {
                        Console.WriteLine(unic);
                    }

                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void WriteToFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);

            var queryUnicWordsByFirstLetter =
                        from unicWord in listOfUnicWord
                        orderby unicWord.FirstLetter
                        group unicWord by unicWord.FirstLetter;

            foreach(var unicWordsGroupByFirsLetter in queryUnicWordsByFirstLetter)
            {
                writer.WriteLine(unicWordsGroupByFirsLetter.Key.ToString().ToUpper());

                foreach (UnicWord unicWord in unicWordsGroupByFirsLetter)
                {
                    writer.Write(unicWord);
                    List<int> temp = unicWord.GetListOfUnicPages();
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (i != temp.Count - 1)
                        {
                            writer.Write(" {0},", temp[i]);
                        }
                        else
                        {
                            writer.Write(" {0}", temp[i]);
                        }

                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
            }

            writer.Close();
        }

    }
}
