using NUnit.Framework;
using PrimeFactors;
using System.Collections.Generic;

namespace PrimeFactorsTest
{
    [TestFixture]
    public class PrimeFactorsTest
    {
        //[Test]
        //public void PrimesForOne_ReturnsOne()
        //{
        //    List<int> result = PrimeFactors.PrimeFactors.GetPrimes(1);

        //    List<int> expected = new List<int>();

        //    Assert.AreEqual(expected,result);
        //}
        //above is not needed anymore as I refactored it below
        [Test]
        [TestCase(1, new int[] { })]
        [TestCase(2, new int[] {2})]
        [TestCase(6, new int[] {2,3})]
        [TestCase(12, new int[] {2,2,3})]
        [TestCase(21, new int[] {3,7})]
        [TestCase(56, new int[] { 2,2,2,7 })]

        public void PrimesForNumbers_ReturnsExpectedList(int number, int [] expected)
        {
            List<int> result = PrimeFactors.PrimeFactors.GetPrimes(number);
            Assert.AreEqual(result, expected);
        }
    }
}
