using StringExtensions;

namespace StringExtensionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CapitalizeTest()
        {
            string test = "lower case string";

            Assert.AreEqual("Lower case string", "lower case string".Capitalize());
        }
    }
}