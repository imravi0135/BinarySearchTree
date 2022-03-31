using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Binary search tree problem ");
            ViewBST();
            Console.ReadLine();
        }
       
        public static void ViewBST()
        {
            MyBinaryTree<int> mybinarynode = new MyBinaryTree<int>();
            mybinarynode.CreateNode(56);
            mybinarynode.CreateNode(30);
            mybinarynode.CreateNode(70);
            mybinarynode.CreateNode(22);
            mybinarynode.CreateNode(40);
            mybinarynode.CreateNode(60);
            mybinarynode.CreateNode(95);
            mybinarynode.CreateNode(11);
            mybinarynode.CreateNode(65);
            mybinarynode.CreateNode(3);
            mybinarynode.CreateNode(16);
            mybinarynode.CreateNode(63);
            mybinarynode.CreateNode(67);
            mybinarynode.Root();
            mybinarynode.Display(mybinarynode.root);
            Console.WriteLine("The number of nodes in BST:{0}", mybinarynode.Size(mybinarynode.root));
            bool found = mybinarynode.Search(mybinarynode.root, 63);
            if (found == true)
            {
                Console.WriteLine("Key found");
                Console.WriteLine("the binaary Node 63  is found");
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
    }

}
    
