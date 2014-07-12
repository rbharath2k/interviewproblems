using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class SimpleUnionFind : IUnionFind
    {
        private int[] intArray;

        public SimpleUnionFind(int N)
        {
            for (int i = 0; i < N; i++)
                intArray[i] = i;
        }

        public void Union(int p, int q)
        {
            int pid = intArray[p];
            int qid = intArray[q];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == pid)
                    intArray[i] = qid;
            }
        }

        public Boolean Connected(int p, int q)
        {
            return intArray[p] == intArray[q];
        }

        public int find(int p)
        {
            throw new NotImplementedException();
        }

        public int count()
        {
            throw new NotImplementedException();
        }
    }
}
