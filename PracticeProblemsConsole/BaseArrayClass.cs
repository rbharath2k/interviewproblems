using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public abstract class BaseArrayClass
    {
        private int[] intArray = new int[11];

        public BaseArrayClass()
        {
            Random rand = new Random();
            for (int i = 0; i <= 10; i++)
            {
                intArray[i] = rand.Next(1, 101);
            }
        }

        public void DisplayArray()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
