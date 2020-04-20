using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search_tree
{
    class BinaryTree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }

        public int Count { get; set; }

        public void Add(T item)
        {
            if (Root == null)
            {
                var node = new Node<T>(item);
                Root = node;
                Count = 1;
                return;
            }

            Root.Add(item);
            Count++;
        }

        public List<T> Preorder()
        {
            if (Root != null)
            {
                var list = Root.PreOrder();
                return list;
            }
            return new List<T>();
        }

        public List<T> Postorder()
        {
            if (Root != null)
            {
                var list = Root.PostOrder();
                return list;
            }
            return new List<T>();
        }

        public List<T> Inorder()
        {
            if (Root != null)
            {
                var list = Root.InOrder();
                return list;
            }
            return new List<T>();
        }
    }
}
