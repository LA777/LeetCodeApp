namespace LeetCodeDotNet.Assessments
{
    public class QueueWithTwoStack2
    {
        public class MyQueue
        {
            private readonly Stack<int> stackStraight = new();
            private readonly Stack<int> stackInverted = new();

            public MyQueue()
            {
            }

            public void Push(int x)
            {
                stackStraight.Push(x);
                TransferData(stackStraight, stackInverted);
            }

            public int Pop()
            {
                var number = stackInverted.Pop();
                TransferData(stackInverted, stackStraight);

                return number;
            }

            public int Peek()
            {
                return stackInverted.Peek();
            }

            public bool Empty()
            {
                return stackStraight.Count == 0;
            }

            private void TransferData(Stack<int> stackSource, Stack<int> stackDestination)
            {
                stackDestination.Clear();
                foreach (var element in stackSource)
                {
                    stackDestination.Push(element);
                }
            }
        }
    }
}
