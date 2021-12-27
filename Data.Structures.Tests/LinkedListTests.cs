using Data.Structures;
using System;
using Xunit;

namespace Data.Structures.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void InstantiateNodeWithValue()
        {
            int value = 1;
            LinkedListNode<int> node = new LinkedListNode<int>(value);
            Assert.Equal(value, node.data);
            Assert.Equal(null, node.next);
        }

        [Fact]
        public void InstantiateNodeWithValueAndNext()
        {
            int nextValue = 2;
            LinkedListNode<int> nextNode = new LinkedListNode<int>(nextValue);
            int value = 1;
            LinkedListNode<int> node = new LinkedListNode<int>(value, nextNode);
            Assert.Equal(value, node.data);
            Assert.Equal(nextNode, node.next);
        }

        [Fact] 
        public void InstiateListWithNodeAndReturnSameNode()
        {
            int key = 1;
            LinkedListNode<int> node = new LinkedListNode<int>(key);
            LinkedList<int> linkedList = new LinkedList<int>(node);
            LinkedListNode<int> returnedNode = linkedList.Search(key);
            Assert.Equal(returnedNode, node);
        }
    }
}
