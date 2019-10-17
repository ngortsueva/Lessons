using System;

namespace MathLibrary
{
    public interface IFigure
    {
        double Area();
    }

    public class Circle : IFigure
    {
        private double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return 3.14 * radius*radius;
        }
    }
        
    // Прямоугольный треугольник
    public class RightTriangle : IFigure
    {
        private double a;
        private double b;        

        public RightTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;            
        }

        public double Area()
        {
            return a * b / 2;
        }
    }

    // Равносторонний треугольник
    public class RegularTriangle : IFigure
    {
        private double a;   // сторона треугольника    

        public RegularTriangle(double a)
        {
            this.a = a;
        }

        public double Area()
        {
            return a * a * Math.Sqrt(3) / 4;
        }        
    }

    // Равнобедренный треугольник
    public class IsoscelesTriangle : IFigure
    {
        private double a; // ребро
        private double b; // основание 

        public IsoscelesTriangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Area()
        {
            double h = Math.Sqrt(4 * a * a - b * b) / 2;

            return b * h / 2;            
        }
    }

    // Расчет площади треугольника по формуле Герона
    public class TriangleGerona : IFigure
    {
        private double a, b, c;

        public TriangleGerona(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    // Расчет площади треугольника по стороне и высоте
    public class Triangle : IFigure
    {
        private double a;
        private double h;

        public Triangle(double a, double h)
        {
            this.a = a;
            this.h = h;
        }

        public double Area()
        {
            return a * h / 2;
        }
    }

    public class Figure
    {
        private IFigure figure;

        public void AddFigure(IFigure figure)
        {
            this.figure = figure;
        }

        public double Area()
        {
            return figure.Area();
        }
    }

    public class CheckTriangle
    {
        private double a, b, c;

        public CheckTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Треугольник - прямоугольный?
        public bool IsRight()
        {
            if ((c * c) == (a * a + b * b)) return true;
            else return false;
        }

        // Треугольник - равнобедренный
        public bool IsIsosceles()
        {
            if (a == b || a == c || b == c) return true;
            else return false;            
        }

        // Треугольник - равносторонний
        public bool IsRegular()
        {
            if (a == b && a == c) return true;
            else return false;
        }
    }    
}
