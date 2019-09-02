using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController controller=new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var reutrnValue=controller.Get(1);

            Assert.Equal("Chris Lam",reutrnValue.Value);

        }

        [Fact]
        public void Test1()
        {

        }
    }
}
