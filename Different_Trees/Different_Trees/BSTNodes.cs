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

        public int ChildCount
        {
            get
            {
                int childCount = 0;
                if (LeftChild != null) childCount++;
                if (RightChild != null) childCount++;
                return childCount;
            }
        }

        public BSTNodes<T> FirstChild
        {
            get
            {
                if (LeftChild != null)
                {
                    return LeftChild;
                }
                else if (RightChild != null)
                {
                    return RightChild;
                }
                else
                {
                    return null;
                }

            }
        }


        public BSTNodes(T data, BSTNodes<T> parent = null)
        {
            Data = data;
            Parent = parent;
        }
    }
}
