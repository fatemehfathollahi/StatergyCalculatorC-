using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public interface ICalculator
    {
        decimal Calculate(decimal a, decimal b);
    }
}
