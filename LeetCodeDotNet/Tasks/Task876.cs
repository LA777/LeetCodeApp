namespace LeetCodeDotNet.Tasks
{
    /// <summary>
    /// https://leetcode.com/problems/middle-of-the-linked-list/description/
    /// </summary>
    public class Task876
    {
        public ListNode MiddleNode(ListNode head)
        {
            int count = 0;
            var middleNode = head;
            var currentNode = head;

            while (currentNode != null)
            {
                count++;

                if (count % 2 == 0)
                {
                    if (middleNode.next is not null)
                    {
                        middleNode = middleNode.next;
                    }
                }

                currentNode = currentNode.next;
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
