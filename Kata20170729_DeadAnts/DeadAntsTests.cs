using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170729_DeadAnts
{
    [TestClass]
    public class DeadAntsTests
    {
        [TestMethod]
        public void null_should_be_0()
        {
            AssertDeadAntCountShouldBe(null, 0);
        }

        private static void AssertDeadAntCountShouldBe(string ants, int expected)
        {
            var kata = new Kata();
            var actual = kata.DeadAntCount(ants);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int DeadAntCount(string ants)
        {
            return 0;
        }
    }
}
