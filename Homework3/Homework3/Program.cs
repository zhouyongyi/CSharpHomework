using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        //定义基类Shape
        public abstract class Shaped
        {
            public Shaped()
            {; }
            public abstract double GetArea();
        }
        //定义Circle类，从Shape类中派生
        public class Circle : Shaped
        {
            private double Radius;
            public Circle(double Radius)
            {
                this.Radius = Radius;
            }
            public override double GetArea()
            {
                return System.Math.PI * Radius * Radius;
            }
        }
        //定义Rectangular类，从Shape类中派生
        public class Rectangular : Shaped
        {
            private double Length, Width;
            public Rectangular(double Length, double Width)
            {
                this.Length = Length;
                this.Width = Width;
            }
            public override double GetArea()
            {
                return Length * Width;
            }
        }

        //定义Triangle类，从Shape类中派生
        public class Triangle : Shaped
        {
            private double Ed1, Ed2, Ed3;
            public Triangle(double Ed1, double Ed2, double Ed3)
            {
                this.Ed1 = Ed1;
                this.Ed2 = Ed2;
                this.Ed3 = Ed3;
            }
            public override double GetArea()
            {
                double p = (Ed1 + Ed2 + Ed3) / 2;
                return System.Math.Sqrt(p * (p - Ed1) * (p - Ed2) * (p - Ed3));

            }
        }

        //定义Square类，从Shape类中派生
        public class Square : Shaped
        {
            private double Ed0;
            public Square(double Ed0)
            {

                this.Ed0 = Ed0;
            }
            public override double GetArea()
            {
                return Ed0 * Ed0;
            }

        }
        public class ShapeFactory
        {
            public static Shaped CreateShape(string shaped)
            {
                Shaped shap = null;
                switch (shaped)
                {
                    case "circle":
                        Console.WriteLine("请输入圆的半径");
                        double Rad = Convert.ToDouble(Console.ReadLine());
                        shap = new Circle(Rad);
                        break;
                    case "rectangular":
                        Console.WriteLine("请输入矩形的长和宽（分行输入）");
                        double Len = Convert.ToDouble(Console.ReadLine());
                        double Wid = Convert.ToDouble(Console.ReadLine());
                        shap = new Rectangular(Len, Wid);
                        break;
                    case "triangle":
                        Console.WriteLine("请输入三角形的三边长（分行输入）");
                        double Ed1 = Convert.ToDouble(Console.ReadLine());
                        double Ed2 = Convert.ToDouble(Console.ReadLine());
                        double Ed3 = Convert.ToDouble(Console.ReadLine());
                        shap = new Triangle(Ed1, Ed2, Ed3);
                        break;
                    case "square":
                        Console.WriteLine("请输入正方形的边长");
                        double Ed0 = Convert.ToDouble(Console.ReadLine());
                        shap = new Square(Ed0);
                        break;
                }
                return shap;
            }

        }
        static void Main(string[] args)
        {
            string[] shapefactory = new string[4];
            shapefactory[0] = "circle";
            shapefactory[1] = "rectangular";
            shapefactory[2] = "triangle";
            shapefactory[3] = "square";
            foreach (string SF in shapefactory)
            {
                Shaped shaped = ShapeFactory.CreateShape(SF);
                Console.WriteLine("它的面积是 {0}", shaped.GetArea());
            }
        }
    }
}
