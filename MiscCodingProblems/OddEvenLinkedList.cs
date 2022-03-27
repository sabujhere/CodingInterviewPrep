using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 
    /// </summary>
    class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;

            var odd = head;
            var even = odd.next;
            var evenHead = even;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenHead;
            return head;
        }
    }
}
