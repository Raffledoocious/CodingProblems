using CodingProblems.Models;

namespace CodingProblems
{
	public class ReveseLinkedList
	{
		public ListNode ReverseList(ListNode head)
		{
            if (head == null)
            {
                return head;
            }

            var previous = head;
            var next = head.next;
            previous.next = null;

            while (next != null)
            {
                var nextNext = next.next;
                next.next = previous;
                previous = next;
                next = nextNext;
            }

            return previous;
        }
    }
}
