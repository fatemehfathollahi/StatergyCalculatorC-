﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalculator.Models
{
    public class Divide : ICalculator
    {
        public decimal Calculate(decimal a, decimal b)
        {
            return a / b;
        }
    }
}