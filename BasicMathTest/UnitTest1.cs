using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        public void Test_AddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(10, 10);


            Assert.AreEqual(res, 20);

        }
        [TestMethod]

        public void Test_SubstractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);

        }
        [TestMethod]

        public void Test_DivideMethod()
        {
            BasicMaths bm = new Basicmaths();
            double res = bm.divide(10, 10);
            Assert.AreEqual(res, 1);

        }
        [TestMethod]

        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new Basicmaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }

}

