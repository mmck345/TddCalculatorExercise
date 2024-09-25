namespace Calculator.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void GivenTwoPositiveNumbers_WhenAdded_ThenReturnsCorrectSum()
    {
        var calculator = new Calculator();

        var resultExpected = 5 + 10; // 15

        var result = calculator.Add(5, 10);

        Assert.AreEqual(result, resultExpected);
    }
}