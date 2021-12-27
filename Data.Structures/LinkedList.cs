// implementation of a singly linked list
//
// Cormen et al. pg 236
// 10.2-1

using System;
using System.Collections.Generic;

namespace Data.Structures
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> head {get; private set;}

        public LinkedList()
        {
            head = null;

        }
        
        public LinkedList(LinkedListNode<T> node)
        {
            head = node;
        }

        public LinkedListNode<T> Search(T key)
        {
            LinkedListNode<T> temp = head;
            while (temp != null && temp.data != null)
            {
                if (EqualityComparer<T>.Default.Equals(temp.data, key))
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }

        public void Insert(LinkedListNode<T> node)
        {
            node.next = head;
            head = node;
        }

        public void Delete(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = head;
            LinkedListNode<T> prev = null;
            while (temp != null)
            {
                if (node == temp)
                {
                    // case: head is node
                    if (temp == head)
                    {
                        // only when there is one node
                        if (head.next == null)
                        {
                            head = null;
                        }
                        else
                        {
                            head = head.next;
                        }
                    }
                    else
                    {
                        prev.next = temp.next;
                    }
                }
                prev = temp;
                temp = temp.next;
            }
        }
    }
        
    public class LinkedListNode<T>
    {
        public T data {get; set;}
        public LinkedListNode<T> next {get; set;}
        
        public LinkedListNode(T value)
        {
            data = value;
            next = null;
        }

        public LinkedListNode(T value, LinkedListNode<T> nextNode)
        {
            data = value;
            next = nextNode;
        }
    }
}
