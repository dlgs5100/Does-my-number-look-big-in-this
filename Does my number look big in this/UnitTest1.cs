using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;


namespace Does_my_number_look_big_in_this
{
    [TestFixture]
    public class Sample_Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                                .Returns(true)
                                .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                                .Returns(true)
                                .SetDescription("371 is narcissitic");

            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => Kata.Narcissistic(n);
    }
    public class Kata
    {
        public static bool Narcissistic(int value)
        {
            var result = value.ToString().Select(i => Math.Pow((int)Char.GetNumericValue(i), value.ToString().Length)).Sum();

            return value == result ? true : false;
        }
    }
}
