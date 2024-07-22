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
        public int GetValue(int index)
        {
            if (index == 0)
                return FirstNode.Value;
            else
            {
                Node CurrectNode = FirstNode;
                if (CurrectNode.Next != null)
                {
                    for (int i = 0; i < index; i++)
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
            }
            else
            {
                Node CurrectNode = FirstNode;
                while (CurrectNode.Next != null)
                {
                    CurrectNode = CurrectNode.Next;
                }
                Node NewNode = new Node() { Value = newValue };
                CurrectNode.Next = NewNode;
            }

        }
        public void Delete(int index)
        {
            if (index == 0)
                FirstNode = FirstNode.Next;
            else
            {
                Node CurrectNode = FirstNode;
                if (CurrectNode.Next != null)
                {
                    for (int i = 0; i < index-1; i++)
                        CurrectNode = CurrectNode.Next;
                }
                CurrectNode.Next = CurrectNode.Next.Next;
            }
        }
        public int GetLength()
        {
            int length = 0;
            if (FirstNode == null)
            {
                return 0;
            }
            Node CurrectNode = FirstNode;
            while (CurrectNode.Next != null)
            {
                CurrectNode = CurrectNode.Next;
                length++;
            } 
            return length+1;
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
        list.Push(6);
        list.Delete(0);
        list.Delete(3);
        Console.WriteLine(list.GetValue(0));
        Console.WriteLine(list.GetValue(1));
        Console.WriteLine(list.GetValue(2));
        Console.WriteLine(list.GetValue(3));
        Console.WriteLine(list.GetLength());
    }
}


