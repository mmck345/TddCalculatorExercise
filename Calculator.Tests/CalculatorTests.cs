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


    [TestMethod]
    [DataRow(-5, -10, -15)]
    [DataRow(-0, -1, -1)]
    public void GivenTwoNegativeNumbers_WhenAdded_ThenReturnsCorrectSum(int a, int b, int expected)
    {
        var calculator = new Calculator();
        Assert.AreEqual(calculator.Add(a, b), expected);
    }


}