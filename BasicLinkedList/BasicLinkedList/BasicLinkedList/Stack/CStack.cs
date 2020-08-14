using ABI.Microsoft.UI.Xaml.Controls;
using BasicLinkedList.Node;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace BasicLinkedList.Stack
{

    public class CStack
    {
        CustomNode top;
        CustomNode tail;
        CustomNode current;
        int nodeCount = 0;

        public void Push (int idata)
        {
            CustomNode customNode = new CustomNode(idata);
            customNode.Next = top;
            top = customNode;

        }

        public int Peek()
        {
            return top.idata;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public int Pop()
        {
            int data = 0;
            if (top != null)
            {
                data = top.idata;
                top = top.Next;
            }

            else
            {
                MessageDialog dailog = new MessageDialog("Stack is empty");
                dailog.ShowAsync();

            }

            return data;
        }

            




    }
}
