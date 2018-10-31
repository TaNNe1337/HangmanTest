using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Hangman
    {
        WordGenerator wg = new WordGenerator();
        public char[] Characters { get; private set; }
        public char[] GuessedWord { get; set; }
        public int WrongGuesses { get; set; }

        public void init()
        {
            String words = wg.getWord().ToUpper();
            Characters = words.ToCharArray();
        }
        public void reset()
        {
            WrongGuesses = 0;
            GuessedWord = null;
            Characters = null;
        }
           
    }
}
