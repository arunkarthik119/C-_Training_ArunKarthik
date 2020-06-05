using System;

namespace CalculateArea
{
    class Area
    {
        public float length, breadth, radius, side, hieght, breadthfortriangle;
        static void Main(string[] args)
        {
            Area a = new Area();
            a.Rectangle();
            a.Square();
            a.Circle();
            Console.ReadLine();
        }

        public void Rectangle()
        {
            Console.WriteLine("Enter the Length for Rectangle");
            length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth for Rectangle");
            breadth = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Area of rectangle is :{0}", length * breadth);
        }
        public void Square()
        {

            Console.WriteLine("Enter the side of a square");
            side = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Area of Square is:{0}", side * side);

        }
        public void Circle()
        {
            Console.WriteLine("Enter the Radius of the Circle");
            radius = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Area of Circle is:{0}", 3.14 * radius * radius);

        }
    }
}
