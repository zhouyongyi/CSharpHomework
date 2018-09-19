using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum;
            int sum = 0;
            Console.WriteLine("请输入数字，中间以空格分开");
            inputNum = Console.ReadLine();
            inputNum = inputNum.Trim();
            string[] spiltNums = inputNum.Split(' ');
            int[] nums = new int[spiltNums.Length];
            for (int i = 0; i < spiltNums.Length; i++)
            {
                string temp = spiltNums[i];
                sum += int.Parse(temp);
                nums[i] = int.Parse(temp);
            }
            Array.Sort<int>(nums);
            Console.WriteLine("数组的最大值为" + nums[nums.Length - 1] + " ;");
            Console.WriteLine("数组的最小值为" + nums[0] + " ; ");
            Console.WriteLine("数组的平均值为" + sum / nums.Length + " ;");
            Console.WriteLine("数组的和为" + sum + " ;");
            Console.ReadKey();
        }
    }
}
