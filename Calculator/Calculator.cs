﻿namespace Calculator;

public class Calculator
{
    public static int Add(int number1, int number2) => number1 + number2;
    public static int Subtract(int number1, int number2) => number1 - number2;
    public static int Multiply(int number1, int number2) => number1 * number2;
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
    }
}