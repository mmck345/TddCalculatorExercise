namespace Calculator.Tests;

[TestClass]
public class CalculatorTests
{

    [TestMethod]
    public void GivenTwoPositiveNumbers_WhenAdded_ThenReturnsCorrectSum()
    {
        var resultExpected = 5 + 10; // 15
        var result = Calculator.Add(5, 10);
        Assert.AreEqual(result, resultExpected);
    }


    [TestMethod]
    [DataRow(-5, -10, -15)]
    [DataRow(-0, -1, -1)]
    public void GivenTwoNegativeNumbers_WhenAdded_ThenReturnsCorrectSum(int a, int b, int expected)
    {
        Assert.AreEqual(Calculator.Add(a, b), expected);
    }


}