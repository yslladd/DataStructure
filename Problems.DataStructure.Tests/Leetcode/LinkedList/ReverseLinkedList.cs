using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DataStructure.Tests.Leetcode.LinkedList
{
    public static class ReverseLinkedList
    {        
        public static ListNode ReverseList(ListNode head)
        {
            Stack<ListNode> list = new Stack<ListNode>();
            while (head != null)
            {
                list.Push(head);
                head = head.next;
            }

            ListNode result = null;
            ListNode current = null;

            while (list.Count > 0)
            {
                if (result == null)
                {
                    result = list.Pop();
                    current = result;
                }
                else
                {
                    current.next = list.Pop();
                    current = current.next;
                }
            }

            if (current != null) current.next = null;

            return result;
        }       

    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
