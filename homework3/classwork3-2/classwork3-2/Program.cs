
using classwork3_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork3_2
{
    //抽象形状
    public abstract class shape
    {
        private string myId;
        public shape(string s)
        {
            ID = s;
        }
        public string ID
        {
            get
            {
                return myId;
            }
            set
            {
                myId = value;
            }
        }
        public abstract double Area();
        //面积

        public abstract bool IfLegal();
    }

    //圆形
    public class Circle : shape
    {
        double radius;
        public Circle(double radius, string id) : base(id)
        {
            this.radius = radius;

        }

        public override bool IfLegal()
        {
            return radius > 0;
        }
        public override double Area()
        {
            if (this.IfLegal())
                return System.Math.PI * radius * radius;
            else
                return -1;
        }


    }



    //正方形
    public class Square : shape
    {
        private double mySide;
        public string myId
        {
            get
            {
                return myId;
            }
        }

        public Square(double side, string id) : base(id)
        {
            this.mySide = side;
        }

        public override bool IfLegal()
        {
            return mySide > 0;
        }

        public override double Area()
        {

            if (this.IfLegal())
                return mySide * mySide;
            else
                return -1;

        }
    }

    //长方形
    public class Rectangle : shape
    {
        private double myLength, myWidth;
        public string myId
        {
            get
            {
                return myId;
            }
        }
        public Rectangle(double length, double width, string id) : base(id)
        {
            this.myLength = length;
            this.myWidth = width;
        }

        public override bool IfLegal()
        {
            return myLength > 0 && myWidth > 0;
        }
        public override double Area()
        {

            if (this.IfLegal())
                return myLength * myWidth;
            else
                return -1;
        }
    }

    //三角形
    public class Triangle : shape
    {
        private double side1, side2, side3, s;
        public string myId
        {
            get
            {
                return myId;
            }
        }
        public Triangle(double side1, double side2, double side3, string id) : base(id)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            s = (side1 + side2 + side3) / 2;
        }

        public override bool IfLegal()
        {
            if (side1 > 0 && side2 > 0 && side3 > 0 && side1 < (side2 + side3) && side1 > Math.Abs(side2 - side3))
                return true;
            else
                return false;
        }
        public override double Area()
        {
            if (this.IfLegal())
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            else
                return -1;
        }
    }
}

public class OperationFactory
{
    public static shape CreateShape(int n)
    {
        Random rand = new Random();
        switch (n)
        {
            case 1:
                return  new Square(rand.Next(1, 5), "Square");
                
            case 2:
                return  new Rectangle(rand.Next(1, 5), rand.Next(1, 5), "Rectangle");
               
            case 3:
                return new Circle(rand.Next(1, 5), "Circle");

            case 4:
                int a= rand.Next(3, 6), b=rand.Next(3, 6), c= rand.Next(3, 6);
                while (a >= b + c || a < System.Math.Abs(b - a)) ;
                return new Triangle(a, b, c, "Triangle");
            default:
                return null;
        }

    }
}
class Program
    {
    static void Main(string[] args)
    {
            double sum = 0;
            double[] a = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Random rand1 = new Random();
                a[i] = OperationFactory.CreateShape(rand1.Next(1, 5)).Area();
            }
            for (int i = 0; i < 10; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("10个形状的面积之和为:"+sum);
        }
    }

