using Data.Structures;
using System;
using Xunit;

namespace Data.Structures.Tests
{
    public class DoubleStackTests 
    {
        [Fact]
        public void InstantiationWithEmptyDoubleStack()
        {
            DoubleStack<int> doubleStack = new DoubleStack<int>();
            Assert.IsType(typeof(DoubleStack<int>), doubleStack);
        }
    }
}
