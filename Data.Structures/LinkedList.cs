// implementation of a singly linked list
//
// Cormen et al. pg 236

using System;
using System.Collections.Generic;

namespace Data.Structures
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> head {get; set;}
        
        public LinkedList(LinkedListNode<T>  node)
        {
            head = node;
        }

        public LinkedListNode<T> Search(T  key)
        {
            LinkedListNode<T> temp = head;
            while (temp.data != null && temp != null)
            {
                if (EqualityComparer<T>.Default.Equals(temp.data, key))
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;
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
