using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class ReverseASentence
    {
        private char[] ReverseString(char[] text, int leftInd, int rightInd)
        {
            char tempChar;
            if (text.Length == 0)
                return null;
            while (leftInd < rightInd)
            {
                tempChar = text[leftInd];
                text[leftInd] = text[rightInd];
                text[rightInd] = tempChar;
                leftInd++;
                rightInd--;
            }
            return text;
        }

        public String ReverseSentence(String sentence)
        {
            int lIndex = 0;
            int rIndex = sentence.Length - 1;
            if (rIndex > lIndex)
            {
                char[] reversedSentence = ReverseString(sentence.ToCharArray(), lIndex, rIndex);

                for (rIndex=0; rIndex <= sentence.Length; rIndex++)
                {
                    if (rIndex == sentence.Length || reversedSentence[rIndex] == ' ')
                    {
                        reversedSentence = ReverseString(reversedSentence, lIndex, rIndex);
                        lIndex = rIndex + 1;
                    }
                }
                return reversedSentence.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
