using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class Statistic
    {
        private Dictionary<string, int> _words;

        public Dictionary<string, int> WordsCount(string text)
        {
            _words = new Dictionary<string, int>();
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim(',', '.', '-');
            }

            int spacesCount = 0;
            foreach(string word in words)
            {
                if (_words.ContainsKey(word))
                {
                    _words[word]++;
                }
                else if (word != "")
                {
                    _words.Add(word, 1);
                }
                else
                    spacesCount++;

            }
            _words.Add("всего", words.Length - spacesCount);
            return _words;
        }
    }
}
