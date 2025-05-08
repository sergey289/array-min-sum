using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumTwoSmallest;
using System;
using System.Linq;

namespace SumTwoSmallestTest
{
    [TestClass]
    public class SumTwoSmallestNumbersTests
    {

        ArrayMathHelper  arrayMathHelper = new ArrayMathHelper();

       [TestMethod]
        public void TestSumTwoSmallestNumbers()
        {

            Assert.AreEqual(3, arrayMathHelper.SumTwoSmallestNumbers(new[] { 1, 2, 3, 4 }));

            // Negative numbers
            Assert.AreEqual(-3, arrayMathHelper.SumTwoSmallestNumbers(new[] { -1, -2, 3, 4 }));

            // Duplicates
            Assert.AreEqual(2, arrayMathHelper.SumTwoSmallestNumbers(new[] { 1, 1, 2, 3 }));

            // Large array (performance test)
            var largeArray = Enumerable.Range(1, 1_000_000).ToArray();
            Assert.AreEqual(3, arrayMathHelper.SumTwoSmallestNumbers(largeArray));
        }
    }
}
