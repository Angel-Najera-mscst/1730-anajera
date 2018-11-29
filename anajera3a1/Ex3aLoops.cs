using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anajera3a1
{
    public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }

        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double FutureValue = 0.0;
            try
            {
                int Months = Int32.Parse(strMonths);
                double MonthlyPayment = double.Parse(strMonthlyPayment);
                double MonthlyInterestRate = double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= Months)
                {
                    FutureValue = (FutureValue + MonthlyPayment) * (1 + MonthlyInterestRate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }

            return FutureValue.ToString("n2");
        }
    }
}
