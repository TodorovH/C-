using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Problem3LongestSubsequence.Tests
{
    [TestClass]
    public class UnitTestLongestSubsequence
    {
        [TestMethod]
        public void FindsTheLongestSubsequenceOfEqualNumbers()
        {
            var numbers = new List<int> { 12, 2, 2, 2, 3, 5, 9, 4, 4, 4, 4 };

            var expected = new List<int> { 4, 4, 4, 4 };

            var actual = LongestSubsequence.FindsTheLongestSubsequenceOfEqualNumbers(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
