using System;
using Lib;
using Xunit;

namespace GitVersioning
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Maraba Televole!",new HelloWorldProvider().Provide());
        }
    }
}