using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.Tests
{
    public class UnitTest1
    {

        ValuesController obj=new ValuesController();
        [Fact]
        public void Test1()
        {
            var rtnValue=obj.Get(1);
            Assert.Equal("MAnish kag",rtnValue.Value);
        }

        [Fact]
        public void Test2()
        {

        }
    }
}
