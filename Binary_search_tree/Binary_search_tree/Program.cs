using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();

            tree.Add(5);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(8);
            tree.Add(7);
            tree.Add(6);
            tree.Add(9);

            var lst = tree.Preorder();

            foreach (var item in lst)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();

            lst = tree.Postorder();

            foreach (var item in lst)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();

            lst = tree.Inorder();

            foreach (var item in lst)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.ReadKey();
        }
    }
}
