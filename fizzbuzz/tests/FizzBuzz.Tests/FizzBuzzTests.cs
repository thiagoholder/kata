using System;
using Xunit;

namespace FizzBuzKata.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz fizzbuzz;

        public FizzBuzzTests()
        {
            this.fizzbuzz = new FizzBuzz();
        }

        [Fact]
        public void Number_is_returned_if_not_multiple_of_3()
        {
            Assert.Equal("1", fizzbuzz.StringFor(1));
            Assert.Equal("4", fizzbuzz.StringFor(4));
        }

        [Fact]
        public void Return_fizz_for_multiple_of_3()
        {
            Assert.Equal("Fizz", fizzbuzz.StringFor(3));
            Assert.Equal("Fizz", fizzbuzz.StringFor(6));
        }

        [Fact]
        public void Number_is_returned_if_not_multiple_of_5()
        {
            Assert.Equal("7", fizzbuzz.StringFor(7));
            Assert.Equal("8", fizzbuzz.StringFor(8));
        }

        [Fact]
        public void Return_fizz_for_multiple_of_5()
        {
            Assert.Equal("Buzz", fizzbuzz.StringFor(5));
            Assert.Equal("Buzz", fizzbuzz.StringFor(10));
        }

        [Fact]
        public void Return_fizzbuzz_for_multiple_of_5_and_3()
        {
            Assert.Equal("FizzBuzz", fizzbuzz.StringFor(15));
            Assert.Equal("FizzBuzz", fizzbuzz.StringFor(30));
        }

    }
}
