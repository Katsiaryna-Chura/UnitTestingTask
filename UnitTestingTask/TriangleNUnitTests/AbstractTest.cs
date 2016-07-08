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
    public class AbstractTest
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Console.WriteLine("Base class setUp");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("Base class tearDown");
        }

        [SetUp]
        public void TestSetUp()
        {
            Console.WriteLine($"Test named {TestContext.CurrentContext.Test.Name} setUp");
        }

        [TearDown]
        public void TestTearDown()
        {
            Console.WriteLine("Test tearDown");
        }
    }
}
