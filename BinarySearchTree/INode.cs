using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class INode<T>
    {
        public T data;
        internal INode<T> left;
        internal INode<T> right;

        public INode(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}

