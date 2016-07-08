using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestingTask;

namespace TriangleNUnitTests
{
    [TestFixture]
    public class NUnitTests : AbstractTest
    {
        readonly int Equilateral = 1;
        readonly int Isosceles = 2;
        readonly int Scalene = 3;

        [Test, Timeout(150), Description("This test checks whether the DetectTriangle() function detects a correct equilateral triangle.")]
        [Category("Smoke")]
        public void DetectEquilateralTest()
        {
            Triangle t = new Triangle(2, 2, 2);
            for(;;)
            Assert.AreEqual(Equilateral, t.DetectTriangle());
        }

        [Test, Timeout(150), Description("This test checks whether the DetectTriangle() function detects a correct isosceles triangle.")]
        [Category("Smoke")]
        public void DetectIsoscelesTest()
        {
            Triangle t = new Triangle(2, 2, 1);
            Assert.AreEqual(Isosceles, t.DetectTriangle());
        }

        [Test, Timeout(150), Description("This test checks whether the DetectTriangle() function detects a correct scalene triangle.")]
        [Category("Smoke")]
        public void DetectScaleneTest()
        {
            Triangle t = new Triangle(2, 3, 4);
            Assert.AreEqual(Scalene, t.DetectTriangle());
        }

        [Test, Timeout(150), Description("This test checks whether the GetSquare() function calculates square of a triangle correctly.")]
        [Category("Smoke")]
        public void GetSquareTest()
        {
            double a = 2, b = 3, c = 4;
            Triangle t = new Triangle(a, b, c);
            double p = (a + b + c) / 2;
            Assert.AreEqual(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), t.GetSquare());
        }

        [Ignore("This test isn't necessary.")]
        [Test, Timeout(150), Description("This test checks whether the CheckTriangle() function defines correctly the existence of a  triangle.")]
        [Category("Daily")]
        public void CheckTriangleExistenceTest()
        {
            Triangle t = new Triangle(1, 1, 1);
            Assert.IsTrue(t.CheckTriangle());
        }

        [TestCase(0, 1, 1)]
        [TestCase(-1, 1, 1)]
        [TestCase(2, 2, 6)]
        [Timeout(150), Description("This test checks whether the CheckTriangle() function defines correctly the nonexistence of a triangle.")]
        [Category("Daily")]
        public void CheckTriangleNonExistenceTest(double a, double b, double c)
        {
            Triangle t = new Triangle(a, b, c);
            Assert.IsFalse(t.CheckTriangle());
        }

        [Test, Timeout(150), Description("This test checks whether the DetectTriangle() function doesn't detect an incorrect equilateral triangle as a correct one.")]
        [Category("Daily")]
        public void DetectIncorrectEquilateralTest()
        {
            Triangle t = new Triangle(0, 0, 0);
            Assert.AreEqual(0, t.DetectTriangle());
        }

        [Test, Timeout(150), Description("This test checks whether the DetectTriangle() function doesn't detect an incorrect isosceles triangle as a correct one.")]
        [Category("Daily")]
        public void DetectIncorrectIsoscelesTest()
        {
            Triangle t = new Triangle(-2, -2, 1);
            Assert.AreEqual(0, t.DetectTriangle());
        }

        [Test, Timeout(150), Description("This test checks whether the DetectTriangle() function doesn't detect an incorrect scalene triangle as a correct one.")]
        [Category("Daily")]
        public void DetectIncorrectScaleneTest()
        {
            Triangle t = new Triangle(-2, 2, 1);
            Assert.AreEqual(0, t.DetectTriangle());
        }

        [Test, Timeout(150), Description("This test checks whether the GetSquare() function doesn't calculate the square of an incorrect triangle.")]
        [Category("Daily")]
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
