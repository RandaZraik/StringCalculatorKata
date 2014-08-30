using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

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

        [Fact]
        public void AddReturnsSumOfMultipleNumbersString()
        {
            Assert.Equal(6, StringCalculator.Add("1,2,3"));
        }
    }
}
