using System;
using Xunit;
using ex_average;

namespace AverageTests
{
    public class AverageTest
    {
        [Fact]
        public void check_calculate_int()
        {
            Average<int> average = new Average<int>();

            average.add(1);
            average.add(2);
            average.add(3);

            int res = average.calculate();

            Assert.Equal(2, res);
        }

        [Fact]
        public void check_calculate_float()
        {
            Average<float> average = new Average<float>();

            average.add(1.1f);
            average.add(2.1f);
            average.add(3.1f);

            float res = average.calculate();

            Assert.Equal(2.1f, res);
        }

        [Fact]
        public void check_calculate_double()
        {
            Average<double> average = new Average<double>();

            average.add(1.1);
            average.add(2.1);
            average.add(3.1);

            double res = average.calculate();

            Assert.Equal(2.1, res);
        }

        [Fact]
        public void check_add_string_throw_exception()
        {
            Average<string> average = new Average<string>();

            Assert.Throws<ArgumentException>(() => average.add("one"));
        }
    }
}
