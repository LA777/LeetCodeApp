namespace LeetCodeDotNet.Tasks
{
    /// <summary>
    /// https://leetcode.com/problems/middle-of-the-linked-list/description/
    /// </summary>
    public class Task876
    {
        public ListNode MiddleNode(ListNode head)
        {
            var middleNode = head;
            var currentNode = head;

            while (currentNode != null && currentNode.next != null)
            {
                middleNode = middleNode.next;
                currentNode = currentNode.next.next;
            }

            return middleNode;
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
