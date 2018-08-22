using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeOrder
{
    class Program
    {
        public class Node
        {
            public Node Next;
            public int OrderId;
        }
        public class NodeTree
        {
            public NodeTree Right;
            public NodeTree Left;
            public int OrderId;
        }
        static void InsertNode(Node node, int num)
        {

        }
        static void InsertTree(NodeTree tree, int num)
        {

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Node Order:");
            Node node = new Node() { OrderId = 10 };
            InsertNode(node, 9);
            InsertNode(node, 11);
            InsertNode(node, 12);
            InsertNode(node, 8);
            InsertNode(node, 13);
            InsertNode(node, 1);
            InsertNode(node, 40);
            InsertNode(node, 8);
            InsertNode(node, 100);
            InsertNode(node, 2);
            PrintAllNodes(node);
            Console.WriteLine("\nTree Order:");
            NodeTree tree = new NodeTree() { OrderId = 10 };
            InsertTree(tree, 15);
            InsertTree(tree, 12);
            InsertTree(tree, 8);
            InsertTree(tree, 40);
            InsertTree(tree, 30);
            InsertTree(tree, 100);
            InsertTree(tree, 1);
            PrintTree(tree, "");

            Console.ReadLine();
        }





        static void PrintTree(NodeTree root, string prefix)
        {
            if(root == null)
            {
                Console.WriteLine(prefix + "+- <null>");
                return;
            }
            Console.WriteLine(prefix + "+- " + root.OrderId);
            PrintTree(root.Left, prefix + "|  ");
            PrintTree(root.Right, prefix + "|  ");

        }
        static void PrintAllNodes(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.OrderId);
                current = current.Next;
            }
        }
    }
}
