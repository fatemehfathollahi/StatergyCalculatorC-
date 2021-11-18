using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCalculator.Models;

namespace WebCalculator.Helper
{
    public class CalculateService
    {
        private ICalculator _calculator;

        public decimal Calculate(decimal a, decimal b)
        {
            return _calculator.Calculate(a, b);
        }
        public void SetCalculate(ICalculator calculator)
        {
            _calculator = calculator;
        }
    }
}