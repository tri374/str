using System;
using System.Security.Cryptography.X509Certificates;

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
        Summa(arr);
        min(arr);
        max(arr);
        static void Summa(int[] arr)
        {
            /*   int sum = arr.Sum();
               int m = arr.Min();
               int s = arr.Max();*/
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            int r = -1;
            int e = 0;
            while (r < 9)
            {
                r++;
                e = e + arr[r];
            }
            int w = 0;
            for (int s = 0; s < 10; s++)
            {
                w = w + arr[s];
            }
            Console.WriteLine("\nСумма всех чисел(for): " + w);
            Console.WriteLine("Сумма всех чисел(while): " + e);
            Console.WriteLine("Сумма всех чисел(foreach): " + sum);
        }
        static void min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            int m = arr[0];
            int y = -1;
            while (y < 8)
            {
                y++;
                if (arr[y] < m) m = arr[y];
            }
            int a = -1;
            int q = arr[0];
            foreach (int e in arr)
            {
                a++;
                if (q > arr[a])
                    q = arr[a];
            }
            Console.WriteLine("\nМинимальное число(for): " + min);
            Console.WriteLine("\nМинимальное число(while): " + m);
            Console.WriteLine("\nМинимальное число(foreach): " + q);
        }
        static void max(int[] arr)
        {
            int mx = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (mx < arr[i])
                    mx = arr[i];
            }
            int m = arr[0];
            int y = -1;
            while (y < 8)
            {
                y++;
                if (arr[y] > m) m = arr[y];
            }
            int a = -1;
            int q = arr[0];
            foreach (int e in arr)
            {
                a++;
                if (q < arr[a])
                    q = arr[a];
            }
            Console.WriteLine("\nМаксимальное число(for): " + mx);
            Console.WriteLine("\nМаксимальное число(while): " + m);
            Console.WriteLine("\nМаксимальное число(foreach): " + q);
        }
    }
}