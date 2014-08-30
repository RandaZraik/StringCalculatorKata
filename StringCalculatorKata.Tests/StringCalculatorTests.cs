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
    }
}
