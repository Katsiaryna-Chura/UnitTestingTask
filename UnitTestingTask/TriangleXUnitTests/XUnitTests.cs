using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using UnitTestingTask;

namespace TriangleXUnitTests
{
    public class XUnitTests : IDisposable
    {
        static Logger logger = new Logger("xUnit");

        readonly int Equilateral = 1;
        readonly int Isosceles = 2;
        readonly int Scalene = 3;

        public XUnitTests()
        {
            logger.Log("Test initialization");
        }

        public void Dispose()
        {
            logger.Log("Test cleanup");
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void DetectEquilateralTest()
        {
            Triangle t = new Triangle(2, 2, 2);
            Assert.Equal(Equilateral, t.DetectTriangle());
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void DetectIsoscelesTest()
        {
            Triangle t = new Triangle(2, 2, 1);
            Assert.Equal(Isosceles, t.DetectTriangle());
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void DetectScaleneTest()
        {
            Triangle t = new Triangle(2, 3, 4);
            Assert.Equal(Scalene, t.DetectTriangle());
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void GetSquareTest()
        {
            double a = 2, b = 3, c = 4;
            Triangle t = new Triangle(a, b, c);
            double p = (a + b + c) / 2;
            Assert.Equal(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), t.GetSquare());
        }

        [Fact(Skip = "This test isn't necessary.")]
        [Trait("Category", "Daily")]
        public void CheckTriangleExistenceTest()
        {
            Triangle t = new Triangle(1, 1, 1);
            Assert.True(t.CheckTriangle());
        }

        [Theory]
        [InlineData(0,1,1)]
        [InlineData(-1,1,1)]
        [InlineData(2,2,6)]
        [Trait("Category", "Daily")]
        public void CheckTriangleNonExistenceTest(double a, double b, double c)
        {
            Triangle t = new Triangle(a, b, c);
            Assert.False(t.CheckTriangle());
        }

        [Fact]
        [Trait("Category", "Daily")]
        public void DetectIncorrectEquilateralTest()
        {
            Triangle t = new Triangle(0, 0, 0);
            Assert.Equal(0, t.DetectTriangle());
        }

        [Fact]
        [Trait("Category", "Daily")]
        public void DetectIncorrectIsoscelesTest()
        {
            Triangle t = new Triangle(-2, -2, 1);
            Assert.Equal(0, t.DetectTriangle());
        }

        [Fact]
        [Trait("Category", "Daily")]
        public void DetectIncorrectScaleneTest()
        {
            Triangle t = new Triangle(-2, 2, 1);
            Assert.Equal(0, t.DetectTriangle());
        }

        [Fact]
        [Trait("Category", "Daily")]
        public void GetSquareOfIncorrectTriangleTest()
        {
            double a = 0, b = 3, c = 4;
            Triangle t = new Triangle(a, b, c);
            double p = (a + b + c) / 2;
            Assert.Throws<ArithmeticException>(() => t.GetSquare());
            //Assert.AreEqual(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), t.GetSquare());
        }
    }
}
