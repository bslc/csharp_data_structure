using Data.Structures;
using System;
using Xunit;

namespace Data.Structures.Tests
{
    public class QueueTests
    {
        int firstObject = 11;
        int secondObject = 21;
        int thirdObject = 31;
        int fourthObject = 41;
        
        [Fact]
        public void InstantiationWithEmptyQueue()
        {
            Queue<int> queue = new Queue<int>();
            Assert.IsType(typeof(Queue<int>), queue);
        }

        [Fact]
        public void InsertObjectsAndGetSameObjecstBackInOrder()
        {
            Queue<int> queue = new Queue<int>(2);
            queue.Enqueue(firstObject);
            queue.Enqueue(secondObject);
            var returnObj1 = queue.Dequeue();
            var returnObj2 = queue.Dequeue();
            Assert.Equal(firstObject, returnObj1);
            Assert.Equal(secondObject, returnObj2);
        }

        [Fact]
        public void PushMultipleObjectsGetOverflowException()
        {
            Queue <int> queue = new Queue<int>(1);
            queue.Enqueue(firstObject);
            Assert.Throws<QueueOverflowException>(() => queue.Enqueue(secondObject));
        }

        [Fact]
        public void DequeueEmptyQueueObjectGetUnderflowException()
        {
            Queue <int> queue = new Queue<int>(1);
            Assert.Throws<QueueUnderflowException>(() => queue.Dequeue());
        }
        
        [Fact]
        public void HeadIndexWrapAndReturnCorrectObject()
        {
            Queue <int> queue = new Queue<int>(2);
            queue.Enqueue(firstObject);
            queue.Enqueue(secondObject);
            
            var returnObj1 = queue.Dequeue();
            Assert.Equal(firstObject, returnObj1);
            
            queue.Enqueue(thirdObject);
            var returnObj2 = queue.Dequeue();
            Assert.Equal(secondObject, returnObj2);
            var returnObj3 = queue.Dequeue();
            Assert.Equal(thirdObject, returnObj3);
            queue.Enqueue(fourthObject);
            var returnObj4 = queue.Dequeue();
            Assert.Equal(fourthObject, returnObj4);
        }
    
        [Fact]
        public void DequeueAfterOperationsThrowException()
        {
            Queue <int> queue = new Queue<int>(1);
            queue.Enqueue(firstObject);
            var returnObj1 = queue.Dequeue();
            Assert.Throws<QueueUnderflowException>(() => queue.Dequeue());
        }}
}
