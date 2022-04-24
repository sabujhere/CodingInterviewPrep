using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 21. Merge Two Sorted Lists
    /// </summary>
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            var resultHead = new ListNode();
            var head = resultHead;
            var list1Ptr = list1;
            var list2Ptr = list2;
            while (list1Ptr != null && list2Ptr != null)
            {
                if (list1Ptr.val < list2Ptr.val)
                {
                    resultHead.next = list1Ptr;
                    list1Ptr = list1Ptr.next;
                }
                else
                {
                    resultHead.next = list2Ptr;
                    list2Ptr = list2Ptr.next;
                }
                resultHead = resultHead.next;
            }
            if (list1Ptr != null)
            {
                resultHead.next = list1Ptr;
            }
            if (list2Ptr != null)
            {
                resultHead.next = list2Ptr;
            }
            return head.next;
        }
    }
}
