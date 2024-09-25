namespace Calculator;

public class Calculator
{
    public static int Add(int number1, int number2) => number1 + number2;
    public static int Subtract(int number1, int number2) => throw new NotImplementedException();
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to simple calculator!");
    }
}