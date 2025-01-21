using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Problems.DataStructure.Tests.BinaryTree;
using Problems.DataStructure.Tests.BinaryGapInteger;
using Problems.DataStructure.Tests.Fibonacci;
using System.Collections.Generic;
using Problems.DataStructure.Tests.Leetcode.Arrays;
using Problems.DataStructure.Tests.OddNumbers;
using System.Xml;
using Problems.DataStructure.Tests.Leetcode.LinkedList;

namespace Problems.DataStructure.Tests
{
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Connect nodes at the same level in a binary tree
        /// </summary>
        [TestMethod]
        public void BinaryTreeMax()
        {
            // Create a sample binary tree
            Node root = new Node(20);

            root.Right = new Node(25);
            root.Right.Parent = new Node(20);

            root.Left = new Node(9);
            root.Left.Parent = new Node(20);
            root.Left.Left = new Node(5);
            root.Left.Left.Parent = new Node(9);

            root.Left.Right = new Node(12);
            root.Left.Right.Parent = new Node(9);

            root.Left.Right.Right = new Node(14);
            root.Left.Right.Right.Parent = new Node(12);

            root.Left.Right.Left = new Node(11);
            root.Left.Right.Left.Parent = new Node(12);


            Console.WriteLine("Binary Tree before connecting nodes:");
            BinaryTreeClass.PrintConnectedNodes(root);

            Console.WriteLine("Print the next max node:");
            var current = BinaryTreeClass.PrintNexMaxNode(root.Left.Right.Right); // 12. Result: 14
            Console.Write($"-> {current.Data}");
        }


        /// <summary>
        /// Connect nodes at the same level in a binary tree
        /// </summary>
        [TestMethod]
        public void BinaryTree()
        {
            // Create a sample binary tree
            Node root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);
            root.Right.Left = new Node(6);
            root.Right.Right = new Node(7);

            Console.WriteLine("Binary Tree before connecting nodes:");
            BinaryTreeClass.PrintConnectedNodes(root);

            BinaryTreeClass.ConnectNodesAtSameLevel(root);

            Console.WriteLine("\nBinary Tree after connecting nodes:");
            BinaryTreeClass.PrintConnectedNodes(root);
        }

        /// <summary>
        /// A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.
        /// For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.        
        /// Write a function:        
        /// class Solution { public int solution(int N); }        
        /// that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.        
        /// For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.        
        /// Write an efficient algorithm for the following assumptions:        
        /// N is an integer within the range [1..2,147,483,647]         
        /// </summary>
        /// <param name="n"></param>
        [TestMethod]
        public void GetBinaryGapFromAnInteger()
        {
            int num = 529; //1000010001
            var numExpected = 4;

            var result = BinaryGap.GetBinaryGap(num);

            Assert.AreEqual(numExpected, result);
        }

        [TestMethod]
        [DataRow(5)]
        public void Fibonacci(int num)
        {
            var sequence = FibonacciClass.Fibonacci(num);
            foreach (var item in sequence)
            {
                Console.Write(item + " ");
            }
        }

        [TestMethod]
        public void FibonacciGPT()
        {
            // GPT 3.5
            int num = 10;
            List<int> sequence = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write(FibonacciClass.FibonacciGPT(i) + " ");
            }
        }

        [TestMethod]
        public void OddOccurrencesInArray()
        {
            int odd = OddNumbersClass.OddOccurrencesInArrayAnswer2();
            Console.Write(odd);
        }

        [TestMethod]
        public void OddOccurrencesInArrayGPT()
        {
            // GPT 3.5
            int result = OddNumbersClass.OddOccurrencesInArrayAnswer();
            Console.Write(result);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(7, 1, 5, 3, 6, 4)]
        [DataRow(2, 1, 4)]
        [DataRow(2, 4, 1)]
        public void BestTimeBuysSellStock(params int[] prices)
        {
            int result = BestTimeBuySellStock.MaxProfit(prices);
            Console.WriteLine(result);
        }


        [TestMethod]
        [DataRow(1, 2, 3, 1)]
        [DataRow(1, 2, 3, 4)]
        [DataRow(1, 1, 1, 3, 3, 4, 3, 2, 4, 2)]
        public void ContainsDuplicateTest(params int[] nums)
        {
            bool result = ContainsDuplicate.ContainsDuplicateNumbers(nums);
            Console.WriteLine(result);
        }

        [TestMethod]
        [DataRow(1, 2, 3, 4)]
        public void ProductOfArrayExceptSelfTest(params int[] nums)
        {
            int[] result = ProductOfArrayExceptSelf.ProductOfArrayExceptSelfAnswer(nums);
            Console.WriteLine(result);
        }

        [TestMethod]
        [DataRow(-2, 1, -3, 4, -1, 2, 1, -5, 4)]
        [DataRow(1)]
        [DataRow(5, 4, -1, 7, 8)]
        public void MaximumSubarrayTest(params int[] nums)
        {
            int result = MaximumSubarray.MaximumSubarrayAnswer(nums);
            Console.WriteLine(result);
        }


        [TestMethod]
        [DataRow(-1, 0, 1, 2, -1, -4)]
        public void ThreeSumTest(params int[] nums)
        {
            IList<IList<int>> result = ThreeSum.ThreeSumAnswer(nums);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void ReverseLinkedListTest()
        {
            ListNode listNode = new ListNode(1, 
                new ListNode(2, 
                    new ListNode(3, 
                        new ListNode(4, 
                            new ListNode(5)))));

            var result = ReverseLinkedList.ReverseList(listNode);            
            Console.WriteLine(result);
        }

    }


}
