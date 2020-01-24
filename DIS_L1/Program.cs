using System;
using System.Diagnostics;
namespace DIS_L1
{
    class L1_Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //// obtaining user input
            //Console.WriteLine("Please provide your input");
            //string userInput = Console.ReadLine();

            //// parsing to specific data types
            //int inputNumber = Convert.ToInt32(userInput);

            //// parsing with error handling
            //Console.WriteLine("Please provide your input");
            //string userInputToCheck = Console.ReadLine();

            //try
            //{
            //    int inputNumberChecked = Convert.ToInt32(userInputToCheck);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

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
}
