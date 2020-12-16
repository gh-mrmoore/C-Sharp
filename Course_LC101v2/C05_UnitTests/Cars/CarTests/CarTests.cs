using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        Car testCar;
        [TestInitialize]
        public void CreateCarObject()
        {
            Car testCar = new Car("Chevrolet", "Bolt", 10, 50);
        }

        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            //Car testCar1 = new Car("Chevy", "Volt", 10, 50);
            Assert.AreEqual(10, testCar.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            testCar.Drive(50);
            Assert.AreEqual(9, testCar.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            testCar.Drive(550);   //drive 550 miles when range should only be 500
            Assert.AreEqual(0, testCar.GasTankLevel, .001);
        }
        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            testCar.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank.");
        }

    }
}
