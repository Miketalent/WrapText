using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WrapText;

namespace WrapTextTest
{
    [TestClass]
    public class WrapTextTest
    {
        [TestMethod]
        public void ShallReturnOriginalStrIfColumnGreaterThanInputStrLength()
        {
            var input = "abc";
            var expected = "abc";
            var actual = WrapTextUtil.wrapText(input, input.Length + 1);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShallReturnOriginalStrIfColumnEqualToInputStrLength()
        {
            var input = "abc";
            var expected = "abc";
            var actual = WrapTextUtil.wrapText(input, input.Length);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShallInsertLineBreakAtIndex2IfInputStrLengthIs3AndColumnIs2()
        {
            var input = "abc";
            var expected = "ab\nc";
            var actual = WrapTextUtil.wrapText(input, 2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShallInsertLineBreakAtIndex2IfInputStrLengthIs4AndColumnIs2()
        {
            var input = "abcd";
            var expected = "ab\ncd";
            var actual = WrapTextUtil.wrapText(input, 2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShallInsertLineBreakAtIndex1AndIndex2IfInputStrLengthIs3AndColumnIs1()
        {
            var input = "abc";
            var expected = "a\nb\nc";
            var actual = WrapTextUtil.wrapText(input, 1);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowIfInputColumnIsNegative()
        {
            var input = "abc";
            WrapTextUtil.wrapText(input, -1);

        }


    }
}
