using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class InsertionSort : BaseArrayClass
    {
        private int[] intArray = new int[11];

        public void SortResults()
        {
            int lenOfArray = intArray.Length;
            int tempVar=0;
            for (int i = 0; i < lenOfArray; i++)
            {
                tempVar = intArray[i];
                int j = i - 1;
                while (j >= 0 && intArray[j] > tempVar)
                {
                    intArray[j + 1] = intArray[j];
                    j = j - 1;
                }
                intArray[j + 1] = tempVar;
            }
        }


    }
}
