using System;
using System.Linq;
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

        [TestMethod]
        public void ant_ant_should_be_0()
        { 
            AssertDeadAntCountShouldBe("ant ant", 0);
        }

        [TestMethod]
        public void ant_an_t_should_be_1()
        {
            AssertDeadAntCountShouldBe("ant an t", 1);
        }

        [TestMethod]
        public void ant_an_t_an_t_should_be_2()
        {
            AssertDeadAntCountShouldBe("ant an t an t", 2);
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
            if (string.IsNullOrWhiteSpace(ants))
            {
                return 0;
            }

            ants = RemoveLiveAnts(ants);

            return DeadAntsCount(ants);
        }

        private static int DeadAntsCount(string ants)
        {
            return ants.ToCharArray().Count(a => a == 'a');
        }

        private static string RemoveLiveAnts(string ants)
        {
            return ants.Replace("ant", "").Trim();
        }
    }
}
