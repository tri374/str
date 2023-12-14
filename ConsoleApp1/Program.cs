using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        string p = "";
        Console.WriteLine("Веддите число");
        static int Fib(int n)
        {
            if (n <= 1)
                return n;

            return Fib(n - 1) + Fib(n - 2);
        }
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p);
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fib(i) + " ");
            }
        }
        Console.WriteLine("\nВедите число");
        int z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(p);
        int b = 0;
        while (b < z)
        {
            Console.Write(Fib(b) + " ");
            b++;
        }
        Console.WriteLine("\nВедите число");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(p);
        int[] a = new int[m];
        for (int i = 0; i < m; i++)
        {
            a[i] = i;
        }
        int v = 0;
        foreach (int d in a)
        {
            if (v < m)
                v = d;
                Console.Write(Fib(d) + " ");
        }
        int F(int n)
        {
            if (n == 0 || n == 1) return n;

            return F(n - 1) + F(n - 2);
        }
    }
}