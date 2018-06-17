using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Trees
{
    class BST<T> where T : IComparable<T>
    {
        bool IsEmpty = true;

        BSTNodes<T> Root;
        bool IsRightChild = true;
        bool IsLeftChild = true;

        public void Search(T key)
        {
            BSTNodes<T> current = Root;
            while (current != null)
            {
                if (key.CompareTo(current.Data) == -1)
                {
                    current = current.LeftChild;
                }
                else
                {
                    current = current.RightChild;
                }
            }
        }

        public void Insert(T value)
        {
            
            if (Root == null)
            {
                Root = new BSTNodes<T>(value);
                IsEmpty = false;
            }
            else
            {
                BSTNodes<T> tempNode = Root;
                BSTNodes<T> parentNode = Root.Parent;
                while(tempNode != null)
                {
                    // if the value is less than the current node...
                    if (value.CompareTo(tempNode.Data) < 0)
                    {
                        // and if there's a left child...
                        // go down the left child
                        if (tempNode.LeftChild == null)
                        {
                            if (value.CompareTo(tempNode.Data) >= 0)
                            {
                                tempNode = tempNode.LeftChild;
                            }
                            else if (value.CompareTo(tempNode.Data) < 0)
                            {
                                tempNode.LeftChild = new BSTNodes<T>(value);
                            }
                        }
                    }

                    else
                    {
                        if (value.CompareTo(tempNode.Data) >= 0)
                        {
                             if (tempNode.RightChild == null)
                            {
                                if (value.CompareTo(tempNode.Data) <= 0)
                                {
                                    tempNode = tempNode.RightChild;
                                }
                                else if (value.CompareTo(tempNode.Data) > 0)
                                {
                                    tempNode.RightChild = new BSTNodes<T>(value);
                                }
                            }

                                        
                        }
                        
                    }
                    // otherwise if the value is greater than or equal to the current node
                    // and if there's a right child...
                    // go down the right child
                }
                

            }

        }

        void Delete(T value)
        {
            throw new NotImplementedException();
        }
    }
}
