using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public class Solution
        {
            public static void Main()
            {
                Solution s = new Solution();
                s.IsPalindrome(new ListNode(0, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(2, new ListNode(1, new ListNode(0))))))))); // returns true
                s.IsPalindrome(new ListNode(0, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(2, new ListNode(5, new ListNode(0))))))))); // returns false
            }


            public bool IsPalindrome(ListNode head)
            {
                var values = new List<int>();
                while(head != null)
                {
                    values.Add(head.val);
                    head = head.next;
                }

                int x = 0;
                int end = values.Count() - 1;
                while (x < end)
                {
                    if (values[x] != values[end])
                        return false;
                    x++;
                    end--;
                }

                int[] a = new int[1];


               return true;
            }
        }
    }
}
