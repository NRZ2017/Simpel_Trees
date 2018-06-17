using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BST<int> bst = new BST<int>();

            bst.Insert(10);
            bst.Insert(20);
            bst.Insert(14);
        }
    }
}
