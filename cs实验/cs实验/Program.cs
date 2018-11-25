using cs实验;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Rectangle\n2.Triangle\n3.Circle\n4.Random");
            Random random = new Random();
            switch (Console.Read())
            {
                case '1':
                    Rectangle rectangle = new Rectangle(Math.Round(random.NextDouble() * 10, 2),
                        Math.Round(random.NextDouble() * 10, 2));
                    Console.WriteLine("Rectangle\nWidth = " + rectangle.width.ToString() + 
                        " Height = " + rectangle.height + "\nArea = " + rectangle.Area());
                    break;
                case '2':
                    Triangle triangle = new Triangle(Math.Round(random.NextDouble() * 10, 2),
                        Math.Round(random.NextDouble() * 10, 2));
                    Console.WriteLine("Triangle\nWidth = " + triangle.width.ToString() + 
                        " Height = " + triangle.height+ "\nArea = " + triangle.Area()); 
                    break;
                case '3':
                    Circle circle = new Circle(Math.Round(random.NextDouble() * 10, 2));
                    Console.Write("Circle\nRadius = "+circle.radius+"\nArea = "+circle.Area());
                    break;
                case '4':
                    dataMaker maker = new dataMaker();
                    List<double> list = maker.list;
                    _Random _random = new _Random(list);
                    foreach (int j in list)
                    {
                        for (int tmp = 0; tmp < j; ++tmp)
                            Console.Write('*');
                        Console.WriteLine();
                    }
                    Console.WriteLine(_random.Area());
                    break;
                //case 'S': status = false;
                //    break;
                default: break;
            }
            Console.ReadLine();
        }
    }
}
