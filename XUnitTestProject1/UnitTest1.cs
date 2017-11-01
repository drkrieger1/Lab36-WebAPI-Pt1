using Lab36Erik.Controllers;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var controller = new TasksController();

            //act
            var result = controller.Get("1");

            //assert
            Assert.IsType(typeof(string), result);
        }
    }
}
