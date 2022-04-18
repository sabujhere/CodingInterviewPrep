using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class MiddleoftheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var slowPtr = head;
            var fastPtr = head;
            while (fastPtr != null && fastPtr.next != null)
            {
                slowPtr = slowPtr.next;
                fastPtr = fastPtr.next.next;
            }

            return slowPtr;

        }
    }
}
