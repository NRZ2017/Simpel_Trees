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
            bst.Insert(34);
            bst.Insert(2);
            bst.Delete(20);
            bst.Delete(2);
            bool x = bst.Contains(10);
            bool y = bst.Contains(35);
        }
    }
}
