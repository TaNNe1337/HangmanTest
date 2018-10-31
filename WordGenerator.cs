using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class WordGenerator
    {
        public WordGenerator(){
            FileStream fs = new FileStream(@"Words.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string line;
            while (sr.Peek() != -1)
            {
                line = sr.ReadLine();
                words.Add(line);
            }
            sr.Close();
            fs.Close();
    }
        private List<String> words = new List<String>();

        public String getWord(){
            Random r = new Random();
            int index = r.Next(0, words.Count);
            return words[index];
        }

    }
}
