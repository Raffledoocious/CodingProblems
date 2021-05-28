using System.Collections.Generic;

namespace CodingProblems
{
 
	public static class MergeSortedLists 
	{
		public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 == null) return l2;
			if (l2 == null) return l1;

			var head = new ListNode(0);
			var runner = head;

			while (l1 != null && l2 != null)
			{
				if (l1.val <= l2.val)
				{
					runner.next = l1;
					l1 = l1.next;
				}
				else
				{
					runner.next = l2;
					l2 = l2.next;
				}
			}

			runner = runner.next;

			if (l1 != null) runner.next = l1;
			if (l2 != null) runner.next = l2;

			return head.next;
		}
	}

	 public class ListNode {
		 public int val;
		 public ListNode next;
		 public ListNode(int val=0, ListNode next=null) {
			 this.val = val;
			 this.next = next;
		 }
	 }
}
