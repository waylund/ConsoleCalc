using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = string.Empty;
            while (inp != "exit")
            {
                inp = Console.ReadLine();
                inp = inp.ToLower();
                if (inp.Contains("fibo"))
                {
                    string[] fstr = inp.Split(':');
                    int place = int.Parse(fstr[fstr.Length - 1]);
                    Console.WriteLine(calculations.fibonacci(place));
                }
            }
        }
    }
}
