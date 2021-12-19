// implementation of stack using fixed length array
// Cormen et al. pg 232
using System;

namespace Data.Structures
{
    public class Stack<T>
    {
        // array
        private T[] objects;
        // index for the top of the stack
        private int top;  
        
        public Stack()
        {
        }
        
        public Stack(int length)
        {
            objects = new T[length];
            top = 0;
        }

        public bool IsEmpty()
        {
            if (objects == null || top == 0)
            {
                return true;
            }
            return false;
        }
        
        public void Push(T obj)
        {
            try
            {
                objects[top] = obj;
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new StackOverflowException("Stack overflowed.", ex);
            }
            top++;
        }

        public object Pop()
        {
            if (top == 0)
            {
                throw new StackUnderflowException("Stack underflowed.");
            }
            top--;
            var returnObj = objects[top];
            return returnObj;
        }

        public int Count()
        {
            return top;
        }
    }

    public class StackOverflowException : Exception
    {
        public StackOverflowException() : base() {} 
        public StackOverflowException(string message) : base(message) {} 
        public StackOverflowException(string message, Exception inner) : base(message, inner) {} 
    }

    public class StackUnderflowException : Exception
    {
        public StackUnderflowException() : base() {} 
        public StackUnderflowException(string message) : base(message) {} 
        public StackUnderflowException(string message, Exception inner) : base(message, inner) {} 
    }
}
