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
    }
}
