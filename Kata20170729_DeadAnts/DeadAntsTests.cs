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

        [TestMethod]
        public void ant_anantt_aantnt_should_be_2()
        {
            AssertDeadAntCountShouldBe("ant anantt aantnt", 2);
        }

        [TestMethod]
        public void ant_ant_a_nt_should_be_1()
        {
            AssertDeadAntCountShouldBe("ant ant .... a nt", 1);
        }

        [TestMethod]
        public void ant_a_nt_t_should_be_1()
        {
            AssertDeadAntCountShouldBe("ant a nt t", 2);
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
            var a = ants.Count(x => x == 'a');
            var n = ants.Count(x => x == 'n');
            var t = ants.Count(x => x == 't');

            return (new[]{ a, n ,t }).Max();
        }

        private static string RemoveLiveAnts(string ants)
        {
            return ants.Replace("ant", "").Trim();
        }
    }
}
