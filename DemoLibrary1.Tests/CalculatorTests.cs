using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary1.Tests
{
    public class CalculatorTests
    {
        //Fact lets you test one thing, 
        //otherwise testing multiple things ruins the aesthetics of the code
        [Theory]
        [InlineData(4, 2, 6)]
        [InlineData(12.5, 3, 15.5)]
        [InlineData(double.MaxValue, 5, double.MaxValue)] //max value stored in thsi type of variable - used for edge cases / extreme data
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        { 
            //act
            double actual = Calculator.Add(x,y);
            //assert phase
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_SimpleValuesShouldCalculate()
        {
            //arrange
            double expected = 3;
            //act
            double actual = Calculator.Subtract(5, 2);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            //returning 0 is our current business logic, not mathematically correct, would need changing in the method being called
            double expected = 0;
            double actual = Calculator.Divide(15, 0);
            Assert.Equal(expected, actual);
        }


    }
}
