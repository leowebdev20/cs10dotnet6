using Packt;
using Xunit;

namespace UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            double a = 2;
            double b = 2;
            double expected = 4;
            Calculator calc = new();

            double actual = calc.Add(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            double a = 2;
            double b = 3;
            double expected = 5;
            Calculator calc = new();

            double actual = calc.Add(a, b);

            Assert.Equal(expected, actual);

        }
    }
}