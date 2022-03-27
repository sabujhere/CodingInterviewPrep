using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 141. Linked List Cycle
    /// </summary>
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            var slow = head;
            var fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
