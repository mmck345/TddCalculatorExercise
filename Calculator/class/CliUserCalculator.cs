namespace CliUserCalculator;
using Calculator;

public class CliUserCalculator
{
    static readonly double exitCode = -10;

    static bool CheckIfExitCodeEnter(double number) => number == exitCode;

    public static bool StartCalcultorInput()
    {
        double leftNumber;
        double rightNumber;
        string calculatorOperator;


        try
        {
            Console.Write("Enter a left number: ");
            leftNumber = Convert.ToDouble(Console.ReadLine());
            if (CheckIfExitCodeEnter(leftNumber)) return false;
            Console.Write("Enter a right number: ");
            rightNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a operator (+, -, *, /): ");
            calculatorOperator = Console.ReadLine();

            double result;

            result = calculatorOperator switch
            {
                "+" => Calculator.Add(leftNumber, rightNumber),
                "-" => Calculator.Subtract(leftNumber, rightNumber),
                "*" => Calculator.Multiply(leftNumber, rightNumber),
                "/" => Calculator.Divide(leftNumber, rightNumber),
                _ => throw new Exception($"The operator {calculatorOperator} is not avilable!"),
            };
            Console.WriteLine($"The result is: {result}");
        }
        catch (DivideByZeroException err)
        {
            Console.WriteLine($"Cannot divide by zero: {err}");
        }
        catch (Exception err)
        {
            Console.WriteLine($"An unexpected error occurred: {err}");
            return true;
        }


        Console.WriteLine("------------------------");

        return true;
    }
}
