using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeConsole
{
    public interface IUnionFind
    {
        void Union(int p, int q);
        Boolean Connected(int p, int q);
        int find(int p);
        int count();

    }
}
