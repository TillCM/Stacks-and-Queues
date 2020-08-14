﻿using BasicLinkedList.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList.LinkedList
{
    public  class CircularSinlyLinkedList
    {

        CustomNode head;
        int NodeCount = 0;
        public int check;
        CustomNode current;
        CustomNode tail;
        List<string> nextlist;


        public void append(string data)
        {
            CustomNode customNode = new CustomNode(data);
           

            // check if there is a head 
            if (head == null)
            {
                // create a head if there is not one 
                head = customNode;
                head.Next = head;
                NodeCount++;
                return;
            }
            // if there is a head -> start walking through the list staring at the head 
            current = head;
            //Taverse the list untill you get back to the head 
            while (current.Next != head)
            {
                // keep moving through the list one node at a time 
                current = current.Next;
            }

            //create a new node if current.next is empty :-)
            current.Next = customNode;
            customNode.Next =head;
           
            NodeCount++;
        }

        public void prepend(string data)
        {
            /*This method adds a New node to the beginning of the list
             * It sets the current head as its next value
             * It then sets the new Node to be the head node
             */

            // create new Node called newHead
            CustomNode newHead = new CustomNode(data);
            NodeCount++;
            //set the old head node as the next value of the new head
            newHead.Next = head;
            //set the newHead as the head value
            head = newHead;
        }

        public void deleteWithData(string data)
        {
            //check if the list is empty first

            if (head == null)
            {
                Console.WriteLine("could not delete value : list is empty");
                return;
            }

            // handle the case if the head contains the data that we want to delete

            if (head.data.Equals(data))
            {
                // walk around the head and set the very next node to be the head 
                head = head.Next;
            }

            /* we never actually 
             * delete the node 
             * we just change the next pointer
             * to point to another node (walk around the node)
             */


            //1. start at beginning of list 
            CustomNode current = head;

            // 2. we start walking throug the list untill there are no nodes left
            while (current.Next != null)
            {
                // 3. check if the data in each node matches the data you want to delete
                if (current.data.Equals(data))
                {
                    // 4. walk around that value
                    current.Next = current.Next.Next;
                    System.Diagnostics.Debug.WriteLine("Node Deleted");
                    return;
                }
                //if the data does not match- check the next element
                current = current.Next;
            }




        }



        public int Count()
        {
            return NodeCount;
        }


        public List<string> showNext(int count, int listSize)
        {
            nextlist = new List<string>();
            current = head;

            nextlist.Add(current.data);

            while (current.Next != null)
            {

                nextlist.Add(current.Next.data);
                current = current.Next;

            }



            return nextlist;

        }


    }
}

