# Stacks-and-Queues
Stack and Queue data structures coded up from scratch
# 1. Pushing to a Stack:
 

  public class CStack
    {
        CustomNode top;
        CustomNode tail;
        CustomNode current;
        int nodeCount = 0;

        public void Push (int idata)
        {
            CustomNode customNode = new CustomNode(idata);

            if (top == null)
            {
                top = customNode;
                top.Next = null;
                nodeCount++;
            }
            else
            {
                current = top;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = customNode;
                nodeCount++;
                
            }
