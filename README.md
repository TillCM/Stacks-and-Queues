# Stacks-and-Queues
Stack and Queue data structures coded up from scratch
# 1. Pushing to a Stack:
A Stack is a simple data structure that follows the LIFO  (Last In First Out) method. It is like a stack of plates...
you usually pick up the last plate you placed on the stack. You dont try and pull a plate out from the bottom.
Well.. most people don't.

![Stack: LIFO](https://github.com/TillCM/Stacks-and-Queues/blob/master/stack.JPG)

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




