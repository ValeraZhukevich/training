﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Text
    {
        public int NumberOfSentences { get { return ListOfSenteces.Count(); } }
        public int NumberOfWords;
        private const int numberOfSentencesOnPage = 10;
        public IList<Sentence> ListOfSenteces { get; }
    }
}
