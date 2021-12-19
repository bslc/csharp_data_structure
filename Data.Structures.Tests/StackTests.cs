using System;
using Xunit;
using Data.Structures;

namespace Data.Structures.Tests
{
    public class StackTest
    {
        int firstObject = 11;
        int secondObject = 21;
        int thirdObject = 31;
        int fourthObject = 41;
        int fifthObject = 51;
        
        [Fact]
        public void InstantiationWithEmptyStack()
        {
            Stack<int> stack = new Stack<int>();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void PushOneObjectWithLengthOne()
        {
            Stack<int> stack = new Stack<int>(1);
            stack.Push(firstObject);
            Assert.False(stack.IsEmpty());
            Assert.Equal(1, stack.Count());
        }

        [Fact]
        public void PushMultipleObjectsWithCorrectLength()
        {
            Stack<int> stack = new Stack<int>(4);
            stack.Push(firstObject);
            stack.Push(secondObject);
            stack.Push(thirdObject);
            stack.Push(fourthObject);
            Assert.Equal(4, stack.Count());
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void PushMultipleObjectsGetOverflowException()
        {
            Stack<int> stack = new Stack<int>(1);
            stack.Push(firstObject);
            Assert.Throws<StackOverflowException>(() => stack.Push(secondObject));
        }

        [Fact] 
        public void PopObjectEqualOriginalObject()
        {
            Stack<int> stack = new Stack<int>(1);
            stack.Push(firstObject);
            var actual = stack.Pop();
            Assert.Equal(firstObject, actual);
            Assert.True(stack.IsEmpty());
        }
        
        [Fact]
        public void PopEmptyStackGetUnderflowException()
        {
            Stack<int> stack = new Stack<int>();
            Assert.Throws<StackUnderflowException>(() => stack.Pop());
        }
    }
}
