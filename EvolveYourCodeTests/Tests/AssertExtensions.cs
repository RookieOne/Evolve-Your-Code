using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvolveYourCodeTests.Tests
{
    public static class AssertExtensions
    {
        //public static void ShouldBe(this decimal expected, decimal actual)
        //{
        //    Assert.AreEqual(expected, actual);
        //}

        //public static void ShouldBe(this string expected, string actual)
        //{
        //    Assert.AreEqual(expected, actual);
        //}

        public static void ShouldBe<T>(this T actual, T expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldBeType<T>(this object o)
        {
            Assert.IsInstanceOfType(o, typeof(T));
        }
    }
}