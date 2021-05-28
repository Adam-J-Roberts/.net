using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp23
{
    class Program
    {

        // public static Thread threadsArray = new Thread[args.Length];

        static void Main(string[] args)
        {
            Process[] proc = new Process[args.Length];
            int i = 0;
            foreach (String element in args)
            {
                proc[i] = new Process();
                proc[i].StartInfo.FileName = args[i];
                proc[i].Start();
                i++;
            }
            bool run = true;
            while (run == true)
            {
                int j = 0;
                foreach (String element in args)
                {
                    if (proc[j].HasExited)
                    {
                        proc[j].Start();
                    }
                    j++;
                }
            }
        }
    }
}
