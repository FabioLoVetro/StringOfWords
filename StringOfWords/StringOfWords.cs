using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOfWords
{
    public class StringOfWords
    {
        private String words;

        public string[] readString(String stringWord) {
            String[] arrayWords = stringWord.Split(' ');
                return arrayWords;
        }
    }
}
