using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static double findRoot(double x)
        {
            return Math.Pow(x, 3) -2;
        }
        static void Main(string[] args)
        {
            /*Write a program to compute and display the root of the equation y=x^3-2*/
            Console.WriteLine("Finding the root of y=x^3-2");

            double mid = 0;
            double low = 0;
            double high = 2;
            double goal = 0.0000001;


            do
            {
                mid = (low + high) / 2;

                if (findRoot(high) * findRoot(mid) < 0)
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
            } while (high - low > goal);


            Console.WriteLine("Your number is {0}", mid);


        }
    }
}
