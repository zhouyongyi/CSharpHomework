using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            String inputNum = "";
            Console.WriteLine("请输入一个正整数：");
            inputNum = Console.ReadLine();
            num = Int32.Parse(inputNum);
            Console.Write("它的素数因子有：");
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    int j = 1;
                    while (++j < i)
                        if (i % j == 0)  
                            break;       
                    if (j == i) Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
