namespace Calculator.Tests;

[TestClass]
public class CalculatorTests
{

    // Add
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

    // Subtract

    [TestMethod]
    [DataRow(5, 10, -5)]
    [DataRow(1000, 1, 999)]
    public void GivenTwoPositiveNumbers_WhenSubtract_ThenReturnsCorrectValue(int a, int b, int expected)
    {
        var result = Calculator.Subtract(a, b);
        Assert.AreEqual(result, expected);
    }

    
    // Multiply
    
    [TestMethod]
    [DataRow(5, 10, 50)]
    [DataRow(0, 10, 0)]
    public void GivenTwoPositiveNumbers_WhenMultiply_ThenReturnsCorrectValue(int a, int b, int expected)
    {
        var result = Calculator.Subtract(a, b);
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [DataRow(-120, -3, 360)]
    [DataRow(-120, 3, -360)]
    public void GivenTwoNegativeNumbers_WhenMultiply_ThenReturnsCorrectValue(int a, int b, int expected)
    {
        var result = Calculator.Subtract(a, b);
        Assert.AreEqual(result, expected);
    }


}