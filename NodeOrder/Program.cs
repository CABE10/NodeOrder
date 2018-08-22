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
        static void InsertNode(ref Node node, int num)
        {
            Node current = node;
            while (current != null)
            {
                if(num > current.OrderId)
                {
                    if (current.Next == null)
                    {
                        current.Next = new Node() { OrderId = num };
                        break;
                    }
                }
                else if(num == current.OrderId)
                {
                    Node next = new Node() { OrderId = num, Next = current.Next };
                    current.Next = next;
                    break;
                }
                else if(num < current.OrderId)
                { //I am less than the current node. I need to go before.
                    node = new Node() { OrderId = num, Next = current };
                    break;
                }
                current = current.Next;
            }
        }
        static void InsertTree(NodeTree tree, int num)
        {
            if(num < tree.OrderId)
            {
                if(tree.Left != null)
                {
                    InsertTree(tree.Left, num);
                }
                else
                {
                    tree.Left = new NodeTree() { OrderId = num };
                }
            }
            else if (num > tree.OrderId)
            {
                if(tree.Right != null)
                {
                    InsertTree(tree.Right, num);
                }
                else
                {
                    tree.Right = new NodeTree() { OrderId = num };
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Node Order:");
            Node node = new Node() { OrderId = 10 };
            InsertNode(ref node, 9);
            InsertNode(ref node, 11);
            InsertNode(ref node, 12);
            InsertNode(ref node, 8);
            InsertNode(ref node, 13);
            InsertNode(ref node, 1);
            InsertNode(ref node, 40);
            InsertNode(ref node, 8);
            InsertNode(ref node, 100);
            InsertNode(ref node, 2);
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
            PrintTree(tree, ""); //looks odd, but it works.

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
