using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Trees
{
    class BST<T> where T : IComparable<T>
    {
        public int Count { get; private set; }

        public bool IsEmpty
        {
            get
            {
                return Count == 0;
            }
        }

        BSTNodes<T> Root;


        public bool Contains(T key)
        {
            BSTNodes<T> current = Root;
            while (current != null)
            {
                if (key.CompareTo(current.Data) < 0)
                {
                    current = current.LeftChild;
                }
                else if (key.CompareTo(current.Data) > 0)
                {
                    current = current.RightChild;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public bool Delete(T value)
        {
            BSTNodes<T> tempnode = Root;
            while (tempnode != null)
            {
                if (value.CompareTo(tempnode.Data) < 0)
                {
                    tempnode = tempnode.LeftChild;
                }
                else if (value.CompareTo(tempnode.Data) > 0)
                {
                    tempnode = tempnode.RightChild;
                }
                else
                {
                    RemoveNode(tempnode);
                    Count--;
                    return true;
                }
            }

            return false;
        }

        private void RemoveNode(BSTNodes<T> node)
        {
            if (node.ChildCount == 0)
            {
                //remove parent pointer to us
                if (node.Parent.LeftChild == node)
                {
                    node.Parent.LeftChild = null;
                }
                else
                {
                    node.Parent.RightChild = null;
                }
            }
            else if (node.ChildCount == 1)
            {
                //link parent and child 
                var child = node.FirstChild;
                child.Parent = node.Parent;
                if (node.Parent.LeftChild == node)
                {
                    node.Parent.LeftChild = child;
                }
                else
                {
                    node.Parent.RightChild = child;
                }
            }
            else if (node.ChildCount == 2)
            {
                //find prime node: left once, all the way right
                //copy prime nodes value into temp value
                //recursive delete prime node (non-recursive: make another function)
                var primeNode = node.LeftChild;
                while (primeNode.RightChild != null)
                {
                    primeNode = primeNode.RightChild;
                }
                node.Data = primeNode.Data;
                RemoveNode(primeNode);
            }
        }


        public void Insert(T value)
        {
            Count++;
            if (Root == null)
            {
                Root = new BSTNodes<T>(value);
            }
            else
            {
                BSTNodes<T> tempNode = Root;

                while (tempNode != null)
                {
                    if (value.CompareTo(tempNode.Data) < 0)
                    {
                        if (tempNode.LeftChild != null)
                        {
                            tempNode = tempNode.LeftChild;
                        }
                        else
                        {
                            //add a left child
                            tempNode.LeftChild = new BSTNodes<T>(value, tempNode);
                            break;
                        }
                    }
                    else if (value.CompareTo(tempNode.Data) >= 0)
                    {
                        if (tempNode.RightChild != null)
                        {
                            tempNode = tempNode.RightChild;
                        }
                        else
                        {
                            tempNode.RightChild = new BSTNodes<T>(value, tempNode);
                            break;
                        }
                    }
                }
            }


        }
    }
}
