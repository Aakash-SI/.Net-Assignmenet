using System;

namespace Shape_Hierarchy
{
    interface I_Shape
    {
        double Calculate_Area();
        double Calculate_Perimeter();
    }

    class Circle : I_Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Calculate_Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Calculate_Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public void Display_Details()
        {
            Console.WriteLine($"Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Calculate_Area():F2}");
            Console.WriteLine($"Perimeter: {Calculate_Perimeter():F2}");
        }
    }

    class Rectangle : I_Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Calculate_Area()
        {
            return Width * Height;
        }

        public double Calculate_Perimeter()
        {
            return 2 * (Width + Height);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Shape: Rectangle");
            Console.WriteLine($"Width: {Width}, Height: {Height}");
            Console.WriteLine($"Area: {Calculate_Area():F2}");
            Console.WriteLine($"Perimeter: {Calculate_Perimeter():F2}");
        }
    }

    class Triangle : I_Shape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double Calculate_Area()
        {
            return 0.5 * Base * Height;
        }

        public double Calculate_Perimeter()
        {
            double hypotenuse = Math.Sqrt(Base * Base + Height * Height);
            return Base + 2 * hypotenuse;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Shape: Triangle");
            Console.WriteLine($"Base: {Base}, Height: {Height}");
            Console.WriteLine($"Area: {Calculate_Area():F2}");
            Console.WriteLine($"Perimeter: {Calculate_Perimeter():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(5, 6);
            Triangle triangle = new Triangle(5, 6);

            circle.Display_Details();
            Console.WriteLine();
            rectangle.DisplayDetails();
            Console.WriteLine();
            triangle.DisplayDetails();
        }
    }
}
