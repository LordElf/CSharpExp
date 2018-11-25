using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs实验
{
    abstract public class Shape : IArea
    {
        public double width;
        public double height;
        public double radius;
        public List<double> list;

        abstract public double Area();
        
    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return Math.Round(this.width * this.height, 2);
        }
        
        
    }

    public class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return Math.Round(this.width * this.height / 2, 2);
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.Round(3.14 * radius * radius, 2);
        }
    }

    public class _Random : Shape
    {
        public _Random(List<double> list)
        {
            this.list = list;
        }
        public override double Area()
        {
            return Math.Round((list.Sum() * 2 - list.First() - list.Last()) / 2, 2);
        }
    }
}
