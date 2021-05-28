using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        public static List<DirectoryInfo> DirectorySearch(DirectoryInfo dir)
        {
            List<DirectoryInfo> subs = new List<DirectoryInfo>();
            subs.Add(dir);
            foreach (DirectoryInfo x in dir.GetDirectories())
            {
                foreach (DirectoryInfo y in DirectorySearch(x))
                {
                    subs.Add(y);
                }
            }
            return subs;
        }
        public static void Print(List<FileInfo> fileEntries, DateTime fromDate, DateTime toDate)
        {
            foreach (var elements in fileEntries)
            {
                if ((elements.LastWriteTime < toDate) && elements.LastWriteTime > fromDate)
                {
                    Console.WriteLine(elements);
                }
            }
        }

        static void Main(string[] args)
        {

            string path =args[0] ;
            DirectoryInfo dir = new DirectoryInfo(path);
            DateTime fromDate = Convert.ToDateTime(args[1]);
            DateTime toDate = DateTime.Now;

            if (Directory.Exists(path))
            {
                List<DirectoryInfo> subs = DirectorySearch(dir);
                List<FileInfo> fileEntries = new List<FileInfo>();
                foreach (DirectoryInfo f in subs)
                {
                    foreach (FileInfo element in f.GetFiles())
                    {
                        fileEntries.Add(element);

                    }
                }

                Print(fileEntries, fromDate, toDate);
            }
        }
    }
}
