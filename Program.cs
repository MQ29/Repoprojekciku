using System;
namespace Projekcik
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = Checkout(3, 22, 2, 23, 10, 65, 43, 2);
            System.Console.WriteLine(total);



        }

        static double Checkout(params double[] prices)
        {
            double total1 = 0;
            foreach (double price in prices)
            {
                total1 += price;
            }
            return total1;
        }














































    }



}

