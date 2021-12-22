// incomplete implementation of deque data structure
// Cormen et al. pg 236 
// 10.1-5 

using System;

namespace Data.Structures
{
    public class Deque<T>
    {
        // array
        private T[] objects;
        private int length;
        // indices of the Deque
        private int leftIndex;
        private int rightIndex;
        private bool empty;
        private bool full;
        
        public Deque()
        {
        }
    
        public Deque(int len)
        {
            objects = new T[len];
            length = len;
            leftIndex = 0;
            rightIndex = 0;
            empty = true;
            full = false;
        }

        public void LeftEnqueue(T obj) 
        {
            // if full, throw overflow exception
            // enqueue from the left side of the array
            // set empty to false
            // decrease the index leftIndex after each insert
            // need to wrap around the array when leftIndex reachs 0
            // if leftIndex == rightIndex, set full to true
            throw new NotImplementedException();
        }

        public void RightEnqueue(T obj) 
        {
            // if full, throw overflow exception
            // enqueue from the right side of the array
            // set empty to false
            // increase the index rightIndex after each insert
            // need to wrap around the array when rightIndex reachs length - 1
            // if leftIndex == rightIndex, set full to true
            throw new NotImplementedException();
        }

        public object LeftDequeue()
        {
            // if empty, throw underflow exception
            // dequeue from the left side of the array
            // set full to false
            // decrease the leftIndex by 1
            // need to wrap around the array when leftIndex reachs length - 1
            // if leftIndex == rightIndex, set empty to true
            throw new NotSupportedException();
        }

        public object RightDequeue()
        {
            // if empty, throw underflow exception
            // dequeue from the right side of the array
            // set full to false
            // decrease the rightIndex by 1
            // need to wrap around the array when rightIndex reachs 0
            // if leftIndex == rightIndex, set empty to true
            throw new NotSupportedException();
        }
    }
    
    public class DequeOverflowException : Exception
    {
        public DequeOverflowException() : base() {} 
        public DequeOverflowException(string message) : base(message) {} 
        public DequeOverflowException(string message, Exception inner) : base(message, inner) {} 
    }

    public class DequeUnderflowException : Exception
    {
        public DequeUnderflowException() : base() {} 
        public DequeUnderflowException(string message) : base(message) {} 
        public DequeUnderflowException(string message, Exception inner) : base(message, inner) {} 
    }
}
