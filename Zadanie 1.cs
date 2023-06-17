using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, potegowanie;
        
        Console.WriteLine("Podaj podstawę");
        a = (int) inputValue();
        Console.WriteLine("Podaj wykładnik");
        b = (int) inputValue();
        potegowanie = (int) Math.Pow(a, b);
        Console.WriteLine("Wynik potęgowania wynosi: " + potegowanie);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
