using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inheritance;

namespace InheritanceTests
{
    [TestClass]
    public class TestInheritance
    {
        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            Lesson_HouseCat keyboardCat = new Lesson_HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }

        [TestMethod]
        public void ExerciseNewDesktopTest()
        {
            Exercise_Desktop testDesktop = new Exercise_Desktop("Water", false, 16.0, 256.0);
            Assert.AreEqual(16.0, testDesktop.RamMemory, .001);
        }
    }
}
