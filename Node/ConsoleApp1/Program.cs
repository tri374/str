using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
public class Program
{

    class Node
    {
        public int Value;
        public Node Next;
    }
    class List
    {
        public Node FirstNode;
        public Node LastNode;
        public int length = 0;
        public int GetValue(int index)
        {
            if (index == 0)
            {
                Console.WriteLine("error 0");
                return -1;
            }
            if (index == 1)
                return FirstNode.Value;
            else
            {
                Node CurrectNode = FirstNode;
                if (CurrectNode.Next != null)
                {
                    for (int i = 1; i < index; i++)
                        CurrectNode = CurrectNode.Next;
                }
                return CurrectNode.Value;
            }
        }
        public void Push(int newValue)
        {
            if (FirstNode == null)
            {
                FirstNode = new Node() { Value = newValue };
                LastNode = FirstNode;
            }
            else
            {
                Node CurrectNode = LastNode;
                Node NewNode = new Node() { Value = newValue };
                CurrectNode.Next = NewNode;
                LastNode = CurrectNode.Next;
            }
            
            length++;

        }
        public void Delete(int index)
        {
            if (index == 0)
                Console.WriteLine("error 0");
            if (index == 1)
                FirstNode = FirstNode.Next;
            else
            {

                Node CurrectNode = FirstNode;
                if (CurrectNode.Next != null)
                {
                    for (int i = 1; i < index - 1; i++)
                        CurrectNode = CurrectNode.Next;
                    if (CurrectNode.Next.Next == null)
                    {
                        LastNode = CurrectNode;
                    }
                }
                CurrectNode.Next = CurrectNode.Next.Next;
            }
            length--;
        }
        public int GetLength()
        {
            return length;
        }
    }
    static void Main(string[] args)
    {
        List list = new List();
        list.Push(1);
        list.Push(2);
        list.Push(3);
        list.Push(4);
        list.Push(5);
        Console.WriteLine(list.GetValue(1));
        Console.WriteLine(list.GetValue(2));
        Console.WriteLine(list.GetValue(3));
        Console.WriteLine(list.GetValue(4));
        Console.WriteLine(list.GetValue(5));
        list.Delete(3);
        Console.WriteLine(list.GetValue(1));
        Console.WriteLine(list.GetValue(2));
        Console.WriteLine(list.GetValue(3));
        Console.WriteLine(list.GetValue(4));
        Console.WriteLine(list.GetLength());
        DateTime date1;
        DateTime date2;
        date1 = DateTime.Now;
        //for (int i = 0; i <= 500000; i++)
        //{
        //    list.Push(i);
        //}
        date2 = DateTime.Now;
        //Console.WriteLine("500.000 Элементов - " + date2.Subtract(date1));
    }
}


