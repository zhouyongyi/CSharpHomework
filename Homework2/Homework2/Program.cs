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
            string inputNUM;
            Console.WriteLine("请输入一个数字");
            inputNUM = Console.ReadLine();
            inputNUM = inputNUM.Trim();
            string[] spiltNUMs = inputNUM.Split(' ');
            int num = int.Parse(spiltNUMs[0]);
            List<int> factors = new List<int>();
            List<int> primefactors = new List<int>();
            for (int i = 2; i < num + 1; i++)
            {
                if (num % i == 0)
                {
                    factors.Add(i);
                }
            }
            Console.Write("素数因子有 ");
            foreach (int ele in factors)
            {
                int j = (int)Math.Ceiling(Math.Sqrt(Convert.ToDouble(ele)));
                int flag = 1;
                for (int i = 2; i <= j; i++)
                {
                    if (ele == 2)
                    {
                        continue;
                    }
                    if (ele % i == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (Convert.ToBoolean(flag))
                {
                    Console.Write(ele + "  ");
                }
            }
        }
    }
}
