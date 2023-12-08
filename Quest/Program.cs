using System;

public class Programm
{
    public static void Main()
    {
        Random rar = new Random();
        int[] arr = new int[10];
        Console.WriteLine("Набор чисел:");
        for (int c = 0; c < arr.Length; c++)
        {
            arr[c] = rar.Next(1, 50);
            int a = arr[c];
            Console.Write(a + " ");
        }
        int sum = arr.Sum();
        int m = arr.Min();
        int s = arr.Max();
        Console.WriteLine("\nМинимальное число: " + m);
        Console.WriteLine("Максимальное число: " + s);
        Console.WriteLine("Сумма всех чисел: " + sum);
    }
}