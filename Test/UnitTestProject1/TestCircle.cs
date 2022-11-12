using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void TestCalculateAreaCircle()
        {
            Circle circle = new Circle();

            double inputRadius = 3;
            double expected = 28.27;
            double actual;
            actual = circle.CalculateArea(inputRadius);
            Assert.AreEqual(expected, actual, "TestCalculateAreaCircle is not correct");
        }
    }
}
