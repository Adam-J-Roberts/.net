using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = -1;

            Console.Write("How many numbers do you want averaged: ");
            string quant = Console.ReadLine();
            int num = int.Parse(quant);


            Console.WriteLine("You selected {0} numbers to average", quant);
            int[] avg = new int[num];

            Console.Write("Please enter a number: ");

            for(int i = 0; i != num; i++)
            {
                do
                {
                    entry = int.Parse(Console.ReadLine());
                    if(entry < 0)
                    {
                        MessageBox.Show("Positive numbers only dick..\n");
                        entry = 0;
                    }
                } while (entry < 0);
                avg[i] = entry;
            }

            int total = 0;

            for (int j = 0; j != num; j++)
            {
                total += avg[j];
            }

            Console.Write("The average of your numbers is {0}.\n", (total/num));



        }
    }
}
