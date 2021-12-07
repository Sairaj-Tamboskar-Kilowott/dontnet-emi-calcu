using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, 
                LoanDurationInYearCount = 2 };
            ICalculator emiCalculator = new Calculator();

            #region monthly compounding
            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Monthly EMI is {emiMonthly.EmiPayment}");
            else 
                Console.WriteLine(emiMonthly.ErrorMessage);
            #endregion

            // fill other regions below...

            #region continuous compounding
            var emiContinuous = emiCalculator.CalculateContinousEmi(emiRequest);
            if (string.IsNullOrEmpty(emiContinuous.ErrorMessage))
                Console.WriteLine($"Continuous EMI is {emiContinuous.EmiPayment}");
            else
                Console.WriteLine(emiContinuous.ErrorMessage);
            #endregion

            #region daily compounding
            var emiDaily = emiCalculator.CalculateDailyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiDaily.ErrorMessage))
                Console.WriteLine($"Daily EMI is {emiDaily.EmiPayment}");
            else
                Console.WriteLine(emiDaily.ErrorMessage);
            #endregion

        }
    }
}

