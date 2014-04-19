using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class MergeSort : BaseArrayClass
    {
        private int[] intArray = new int[11];

        public void SortResults()
        {
            
        }

        public void MergeSorting(int[] array)
        {
            int[] helper = new int[array.Length];
            MergeSortingHelper(array, helper, 0, array.Length - 1);
        }

        void MergeSortingHelper(int[] array, int[] helper, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high)/2;
                MergeSortingHelper(array,helper,low,middle);
                MergeSortingHelper(array,helper,middle+1,high);
                MergeArrays(array, helper, low, middle, high);
            }
        }

        void MergeArrays(int[] array, int[] helper, int low, int middle, int high)
        {
            
        }
    }
}
