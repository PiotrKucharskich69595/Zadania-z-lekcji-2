using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, k;

        do
        {
            Console.Write("Podaj liczbę n (n >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        do
        {
            Console.Write("Podaj liczbę k (k >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);


        int factorialN = Factorial(n);
        int factorialK = Factorial(k);
        
        int m = (factorialN - factorialK) / factorialK;

        Console.WriteLine($"Wartość m = {m}");
    }

    static int Factorial(int number)
    {
        int factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}