using Data.Structures;
using System;
using Xunit;

namespace Data.Structures.Tests
{
    public class QueueWithTwoStacksTests
    {
        [Fact]
        public void InstantiationWithEmptyQueueWithTwoStacks()
        {
            QueueWithTwoStacks<int> queue = new QueueWithTwoStacks<int>();
            Assert.IsType(typeof(QueueWithTwoStacks<int>), queue);
        }
    }
}
