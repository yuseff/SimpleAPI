using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void IsJoeCool()
        {
            var retVal = controller.Get(12);
            Assert.Equal("Joe Namath", retVal.Value);
        }

        [Fact]
        public void IsTheBabe()
        {
            var retVal = controller.Get(3);
            Assert.Equal("Babe Ruth", retVal.Value);
        }

        [Fact]
        public void IsIronMan()
        {
            var retVal = controller.Get(4);
            Assert.Equal("Lou Gehrig", retVal.Value);
        }

        [Fact]
        public void IsMrOctober()
        {
            var retVal = controller.Get(44);
            Assert.Equal("Reggie Jackson", retVal.Value);
        }

        [Fact]
        public void AlphabeticComparisons()
        {
            var reggie = controller.Get(44).Value;
            var lou = controller.Get(4).Value;
            
            Assert.True(string.Compare(lou, reggie) == -1);
            Assert.True(string.Compare(reggie, lou) == 1);

            var gretzky = controller.Get(99).Value;
            Assert.True(string.Compare(gretzky, reggie) == 1);
        }
    }  
}
