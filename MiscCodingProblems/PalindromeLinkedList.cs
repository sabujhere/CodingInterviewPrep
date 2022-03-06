using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 234. Palindrome Linked List
    /// </summary>
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            slow = Reverse(slow);
            fast = head;
            while(slow != null)
            {
                if(slow.val != fast.val) return false;
                slow = slow.next;
                fast = fast.next;
            }
            return true;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            while(head != null)
            {
                ListNode node = head.next;
                head.next = prev;
                prev = head;
                head = node;
            }

            return prev;
        }
    }


    

}
