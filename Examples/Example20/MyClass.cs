using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example20
{
    class MyClass
    {
        public string text;

        public void helloWorld()
        {
            text = "Hello World!";
        }

        public void resetText()
        {
            text = " ";
        }

        public void setText(string text)
        {
            this.text = text;
        }

        public string makeSentence(string[] words)
        {
            string sentence = "";
            foreach (string word in words)
            {
                sentence += " " + word;
            }

            return sentence;
        }

        public bool compareStrings(string a, string b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }

        public string[] seperateWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            return words;
        }

    }
}
