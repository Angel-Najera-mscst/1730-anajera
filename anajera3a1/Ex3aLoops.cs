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

        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double FutureValue = 0.0;
            try
            {
                int Months = Int32.Parse(strMonths);
                double MonthlyPayment = double.Parse(strMonthlyPayment);
                double MonthlyInterestRate = double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    FutureValue = (FutureValue + MonthlyPayment) * (1 + MonthlyInterestRate);
                    i++;
                }
                while (i <= Months);
            }
            catch
            {
                return "Invalid input";
            }

            return FutureValue.ToString("n2");
        }

        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double FutureValue = 0.0;
            try
            {
                int Months = Int32.Parse(strMonths);
                double MonthlyPayment = double.Parse(strMonthlyPayment);
                double MonthlyInterestRate = double.Parse(strMonthlyInterestRate);
                for (int i = 1; i <= Months; i++)
                {
                    FutureValue = (FutureValue + MonthlyPayment) * (1 + MonthlyInterestRate);
                }
            }
            catch
            {
                return "Invalid input";
            }

            return FutureValue.ToString("n2");
        }
        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();


            }
            catch
            {
                result = "Invalid input";
            }

            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }
    }
}
