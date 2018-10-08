using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        class Order
        {
            public int GoodsNumber, GoodsPrice;
            public string GoodsName;
        }
        class OrderDetails
        {
            public static List<Order> Orders;
            public static int Count
            {
                get
                {
                    return Orders.Count;
                }
            }
            static OrderDetails()
            {
                Orders = new List<Order>();
            }
            public static Order Information()
            {
                Order myGoods = new Order();
                Console.WriteLine("Please input goods information:");
                Console.WriteLine("\nPlease input name:");
                myGoods.GoodsName = Console.ReadLine();
                Console.WriteLine("\nPlease input num:");
                myGoods.GoodsNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPlease input price:");
                myGoods.GoodsPrice = int.Parse(Console.ReadLine());

                return myGoods;
            }
            public void ShowGoodsInformation(Order myGoods)
            {
                if (myGoods == null) return;
                Console.WriteLine("The information");
                Console.WriteLine("Name:{0}", myGoods.GoodsName);
                Console.WriteLine("Num:{0}", myGoods.GoodsNumber);
                Console.WriteLine("Price:{0}", myGoods.GoodsPrice);
                Console.WriteLine();
            }
            public Order SearchByNum(int GoodsNumber)
            {
                for (int i = 0; i < Orders.Count; i++)
                {
                    if (Orders[i].GoodsNumber == GoodsNumber)
                    {
                        return Orders[i];
                    }
                }
                return null;
            }
            public void AddGoods(Order myGoods)
            {
                if (myGoods != null)
                {
                    Orders.Add(myGoods);
                    Console.WriteLine("There are {0} goods", Orders.Count);
                }
                else
                    Console.WriteLine("Please check your information");
            }
            public void Delete(int GoodsNumber)
            {
                Order Stu = SearchByNum(GoodsNumber);
                if (Stu != null)
                {
                    Orders.Remove(Stu);
                    Console.WriteLine("{0} has been deleted", GoodsNumber);
                    Console.WriteLine("There are {0} goods", Orders.Count);
                }
                else
                    Console.WriteLine("Please check your information");
            }
        }
        class OrderService
        {
            public void Check()
            {
                do
                {
                    Console.WriteLine
                    ("Please choose service：\n1、Add \n2、Delete \n3、Search by num");
                    int number = int.Parse(Console.ReadLine());
                    if (number > 4 || number < 1)
                        Console.WriteLine("Please chech information");
                    OrderDetails myStumanage = new OrderDetails();
                    switch (number)
                    {
                        case 1:
                            Order goods = OrderDetails.Information();
                            myStumanage.AddGoods(goods);
                            myStumanage.ShowGoodsInformation(goods);
                            break;
                        case 2:
                            Console.WriteLine("Please input which one to delete");
                            Console.WriteLine("Please input num：");
                            int GoodsNumber = int.Parse(Console.ReadLine());
                            myStumanage.SearchByNum(GoodsNumber);
                            myStumanage.Delete(GoodsNumber);
                            break; 
                        case 3:
                            Console.WriteLine("Please input which one to search：");
                            Console.WriteLine("Please input num：");
                            GoodsNumber = int.Parse(Console.ReadLine());
                            myStumanage.SearchByNum(GoodsNumber);
                            goods = myStumanage.SearchByNum(GoodsNumber);
                            myStumanage.ShowGoodsInformation(goods);
                            break;
                    }
                    Console.Write("Do you want to continue?(y/n)");
                    if (Console.ReadLine() != "y")
                        break;
                } while (true);
            }
        }
        class Program2
        {
            public static void Main(string[] args)
            {
                OrderService myService = new OrderService();
                myService.Check();
            }
        }
    }
}
