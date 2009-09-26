using NUnit.Framework;

namespace ExtensionMethodsConsole
{
    public static class AssertExtensions
    {
        public static void ShouldBe(this int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}