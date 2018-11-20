using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anajera2g2
{
    class Ex2gCalculations
    {
        public static string Swich01(string customerType)
        {
            //1a) 'Switch' with no defult
            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R";
                    discountPercent = .1m;
                    break;
                case "C";
                    discountPercent = .2m;
                    break;
                    return discountPercent.ToString("0.0");
            }
        }
        public static string If01(string customerType)
        {
            // 1b) Seperate If01 statements
            decimal discountpercent = .1m;

            if (customerType == "R")
                discountpercent = .1m;
            if (customerType == "C")
                discountpercent = .2m;
            return discountpercent.ToString("0.0");
        }
        public static string ElseIf01(string customerType)
        {
            // 1c) if elseif
            decimal discountpercent = .1m;

            if (customerType == "R")
                discountpercent = .1m;
            else if (customerType == "C")
                discountpercent = .2m;
            return discountpercent.ToString("0.0");
        }
        public static string NestedIfElse01(string customerType)
        {
            // 1d) nested if-else
            decimal discountpercent = .1m;

            if (customerType == "R")
            {
                discountpercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountpercent = .2m;
                }
            }

            return discountpercent.ToString("0.0");
        }
        public static string SwichDefault01(string customerType)
        {
            //1e) 'Switch' with defult
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R";
                    discountPercent = .1m;
                    break;
                case "C";
                    discountPercent = .2m;
                    break;
                default: discountPercent = .1m;
                    break;
            }
            return discountPercent.ToString("0.0");
    }   }
}
