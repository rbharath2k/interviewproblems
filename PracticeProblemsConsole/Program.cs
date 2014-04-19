using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSort myInsertionSort = new InsertionSort();
            myInsertionSort.DisplayArray();
            myInsertionSort.SortResults();
            myInsertionSort.DisplayArray();
            Console.ReadLine();
        }
    }
}
