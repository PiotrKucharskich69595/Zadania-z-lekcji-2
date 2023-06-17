using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
     int n, x;
     double e = 0;
     long Silnia(int n)   
     {
        return n == 0 ? 1 : n * Silnia(n -1);
     }
     Console.Write("Podaj n: ");
     n = Convert.ToInt32(Console.ReadLine());

     Console.Write("Podaj x: ");
     x = Convert.ToInt32(Console.ReadLine());

     for (int i = 0; i <n; i++)
     {
       e += Math.Pow(x, 1) / Silnia(i); 
     }
    }
    Console.WriteLine("Suma {0} pierwszych wyrazów funkcji e^x wynosi: {1}", n, e);
}