using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program
{

    public static void Main()
    {
        string p = "";
        Console.WriteLine("Веддите число");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(p);
        int z = 1;
        int x = 0;
        int[] c = new int[n];
        for (int i = 0; i < n; i++)
        {
            c[i] = z + x;
            Console.Write(c[i] + " ");
            z += x;
            x += z;
        }
    }
}