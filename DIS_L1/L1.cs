using System;
using System.Diagnostics;

namespace DIS_L1
{
    class L1
    {
        // example 1 - simple computation
        // M disambiguates between double and decimal
        decimal income = 10000000.45M;
        decimal taxRate = 0.1M;
        decimal taxLiability = income * taxRate;
        Console.WriteLine("Tax liability is " + taxLiability);

            // example 2 - API usage
            double rate = 0.06;
        double doublingTime = Math.Log(2) / Math.Log(1 + rate);

        Console.WriteLine("Doubling time is " + doublingTime + " years");
    }
}
