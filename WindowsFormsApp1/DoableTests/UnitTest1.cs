using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoableTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTest1 test = new UnitTest1();

            ViewResult result = test.Index() as ViewResult
        }
    }
}
