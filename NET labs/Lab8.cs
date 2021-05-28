using System;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What file are we loading?");
            string path = Console.ReadLine();
            Hashtable frequency = new Hashtable(StringComparer.InvariantCultureIgnoreCase);
            int value;
            if (!File.Exists(path))
            {
                // Create a file to write to.
                System.Console.WriteLine("No such file.");
                Environment.Exit(0);
            }

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

            string pattern = @"\b\w+\b";
            Regex rgx = new Regex(pattern);
            foreach (Match match in rgx.Matches(readText))
            {
                //Console.WriteLine("{0}", match.Value);
                if (frequency.Contains(match.Value))
                {
                    value = (int)frequency[match.Value];
                    frequency[match.Value] = value+1;
                }
                else
                {
                    frequency.Add(match.Value, 1);
                }

            }
            foreach (DictionaryEntry entry in frequency)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }

        }
    }
}
        /*
            Match elements = Regex.Match(readText, @"\W", RegexOptions.IgnoreCase);
            Hashtable frequency = new Hashtable();
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i]);
            }
            */