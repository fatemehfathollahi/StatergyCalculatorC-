using System;
using WebCalculator.Helper;
using WebCalculator.Models;
using Xunit;

namespace WebCalculator.Test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(472,61,Operation.MultiPly,28792)]
        [InlineData(684,9427,Operation.Minus,-8743)]
        [InlineData(1460,8760,Operation.Plus,10220)]
        [InlineData(780,20,Operation.Divide,39)]
        public void CalculateTest(decimal number1, decimal number2, Operation operation,decimal expectedResult)
        {
            var _calSerivec = new CalculateService();
            switch (operation)
            {
                case Operation.Divide:
                    _calSerivec.SetCalculate(new Divide());
                    break;
                case Operation.Minus:
                    _calSerivec.SetCalculate(new Minus());
                    break;
                case Operation.MultiPly:
                    _calSerivec.SetCalculate(new MultiPly());
                    break;
                case Operation.Plus:
                    _calSerivec.SetCalculate(new Plus());
                    break;
                default:
                    break;
               
            }

            var calculatedResult = _calSerivec.Calculate(number1, number2);

            Assert.Equal(expectedResult, calculatedResult);
        }
    }
}
