using System;
using System.Collections.Generic; 
using System.Security.Cryptography; 
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Vector 
{
    public int size = 1;
    int[] mas;
    public void Push(int a)
    {
        if (mas == null)
        {
            mas = new int[1];
            mas[0] = a;
        }
        else
        {
            int[] masCopy = mas;
            mas = new int[size + 1];
            for(int i = 0; i < size; i++)
            {
                mas[i] = masCopy[i];
            }
            mas[size] = a;
            size++;
        }
    }
    public int Pull()
    {
        size--;
        int x = mas[size];
        int[] masCopy = mas;
        mas = new int[size];
        for (int i = 0; i < size; i++)
        {
            mas[i] = masCopy[i];
        }
        return x;
    }
}
public class Programm
{ 
    static void Main() 
    {
        Vector vector = new Vector();
        DateTime now = DateTime.Now;
        for (int i = 0; i <= 100000; i++)
        {
            vector.Push(i);
        }
        DateTime now2 = DateTime.Now;
        Console.WriteLine(now2.Subtract(now));
        //vector.Push(3);
        //vector.Push(8);
        //vector.Push(10);
        //vector.Push(13);
        //vector.Push(22);
        //vector.Push(15);
        //Console.WriteLine($"Массив содержит {vector.size} элементов" + "\nПоследннее число:" + vector.Pull() + "");
        //Console.WriteLine($"Массив содержит {vector.size} элементов" + "\nПоследннее число:" + vector.Pull());
        //Console.WriteLine($"Массив содержит {vector.size} элементов" + "\nПоследннее число:" + vector.Pull());
        //Console.WriteLine($"Массив содержит {vector.size} элементов" + "\nПоследннее число:" + vector.Pull());
        //Console.WriteLine($"Массив содержит {vector.size} элементов" + "\nПоследннее число:" + vector.Pull());
        //Console.WriteLine($"Массив содержит {vector.size} элементов" + "\nПоследннее число:" + vector.Pull());
    }
}