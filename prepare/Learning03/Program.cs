using System;

class Program
{
    static void Main(string[] args)
    {
        string test1;
        double test2;

        Fraction fractionTest = new Fraction(5, 8);

        test1 = fractionTest.GetFractionString();
        test2 = fractionTest.GetDecimalValue();

        Console.WriteLine(test1);
        Console.WriteLine(test2);
    }
}