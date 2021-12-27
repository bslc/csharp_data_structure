// incomplete implementation of a queue with two stacks
//
// We would implement a stack with two queues by using one queue as store and
// another to pop. Assuming no overflow or underflow conditions, we would push
// into the stack for storing an element in the current queue. When we need to
// pop an element, we woudl dequeue from the current queue one-by-one until the
// very last element and return that element. 
//
// Cormen et al. pg 235
// 10.1-7

using System;

namespace Data.Structures
{
    public class StackWithTwoQueues<T>
    {
        // declaring the two stacks for the queue
        private Queue<T> _queueOne;
        private Queue<T> _queueTwo;
        private Queue<T> _currentQueue;

        public StackWithTwoQueues()
        {
        }
    
        public StackWithTwoQueues(int len)
        {
            _queueOne = new Queue<T>(len);
            _queueTwo = new Queue<T>(len);
            _currentQueue = _queueOne;
        }

        public void Push(T obj)
        {
            // check for overflow if queue is at max capacity
            // enqueue object into current queue
        }

        public object Pop()
        {
            // check for underflow if current queue is empty
            // dequeue each element from the current queue and store them in the
            // empty queue except for the last one. 
            // set previous opertional queue as empty queue
            // set emtpy queue as operational queue
            // deque the last element from the former operational queue and
            // return it
            return null;
        }
    }
    
    public class StackWithTwoQueuesOverflowException : Exception
    {
        public StackWithTwoQueuesOverflowException() : base() {} 
        public StackWithTwoQueuesOverflowException(string message) : base(message) {} 
        public StackWithTwoQueuesOverflowException(string message, Exception inner) : base(message, inner) {} 
    }

    public class StackWithTwoQueuesUnderflowException : Exception
    {
        public StackWithTwoQueuesUnderflowException() : base() {} 
        public StackWithTwoQueuesUnderflowException(string message) : base(message) {} 
        public StackWithTwoQueuesUnderflowException(string message, Exception inner) : base(message, inner) {} 
    }
}
