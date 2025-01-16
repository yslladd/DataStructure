using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.DataStructure.Tests.BinaryTree
{
    public static class BinaryTreeClass
    {
        public static void ConnectNodesAtSameLevel(Node root)
        {
            if (root == null)
                return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);            

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    Node current = queue.Dequeue();

                    if (i < levelSize - 1)
                        current.Next = queue.Peek();

                    if (current.Left != null)
                        queue.Enqueue(current.Left);

                    if (current.Right != null)
                        queue.Enqueue(current.Right);
                }
            }
        }

        public static void PrintConnectedNodes(Node root)
        {
            while (root != null)
            {
                Node current = root;
                while (current != null)
                {
                    Console.Write($"{current.Data} -> ");
                    current = current.Next;
                }
                Console.WriteLine("null");
                root = root.Left; // Move to the next level
            }
        }

        public static Node PrintNexMaxNode(Node root)
        {
            // if node.right exists
            // go down to the right and check if the left exist, if exist, get the last left and return
            if (root.Right != null)
            {
                Node current = root.Left;
                while (current.Left != null)
                {
                    current = current.Left;
                }
                return current; // Move to the next level
            }
            else
            {
                // go up check if you came from the right and keep going, otherwise return the left            
                Node current = root.Parent;
                if (root == current.Right)
                {
                    //came from the right
                    var upRight = current.Right;
                    while (upRight.Right != null)
                    {
                        upRight = upRight.Right;
                    }
                    return upRight;
                }
                else {
                    //came from the left
                    return current;
                }
            }
        }
    }
}
