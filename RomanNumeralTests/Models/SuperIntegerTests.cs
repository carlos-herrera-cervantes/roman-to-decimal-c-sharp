using RomanNumeralConsoleApp.Models;
using Xunit;

namespace RomanNumeralTests.Models
{
    public class SuperIntegerTests
    {
        [Fact]
        public void ConvertToDecimal_Should_Return_Decimal_Representation()
        {
            var romanNumber = "IV";
            const int ExpectedResult = 4;
            
            var result = SuperInteger.ConvertToDecimal(romanNumber);

            Assert.Equal(ExpectedResult, result);
        }
    }
}