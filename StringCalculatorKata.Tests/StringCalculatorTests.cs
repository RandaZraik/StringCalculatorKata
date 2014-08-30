using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void AddReturnsZeroOnEmptyString()
        {
            Assert.Equal(0, StringCalculator.Add(""));
        }

        [Fact]
        public void AddReturnsNumberOnNumberString()
        {
            Assert.Equal(1, StringCalculator.Add("1"));
        }

        [Fact]
        public void AddReturnsSumOfTwoNumbersString()
        {
            Assert.Equal(3, StringCalculator.Add("1,2"));
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("1,2,3,4", 10)]
        public void AddReturnsSumOfMultipleNumbersString(string number, int expected)
        {
            Assert.Equal(expected, StringCalculator.Add(number));
        }

        [Fact]
        public void AddAcceptsNewlineAsDelimiter()
        {
            Assert.Equal(6, StringCalculator.Add("1\n2,3"));
        }

        [Fact]
        public void AddAcceptsDifferentDelimiter()
        {
            Assert.Equal(10, StringCalculator.Add("//;\n1;2;3;4"));
        }

        [Fact]
        public void AddThrowsExceptionOnNegativeNumbers()
        {
            Assert.Throws<Exception>(() => StringCalculator.Add("-1,-2,8,9,-6\n-6"));
        }

        [Fact]
        public void AddIgnoresNumbersBiggerThan1000()
        {
            Assert.Equal(1006, StringCalculator.Add("1,5\n1000,2000"));
        }
    }
}
