using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sum_of_Digits___Digital_Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits___Digital_Root.Tests
{
    [TestClass()]
    public class NumberTests
    {
        Number testNum;

        [TestInitialize()]
        public void SetUp()
        {
            testNum = new Number();
        }

        [TestMethod()]
        public void DigitalRootTest()
        {
            Assert.AreEqual(0, testNum.DigitalRoot(0));
        }

        [TestMethod()]
        public void LargeNumTest()
        {
            Assert.AreEqual(21, testNum.DigitalRoot(189021));
        }
    }
}