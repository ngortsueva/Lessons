using System;
using Xunit;
using MathLibrary;

namespace MathLibraryTests
{
    public class FigureTests
    {
        [Fact]
        public void Circle_CalculateArea_Test()
        {
            Circle circle = new Circle(3);

            double result = circle.Area();

            Assert.Equal(28.26, Math.Round(result,2));
        }

        [Fact]
        public void Triangle_CalculateArea_Test()
        {
            TriangleGerona triangle = new TriangleGerona(2, 2, 3);

            var result = triangle.Area();

            Assert.Equal(1.98, Math.Round(result,2));
        }
    }
}
