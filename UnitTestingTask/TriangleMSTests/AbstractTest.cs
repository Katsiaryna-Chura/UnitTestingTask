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
        protected static Logger logger = new Logger("MSTest");
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            logger.Log("Base class initialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            logger.Log("Base class cleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            logger.Log($"Test named '{TestContext.TestName}' initialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            logger.Log("Test cleanup");
        }
    }
}
