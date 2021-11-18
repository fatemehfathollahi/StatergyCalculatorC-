using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalculator.Helper;
using WebCalculator.Helpers;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculateService calculateService;
        public CalculatorController()
        {
            calculateService = new CalculateService();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calculate(decimal a, decimal b, string operation)
        {                                                                                        
            var result = CanHandle(a, b, operation);
            return View("Index",(object) $"{a} {operation} {b} = {result}");
        }

        #region Utilites
        decimal CanHandle(decimal a, decimal b, string operation)
        {
            Operation _operation = MyEnumExtensions.GetEnumValueFromDescription<Operation>(operation);
            switch (_operation)
            {
                case Operation.Divide:
                     calculateService.SetCalculate(new Divide());
                    break;
                case Operation.Minus:
                    calculateService.SetCalculate(new Minus());
                    break;
                case Operation.MultiPly:
                    calculateService.SetCalculate(new MultiPly());
                    break;
                case Operation.Plus:
                    calculateService.SetCalculate(new Plus());
                    break;
                default:
                    break;
            }
          var  _result = calculateService.Calculate(a, b);
            return _result;
        }

        #endregion

    }
}