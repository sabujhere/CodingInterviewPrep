using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 206. Reverse Linked List
    /// </summary>
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode node;
            ListNode prev = null;
            while (head != null)
            {
                node = head.next;
                head.next = prev;
                prev = head;
                head = node;
            }
            return prev;
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
