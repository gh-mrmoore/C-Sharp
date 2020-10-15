using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBrackets;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        [TestMethod]
        public void StudioTest01()
        {
            // test []
            Assert.IsTrue(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void StudioTest02()
        {
            // test "[LaunchCode]"
            Assert.IsTrue(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void StudioTest03()
        {
            // test "Launch[Code]"
            Assert.IsTrue(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        [TestMethod]
        public void StudioTest04()
        {
            // test "[]LaunchCode"
            Assert.IsTrue(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void StudioTest05()
        {
            // test "[]LaunchCode"
            Assert.IsTrue(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        
        [TestMethod]
        public void StudioTest06()
        {
            // test "[LaunchCode"
            Assert.IsFalse(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }
        
        [TestMethod]
        public void StudioTest07()
        {
            // test "Launch]Code["
            Assert.IsFalse(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void StudioTest08()
        {
            // test "["
            Assert.IsFalse(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void StudioTest09()
        {
            // test "]["
            Assert.IsFalse(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void StudioTest10()
        {
            // test "[]LaunchCode" a different way
            Assert.AreEqual(true, BalancedBrackets.BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void StudioTest11()
        {
            // test "eduritga[egi][][]][][][][][]]]][[[[]][["
            Assert.IsFalse(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("eduritga[egi][][]][][][][][]]]][[[[]][["));
        }

        [TestMethod]
        public void StudioTest12()
        {
            // test "93q7t54978hegper8-ghe987hb87uh-ter78ge-r87gbhre7v8gbh-8re7g"
            Assert.IsFalse(BalancedBrackets.BalancedBrackets.HasBalancedBrackets("93q7t54978hegper8-ghe987hb87uh-ter78ge-r87gbhre7v8gbh-8re7g"));
        }
    }
}
