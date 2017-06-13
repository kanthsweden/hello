using System;
using Xunit;


namespace SecondApp
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int result = Prime.Check_Prime(3);
            Assert.Equal(1, result);
        }
    }
}
