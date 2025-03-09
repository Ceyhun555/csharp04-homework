using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Tasks.ShapeCalculator
{
    class Program
    {
        static void Main()
        {
            ShapeProcessor processor = new ShapeProcessor();

            Circle circle = new Circle(5);
            processor.ProcessShape(circle);

            Rectangle rectangle = new Rectangle(4, 6);
            processor.ProcessShape(rectangle);

            Triangle triangle = new Triangle(3, 4, 5);
            processor.ProcessShape(triangle);
        }
    }

    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    // Interface for resizable shapes
    interface IResizable
    {
        void Resize(double factor);
    }

    // Circle class implementing IShape and IResizable
    class Circle : IShape, IResizable
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0) radius = 1; // Basic validation
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public void Resize(double factor)
        {
            if (factor > 0) radius *= factor;
        }
    }

    // Rectangle class implementing IShape and IResizable
    class Rectangle : IShape, IResizable
    {
        private double length, width;

        public Rectangle(double length, double width)
        {
            if (length <= 0) length = 1;
            if (width <= 0) width = 1;
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        public void Resize(double factor)
        {
            if (factor > 0)
            {
                length *= factor;
                width *= factor;
            }
        }
    }

    // Triangle class implementing IShape
    class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0) a = 1;
            if (b <= 0) b = 1;
            if (c <= 0) c = 1;

            // Validate triangle inequality
            if (a + b > c && a + c > b && b + c > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else // Default values if invalid
            {
                this.a = 3;
                this.b = 4;
                this.c = 5;
            }
        }

        public double CalculateArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public double CalculatePerimeter()
        {
            return a + b + c;
        }
    }

    // ShapeProcessor class for handling shape operations
    class ShapeProcessor
    {
        public void ProcessShape(IShape shape)
        {
            Console.WriteLine("Area: " + shape.CalculateArea());
            Console.WriteLine("Perimeter: " + shape.CalculatePerimeter());
        }
    }

}
