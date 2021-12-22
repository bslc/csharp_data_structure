// implementation of queue, i.e., FIFO,  using fixed length array
// Cormen et al. pg 232
// Implmented 10.1-4 
using System;

namespace Data.Structures
{
    public class Queue<T>
    {
        // array
        private T[] objects;
        // index for the top of the stack
        private int length;
        private int head;
        private int tail;
        // use head == tail to detect overflow and underflow
        // need empty and full to indicate the case 
        private bool empty = true;
        private bool full = false;
        
        public Queue()
        {
        }
    
        public Queue(int len)
        {
            objects = new T[len];
            length = len;
            head = 0;
            tail = 0;
        }

        public void Enqueue(T obj)
        {
            if (full)
            {
                throw new QueueOverflowException("Queue overflow.");
            }
            objects[tail] = obj;
            empty = false;
            if (tail + 1 == length)
            {
                tail = 0;
            }
            else
            {
                tail++;
            }
            if (head == tail)
            {
                full = true;
            }
        }

        public object Dequeue()
        {
           if (empty)
           {
               throw new QueueUnderflowException("Queue underflow.");
           }
           var returnObj = objects[head];
           full = false;
           if (head + 1 == length)
           {
               head = 0;
           }
           else
           {
               head++;
           }           
           if (head == tail)
           {
               empty = true;
           }
           return returnObj;
        }
    }
    
    public class QueueOverflowException : Exception
    {
        public QueueOverflowException() : base() {} 
        public QueueOverflowException(string message) : base(message) {} 
        public QueueOverflowException(string message, Exception inner) : base(message, inner) {} 
    }

    public class QueueUnderflowException : Exception
    {
        public QueueUnderflowException() : base() {} 
        public QueueUnderflowException(string message) : base(message) {} 
        public QueueUnderflowException(string message, Exception inner) : base(message, inner) {} 
    }
}
