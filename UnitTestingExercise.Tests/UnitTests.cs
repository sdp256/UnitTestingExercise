using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(20, 40, 60, 120)]
        [InlineData(-100, 100, 1000, 1000)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(200, 100, 100)]
        [InlineData(69, 69, 0)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(-5, 30, -150)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(100, 10, 10)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        //[Fact]
        //public void SayHello()
        //{
        //    //Arrange
        //    var expected = "Hello";
        //    //Act
        //    var actual = SayHello.
        //    //Assert
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void YourMethodName2()
        //{
        //    //Arrange

        //    //Act

        //    //Assert
        //}
    }
}
