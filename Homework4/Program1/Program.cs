using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock theClock = new Clock();
            theClock.OnTime += ItISOnTime;
            DateTime time = DateTime.Now;
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.Write("Please input hour:");
                    int clockHour = int.Parse(Console.ReadLine());
                    Console.Write("Please input minute:");
                    int clockMinute = int.Parse(Console.ReadLine());
                    time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, clockHour, clockMinute, 0);
                    if (time < DateTime.Now)
                    {
                        Console.WriteLine("Please input a effective time");
                        continue;
                    }
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Please input a effective time");
                }
            }
            theClock.SetAlarm(time);
            Console.ReadKey();
        }
        static void ItISOnTime(object sender, ClockEventArgs e)
        {
            while (e.Time > DateTime.Now)
            {
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Time out");
            while (true)
            {
                Console.Beep();
            }
        }
    }
}
