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

        public void InstantiateEmptyListReturnCorrectType()
        {
            LinkedList<int> list =  new LinkedList<int>();
            Assert.IsType(typeof(LinkedList<int>), list);
        }
    
        [Fact] 
        public void InsertNodeIntoEmptyListReturnSameNode()
        {
            int key = 1;
            LinkedListNode<int> node = new LinkedListNode<int>(key);
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Insert(node);
            LinkedListNode<int> returnedNode = linkedList.Search(key);
            Assert.Equal(returnedNode, node);
        }

        [Fact] 
        public void SearchForNonExistingNodeInEmptyListReturnNull()
        {
            int key = 1;
            LinkedListNode<int> node = new LinkedListNode<int>(key);
            LinkedList<int> linkedList = new LinkedList<int>();
            int notKey = 2;
            LinkedListNode<int> returnedNode = linkedList.Search(notKey);
            Assert.Equal(returnedNode, null);
            Assert.NotEqual(returnedNode, node);
        }

        [Fact] 
        public void SearchForNonExistingNodeInNonEmptyListReturnNull()
        {
            int key = 1;
            LinkedListNode<int> node = new LinkedListNode<int>(key);
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Insert(node);
            int notKey = 2;
            LinkedListNode<int> returnedNode = linkedList.Search(notKey);
            Assert.Equal(returnedNode, null);
            Assert.NotEqual(returnedNode, node);
        }

        [Fact] 
        public void InsertNodeIntoNonEmptyListReturnSameNode()
        {
            int firstKey = 1;
            LinkedListNode<int> firstNode = new LinkedListNode<int>(firstKey);
            LinkedList<int> linkedList = new LinkedList<int>(firstNode);

            int secondKey = 2;
            LinkedListNode<int> secondNode = new LinkedListNode<int>(secondKey);
            linkedList.Insert(secondNode);
            LinkedListNode<int> returnedNode = linkedList.Search(secondKey);
            Assert.Equal(returnedNode, secondNode);
        
            LinkedListNode<int> secondReturnedNode = linkedList.Search(firstKey);
            Assert.Equal(secondReturnedNode, firstNode);
        }
    
        [Fact] 
        public void DeleteHeadReturnNull()
        {
            int key = 1;
            LinkedListNode<int> node = new LinkedListNode<int>(key);
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Insert(node);
            linkedList.Delete(node);
            LinkedListNode<int> returnedNode = linkedList.Search(key);
            Assert.Equal(returnedNode, null);
            Assert.Equal(linkedList.head, null);
        }
    
        [Fact] 
        public void DeleteHeadReturnRemainingNode()
        {
            int firstKey = 1;
            LinkedListNode<int> firstNode = new LinkedListNode<int>(firstKey);

            int secondKey = 2;
            LinkedListNode<int> secondNode = new LinkedListNode<int>(secondKey);
            LinkedList<int> linkedList = new LinkedList<int>(firstNode);
            linkedList.Insert(secondNode);
            
            linkedList.Delete(secondNode);
            
            LinkedListNode<int> returnedNode = linkedList.Search(secondKey);
            Assert.Equal(returnedNode, null);
            Assert.Equal(linkedList.head, firstNode);
            
            returnedNode = linkedList.Search(firstKey);
            Assert.Equal(returnedNode, firstNode);
        }
    
        [Fact] 
        public void DeleteSecondNoderReturnRemainingNode()
        {
            int firstKey = 1;
            LinkedListNode<int> firstNode = new LinkedListNode<int>(firstKey);

            int secondKey = 2;
            LinkedListNode<int> secondNode = new LinkedListNode<int>(secondKey);
            LinkedList<int> linkedList = new LinkedList<int>(firstNode);
            linkedList.Insert(secondNode);
            
            linkedList.Delete(secondNode);
            
            LinkedListNode<int> returnedNode = linkedList.Search(secondKey);
            Assert.Equal(returnedNode, null);
            Assert.Equal(linkedList.head, firstNode);
            
            returnedNode = linkedList.Search(firstKey);
            Assert.Equal(returnedNode, firstNode);
        }
    
        [Fact] 
        public void DeleteFirstNoderReturnRemainingNode()
        {
            int firstKey = 1;
            LinkedListNode<int> firstNode = new LinkedListNode<int>(firstKey);

            int secondKey = 2;
            LinkedListNode<int> secondNode = new LinkedListNode<int>(secondKey);
            LinkedList<int> linkedList = new LinkedList<int>(firstNode);
            linkedList.Insert(secondNode);
            
            linkedList.Delete(firstNode);
            
            LinkedListNode<int> returnedNode = linkedList.Search(secondKey);
            Assert.Equal(returnedNode, secondNode);
            Assert.Equal(linkedList.head, secondNode);
            
            returnedNode = linkedList.Search(firstKey);
            Assert.Equal(null, returnedNode);
        }
    }
}
