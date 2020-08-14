using ABI.Windows.Perception.People;
using BasicLinkedList.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList.Queue
{
    class CQueue
    {
        CustomNode tail;
        CustomNode head;
        public void Add( string data)
        {
            CustomNode customNode = new CustomNode(data);

            if (tail !=null)
            {
                tail.Next = customNode;
            }

            tail = customNode;

            if(head == null)
            {
                head = customNode;
            }

        }

        public string Peek()
        {
            return head.data;
        }

        public void Pop()
        {
            head = head.Next;
        }
    }

  
}
