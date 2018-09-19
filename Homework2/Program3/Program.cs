using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            for (int i = 2; i < 101; i++)
            {
                nums.Add(i);
            }
            for (int i = 2; i < 51; i++)
            {
                Removemultiple(2, 100, i, nums);
            }
            Console.WriteLine("2到100以内的素数有：");
            foreach (int ele in nums)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
        }
        static void Removemultiple(int begin, int end, int multip, List<int> num)
        {
            for (int i = begin; i < end + 1; i++)
            {
                if (i == multip)
                {
                    continue;
                }
                if (i % multip == 0)
                {
                    num.Remove(i);
                }
            }
        }
    }
}
