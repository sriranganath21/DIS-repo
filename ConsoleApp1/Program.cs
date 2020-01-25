using System;
using System.Diagnostics;

namespace Project01_Introduction
{
    // All organizing structures use { and } to define their boundaries
    class L1_Program
    {
        // All .NET programs begin with the main method
        // It looks like this
        static void Main(string[] args)
        {
            // example 0 - first program
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();
            // Debug.WriteLine("Hello World!");

            // obtaining user input
            //Console.WriteLine("Please provide your input");
            //string userInput = Console.ReadLine();

            // parsing to specific data types
            //int inputNumber = Convert.ToInt32(userInput);

            // parsing with error handling
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
            //decimal income = 10000000.45M;
            //decimal taxRate = 0.1M;
            //decimal taxLiability = income * taxRate;
            //Console.WriteLine("Tax liability is " + taxLiability);

            //// example 2 - API usage
            //double rate = 0.06;
            //double doublingTime = Math.Log(2) / Math.Log(1 + rate);

            //Console.WriteLine("Doubling time is " + doublingTime + " years");


            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6

            //Write your code here




            Console.WriteLine("Please enter the first side of the triangle");
            string first = Console.ReadLine();
            int a = Convert.ToInt32(first);


            Console.WriteLine("Please enter the second side of the triangle");
            string second = Console.ReadLine();
            int b = Convert.ToInt32(second);

            Console.WriteLine("Please enter the third side of the triangle");
            string third = Console.ReadLine();
            int c = Convert.ToInt32(third);

            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("area of a triangle is" + area);

            // example 3 - selection
            //if (income < 400000)
            //    taxLiability = 0;
            //else
            //{
            //    taxRate = 0.5M;
            //    taxLiability = taxRate * income;
            //}

            //Debug.WriteLine("Tax liability is " + taxLiability);

            //// example 4 - numeric input
            //string incomeInput = Console.ReadLine();

            //Debug.WriteLine("Thanks, you entered " + incomeInput);

            //income = Convert.ToDecimal(incomeInput);
            //if (income > 400000)
            //{
            //    taxRate = 0.5M;
            //    taxLiability = taxRate * income;
            //}
            //else
            //{
            //    taxLiability = 0;
            //}

            //Debug.WriteLine("Tax liability is " + taxLiability);


            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            // Write your code here

            Console.WriteLine("Enter a whole number");
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num);
            if (n % 2 == 0)
            {
                Console.WriteLine("Its an even number");
            }
            else
            {
                Console.WriteLine("Its an odd number");
            }



            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            // Write your code here
            Console.WriteLine("Please enter the first number");
            string num1 = Console.ReadLine();
            int x = Convert.ToInt32(num1);


            Console.WriteLine("Please enter the second number");
            string num2 = Console.ReadLine();
            int y = Convert.ToInt32(num2);

            Console.WriteLine("Please enter the third number");
            string num3 = Console.ReadLine();
            int z = Convert.ToInt32(num3);

            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("The largest of the three is " + x);

                }
                else
                {
                    Console.WriteLine("The largest of the three is " + z);
                }
            }
            else if (y > z)
            {
                Console.WriteLine("The Largest of three is " + y);
            }
            else
            {
                Console.WriteLine("The Largest of three is " + z);
            }



            // example 5 - loop
            //bool stopProgram = false;

            //while (stopProgram == false)
            //{
            //    Console.Write("Please enter income: $");
            //    income = Convert.ToDecimal(Console.ReadLine());

            //    if (income > 400000)
            //    {
            //        taxRate = 0.5M;
            //        taxLiability = taxRate * income;
            //    }
            //    else if (income >= 0)
            //    {
            //        taxLiability = 0;
            //    }
            //    else
            //    {
            //        stopProgram = true;
            //    }

            //    Console.WriteLine("Tax liability is " + taxLiability);
            //} // end while loop


            // Exercise 4
            // Input a value (n) from the user and calculate the sum of first n natural numbers.
            // Eg. n=5. sum = 1+2+3+4+5 = 15

            // Write your code here

            Console.WriteLine("Enter the number value");
            int n1 = Convert.ToInt32(Console.ReadLine());
            double total = 0;
            int i;
            for (i = 1; i <= n1; i++)
            {
                total = i + total;
            }
            Console.WriteLine("the sum " + n1 + " numbers is " + total);

            // Exercise 5
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            // *
            // **
            // ***
            // ****
            // *****

            // Write your code here

            Console.WriteLine("Enter the number of times to repeat pattern");
            int number = Convert.ToInt32(Console.ReadLine());
            int f, e, d;
            for (f = 1; f <= number; f++)
            {

                for (d = 1; d <= f; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }


            // Exercise 6
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            //     *
            //    **
            //   ***
            //  ****
            // *****

            // Write your code here
            Console.WriteLine("Enter the number of times to repeat pattern");
            int numb = Convert.ToInt32(Console.ReadLine());
            int p, q, r;
            for (p = 1; p <= numb; p++)
            {
                for (q = 1; q <= numb - p; q++)
                {
                    Console.Write(" ");
                }
                for (r = 1; r <= p; r++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }


            // example 6 - method
            //income = Convert.ToDecimal(Console.ReadLine());
            //taxLiability = ComputeTaxes(income);
            //Debug.WriteLine("Tax liability is " + taxLiability);


            // Exercise 7
            // Write a method that accepts a parameter (n) and returns the sum of first n natural numbers.

            // Write your code here




            // example 7 - arrays
            //decimal[] incomes = new decimal[] { 100.0M, 234532, 2443245.1M, 123443 };

            //for (int i = 0; i < 4; i++)
            //{
            //    Debug.WriteLine(incomes[i]);
            //}


            // Exercise 8
            // Enter n numbers in an array and print all the even numbers.

            // Write your code here



            // Exercise 9
            // Enter n numbers in an array and find the highest and the smallest number.

            // Write your code here

            // }

            //static decimal ComputeTaxes(decimal income)
            //{
            //    decimal taxLiability;
            //    decimal taxRate;

            //    if (income < 400000)
            //        taxLiability = 0;
            //    else
            //    {
            //        taxRate = 0.5M;
            //        taxLiability = taxRate * income;
            //    }

            //    return taxLiability;
        }
    }
}