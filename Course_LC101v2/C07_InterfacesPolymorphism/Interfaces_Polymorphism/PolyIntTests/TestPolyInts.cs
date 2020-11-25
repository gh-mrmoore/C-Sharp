using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interfaces_Polymorphism;

namespace PolyIntTests
{
    [TestClass]
    public class TestPolyInts
    {
        [TestMethod]
        public void TestHouseCatImplementsEatMethod()
        {
            IFeedable test_cat = new Lesson_HouseCat("test", 10);
            Assert.AreEqual("the feedable is eating", test_cat.Eat());
        }
    }
}
