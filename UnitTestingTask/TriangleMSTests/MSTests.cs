using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingTask;

namespace TriangleMSTests
{
    [TestClass]
    public class MSTests:AbstractTest
    {
        readonly int Equilateral = 1;
        readonly int Isosceles = 2;
        readonly int Scalene = 3;

        [TestMethod]
        [TestCategory("Smoke")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the DetectTriangle() function detects a correct equilateral triangle.")]
        public void DetectEquilateralTest()
        {
            Triangle t = new Triangle(2, 2, 2);
            for (;;)
            Assert.AreEqual(Equilateral, t.DetectTriangle());
        }

        [TestMethod]
        [TestCategory("Smoke")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the DetectTriangle() function detects a correct isosceles triangle.")]
        public void DetectIsoscelesTest()
        {
            Triangle t = new Triangle(2, 2, 1);
            Assert.AreEqual(Isosceles, t.DetectTriangle());
        }

        [TestMethod]
        [TestCategory("Smoke")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the DetectTriangle() function detects a correct scalene triangle.")]
        public void DetectScaleneTest()
        {
            Triangle t = new Triangle(2, 3, 4);
            Assert.AreEqual(Scalene, t.DetectTriangle());
        }

        [TestMethod]
        [TestCategory("Smoke")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the GetSquare() function calculates square of a triangle correctly.")]
        public void GetSquareTest()
        {
            double a = 2, b = 3, c = 4;
            Triangle t = new Triangle(a, b, c);
            double p = (a + b + c) / 2;
            Assert.AreEqual(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), t.GetSquare());
        }

        [Ignore]
        [TestMethod]
        [TestCategory("Smoke")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the CheckTriangle() function defines correctly the existence of a  triangle.")]
        public void CheckTriangleExistenceTest()
        {
            Triangle t = new Triangle(1, 1, 1);
            Assert.IsTrue(t.CheckTriangle());
        }
        
        [TestMethod]
        [TestCategory("Daily")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the CheckTriangle() function defines correctly the nonexistence of a triangle.")]
        public void CheckTriangleNonExistenceTest()
        {
            Triangle t = new Triangle(-1, 1, 1);
            Assert.IsFalse(t.CheckTriangle());
        }

        [TestMethod]
        [TestCategory("Daily")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the DetectTriangle() function doesn't detect an incorrect equilateral triangle as a correct one.")]
        public void DetectIncorrectEquilateralTest()
        {
            Triangle t = new Triangle(0, 0, 0);
            Assert.AreEqual(0, t.DetectTriangle());
        }

        [TestMethod]
        [TestCategory("Daily")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the DetectTriangle() function doesn't detect an incorrect isosceles triangle as a correct one.")]
        public void DetectIncorrectIsoscelesTest()
        {
            Triangle t = new Triangle(-2, -2, 1);
            Assert.AreEqual(0, t.DetectTriangle());
        }

        [TestMethod]
        [TestCategory("Daily")]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the DetectTriangle() function doesn't detect an incorrect scalene triangle as a correct one.")]
        public void DetectIncorrectScaleneTest()
        {
            Triangle t = new Triangle(-2, 2, 1);
            Assert.AreEqual(0, t.DetectTriangle());
        }

        [TestMethod]
        [TestCategory("Daily")]
        [ExpectedException(typeof(ArithmeticException))]
        [Timeout(150)]
        [Owner("Katsiaryna Chura")]
        [Description("This test checks whether the GetSquare() function doesn't calculate the square of an incorrect triangle.")]
        public void GetSquareOfIncorrectTriangleTest()
        {
            double a = 0, b = 3, c = 4;
            Triangle t = new Triangle(a, b, c);
            double p = (a + b + c) / 2;
            Assert.AreEqual(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), t.GetSquare());
        }
    }
}
