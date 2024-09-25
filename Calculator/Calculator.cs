namespace Calculator;
using CliUserCalculator;

public class Calculator
{
    public static double Add(double number1, double number2) => number1 + number2;
    public static double Subtract(double number1, double number2) => number1 - number2;
    public static double Multiply(double number1, double number2) => number1 * number2;
    public static double Divide(double number1, double number2)
    {
        if(number2 == 0) throw new DivideByZeroException();
        return number1 / number2;
    }
}

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to simple calculator!");

        bool continueLoop = true;

        while (continueLoop)
        {
            continueLoop = CliUserCalculator.StartCalcultorInput();
        };

        if (!continueLoop) Console.WriteLine("User ended loop with exit code.");

    }
}