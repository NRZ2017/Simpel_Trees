using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Trees
{
    class BSTNodes<T>
    {
        public T Data;
        public BSTNodes<T> LeftChild;
        public BSTNodes<T> RightChild;
        public BSTNodes<T> Parent;

        public BSTNodes(T data)
        {
            Data = data;
        }
    }
}
