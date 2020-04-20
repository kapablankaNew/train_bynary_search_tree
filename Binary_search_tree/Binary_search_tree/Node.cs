using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search_tree
{
    class Node<T> : IComparable where T : IComparable
    {
        public T Data { get; private set; }

        public Node<T> Left { get; private set; }

        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item.Data);
            }
            else
            {
                throw new Exception("Несовпадение типов");
            }
        }

        public void Add(T data)
        {
            if (data.CompareTo(Data) == -1)
            {
                if (Left != null)
                {
                    Left.Add(data);
                }
                else
                {
                    var node = new Node<T>(data);
                    Left = node;
                }
            }
            else
            {
                if (Right != null)
                {
                    Right.Add(data);
                }
                else
                {
                    var node = new Node<T>(data);
                    Right = node;
                }
            }
        }

        public List<T> PreOrder()
        {
            var list = new List<T>();
            list.Add(Data);
            if (Left != null)
                list.AddRange(Left.PreOrder());
            if (Right != null)
                list.AddRange(Right.PreOrder());
            return list;
        }

        public List<T> PostOrder()
        {
            var list = new List<T>();
            if (Left != null)
                list.AddRange(Left.PostOrder());
            if (Right != null)
                list.AddRange(Right.PostOrder());
            list.Add(Data);
            return list;
        }

        public List<T> InOrder()
        {
            var list = new List<T>();
            if (Left != null)
                list.AddRange(Left.InOrder());
            list.Add(Data);
            if (Right != null)
                list.AddRange(Right.InOrder());
            return list;
        }
    }
}
