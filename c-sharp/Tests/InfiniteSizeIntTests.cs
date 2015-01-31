using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace Tests
{
    [TestClass]
    public class InfiniteSizeIntTests
    {
        [TestMethod]
        public void MustParseCorrectly()
        {
            // Regular parse
            string s = "15368713711936614952811305876380278410754449733078";
            var num = InfiniteSizeInt.Parse(s);
            Assert.AreEqual(s, num.ToString());

            // Removes leading zeros
            s = "00058763802784107544497000";
            string s_expected = "58763802784107544497000";
            num = InfiniteSizeInt.Parse(s);
            Assert.AreEqual(s_expected, num.ToString());

            // Handles zero
            s = "0";
            num = InfiniteSizeInt.Parse(s);
            Assert.AreEqual(s, num.ToString());

            // Handles zero
            s = "00";
            num = InfiniteSizeInt.Parse(s);
            Assert.AreEqual("0", num.ToString());
        }

        [TestMethod]
        public void MustAddCorrectly()
        {
            // Add without a carry
            string s1 = "15368713711936614952811305876380278410754449733078";
            var n1 = InfiniteSizeInt.Parse(s1);
            string s2 = "1";
            var n2 = InfiniteSizeInt.Parse(s2);
            var n3 = n1.Add(n2);
            Assert.AreEqual("15368713711936614952811305876380278410754449733079", n3.ToString());

            // Add with a carry
            s1 = "15368713711936614952811305876380278410754449733078";
            n1 = InfiniteSizeInt.Parse(s1);
            s2 = "555";
            n2 = InfiniteSizeInt.Parse(s2);
            n3 = n1.Add(n2);
            Assert.AreEqual("15368713711936614952811305876380278410754449733633", n3.ToString());

            // Add with a final carry
            s1 = "456";
            n1 = InfiniteSizeInt.Parse(s1);
            s2 = "789";
            n2 = InfiniteSizeInt.Parse(s2);
            n3 = n1.Add(n2);
            Assert.AreEqual("1245", n3.ToString());
        }
    }
}
