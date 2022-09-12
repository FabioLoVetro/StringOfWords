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

        public string[] readString(String stringWord)
        {
            //split the string in an array of words
            String[] arrayWords = stringWord.Split(' ');
            //create a map
            Dictionary<String, String> position2word = new Dictionary<String, String>();
            Dictionary<String, String> position2wordSorted;
            //add the words in the map with the last letter and position as key
            for (int i = 0; i < arrayWords.Length; i++)
            {
                position2word.Add("" + arrayWords[i].ElementAt(arrayWords[i].Length - 1) + i, arrayWords[i]);
            }
            // sort the map
            position2wordSorted = new(position2word.OrderBy(key => key.Key));
            //return an array with the values
            return position2wordSorted.Values.ToArray();
        }
    }
}
