using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /*https://leetcode.com/problems/palindrome-linked-list/
        Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
        Example 1:
            Input: head = [1,2,2,1]
            Output: true
        Example 2:
            Input: head = [1,2]
            Output: false
 
    Constraints:

        The number of nodes in the list is in the range[1, 105].
        0 <= Node.val <= 9
         */

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
                while (head != null)
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
