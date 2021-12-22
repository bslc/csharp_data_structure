using Data.Structures;
using System;
using Xunit;

namespace Data.Structures.Tests
{
    public class Deque 
    {
        [Fact]
        public void InstantiationWithEmptyDeque()
        {
            Deque<int> deque = new Deque<int>();
            Assert.IsType(typeof(Deque<int>), deque);
        }
    }
}
