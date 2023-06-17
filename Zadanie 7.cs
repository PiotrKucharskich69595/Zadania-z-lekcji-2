using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych, których suma = {0}:", n);
        FindNumberPairs(n);

        Console.ReadLine();
    }

    static void FindNumberPairs(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int complement = n - i;
            Console.WriteLine("({0}, {1})", i, complement);
        }
    }
}