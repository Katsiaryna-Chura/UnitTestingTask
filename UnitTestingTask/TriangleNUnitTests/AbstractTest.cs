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
        protected static Logger logger = new Logger("NUnit");

        [OneTimeSetUp]
        public void SetUp()
        {
            logger.Log("Base class setUp");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            logger.Log("Base class tearDown");
        }

        [SetUp]
        public void TestSetUp()
        {
            logger.Log($"Test named {TestContext.CurrentContext.Test.Name} setUp");
        }

        [TearDown]
        public void TestTearDown()
        {
            logger.Log("Test tearDown");
        }
    }
}
