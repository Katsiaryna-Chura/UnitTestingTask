using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitTestingTask;

namespace TriangleMSTests
{
    [TestClass]
    public class AbstractTest
    {
        public TestContext TestContext { get; set; }

        [ClassInitialize()]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("Base class initialize");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            Console.WriteLine("Base class cleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine($"Test named '{TestContext.TestName}' initialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("Test cleanup");
        }
    }
}
