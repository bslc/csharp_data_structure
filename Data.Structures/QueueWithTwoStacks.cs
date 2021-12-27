// incomplete implementation of a queue with two stacks
//
// We would implement a queue length n by using two stacks of length n. One
// stack should be the operating stacak and the other should be empty. To
// enqueue, we would simply push to the operating stack. To dequeue, we would pop
// all the elements from the operating stack into the empty stack. After all the
// elements have been transferred to the then empty stack, we would return the
// pop an element and return it. This would fulfill the first-in first-out
// requirement of a queue. 
//
// Cormen et al. pg 235
// 10.1-6

using System;

namespace Data.Structures
{
    public class QueueWithTwoStacks<T>
    {
        // declaring the two stacks for the queue
        private Stack<T> _stackOne;
        private Stack<T> _stackTwo;
        private Stack<T> _currentStack;

        public QueueWithTwoStacks()
        {
        }
    
        public QueueWithTwoStacks(int len)
        {
            _stackOne = new Stack<T>(len);
            _stackTwo = new Stack<T>(len);
            _currentStack = _stackOne;
        }

        public void Enqueue(T obj)
        {
            // check for overflow if stack is at max capacity
            // push object into current stack
        }

        public object Dequeue()
        {
            // check for underflow if stack is empty
            // pop each object from current operational stack and put into the empty stack until the original 
            // operational stack is empty
            // set previous opertional stack as empty stack
            // set emtpy stack as operational stack
            // pop and return element from the new operational stack
            return null;
        }
    }
    
    public class QueueWithTwoStacksOverflowException : Exception
    {
        public QueueWithTwoStacksOverflowException() : base() {} 
        public QueueWithTwoStacksOverflowException(string message) : base(message) {} 
        public QueueWithTwoStacksOverflowException(string message, Exception inner) : base(message, inner) {} 
    }

    public class QueueWithTwoStacksUnderflowException : Exception
    {
        public QueueWithTwoStacksUnderflowException() : base() {} 
        public QueueWithTwoStacksUnderflowException(string message) : base(message) {} 
        public QueueWithTwoStacksUnderflowException(string message, Exception inner) : base(message, inner) {} 
    }
}
