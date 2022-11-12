using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class TestUnknownFigure
    {
        [TestMethod]
        public void UnknownFigureTestCalculateTriangleArea()
        {
            UnknownFigure unknownFigure = new UnknownFigure();
            double inputSaidA = 3;
            double inputSaidB = 4;
            double inputSaidC = 5;
            double expected = 6;
            double actual = unknownFigure.CalculateArea(inputSaidA, inputSaidB, inputSaidC);
            Assert.AreEqual(expected, actual, "TestCalculateTriangleArea is not correct");
        }

        [TestMethod]
        public void UnknownFigureTestCalculateAreaCircle()
        {
            UnknownFigure unknownFigure = new UnknownFigure();
            double inputRadius = 3;
            double expected = 28.27;
            double actual;
            actual = unknownFigure.CalculateArea(inputRadius);
            Assert.AreEqual(expected, actual, "TestCalculateAreaCircle is not correct");
        }
    }
}
