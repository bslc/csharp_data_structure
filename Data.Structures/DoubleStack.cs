// incomplete implementation of two stack in one array
// Cormen et al. pg 235
// 10.1-2 

using System;

namespace Data.Structures
{
    public class DoubleStack<T>
    {
        // array
        private T[] objects;
        // index for the tops of the stacks
        private int leftTop;
        private int rightTop;
        private int length;
        
        public DoubleStack()
        {
        }
    
        public DoubleStack(int len)
        {
            objects = new T[len];
            length = len;
            leftTop = 0;
            rightTop = length - 1;
        }

        public void LeftPush(T obj) 
        {
            // push like a normal stack
            // if leftTop == rightTop throw overflow Exception
            throw new NotImplementedException();
        }

        public void RightPush(T obj) 
        {
            // push and decrease index rather than increase
            // if leftTop == rightTop throw overflow Exception
            throw new NotImplementedException();
        }

        public object LeftPop()
        {
            // pop like a normal stack
            // if leftTop is less than 0  throw underflow exception
            throw new NotSupportedException();
        }

        public object RightPop()
        {
            // pop and increase index
            // if rightTop is greater than length - 1  throw underflow exception
            throw new NotSupportedException();
        }

    }
    
    public class DoubleStackOverflowException : Exception
    {
        public DoubleStackOverflowException() : base() {} 
        public DoubleStackOverflowException(string message) : base(message) {} 
        public DoubleStackOverflowException(string message, Exception inner) : base(message, inner) {} 
    }

    public class DoubleStackUnderflowException : Exception
    {
        public DoubleStackUnderflowException() : base() {} 
        public DoubleStackUnderflowException(string message) : base(message) {} 
        public DoubleStackUnderflowException(string message, Exception inner) : base(message, inner) {} 
    }
}
