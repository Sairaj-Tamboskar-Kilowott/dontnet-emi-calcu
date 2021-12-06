// See https://aka.ms/new-console-template for more information

using System;

namespace emi_calc
{

public class FirstCalculator
  {

    // funtion to calculate EMI (formula)
    //public double emi_calculator(double p, double i, double t, double n)
    //{
    //    i = i / 100;
    //    double emi = (p * Math.Pow((1 + i / n), (t * n)))/24;

    //    return (emi);
    //}

    // main class
    public static void Main(String[] args)

    {
        //object created
        var take = new EMIvalue();
            try
            {
                //taking user input
                Console.WriteLine("EMI Calculator for 2 wheeler");
                Console.WriteLine("Enter Principle Amount:");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Rate of Interest:");
                double i = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter number of years:");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Monthly Compounding:");
                double n = Convert.ToDouble(Console.ReadLine());


                //calling the function
                double emi = take.emi_calculator(p, i, t, n);

                // print output
                Console.WriteLine("Monthly EMI is:" + emi);

            }


            catch(FormatException x)
            {
                Console.WriteLine("Invalid Input:" +x);
            }
    }
  }

}