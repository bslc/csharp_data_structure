using Data.Structures;
using System;
using Xunit;

namespace Data.Structures.Tests
{
    public class StackWithTwoQueuesTests
    {
        [Fact]
        public void InstantiationWithEmptyStackWithTwoQueues()
        {
            StackWithTwoQueues<int> stack = new StackWithTwoQueues<int>();
            Assert.IsType(typeof(StackWithTwoQueues<int>), stack);
        }
    }
}
