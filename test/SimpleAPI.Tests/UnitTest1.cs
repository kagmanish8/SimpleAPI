using System;
using Xunit;
namespace SimpleAPI.Tests
{
    public class UnitTest1
    {

        SimpleAPI.Controllers.ValuesController obj=new SimpleAPI.Controllers.ValuesController();
        SimpleAPI2.Controllers.ValuesController obj2=new SimpleAPI2.Controllers.ValuesController();
        [Fact]
        public void Test1()
        {
            var rtnValue=obj.Get(1);
            Assert.Equal("MAnish kags",rtnValue.Value);
        }

        [Fact]
        public void Test2()
        {
            var rtnValue=obj2.Get(1);
            Assert.Equal("value",rtnValue.Value);
        }
    }
}
