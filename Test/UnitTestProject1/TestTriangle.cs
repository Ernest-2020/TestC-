using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
namespace UnitTestProject1
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            Triangle triangle = new Triangle();
            double inputSaidA = 3;
            double inputSaidB = 4;
            double inputSaidC = 5;
            double expected = 6;
            double actual = triangle.CalculateArea(inputSaidA,inputSaidB,inputSaidC);
            Assert.AreEqual(expected,actual, "TestCalculateTriangleArea is not correct");
        }
    }
}
