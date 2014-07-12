using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace PracticeConsole
{
    public class QuickUnionFind: IUnionFind
    {
        private int[] intArray;


        public QuickUnionFind(int N)
        {
            for (int i = 0; i < N; i++)
                intArray[i] = i;
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            intArray[i] = j;
        }

        public int Root(int p)
        {
            while (intArray[p] != p)
            {
                p = intArray[p];
            }
            return p;
        }

        public bool Connected(int p, int q)
        {
            int rootp = Root(p);
            int rootq = Root(q);
            return rootp == rootq;
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
