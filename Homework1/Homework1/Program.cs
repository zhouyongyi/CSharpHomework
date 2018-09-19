using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double d1 = 0;
            double d2 = 0;
            double d3 = 0;
            Console.Write("Please input a double:");
            s = Console.ReadLine();
            d1 = double.Parse(s);
            Console.Write("Please input another double:");
            s = Console.ReadLine();
            d2 = Double.Parse(s);
            d3 = d1 * d2;
            Console.WriteLine("The result of their multiplication is:" + d1 + "*" + d2 + "=" + d3);
        }
    }
}
