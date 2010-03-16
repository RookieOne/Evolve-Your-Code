using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodsTests
{
    public static class AssertExtensions
    {
        public static void ShouldBe<T>(this T actual, T expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}