using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class RotateVowels
    {
        public String VowelRotate(string orgString)
        {
            char[] toCharArrary = orgString.ToCharArray();
            int i = 0;
            int j = orgString.Length - 1;
            bool flagFoundVowelUp = false;
            while(i < j)
            {
                if (flagFoundVowelUp)
                {
                    if (toCharArrary[j] == 'a' || toCharArrary[j] == 'e' || toCharArrary[j] == 'i' ||
                        toCharArrary[j] == 'o' || toCharArrary[j] == 'u')
                    {
                        char temp = toCharArrary[i];
                        toCharArrary[i] = toCharArrary[j];
                        toCharArrary[j] = temp;
                        j--;
                        i++;
                        flagFoundVowelUp = false;
                        continue;
                    }
                    else
                    {
                        j--;
                        continue;
                    }
                }
                if (toCharArrary[i] == 'a' || toCharArrary[i] == 'e' || toCharArrary[i] == 'i' || toCharArrary[i] == 'o' || toCharArrary[i] == 'u')
                {
                    flagFoundVowelUp = true;
                }
                else
                {
                    i++;
                }
            }
            return toCharArrary.ToString();
        }
    }
}
